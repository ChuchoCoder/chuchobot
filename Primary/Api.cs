using Newtonsoft.Json;
using Primary.Data;
using Primary.Data.Orders;
using Primary.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static Primary.Api;

namespace Primary;

public class Api
{
    /// <summary>This is the default production endpoint.</summary>
    //public static Uri ProductionEndpoint => new Uri("https://mtzdma.primary.ventures");
    public static Uri ProductionEndpoint => new("https://api.primary.com.ar");

    /// <summary>This is the default demo endpoint.</summary>
    /// <remarks>You can get a demo username at https://remarkets.primary.ventures.</remarks>
    public static Uri DemoEndpoint => new("https://api.remarkets.primary.com.ar");

    /// <summary>
    /// Build a new API object.
    /// </summary>
    public Api(Uri baseUri, HttpClient httpClient = null)
    {
        BaseUri = baseUri;
        HttpClient = httpClient ?? new HttpClient();
        HttpClient.Timeout = TimeSpan.FromMinutes(5);
    }

    public Uri BaseUri { get; private set; }
    public HttpClient HttpClient { get; private set; }

    #region Login

    public string AccessToken { get; private set; }

    /// <summary>
    /// Initialize the specified environment.
    /// </summary>
    /// <param name="username">User used for authentication.</param>
    /// <param name="password">Password used for authentication.</param>
    /// <returns></returns>
    public async Task<bool> Login(string username, string password)
    {
        var uri = new Uri(BaseUri, "auth/getToken");

        HttpClient.DefaultRequestHeaders.Clear();
        HttpClient.DefaultRequestHeaders.Add("X-Username", username);
        HttpClient.DefaultRequestHeaders.Add("X-Password", password);

        var result = await HttpClient.PostAsync(uri, new StringContent(string.Empty));

        if (result.IsSuccessStatusCode)
        {
            AccessToken = result.Headers.GetValues("X-Auth-Token").FirstOrDefault();
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Add("X-Auth-Token", AccessToken);
        }

        return result.IsSuccessStatusCode;
    }

    public void SetAccessToken(string token)
    {
        AccessToken = token;
        HttpClient.DefaultRequestHeaders.Clear();
        HttpClient.DefaultRequestHeaders.Add("X-Auth-Token", AccessToken);
    }

    public const string DemoUsername = "naicigam2046";
    public const string DemoPassword = "nczhmL9@";
    public const string DemoAccount = "REM2046";

    #endregion

    #region Instruments information

    /// <summary>
    /// Get all instruments with details currently traded on the exchange.
    /// </summary>
    /// <returns>Instruments information.</returns>
    public async Task<IEnumerable<InstrumentDetail>> GetAllInstrumentsWithDetails()
    {
        try
        {
            var uri = new Uri(BaseUri, "rest/instruments/details");

            var response = await HttpClient.GetStringAsync(uri);

            var data = JsonConvert.DeserializeObject<GetAllInstrumentsWithDetailsResponse>(response);
            return data.Instruments;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    private class GetAllInstrumentsWithDetailsResponse
    {
        [JsonProperty("instruments")]
        public List<InstrumentDetail> Instruments { get; set; }
    }

    /// <summary>
    /// Get all instruments currently traded on the exchange.
    /// </summary>
    /// <returns>Instruments information.</returns>
    public async Task<IEnumerable<Instrument>> GetAllInstruments()
    {
        var uri = new Uri(BaseUri, "rest/instruments/all");
        var response = await HttpClient.GetStringAsync(uri);

        var data = JsonConvert.DeserializeObject<GetAllInstrumentsResponse>(response);
        return data.Instruments.Select(i => i.InstrumentId);
    }

    private class GetAllInstrumentsResponse
    {
        public class InstrumentEntry
        {
            [JsonProperty("instrumentId")]
            public Instrument InstrumentId { get; set; }
        }

        [JsonProperty("instruments")]
        public List<InstrumentEntry> Instruments { get; set; }
    }

    #endregion

    #region Historical data

    /// <summary>
    /// Get historical trades for a specific instrument.
    /// </summary>
    /// <param name="instrument">Instrument to get information for.</param>
    /// <param name="dateFrom">First date of trading information.</param>
    /// <param name="dateTo">Last date of trading information.</param>
    /// <returns>Trade information for the instrument in the specified period.</returns>
    public async Task<IEnumerable<Trade>> GetHistoricalTrades(Instrument instrument,
                                                                DateTime dateFrom,
                                                                DateTime dateTo)
    {
        var builder = new UriBuilder(BaseUri + "rest/data/getTrades");
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["marketId"] = instrument.Market;
        query["symbol"] = instrument.Symbol;
        query["dateFrom"] = dateFrom.ToString("yyyy-MM-dd");
        query["dateTo"] = dateTo.ToString("yyyy-MM-dd");
        builder.Query = query.ToString();

        var response = await HttpClient.GetStringAsync(builder.Uri);
        var data = JsonConvert.DeserializeObject<GetTradesResponse>(response);

        return data.Status == Status.Error ? throw new Exception($"{data.Message} ({data.Description})") : (IEnumerable<Trade>)data.Trades;
    }

    private class GetTradesResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("trades")]
        public List<Trade> Trades { get; set; }
    }

