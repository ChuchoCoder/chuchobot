using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.Shared;
using System.Collections.Generic;
using System.Linq;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public class SettlementTermArbitrationProcessor
{
    public List<DolarTradedInstrument> TradedInstruments = [];

    internal void Init()
    {
        foreach (var arbitrationTickers in Properties.Settings.Default.TickersToMonitor)
        {
            if (arbitrationTickers.ContainsMultipleTickers())
            {
                var dolarTradedInstrument = new DolarTradedInstrument(arbitrationTickers.GetPesosTicker(), arbitrationTickers.GetDolarTicker(), arbitrationTickers.GetCableTicker());
                TradedInstruments.Add(dolarTradedInstrument);
            }
            else
            {
                var dolarTradedInstrument = new DolarTradedInstrument(arbitrationTickers);
                TradedInstruments.Add(dolarTradedInstrument);
            }
        }
    }

    public void RefreshData()
    {
        foreach (var dolarTradedInstrument in TradedInstruments)
        {
            dolarTradedInstrument.RefreshData();
        }
    }

        public List<SettlementTermTrade> GetSettlementTermTradesPesos(decimal tasaCaucion, int diasLiq24H, bool onlyShowTradesWithTickersOwned)
    {
        var allTrades = new List<SettlementTermTrade>();

        foreach (var tradedInstrument in TradedInstruments)
        {
                var trades = tradedInstrument.GetSettlementTermTrades(tasaCaucion, diasLiq24H, onlyShowTradesWithTickersOwned);
            if (trades != null && trades.Count() > 0)
            {
                allTrades.AddRange(trades);
            }
        }

        return allTrades;
    }

        public List<SettlementTermTrade> GetSettlementTermTradesDolar(decimal tasaCaucion, int diasLiq24H, bool onlyShowTradesWithTickersOwned)
    {
        var allTrades = new List<SettlementTermTrade>();

        foreach (var tradedInstrument in TradedInstruments)
        {
                var dolarTrades = tradedInstrument.Dolar.GetSettlementTermTrades(tasaCaucion, diasLiq24H, onlyShowTradesWithTickersOwned);
            if (dolarTrades != null && dolarTrades.Count() > 0)
            {
                allTrades.AddRange(dolarTrades);
            }
        }

        return allTrades;
    }



        public List<SettlementTermTrade> GetSettlementTermTradesCable(decimal tasaCaucion, int diasLiq24H, bool onlyShowTradesWithTickersOwned)
    {
        var allTrades = new List<SettlementTermTrade>();

        foreach (var tradedInstrument in TradedInstruments)
        {
                var cableTrades = tradedInstrument.Cable.GetSettlementTermTrades(tasaCaucion, diasLiq24H, onlyShowTradesWithTickersOwned);
            if (cableTrades != null && cableTrades.Count() > 0)
            {
                allTrades.AddRange(cableTrades);
            }
        }

        return allTrades;
    }
}

