using ChuchoBot.WinFormsApp.SettlementTerms;
using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;

namespace ChuchoBot.WinFormsApp.Tests;

public class SettlementArbitrationDataTableTests
{
    private readonly SettlementArbitrationDataTable _sut;

    public SettlementArbitrationDataTableTests()
    {
        Settings.Default.Comision = 0;
        Settings.Default.ArancelCaucionColocadora = 1.5m;
        Settings.Default.ArancelCaucionTomadora = 2.5m;
        _sut = new SettlementArbitrationDataTable();
        _sut.Init();
    }

    [Fact]
    public void Arbitraje_Buy_48H_Sell_CI_SinFeriado()
    {
        var buy = Create("AL30 - 48hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(100000, 83m, 1, 2);

        _ = trade.Caucion.InteresNeto.Should().BeApproximately(123, 5);
        _ = trade.ProfitLoss.Should().BeApproximately(22887m, 5);
    }

    [Fact]
    public void Arbitraje_Buy_48H_Sell_CI_ConFeriadoFinDeSemana()
    {
        var buy = Create("AL30 - 48hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 4, 5).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(100000, 83m, 4, 5);

        _ = trade.ProfitLoss.Should().BeApproximately(137355, 5);
    }

    [Fact]
    public void Arbitraje_Buy_24H_Sell_CI()
    {
        var buy = Create("AL30 - 24hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().BeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(100000, 83m, 1, 2);

        _ = trade.BuyComisionDerechos.Should().BeApproximately(1726, 1);
        _ = trade.SellComisionDerechos.Should().BeApproximately(1721, 1);
        _ = trade.Caucion.InteresNeto.Should().BeApproximately(38169, 1);
        _ = trade.ProfitLoss.Should().BeApproximately(-15278, 5);
    }

    [Fact]
    public void Arbitraje_Buy_48H_Sell_24()
    {
        var buy = Create("AL30 - 48hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - 24hs", 0.01m, 100000, 17210, 17220);

        var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

        _ = days.Should().Be(1);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().BeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(100000, 83m, 1, 2);

        _ = trade.ProfitLoss.Should().BeApproximately(-15278, 5);
    }

    [Fact]
    public void Arbitraje_Buy_CI_Sell_48H_SinFeriado()
    {
        var buy = Create("AL30 - CI", 0.01m, 100000, 17090, 17100);
        var sell = Create("AL30 - 48hs", 0.01m, 100000, 17260, 17270);

        var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

        _ = days.Should().Be(-2);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, 1, 2).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(100000, 83m, 1, 2);

        _ = trade.ProfitLoss.Should().BeApproximately(75522m, 5);
    }

    [Fact]
    public void Arbitraje_CEDEAR_Buy_48H_Sell_CI_SinFeriado()
    {
        var buy = Create("PBR - 48hs", 1m, 5, 10732, 10742);
        var sell = Create("PBR - CI", 1m, 5, 10760, 10770);

        var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1, 2);

        _ = days.Should().Be(2);

        _ = TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 95m, 1, 2).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(5, 95m, 1, 2);

        _ = trade.ProfitLoss.Should().BeApproximately(353m, 1);
    }

    [Fact]
    public void Arbitraje_Buy_48H_Sell_24H_FinDeSemana()
    {
        var buy = Create("GD30 - 48hs", 1 / 100m, 19705, 26131.50m, 26141.50m);
        var sell = Create("GD30 - 24hs", 1 / 100m, 19705, 26070, 26080);

        var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 3, 4);

        _ = days.Should().Be(1);

        var trade = new SettlementTermTrade(buy, sell);
        trade.Calculate(19705, 95m, 3, 4);

        _ = trade.SellPriceTarget.Should().BeLessThan(trade.BuyPrice);
        _ = trade.BuyPriceTarget.Should().BeGreaterThan(trade.SellPrice);

        _ = trade.ProfitLoss.Should().BeApproximately(-2035m, 1);
    }

    public InstrumentWithData Create(string ticker, decimal priceConversionFactor, decimal size, decimal bidPrice, decimal offerPrice)
    {
        var instrument = new InstrumentDetail()
        {
            InstrumentId = new Instrument() { Symbol = ticker },
            PriceConvertionFactor = priceConversionFactor
        };
        var data = new InstrumentWithData(instrument)
        {
            Data = new Entries()
            {
                Bids = new Trade[] {
                    new() { Size = size, Price = bidPrice }
                },
                Offers = new Trade[] {
                    new() { Size = size, Price = offerPrice }
                }
            }
        };

        return data;
    }
}
