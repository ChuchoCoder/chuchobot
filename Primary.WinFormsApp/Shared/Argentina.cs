using ChuchoBot.WinFormsApp.Properties;
using Newtonsoft.Json;
using Primary;
using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Shared;

public class Argentina
{
    public static readonly Argentina Data = new();
    private CancellationTokenSource _tokenSource;

    public Primary.Api Api;
    public IEnumerable<InstrumentDetail> AllInstruments;
    private MarketDataWebSocket marketDataSocket;
    private OrderDataWebSocket ordersDataSocket;
    public delegate void MarketDataEventHandler(Instrument instrument, Entries data);
    public event MarketDataEventHandler OnMarketData;
    public ConcurrentDictionary<string, Entries> LatestMarketData = new();
    public ConcurrentDictionary<string, Primary.Data.Orders.OrderStatus> Orders = new();

    public Instrument[] WatchedInstruments { get; private set; }

    private CancellationTokenSource cancellationTokenSource;
    private CancellationTokenSource ordersCancellationTokenSource;
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
        Api = new Primary.Api(new Uri(apiBaseUrl));
        _tokenSource = new CancellationTokenSource();
    }

    public Primary.Api.Position[] Positions { get; set; }

    public bool HasPositions()
    {
        return Positions != null && Positions.Length > 0;
    }

    public void RefreshPositions()
    {
        if (Accounts != null)
        {
            using var track = Telemetry.TrackTime(nameof(RefreshPositions));
            Positions = Api.GetPositions(Accounts).Result;
        }
    }

    public Primary.Api.Account[] Accounts { get; set; }
    public string PrimaryAccount { get; set; }

    public void RefreshAccounts()
    {
        using var track = Telemetry.TrackTime(nameof(RefreshAccounts));
        Accounts = Api.GetAccounts().Result;
        PrimaryAccount = Accounts.FirstOrDefault()?.Name;
    }

    public bool CanTickerBeSelledInCI(string ticker)
    {
        return Positions == null || Positions.Any(x => x.Symbol.Contains(ticker) && x.Instrument.SettlementType == SettlementType.CI);
    }

    public bool CanTickerBeSelledIn24H(string ticker)
    {
        return Positions == null
            || Positions.Any(x =>
                x.Symbol.Contains(ticker)
                && (x.Instrument.SettlementType == SettlementType.CI || x.Instrument.SettlementType == SettlementType.T24H)
                );
    }

    public bool TickerExistsInPositions(string ticker)
    {
        return Positions == null || Positions.Any(x => x.Symbol.Contains(ticker));
    }

    public static bool IsMarketOpen(bool excludeAuctionPeriod = true)
    {
        // convert everything to TimeSpan
        var start = Settings.Default.MarketOpenTime;
        var end = excludeAuctionPeriod ? Settings.Default.MarketCloseTime : Settings.Default.MarketCloseTime - Settings.Default.MarketAuctionTimePeriod;
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
        var start = Settings.Default.MarketOpenTime;
        var end = excludeAuctionPeriod ? Settings.Default.MarketCloseCITime : Settings.Default.MarketCloseCITime - Settings.Default.MarketAuctionTimePeriod;
        var now = Now.TimeOfDay;

        // see if start comes before end
        if (start < end)
        {
            return start <= now && now <= end;
        }
        // start is after end, so do the inverse comparison
        return !(end < now && now < start);
    }

    public static decimal GetDolarMEPCompra()
    {
        var instrumentDataPesos = Argentina.Data.GetLatestOrNull("AL30".ToMervalSymbol24H());
        var instrumentDataDolar = Argentina.Data.GetLatestOrNull("AL30D".ToMervalSymbol24H());

        if (instrumentDataPesos.HasOffers() && instrumentDataDolar.HasBids())
        {
            var precioPesos = instrumentDataPesos.GetTopOfferPrice();
            var precioDolar = instrumentDataDolar.GetTopBidPrice();
            return precioPesos / precioDolar;
        }

        return 0;
    }

    public static decimal GetDolarMEPVenta()
    {
        var instrumentDataPesos = Argentina.Data.GetLatestOrNull("AL30".ToMervalSymbol24H());
        var instrumentDataDolar = Argentina.Data.GetLatestOrNull("AL30D".ToMervalSymbol24H());

        if (instrumentDataPesos.HasBids() && instrumentDataDolar.HasOffers())
        {
            var precioPesos = instrumentDataPesos.GetTopBidPrice();
            var precioDolar = instrumentDataDolar.GetTopOfferPrice();
            return precioPesos / precioDolar;
        }

        return 0;
    }

    public async Task Init()
    {
        var lastUpdatedTimeSpan = TimeSpan.FromHours(12);
        if (File.Exists("InstrumentsWithDetails.json") && DateTime.Now - File.GetLastWriteTime("InstrumentsWithDetails.json") < lastUpdatedTimeSpan)
        {
            Telemetry.LogInformation($"Reading InstrumentsWithDetails from file");
            var instrumentsJson = File.ReadAllText("InstrumentsWithDetails.json");
            var instruments = JsonConvert.DeserializeObject<IEnumerable<InstrumentDetail>>(instrumentsJson);
            AllInstruments = instruments.OrderBy(x => x.InstrumentId.Symbol).ToList();
        }
        else
        {
            using var tracker = Telemetry.TrackTime($"Fetching InstrumentsWithDetails from API");
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

    public Task WatchOrdersWithWebSocket()
    {

        try
        {
            if (ordersCancellationTokenSource != null)
            {
                ordersCancellationTokenSource.Cancel();
                ordersDataSocket.Dispose();
            }
        }
        catch (Exception ex)
        {
            Telemetry.LogWarning(nameof(WatchWithWebSocket), ex);
        }
        ordersCancellationTokenSource = new CancellationTokenSource();
        var accounts = new[] { PrimaryAccount };
        // Subscribe to all entries of Primary Account
        ordersDataSocket = Api.CreateOrderDataSocket(accounts, ordersCancellationTokenSource.Token);

        ordersDataSocket.OnData = OnReceiveOrdersData;
        return marketDataSocket.Start().Unwrap();
    }

    private void OnReceiveOrdersData(Api api, OrderData data)
    {
        try
        {
            Orders.AddOrUpdate(data.OrderReport.Id, data.OrderReport, (key, value) => data.OrderReport);
        }
        catch (Exception ex)
        {
            Telemetry.LogError(nameof(OnReceiveOrdersData), ex);
            throw;
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

        WatchedInstruments = instruments;
        cancellationTokenSource = new CancellationTokenSource();
        // Subscribe to all entries
        marketDataSocket = Api.CreateMarketDataSocket(instruments, Primary.Constants.AllEntries, 1, 5, cancellationTokenSource.Token);

        marketDataSocket.OnData = OnReceiveMarketData;
        return marketDataSocket.Start().Unwrap();
    }

    private void OnReceiveMarketData(Primary.Api api, MarketData marketData)
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
            throw;
        }
    }

    private async Task PullMarketData(Primary.Api api, Instrument instrument)
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
                Debug.WriteLine(ex);
                Telemetry.LogWarning(nameof(PullMarketData), ex);
                return;
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                Telemetry.LogWarning(nameof(PullMarketData), ex);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Telemetry.LogError(nameof(PullMarketData), ex);
                throw;
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
            throw;
        }
    }

    public InstrumentDetail GetInstrumentDetailOrNull(string symbol)
    {
        var instrument = Data.AllInstruments.FirstOrDefault(x => x.InstrumentId?.Symbol == symbol);

        return instrument;

    }

    public InstrumentDetail GetInstrumentDetail(string symbol)
    {
        var instrument = GetInstrumentDetailOrNull(symbol);

        return instrument ?? throw new KeyNotFoundException($"Symbol '{symbol}' not found.");
    }
}