    #endregion

    #region Market data REST API

    /// <summary>
    /// Get all instruments currently traded on the exchange.
    /// </summary>
    /// <returns>Instruments information.</returns>
    public async Task<MarketDataRestApi> GetMarketData(Instrument instrument, short depth = 5, Entry[] entries = null)
    {
        var marketData = await GetMarketData(instrument.Market, instrument.Symbol, depth, entries);

        return marketData;
    }

    /// <summary>
    /// Get all instruments currently traded on the exchange.
    /// </summary>
    /// <returns>Instruments information.</returns>
    public async Task<MarketDataRestApi> GetMarketData(string marketId, string symbol, short depth = 5, Entry[] entries = null)
    {
        var builder = new UriBuilder(BaseUri + "rest/marketdata/get");
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["symbol"] = symbol;
        query["marketId"] = marketId;
        query["entries"] = entries == null ? Constants.AllEntries.ToApiString() : entries.ToApiString();
        query["depth"] = depth.ToString();
        builder.Query = query.ToString();

        var stringTask = await HttpClient.GetStringAsync(builder.ToString());

        var marketData = JsonConvert.DeserializeObject<MarketDataRestApi>(stringTask);

        return marketData;
    }

    #endregion

    #region Market data sockets

    /// <summary>
    /// Create a Market Data web socket to receive real-time market data.
    /// </summary>
    /// <param name="instruments">Instruments to watch.</param>
    /// <param name="entries">Market data entries to watch.</param>
    /// <param name="level"></param>
    /// <param name="depth">Depth of the book.</param>
    /// <returns>The market data web socket.</returns>
    public MarketDataWebSocket CreateMarketDataSocket(IEnumerable<Instrument> instruments,
                                                      IEnumerable<Entry> entries,
                                                      uint level, uint depth
    )
    {
        return CreateMarketDataSocket(instruments, entries, level, depth, new CancellationToken());
    }

    /// <summary>
    /// Create a Market Data web socket to receive real-time market data.
    /// </summary>
    /// <param name="instruments">Instruments to watch.</param>
    /// <param name="entries">Market data entries to watch.</param>
    /// <param name="level"></param>
    /// <param name="depth">Depth of the book.</param>
    /// <param name="cancellationToken">Custom cancellation token to end the socket task.</param>
    /// <returns>The market data web socket.</returns>
    public MarketDataWebSocket CreateMarketDataSocket(IEnumerable<Instrument> instruments,
                                                      IEnumerable<Entry> entries,
                                                      uint level, uint depth,
                                                      CancellationToken cancellationToken
    )
    {
        var marketDataToRequest = new MarketDataInfo()
        {
            Depth = depth,
            Entries = entries.ToArray(),
            Level = level,
            Products = instruments.ToArray()
        };

        return new MarketDataWebSocket(this, marketDataToRequest, cancellationToken);
    }

    #endregion

    #region Order data sockets

