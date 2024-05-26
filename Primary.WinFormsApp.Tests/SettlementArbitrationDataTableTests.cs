﻿using ChuchoBot.WinFormsApp.SettlementTerms;
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
        public void Arbitraje_Buy_24H_Sell_CI_SinFeriado()
    {
            InstrumentWithData buy = Create("AL30 - 24hs", 0.01m, 100000, 17220, 17230);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, days).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(100000, 83m, days);

            trade.Caucion.InteresNeto.Should().BeApproximately(38169m, 5);
            _ = trade.ProfitLoss.Should().BeApproximately(14725m, 5);
    }

    [Fact]
        public void Arbitraje_Buy_24H_Sell_CI_ConFeriadoFinDeSemana()
    {
            InstrumentWithData buy = Create("AL30 - 24hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 5);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, days).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(100000, 83m, days);

        _ = trade.ProfitLoss.Should().BeApproximately(137355, 5);
    }

    [Fact]
    public void Arbitraje_Buy_24H_Sell_CI()
    {
        var buy = Create("AL30 - 24hs", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - CI", 0.01m, 100000, 17210, 17220);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, days).Should().BeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(100000, 83m, days);

        _ = trade.BuyComisionDerechos.Should().BeApproximately(1726, 1);
        _ = trade.SellComisionDerechos.Should().BeApproximately(1721, 1);
        _ = trade.Caucion.InteresNeto.Should().BeApproximately(38169, 1);
        _ = trade.ProfitLoss.Should().BeApproximately(-15278, 5);
    }

    [Fact]
        public void Arbitraje_Buy_CI_Sell_24H()
    {
            InstrumentWithData buy = Create("AL30 - CI", 0.01m, 100000, 17250, 17260);
        var sell = Create("AL30 - 24hs", 0.01m, 100000, 17210, 17220);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, days).Should().BeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(100000, 83m, days);

            _ = trade.ProfitLoss.Should().BeApproximately(-15277, 5);
    }

    [Fact]
        public void Arbitraje_Buy_CI_Sell_24H_SinFeriado()
    {
        var buy = Create("AL30 - CI", 0.01m, 100000, 17090, 17100);
            InstrumentWithData sell = Create("AL30 - 24hs", 0.01m, 100000, 17260, 17270);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1);

            days.Should().Be(-1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 83m, days).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(100000, 83m, days);

            _ = trade.ProfitLoss.Should().BeApproximately(194844m, 5);
    }

    [Fact]
        public void Arbitraje_CEDEAR_Buy_24H_Sell_CI_SinFeriado()
    {
            InstrumentWithData buy = Create("PBR - 24hs", 1m, 5, 10732, 10742);
        var sell = Create("PBR - CI", 1m, 5, 10760, 10770);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 1);

            days.Should().Be(1);

            TradedInstrumentWithSettlementTerms.GetSettlementTermTrade(buy, sell, 95m, days).Should().NotBeNull();

        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(5, 95m, days);

            _ = trade.ProfitLoss.Should().BeApproximately(216m, 1);
    }

    [Fact]
        public void Arbitraje_Buy_24H_Sell_CI_FinDeSemana()
    {
            InstrumentWithData buy = Create("GD30 - 24hs", 1 / 100m, 19705, 26131.50m, 26141.50m);
            InstrumentWithData sell = Create("GD30 - CI", 1 / 100m, 19705, 26070, 26080);

            var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, 3);

            days.Should().Be(3);
        var trade = new SettlementTermTrade(buy, sell);
            trade.Calculate(19705, 95m, days);

        _ = trade.SellPriceTarget.Should().BeLessThan(trade.BuyPrice);
        _ = trade.BuyPriceTarget.Should().BeGreaterThan(trade.SellPrice);

            _ = trade.ProfitLoss.Should().BeApproximately(24123m, 1);
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
