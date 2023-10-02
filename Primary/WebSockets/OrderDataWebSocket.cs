using System;
using System.Threading;
using Newtonsoft.Json;
using Primary.Data.Orders;
using Primary.Net;

namespace Primary.WebSockets
{
    public struct OrderDataRequest
    {
        [JsonProperty("type", Order=-2)]
        public string Type => "os";

        [JsonProperty("accounts")]
        public OrderStatus.AccountId[] Accounts;
    }

    public struct OrderData
    {
        [JsonProperty("orderReport")]
        public OrderStatus OrderReport;
    }

    public class OrderDataWebSocket : WebSocket<OrderDataRequest, OrderData>
    {
        internal OrderDataWebSocket(Api api, OrderDataRequest orderDataToRequest,
                                    CancellationToken cancelToken)
        : 
        base(api, orderDataToRequest, cancelToken)
        {}
    }
}