    /// <summary>
    /// Create a Order Data web socket to receive real-time orders data.
    /// </summary>
    /// <param name="accounts">Accounts to get order events from.</param>
    /// <returns>The order data web socket.</returns>
    public OrderDataWebSocket CreateOrderDataSocket(IEnumerable<string> accounts)
    {
        return CreateOrderDataSocket(accounts, new CancellationToken());
    }

    /// <summary>
    /// Create a Market Data web socket to receive real-time market data.
    /// </summary>
    /// <param name="accounts">Accounts to get order events from.</param>
    /// <param name="cancellationToken">Custom cancellation token to end the socket task.</param>
    /// <returns>The order data web socket.</returns>
    public OrderDataWebSocket CreateOrderDataSocket(IEnumerable<string> accounts,
                                                    CancellationToken cancellationToken
    )
    {
        var request = new OrderDataRequest
        {
            Accounts = accounts.Select(a => new OrderStatus.AccountId() { Id = a }).ToArray()
        };

        return new OrderDataWebSocket(this, request, cancellationToken);
    }

    #endregion

    #region Orders

    /// <summary>
    /// Send an order to the specific account.
    /// </summary>
    /// <param name="account">Account to send the order to.</param>
    /// <param name="order">Order to send.</param>
    /// <returns>Order identifier.</returns>
    public async Task<OrderId> SubmitOrder(string account, Order order)
    {
        var builder = new UriBuilder(BaseUri + "rest/order/newSingleOrder");
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["marketId"] = "ROFX";
        query["symbol"] = order.Instrument.Symbol;
        query["price"] = order.Price.ToApiString();
        query["orderQty"] = order.Quantity.ToString();
        query["ordType"] = order.Type.ToApiString();
        query["side"] = order.Side.ToApiString();
        query["timeInForce"] = order.Expiration.ToApiString();
        query["account"] = account;
        query["cancelPrevious"] = order.CancelPrevious.ToApiString();
        query["iceberg"] = order.Iceberg.ToApiString();
        query["expireDate"] = order.ExpirationDate.ToString("yyyyMMdd");

        if (order.Iceberg)
        {
            query["displayQty"] = order.DisplayQuantity.ToApiString();
        }
        builder.Query = query.ToString();

        var jsonResponse = await HttpClient.GetStringAsync(builder.Uri);

        var response = JsonConvert.DeserializeObject<OrderIdResponse>(jsonResponse);
        return response.Status == Status.Error
            ? throw new Exception($"{response.Message} ({response.Description})")
            : new OrderId()
            {
                ClientOrderId = response.Order.ClientId,
                Proprietary = response.Order.Proprietary
            };
    }

    /// <summary>
    /// Get order information from identifier.
    /// </summary>
    /// <param name="orderId">Order identifier.</param>
    /// <returns>Order information.</returns>
    public async Task<OrderStatus> GetOrderStatus(OrderId orderId)
    {

        var builder = new UriBuilder(BaseUri + "rest/order/id");
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["clOrdId"] = orderId.ClientOrderId;
        query["proprietary"] = orderId.Proprietary;
        builder.Query = query.ToString();

        var jsonResponse = await HttpClient.GetStringAsync(builder.Uri);

        var response = JsonConvert.DeserializeObject<GetOrderResponse>(jsonResponse);
        return response.Status == Status.Error ? throw new Exception($"{response.Message} ({response.Description})") : response.Order;
    }

    /// <summary>
    /// Cancel an order.
    /// </summary>
    /// <param name="orderId">Order identifier to cancel.</param>
    public async Task CancelOrder(OrderId orderId)
    {

        var builder = new UriBuilder(BaseUri + "rest/order/cancelById");
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["clOrdId"] = orderId.ClientOrderId;
        query["proprietary"] = orderId.Proprietary;
        builder.Query = query.ToString();

        var jsonResponse = await HttpClient.GetStringAsync(builder.Uri);
        _ = JsonConvert.DeserializeObject<OrderIdResponse>(jsonResponse);
        //if (response.Status == Status.Error)
        //{
        //    throw new Exception($"{response.Message} ({response.Description})");
        //}
    }

