using ChuchoBot.WinFormsApp.Shared;
using System.Collections.Generic;
using System.Linq;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

internal class DolarCalculatorProcessor
{
    public List<DolarTradedInstrument> dolarTradedInstruments = [];

    internal void Init()
    {
        foreach (var arbitrationTicker in Properties.Settings.Default.TickersToMonitor)
        {
            if (arbitrationTicker.ContainsMultipleTickers())
            {
                var arbitration = new DolarTradedInstrument(arbitrationTicker.GetPesosTicker(), arbitrationTicker.GetDolarTicker(), arbitrationTicker.GetCableTicker());

                dolarTradedInstruments.Add(arbitration);
            }
            else
            {
                var arbitration = new DolarTradedInstrument(arbitrationTicker);

                dolarTradedInstruments.Add(arbitration);
            }

        }
    }

    public void RefreshData()
    {
        foreach (var dolarTradedInstrument in dolarTradedInstruments)
        {
            dolarTradedInstrument.RefreshData();
        }
    }

    public List<BuySellTrade> GetDolarMEPTrades()
    {
        List<BuySellTrade> trades = [];

        foreach (var dolarArbitrationData in dolarTradedInstruments)
        {

            var dolarTrades = dolarArbitrationData.GetDolarMEPTrades().Where(x => x.Last > 0 || x.BuyPrice > 0 || x.SellPrice > 0);
            trades.AddRange(dolarTrades);

        }

        return trades;
    }

    public List<BuySellTrade> GetDolarCableTrades()
    {
        List<BuySellTrade> trades = [];

        foreach (var dolarArbitrationData in dolarTradedInstruments)
        {
            var dolarTrades = dolarArbitrationData.GetDolarCableTrades().Where(x => x.Last > 0 || x.BuyPrice > 0 || x.SellPrice > 0);
            trades.AddRange(dolarTrades);
        }

        return trades;
    }
}
