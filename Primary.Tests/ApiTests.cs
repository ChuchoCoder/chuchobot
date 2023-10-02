using System;
using System.Linq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Primary.Tests
{
    [TestFixture]
    public class ApiTests
    {
        [OneTimeSetUp]
        public async Task Login()
        {
            _api = new Api(Api.DemoEndpoint);
            await _api.Login(Api.DemoUsername, Api.DemoPassword);
        }

        private Api _api;

        [Test]
        public async Task AllAvailableInstrumentsCanBeRetrieved()
        {
            var instruments = await _api.GetAllInstruments();
            Assert.That(instruments, Is.Not.Empty);
            
            foreach (var instrument in instruments)
            {
                Assert.That(instrument.Market, Is.Not.Null.And.Not.Empty);
                Assert.That(instrument.Symbol, Is.Not.Null.And.Not.Empty);
            }
        }

        [Test]
        public async Task AllAvailableInstrumentsWithDetailsCanBeRetrieved()
        {
            var instruments = await _api.GetAllInstrumentsWithDetails();
            Assert.That(instruments, Is.Not.Empty);

            foreach (var instrument in instruments)
            {
                Assert.That(instrument.InstrumentId.Market, Is.Not.Null.And.Not.Empty);
                Assert.That(instrument.InstrumentId.Symbol, Is.Not.Null.And.Not.Empty);
            }
        }

        [Test]
        public async Task HistoricalTradesCanBeRetrievedForAnInstrument()
        {
            // Get a dollar future
            var instruments = await _api.GetAllInstruments();
            var instrument = instruments.Last( i => i.Symbol == Build.DollarFutureSymbol() );

            var dateFrom = DateTime.Today.AddDays(-20);
            var dateTo = DateTime.Today;

            var trades = await _api.GetHistoricalTrades(instrument, dateFrom, dateTo);
            Assert.That(trades, Is.Not.Empty);

            foreach (var trade in trades)
            {
                Assert.That(trade.Price, Is.Not.EqualTo(default(float)));
                Assert.That(trade.Size, Is.Not.EqualTo(default(float)));
                Assert.That(trade.DateTime, Is.Not.EqualTo(default(DateTime)));
                Assert.That(trade.ServerTime, Is.Not.EqualTo(default(long)));

                Assert.That(trade.DateTime.Date, Is.GreaterThanOrEqualTo(dateFrom).And.LessThanOrEqualTo(dateTo));
            }
        }

        // Test: No data (ex. old instrument).
    }
}
