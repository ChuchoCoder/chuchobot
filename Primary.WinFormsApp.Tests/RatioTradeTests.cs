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
    [Fact]
    public void ArbitrajeDolarMepTrade()
    {
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - EWZD - 24hs", EntriesBuilder.Create(100, 13.3m, 13.35m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - EWZ - 24hs", EntriesBuilder.Create(100, 17075m, 17100m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30D - 24hs", EntriesBuilder.Create(100, 63.58m, 63.59m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30 - 24hs", EntriesBuilder.Create(100, 82390m, 82400m), (s, u) => u);

        var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - EWZD - 24hs"));
        var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30D - 24hs"));
        var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - AL30 - 24hs"));
        var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("MERV - XMEV - EWZ - 24hs"));

        var sellThenBuy = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
        var buyThenSell = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
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
        operation.OwnedSell.Comision.Should().BeApproximately(1.28m, 0.01m);
        operation.OwnedBuy.Comision.Should().BeApproximately(1655.28m, 0.01m);

        operation.ArbitrationBuy.Comision.Should().BeApproximately(0.13m, 0.01m);
        operation.ArbitrationSell.Comision.Should().BeApproximately(171.12m, 0.01m);

        // Neto 
        operation.OwnedSell.NetTotal.Should().BeApproximately(1328.71m, 0.01m);
        operation.OwnedBuy.NetTotal.Should().BeApproximately(1711655.28m, 0.01m);

        operation.ArbitrationBuy.NetTotal.Should().BeApproximately(1320.90m, 0.01m);
        operation.ArbitrationSell.NetTotal.Should().BeApproximately(1711069.18m, 0.01m);

        // Neto en Pesos
        operation.OwnedSell.NetTotalInPesos.Should().BeApproximately(1708344.72m, 0.01m);
        operation.OwnedBuy.NetTotalInPesos.Should().BeApproximately(1711655.28m, 0.01m);

        operation.ArbitrationBuy.NetTotalInPesos.Should().BeApproximately(1698295.34m, 0.01m);
        operation.ArbitrationSell.NetTotalInPesos.Should().BeApproximately(1711069.18m, 0.01m);

        operation.ProfitTotalInPesos.Should().BeApproximately(9463.27m, 0.01m);
        operation.ProfitPercentage.Should().BeApproximately(0.0055m, 0.0001m);
        operation.ComisionTotalInPesos.Should().BeApproximately(3651.49m, 0.01m);

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
