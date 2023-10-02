using System;
using System.Linq;
using System.Threading.Tasks;

namespace Primary.Examples
{
    internal static class GetInstrumentsAndDataExample
    {
        private static async Task RunExample()
        //static async Task Main(string[] args)
        {
            Console.WriteLine("Connecting to ReMarkets...");
            
            var api = new Api(Api.DemoEndpoint);
            await api.Login(Api.DemoUsername, Api.DemoPassword);

            // Get instruments
            Console.WriteLine("Getting available instruments...");

            var allIInstruments = await api.GetAllInstruments();
            foreach (var instrument in allIInstruments)
            {
                Console.WriteLine($"{instrument.Market} / {instrument.Symbol}");
            }

            // Get all the dollar futures
            var dollarFutures = allIInstruments.Where( s => s.Symbol.StartsWith("DO") &&
                                                            !s.Symbol.StartsWith("DOP ")
            );
            foreach (var dollarFuture in dollarFutures)
            {
                Console.WriteLine($"{dollarFuture.Symbol}");
            }

            var sampleInstrument = allIInstruments.Last( i => i.Symbol == Tests.Build.DollarFutureSymbol() );
            Console.WriteLine($"Getting trades for {sampleInstrument.Symbol}");

            var threeDaysAgo = DateTime.Today.AddDays(-5);

            foreach (var trade in await api.GetHistoricalTrades(sampleInstrument, threeDaysAgo, DateTime.Today))
            {
                Console.WriteLine($"{trade.DateTime.ToLocalTime()}: ${trade.Price} ({trade.Size})");
            }
        }
    }
}
