using System;
using System.Linq;
using System.Threading.Tasks;
using Primary.Data;

namespace Primary.Examples
{
    internal static class WebSocketExample
    {
        private static async Task Main()
        {
            Console.WriteLine("Connecting to ReMarkets...");

            var api = new Api(Api.DemoEndpoint);
            await api.Login(Api.DemoUsername, Api.DemoPassword);

            // Get a all dollar futures
            Console.WriteLine("Getting available instruments...");

            var allIInstruments = await api.GetAllInstruments();

            var symbols = new[]
            {
                "DOMay20",
                "DOJun20",
                "DOJul20"
            };
            var dollarFuture = allIInstruments.Where(c => symbols.Contains(c.Symbol));

            // Subscribe to bids and offers
            var entries = new[] { Entry.Bids, Entry.Offers };

            Console.WriteLine("Connecting to market data...");

            using var socket = api.CreateMarketDataSocket(dollarFuture, entries, 1, 1);
            socket.OnData = OnMarketData;

            var socketTask = await socket.Start();
            socketTask.Wait();
            await socketTask;
        }

        private static void OnMarketData(Api api, MarketData marketData)
        {
            var bid = default(decimal);
            var offer = default(decimal);

            var bidSize = default(decimal);
            var offerSize = default(decimal);

            foreach(var trade in marketData.Data.Bids)
            {
                bid = trade.Price;
                bidSize = trade.Size;
            }

            foreach(var trade in marketData.Data.Offers)
            {
                offer = trade.Price;
                offerSize = trade.Size;
            }

            Console.WriteLine($"({marketData.Timestamp}) " +
                              $"{marketData.Instrument.Symbol} -> " +
                              $"{bid} ({bidSize}) --> ${offer - bid} <-- {offer} ({offerSize})"
            );
        }
    }
}
