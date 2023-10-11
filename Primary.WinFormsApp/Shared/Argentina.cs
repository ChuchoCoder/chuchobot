using Newtonsoft.Json;
using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class Argentina
    {
        public readonly static Argentina Data = new Argentina();
        private CancellationTokenSource _tokenSource;

        public Primary.Api Api;
        public IEnumerable<InstrumentDetail> AllInstruments;
        private MarketDataWebSocket marketDataSocket;
        public delegate void MarketDataEventHandler(Instrument instrument, Entries data);
        public event MarketDataEventHandler OnMarketData;
        public ConcurrentDictionary<string, Entries> LatestMarketData = new ConcurrentDictionary<string, Entries>();

        public Entries GetLatestOrNull(string symbol)
        {
            if (LatestMarketData.ContainsKey(symbol))
            {
                return LatestMarketData[symbol];
            }

            return null;
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

        public static bool IsMarketOpen(bool excludeAuctionPeriod = true)
        {
            // convert everything to TimeSpan
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = excludeAuctionPeriod ? new TimeSpan(17, 0, 0) : new TimeSpan(17, 57, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }

        public static bool IsCIOpen(bool excludeAuctionPeriod = true)
        {
            // convert everything to TimeSpan
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = excludeAuctionPeriod ? new TimeSpan(16, 0, 0) : new TimeSpan(15, 57, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }


        public async Task Init()
        {
            var lastUpdatedTimeSpan = TimeSpan.FromHours(12);
            if (File.Exists("InstrumentsWithDetails.json") && (DateTime.Now - File.GetLastWriteTime("InstrumentsWithDetails.json")) < lastUpdatedTimeSpan)
            {
                var instrumentsJson = File.ReadAllText("InstrumentsWithDetails.json");
                var instruments = JsonConvert.DeserializeObject<IEnumerable<InstrumentDetail>>(instrumentsJson);
                AllInstruments = instruments.OrderBy(x => x.InstrumentId.Symbol).ToList();
            }
            else
            {
                var instruments = await Api.GetAllInstrumentsWithDetails();
                AllInstruments = instruments.OrderBy(x => x.InstrumentId.Symbol).ToList();
                var instrumentsJson = JsonConvert.SerializeObject(AllInstruments, Formatting.Indented);
                File.WriteAllText("InstrumentsWithDetails.json", instrumentsJson);
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
            // Subscribe to all entries
            marketDataSocket = Api.CreateMarketDataSocket(instruments, Constants.AllEntries, 1, 5);

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
                    LatestMarketData.AddOrUpdate(marketData.Instrument.Symbol, marketData.Data, (key, data) => marketData.Data);

                    OnMarketData?.Invoke(marketData.Instrument, marketData.Data);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

                    LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                    OnMarketData?.Invoke(instrument, marketDataRestApi.Data);

                    await Task.Delay(TimeSpan.FromSeconds(5), _tokenSource.Token);

                    if (_tokenSource.IsCancellationRequested)
                    {
                        return;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex);
                    return;
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
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

                LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                OnMarketData?.Invoke(instrument, marketDataRestApi.Data);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

            if (instrument == null)
                throw new KeyNotFoundException($"Symbol '{symbol}' not found.");

            return instrument;

        }
    }
}
