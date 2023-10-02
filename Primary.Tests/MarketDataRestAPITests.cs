using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Primary.Data;

namespace Primary.Tests
{
    [TestFixture]
    internal class MarketDataRestAPITests
    {
        [OneTimeSetUp]
        public async Task Login()
        {
            _api = new Api(Api.DemoEndpoint);
            await _api.Login(Api.DemoUsername, Api.DemoPassword);
        }

        private Api _api;

        [Test]
        public async Task GetMarketData_ShouldGetAllEntries()
        {
            // Get a dollar future
            var instruments = await _api.GetAllInstruments();
            var instrument = instruments.Last(i => i.Symbol == Build.DollarFutureSymbol());

            var marketData = await _api.GetMarketData(instrument.Market, instrument.Symbol);

            marketData.Should().NotBeNull();
            marketData.Data.Should().NotBeNull();
            marketData.Data.SettlementPrice.Should().NotBeNull();
            marketData.Data.SettlementPrice.Price.Value.Should().NotBe(default);
            marketData.Data.OpenInterest.Size.Value.Should().NotBe(default);
        }
    }
}
