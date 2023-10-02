using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primary.Data;

namespace Primary.WinFormsApp.Tests
{
    [TestClass]
    public class SettlementArbitrationDataTableTests
    {
        private SettlementArbitrationDataTable _sut;

        [TestInitialize]
        public void Init()
        {
            _sut = new SettlementArbitrationDataTable();
        }

        [TestMethod]
        public void Arbitraje_Buy_48H_Sell_CI_SinFeriado()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("AL30 - 48hs", 0.01m, 100000, 17260);
            InstrumentWithData sell = Create("AL30 - CI", 0.01m, 100000, 17210);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().NotBeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(100000, 83m, 1.5m, 2.5m, 1, 2);

            _ = trade.ProfitLoss.Should().BeApproximately(22887m, 5);
        }

        [TestMethod]
        public void Arbitraje_Buy_48H_Sell_CI_ConFeriadoFinDeSemana()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("AL30 - 48hs", 0.01m, 100000, 17260);
            InstrumentWithData sell = Create("AL30 - CI", 0.01m, 100000, 17210);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 4, 5).Should().NotBeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(100000, 83m, 1.5m, 2.5m, 4, 5);

            _ = trade.ProfitLoss.Should().BeApproximately(137355, 5);
        }

        [TestMethod]
        public void Arbitraje_Buy_24H_Sell_CI()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("AL30 - 24hs", 0.01m, 100000, 17260);
            InstrumentWithData sell = Create("AL30 - CI", 0.01m, 100000, 17210);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().BeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(100000, 83m, 1.5m, 2.5m, 1, 2);

            _ = trade.ProfitLoss.Should().BeApproximately(-15278, 5);
        }

        [TestMethod]
        public void Arbitraje_Buy_48H_Sell_24()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("AL30 - 48hs", 0.01m, 100000, 17260);
            InstrumentWithData sell = Create("AL30 - 24hs", 0.01m, 100000, 17210);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

            days.Should().Be(1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().BeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(100000, 83m, 1.5m, 2.5m, 1, 2);

            _ = trade.ProfitLoss.Should().BeApproximately(-15278, 5);
        }

        [TestMethod]
        public void Arbitraje_Buy_CI_Sell_48H_SinFeriado()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("AL30 - CI", 0.01m, 100000, 17100);
            InstrumentWithData sell = Create("AL30 - 48hs", 0.01m, 100000, 17260);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

            days.Should().Be(-2);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().NotBeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(100000, 83m, 1.5m, 2.5m, 1, 2);

            _ = trade.ProfitLoss.Should().BeApproximately(75522m, 5);
        }

        [TestMethod]
        public void Arbitraje_CEDEAR_Buy_48H_Sell_CI_SinFeriado()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("PBR - 48hs", 1m, 5, 10742);
            InstrumentWithData sell = Create("PBR - CI", 1m, 5, 10760);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

            days.Should().Be(2);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 95m, 1, 2).Should().NotBeNull();

            var trade = new SettlementTermTrade(buy, sell).Calculate(5, 95m, 1.5m, 2.5m, 1, 2);

            _ = trade.ProfitLoss.Should().BeApproximately(353m, 1);
        }



        [TestMethod]
        public void Arbitraje_Buy_48H_Sell_24H_FinDeSemana()
        {
            _sut.Init();

            Properties.Settings.Default.Comision = 0;

            InstrumentWithData buy = Create("GD30 - 48hs", 1 / 100m, 19705, 26141.50m);
            InstrumentWithData sell = Create("GD30 - 24hs", 1 / 100m, 19705, 26070); 

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 3, 4);

            days.Should().Be(1);

            var trade = new SettlementTermTrade(buy, sell).Calculate(19705, 95m, 1.5m, 2.5m, 3, 4);

            trade.SellPriceTarget.Should().BeLessThanOrEqualTo(trade.BuyPrice);
            trade.BuyPriceTarget.Should().BeGreaterThan(trade.SellPrice);

            _ = trade.ProfitLoss.Should().BeApproximately(-2035m, 1);
        }

        public InstrumentWithData Create(string ticker, decimal priceConversionFactor, decimal size, decimal price)
        {
            InstrumentDetail instrument = new InstrumentDetail()
            {
                InstrumentId = new Instrument() { Symbol = ticker },
                PriceConvertionFactor = priceConversionFactor
            };
            InstrumentWithData data = new InstrumentWithData(instrument)
            {
                Data = new Entries()
                {
                    Bids = new Trade[] {
                        new Trade { Size = size, Price = price }
                    },
                    Offers = new Trade[] {
                        new Trade { Size = size, Price = price }
                    }
                }
            };

            return data;
        }
    }
}
