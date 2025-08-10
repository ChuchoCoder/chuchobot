using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Primary.Api;

namespace ChuchoBot.WinFormsApp.Tests;

public class DolarArbitrationProcessorTests: InstrumentTests
{
    public DolarArbitrationProcessorTests()
    {
        Argentina.Data.LatestMarketData.Clear();
    }

    [Fact]
    public void Arbitrar_Dolar_MEP_BABA_AL30()
    {
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - BABAD - 24hs", EntriesBuilder.Create(100, 10.3m, 10.5m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - BABA - 24hs", EntriesBuilder.Create(100, 11125m, 11150m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30D - 24hs", EntriesBuilder.Create(100, 70m, 70.01m), (s, u) => u);
        Argentina.Data.LatestMarketData.AddOrUpdate("MERV - XMEV - AL30 - 24hs", EntriesBuilder.Create(100, 77000m, 77020m), (s, u) => u);

        var dolarArbi = new DolarArbitrationProcessor(["AL30", "BABA"]);

        dolarArbi.Init();

        var trades = dolarArbi.GetArbitrationTrades(ccl: false, dc: false, cd: false);

        trades.Count.Should().Be(1);
        var dolarMepCompra = 11150m / 10.3m;
        var dolarMepVenta = 77000m / 70.01m;
        var profit = dolarMepVenta / dolarMepCompra - 1m;
        trades[0].Profit.Should().BeApproximately(profit, 0.001m);
    }
}
