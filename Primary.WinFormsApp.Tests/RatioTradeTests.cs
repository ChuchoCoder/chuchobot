using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Tests;

public class RatioTradeTests : InstrumentTests
{
    public RatioTradeTests()
    {
        Argentina.Data.LatestMarketData.Clear();
    }

    [Fact]
    public void ArbitrajeDolarDvsC()
    {
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - GD35 - 24hs", EntriesBuilder.Create(20000, 60000.50m, 60000.51m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30 - 24hs", EntriesBuilder.Create(17410, 60000.15m, 60000.16m), (s, u) => u);

        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30D - 24hs", EntriesBuilder.Create(17410, 60.13m, 60.14m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30C - 24hs", EntriesBuilder.Create(17410, 60.03m, 60.04m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - GD35D - 24hs", EntriesBuilder.Create(20000, 62.15m, 62.16m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - GD35C - 24hs", EntriesBuilder.Create(20000, 62.11m, 62.12m), (s, u) => u);

        var al30c = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30C - 24hs"));
        var gd35c = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - GD35C - 24hs"));
        var gd35d = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - GD35D - 24hs"));
        var al30d = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30D - 24hs"));

        var sellThenBuy = new BuySellTrade(al30c, al30d);
        var buyThenSell = new BuySellTrade(gd35d, gd35c);
        var ratioTrade = new RatioTrade(RatioTradeType.DvsC, sellThenBuy, buyThenSell);

        ratioTrade.RefreshData();

        var operation = ratioTrade.CalculateTrade();

        operation.RatioTrade.BuyThenSell.InverseBuyPriceText.Should().Be("62.11 / 62.16 = 0.999");
        operation.RatioTrade.BuyThenSellRatio.Should().BeApproximately(0.9991956241956241956241956242m, 0.0000001m);
        operation.RatioTrade.SellThenBuy.BuyPriceText.Should().Be("60.04 / 60.13 = 0.999");
        operation.RatioTrade.SellThenBuyRatio.Should().BeApproximately(0.9985032429735572925328455014m, 0.0000001m);

        operation.OwnedSell.Size.Should().Be(17410);
        operation.ArbitrationSell.Size.Should().Be(16831);

        // Total
        operation.OwnedSell.Total.Should().BeApproximately(10468.63m, 0.01m);
        operation.OwnedBuy.Total.Should().BeApproximately(10452.96m, 0.01m);

        operation.ArbitrationBuy.Total.Should().BeApproximately(10462.15m, 0.01m);
        operation.ArbitrationSell.Total.Should().BeApproximately(10453.73m, 0.01m);

        // Comision
        operation.OwnedSell.Comision.Should().BeApproximately(1.05m, 0.01m);
        operation.OwnedBuy.Comision.Should().BeApproximately(1.05m, 0.01m);

        operation.ArbitrationBuy.Comision.Should().BeApproximately(1.05m, 0.01m);
        operation.ArbitrationSell.Comision.Should().BeApproximately(1.05m, 0.01m);

        // Neto 
        operation.OwnedSell.NetTotal.Should().BeApproximately(10468.63m - 1.05m, 0.01m);
        operation.OwnedBuy.NetTotal.Should().BeApproximately(10452.96m + 1.05m, 0.01m);

        operation.ArbitrationBuy.NetTotal.Should().BeApproximately(10462.15m + 1.05m, 0.01m);
        operation.ArbitrationSell.NetTotal.Should().BeApproximately(10453.73m - 1.05m, 0.01m);

