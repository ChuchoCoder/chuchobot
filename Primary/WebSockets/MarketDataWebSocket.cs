using System;
using System.Threading;
using Primary.Data;
using Primary.Net;

namespace Primary.WebSockets
{
    public class MarketDataWebSocket : WebSocket<MarketDataInfo, MarketData>
    {
        internal MarketDataWebSocket(Api api, MarketDataInfo marketDataToRequest, 
                                     CancellationToken cancelToken)
        : 
        base(api, marketDataToRequest, cancelToken)
        {}
    }
}