    private struct OrderIdResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("description")]
        public string Description;

        public struct Id
        {
            [JsonProperty("clientId")]
            public string ClientId { get; set; }

            [JsonProperty("proprietary")]
            public string Proprietary { get; set; }
        }

        [JsonProperty("order")]
        public Id Order;
    }

    private struct GetOrderResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("order")]
        public OrderStatus Order;
    }

    #endregion

    #region Constants

    private static class Status
    {
        public const string Error = "ERROR";
    }

    #endregion

    #region Positions

    public class AccountsResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }
    }

    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brokerId")]
        public int BrokerId { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }
    }

    public async Task<Account[]> GetAccounts()
    {

        var builder = new UriBuilder(BaseUri + "rest/accounts");

        var jsonResponse = await HttpClient.GetStringAsync(builder.Uri);

        /*
         {
            "status":"OK",
            "accounts":[
                {
                    "id": 123,
                    "name":"12345",
                    "brokerId":2,
                    "status":true
                }
            ]
         }
        */
        var response = JsonConvert.DeserializeObject<AccountsResponse>(jsonResponse);
        return response.Status == Status.Error ? throw new Exception(jsonResponse) : response.Accounts;
    }

    public class PositionsResponse
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("positions")]
        public Position[] Positions { get; set; }
    }

    public class PositionInstrument

    {
        [JsonProperty("symbolReference")]
        public string SymbolReference { get; set; }

        [JsonProperty("settlType")]
        public string SettlType { get; set; }
    }

    public static class SettlementType
    {
        public const string CI = "0";
        public const string T24H = "1";
        public const string T48H = "2";
    }

    public class Position
    {
        [JsonProperty("instrument")]
        public PositionInstrument Instrument { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("buySize")]
        public decimal BuySize { get; set; }

        [JsonProperty("buyPrice")]
        public decimal BuyPrice { get; set; }

        [JsonProperty("sellSize")]
        public decimal SellSize { get; set; }

        [JsonProperty("sellPrice")]
        public decimal SellPrice { get; set; }

        [JsonProperty("totalDailyDiff")]
        public decimal TotalDailyDiff { get; set; }

        [JsonProperty("totalDiff")]
        public decimal TotalDiff { get; set; }

        [JsonProperty("tradingSymbol")]
        public string TradingSymbol { get; set; }

        [JsonProperty("originalBuyPrice")]
        public decimal OriginalBuyPrice { get; set; }

        [JsonProperty("originalSellPrice")]
        public decimal OriginalSellPrice { get; set; }

        [JsonProperty("originalBuySize")]
        public decimal OriginalBuySize { get; set; }

        [JsonProperty("originalSellSize")]
        public decimal OriginalSellSize { get; set; }
    }

    public async Task<Position[]> GetPositions()
    {
        var accounts = await GetAccounts();

        var allPositions = new List<Position>();
        foreach (var account in accounts)
        {
            var positions = await GetPositions(account.Name);
            allPositions.AddRange(positions);
        }

        return allPositions.ToArray();
    }


    public async Task<Position[]> GetPositions(string accountName)
    {
        var builder = new UriBuilder(BaseUri + $"rest/risk/position/getPositions/{accountName}");

        var jsonResponse = await HttpClient.GetStringAsync(builder.Uri);

        /*
        {
            "status":"OK",
            "positions":[
                  {
                     "instrument":{
                        "symbolReference":"KO",
                        "settlType":2
                     },
                     "symbol":"MERV - XMEV - KO - 48hs",
                     "buySize": 123.0,
                     "buyPrice": 123.0,
                     "sellSize":0.0,
                     "sellPrice":0.0,
                     "totalDailyDiff":12.5,
                     "totalDiff":10.2,
                     "tradingSymbol":"MERV - XMEV - KO - 48hs",
                     "originalBuyPrice":123.0,
                     "originalSellPrice":0.0,
                     "originalBuySize":0,
                     "originalSellSize":0
                  }
             ]
        }
        */
        var response = JsonConvert.DeserializeObject<PositionsResponse>(jsonResponse);
        return response.Status == Status.Error ? throw new Exception(jsonResponse) : response.Positions;
    }


    #endregion
}
