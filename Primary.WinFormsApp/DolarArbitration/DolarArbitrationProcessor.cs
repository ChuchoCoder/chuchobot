using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        if (Argentina.Data.Positions == null || Argentina.Data.Positions.Length == 0)
        {
            MessageBox.Show("No hay posiciones abiertas en Argentina", "Sin Posiciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

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
                var profitableTrades = dolarTrades.Where(x => !x.IsInAuction && x.Profit > minProfit);
                if (profitableTrades.Any())
                {
                    trades.AddRange(profitableTrades);
                }
            }

            if (ccl)
            {
                var cableTrades = dolarArbitrationData.GetDolarCableArbitrations();
                var profitableTrades = cableTrades.Where(x => !x.IsInAuction && x.Profit > minProfit);
                if (profitableTrades.Any())
                {
                    trades.AddRange(profitableTrades);
                }
            }

            if (dc)
            {
                var cableDolarTrades = dolarArbitrationData.GetSellDolarBuyCableArbitrationTrades();
                var profitableTrades = cableDolarTrades.Where(x => !x.IsInAuction && x.Profit > minProfit);
                if (profitableTrades.Any())
                {
                    trades.AddRange(profitableTrades);
                }
            }

            if (cd)
            {
                var dolarCableTrades = dolarArbitrationData.GetBuyDolarSellCableArbitrationTrades();
                var profitableTrades = dolarCableTrades.Where(x => !x.IsInAuction && x.Profit > minProfit);
                if (profitableTrades.Any())
                {
                    trades.AddRange(profitableTrades);
                }
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
