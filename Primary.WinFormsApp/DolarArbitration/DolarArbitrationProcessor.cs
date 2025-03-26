using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChuchoBot.WinFormsApp.DolarArbitration;


public class DolarArbitrationProcessor
{
    public List<DolarArbitrationInstruments> dolarArbitrationPairCollection = [];
    public IEnumerable<string> TickersToMonitor;

    public DolarArbitrationProcessor() : this(Properties.Settings.Default.TickersToMonitor.Cast<string>())
    {
    }

    public DolarArbitrationProcessor(IEnumerable<string> tickersToMonitor)
    {
        TickersToMonitor = tickersToMonitor;
    }

    internal void Init()
    {
        foreach (var ownedTicker in Argentina.Data.Positions)
        {
            var ticker = ownedTicker.Symbol.GetTicker();
            var owned = new DolarTradedInstrument(ticker);

            foreach (var arbitrationTicker in TickersToMonitor)
            {
                if (ticker != arbitrationTicker)
                {
                    if (arbitrationTicker.ContainsMultipleTickers())
                    {
                        var tickerPesos = arbitrationTicker.GetPesosTicker();
                        var tickerDolar = arbitrationTicker.GetDolarTicker();
                        var tickerCable = arbitrationTicker.GetCableTicker();
                        var arbitration = new DolarTradedInstrument(tickerPesos, tickerDolar, tickerCable);

                        dolarArbitrationPairCollection.Add(new DolarArbitrationInstruments(owned, arbitration));
                    }
                    else
                    {
                        var arbitration = new DolarTradedInstrument(arbitrationTicker);

                        dolarArbitrationPairCollection.Add(new DolarArbitrationInstruments(owned, arbitration));
                    }
                }
            }
        }
    }

    public void RefreshData()
    {
        foreach (var dolarArbitrationData in dolarArbitrationPairCollection)
        {
            dolarArbitrationData.Owned.RefreshData();
            dolarArbitrationData.Arbitration.RefreshData();
        }
    }

    public List<RatioTrade> GetArbitrationTrades(decimal minProfit = 0.005m, bool mep = true, bool ccl = true, bool dc = true, bool cd = true)
    {
        var trades = new List<RatioTrade>();

        foreach (var dolarArbitrationData in dolarArbitrationPairCollection)
        {

            if (mep)
            {
                var dolarTrades = dolarArbitrationData.GetDolarMEPArbitrations();
                trades.AddRange(dolarTrades.Where(x => x.Profit > minProfit));
            }

            if (ccl)
            {
                var cableTrades = dolarArbitrationData.GetDolarCableArbitrations();
                trades.AddRange(cableTrades.Where(x => x.Profit > minProfit));
            }

            if (dc)
            {
                var cableDolarTrades = dolarArbitrationData.GetSellDolarBuyCableArbitrationTrades();
                trades.AddRange(cableDolarTrades.Where(x => x.Profit > minProfit));
            }

            if (cd)
            {
                var dolarCableTrades = dolarArbitrationData.GetBuyDolarSellCableArbitrationTrades();
                trades.AddRange(dolarCableTrades.Where(x => x.Profit > minProfit));
            }
        }

        return trades;
    }

    public void OnMarketData(Instrument instrument, Entries data)
    {
        try
        {
            foreach (var item in dolarArbitrationPairCollection)
            {
                _ = item.UpdateData(instrument, data);
            }
        }
        catch (Exception ex)
        {
            Telemetry.LogError(nameof(OnMarketData), ex);
        }
    }
}
