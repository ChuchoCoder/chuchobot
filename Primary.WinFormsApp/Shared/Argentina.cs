using Newtonsoft.Json;
using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class Argentina
    {
        public static readonly Argentina Data = new Argentina();
        private CancellationTokenSource _tokenSource;

        public Primary.Api Api;
        public IEnumerable<InstrumentDetail> AllInstruments;
        private MarketDataWebSocket marketDataSocket;
        public delegate void MarketDataEventHandler(Instrument instrument, Entries data);
        public event MarketDataEventHandler OnMarketData;
        public ConcurrentDictionary<string, Entries> LatestMarketData = new ConcurrentDictionary<string, Entries>();
        private CancellationTokenSource cancellationTokenSource;
        private static readonly TimeZoneInfo ArgentinaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Argentina Standard Time");
        private static DateTimeOffset Now => TimeZoneInfo.ConvertTime(DateTime.Now, ArgentinaTimeZone);

        public Entries GetLatestOrNull(string symbol)
        {
            return LatestMarketData.ContainsKey(symbol) ? LatestMarketData[symbol] : null;
        }

        public Argentina()
        {
            var url = Properties.Settings.Default.ApiBaseUrl;
            Init(url);
        }

        public void Init(string apiBaseUrl)
        {
            Api = new Api(new Uri(apiBaseUrl));
            _tokenSource = new CancellationTokenSource();
        }

        public Api.Position[] Positions { get; set; }

        public void RefreshPositions()
        {
            if (Accounts != null)
            {
                using (var track = Telemetry.TrackTime(nameof(RefreshPositions)))
                {
                    Positions = Api.GetPositions(Accounts).Result;
                }
            }
        }

        public Api.Account[] Accounts { get; set; }

        public void RefreshAccounts()
        {
            using (var track = Telemetry.TrackTime(nameof(RefreshAccounts)))
            {
                Accounts = Api.GetAccounts().Result;
            }
        }

        public bool CanTickerBeSelledInCI(string ticker)
        {
            return Positions == null || Positions.Any(x => x.Symbol.Contains(ticker) && (x.Instrument.SettlementType == SettlementType.CI));
        }

        public bool CanTickerBeSelledIn24H(string ticker)
        {
            return Positions == null
                || Positions.Any(x =>
                    x.Symbol.Contains(ticker)
                    && (x.Instrument.SettlementType == SettlementType.CI || x.Instrument.SettlementType == SettlementType.T24H)
                    );
        }

        public static bool IsMarketOpen(bool excludeAuctionPeriod = true)
        {
            // convert everything to TimeSpan
            var start = new TimeSpan(10, 0, 0);
            var end = excludeAuctionPeriod ? new TimeSpan(17, 0, 0) : new TimeSpan(17, 57, 0);
            var now = Now.TimeOfDay;

            // see if start comes before end
            if (start < end)
            {
                return start <= now && now <= end;
            }
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }

        public static bool IsCIOpen(bool excludeAuctionPeriod = true)
        {
            // convert everything to TimeSpan
            var start = new TimeSpan(10, 0, 0);
            var end = excludeAuctionPeriod ? new TimeSpan(16, 30, 0) : new TimeSpan(16, 27, 0);
            var now = Now.TimeOfDay;

            // see if start comes before end
            if (start < end)
            {
                return start <= now && now <= end;
            }
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }


        public async Task Init()
        {
            var lastUpdatedTimeSpan = TimeSpan.FromHours(12);
            if (File.Exists("InstrumentsWithDetails.json") && (DateTime.Now - File.GetLastWriteTime("InstrumentsWithDetails.json")) < lastUpdatedTimeSpan)
            {
                Telemetry.LogInformation($"Reading InstrumentsWithDetails from file");
                var instrumentsJson = File.ReadAllText("InstrumentsWithDetails.json");
                var instruments = JsonConvert.DeserializeObject<IEnumerable<InstrumentDetail>>(instrumentsJson);
                AllInstruments = instruments.OrderBy(x => x.InstrumentId.Symbol).ToList();
            }
            else
            {
                using (var tracker = Telemetry.TrackTime($"Fetching InstrumentsWithDetails from API"))
                {
                    var instruments = await Api.GetAllInstrumentsWithDetails();
                    AllInstruments = instruments.OrderBy(x => x.InstrumentId.Symbol).ToList();
                    var instrumentsJson = JsonConvert.SerializeObject(AllInstruments, Formatting.Indented);
                    File.WriteAllText("InstrumentsWithDetails.json", instrumentsJson);
                }
            }
        }

        public IEnumerable<Task> WatchWithRestApi(Instrument[] instruments)
        {
            foreach (var instrument in instruments)
            {
                var task = Task.Factory.StartNew(() => PullMarketData(Api, instrument), _tokenSource.Token,
                                                   TaskCreationOptions.LongRunning,
                                                   TaskScheduler.Default);

                yield return task.Unwrap();
            }
        }

        public Task WatchWithWebSocket(Instrument[] instruments)
        {

            try
            {
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Cancel();
                    marketDataSocket.Dispose();
                }
            }
            catch (Exception ex)
            {
                Telemetry.LogWarning(nameof(WatchWithWebSocket), ex);
            }

            cancellationTokenSource = new CancellationTokenSource();
            // Subscribe to all entries
            marketDataSocket = Api.CreateMarketDataSocket(instruments, Constants.AllEntries, 1, 5, cancellationTokenSource.Token);

            marketDataSocket.OnData = OnReceiveMarketData;
            return marketDataSocket.Start().Unwrap();
        }

        private void OnReceiveMarketData(Api api, MarketData marketData)
        {
            try
            {
                if (marketData.Instrument != null)
                {
                    //Console.WriteLine(marketData.Instrument?.Symbol + ": " + marketData.Data?.Last?.Price);
                    _ = LatestMarketData.AddOrUpdate(marketData.Instrument.Symbol, marketData.Data, (key, data) => marketData.Data);

                    OnMarketData?.Invoke(marketData.Instrument, marketData.Data);

                }
            }
            catch (Exception ex)
            {
                Telemetry.LogError(nameof(OnReceiveMarketData), ex);
                throw ex;
            }
        }

        private async Task PullMarketData(Api api, Instrument instrument)
        {
            while (true)
            {
                try
                {
                    var marketDataRestApi = await api.GetMarketData(instrument);

                    _ = LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                    OnMarketData?.Invoke(instrument, marketDataRestApi.Data);

                    await Task.Delay(TimeSpan.FromSeconds(5), _tokenSource.Token);

                    if (_tokenSource.IsCancellationRequested)
                    {
                        return;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    Telemetry.LogWarning(nameof(PullMarketData), ex);
                    return;
                }
                catch (WebException ex)
                {
                    Telemetry.LogWarning(nameof(PullMarketData), ex);
                }
                catch (Exception ex)
                {
                    Telemetry.LogError(nameof(PullMarketData), ex);
                    throw ex;
                }
            }

        }

        public IEnumerable<Task> RefreshMarketData(Instrument[] instruments)
        {
            foreach (var instrument in instruments)
            {
                yield return RefreshMarketData(instrument);
            }
        }

        public async Task RefreshMarketData(Instrument instrument)
        {
            try
            {
                var marketDataRestApi = await Api.GetMarketData(instrument);

                _ = LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                OnMarketData?.Invoke(instrument, marketDataRestApi.Data);
            }
            catch (WebException ex)
            {
                Telemetry.LogError(nameof(RefreshMarketData), ex);
            }
            catch (Exception ex)
            {
                Telemetry.LogError(nameof(RefreshMarketData), ex);
                throw ex;
            }
        }

        public InstrumentDetail GetInstrumentDetailOrNull(string symbol)
        {
            var instrument = Data.AllInstruments.FirstOrDefault(x => x.InstrumentId.Symbol == symbol);

            return instrument;

        }

        public InstrumentDetail GetInstrumentDetail(string symbol)
        {
            var instrument = GetInstrumentDetailOrNull(symbol);

            return instrument ?? throw new KeyNotFoundException($"Symbol '{symbol}' not found.");
        }
    }
}