        // Neto en Pesos
        operation.ProfitTotal.Should().BeApproximately(3.07m, 0.01m);
        operation.ProfitPercentage.Should().BeApproximately(0.00029m, 0.00001m);
        operation.Comision.Should().BeApproximately(4.18m, 0.01m);

    }

    [Fact]
    public void ArbitrajeDolarMepTrade()
    {
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - EWZD - 24hs", EntriesBuilder.Create(100, 13.3m, 13.35m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - EWZ - 24hs", EntriesBuilder.Create(100, 17075m, 17100m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30D - 24hs", EntriesBuilder.Create(100000, 63.58m, 63.59m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30 - 24hs", EntriesBuilder.Create(100000, 82390m, 82400m), (s, u) => u);

        var ewzd = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - EWZD - 24hs"));
        var al30D = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30D - 24hs"));
        var al30 = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30 - 24hs"));
        var ewz = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - EWZ - 24hs"));

        var sellThenBuy = new BuySellTrade(ewz, ewzd);
        var buyThenSell = new BuySellTrade(al30D, al30);
        var ratioTrade = new RatioTrade(RatioTradeType.MEP, sellThenBuy, buyThenSell);

        ratioTrade.RefreshData();

        var operation = ratioTrade.CalculateTrade();

        operation.RatioTrade.BuyThenSellRatio.Should().BeApproximately(1295.64m, 0.01m);
        operation.RatioTrade.SellThenBuyRatio.Should().BeApproximately(1285.71m, 0.01m);

        // Total
        operation.OwnedSell.Total.Should().BeApproximately(1330.00m, 0.01m);
        operation.OwnedBuy.Total.Should().BeApproximately(1710000.00m, 0.01m);

        operation.ArbitrationBuy.Total.Should().BeApproximately(1320.76m, 0.01m);
        operation.ArbitrationSell.Total.Should().BeApproximately(1711240.30m, 0.01m);

        // Comision
        operation.OwnedSell.Comision.Should().BeApproximately(1.13m, 0.01m);
        operation.OwnedBuy.Comision.Should().BeApproximately(1448.37m, 0.01m);

        operation.ArbitrationBuy.Comision.Should().BeApproximately(0.13m, 0.01m);
        operation.ArbitrationSell.Comision.Should().BeApproximately(171.12m, 0.01m);

        // Neto 
        operation.OwnedSell.NetTotal.Should().BeApproximately(1328.87m, 0.01m);
        operation.OwnedBuy.NetTotal.Should().BeApproximately(1711448.37m, 0.01m);

        operation.ArbitrationBuy.NetTotal.Should().BeApproximately(1320.90m, 0.01m);
        operation.ArbitrationSell.NetTotal.Should().BeApproximately(1711069.18m, 0.01m);

        // Neto en Pesos
        operation.OwnedSell.NetTotalInPesos.Should().BeApproximately(1721746.92m, 0.01m);
        operation.OwnedBuy.NetTotalInPesos.Should().BeApproximately(1711448.37m, 0.01m);

        operation.ArbitrationBuy.NetTotalInPesos.Should().BeApproximately(1711411.42m, 0.01m);
        operation.ArbitrationSell.NetTotalInPesos.Should().BeApproximately(1711069.17m, 0.01m);

        operation.ProfitTotalInPesos.Should().BeApproximately(9956.30m, 0.01m);
        operation.ProfitPercentage.Should().BeApproximately(0.0057m, 0.0001m);
        operation.ComisionTotalInPesos.Should().BeApproximately(3250.173m, 0.01m);

    }

    [Fact]
    public void ArbitrajeDolarMepBABAAL30Trade()
    {

        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - BABAD - 24hs", EntriesBuilder.Create(100, 10.3m, 10.5m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - BABA - 24hs", EntriesBuilder.Create(100, 11125m, 11150m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30D - 24hs", EntriesBuilder.Create(100, 70m, 70.01m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30 - 24hs", EntriesBuilder.Create(100, 77000m, 77020m), (s, u) => u);

        var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - BABAD - 24hs"));
        var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30D - 24hs"));
        var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30 - 24hs"));
        var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - BABA - 24hs"));

        var sellThenBuy = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
        var buyThenSell = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
        var ratioTrade = new RatioTrade(RatioTradeType.MEP, sellThenBuy, buyThenSell);

        ratioTrade.RefreshData();

        ratioTrade.SellThenBuyRatio.Should().BeApproximately(1082.52m, 0.01m);
        ratioTrade.BuyThenSellRatio.Should().BeApproximately(1099.84m, 0.01m);

        ratioTrade.Profit.Should().BeGreaterThan(0);

    }
}
