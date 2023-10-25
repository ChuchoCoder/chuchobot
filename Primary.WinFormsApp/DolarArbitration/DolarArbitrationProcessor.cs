using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{

    public class DolarArbitrationProcessor
    {
        public List<DolarArbitrationInstruments> dolarArbitrationPairCollection = new List<DolarArbitrationInstruments>();

        internal void Init()
        {
            foreach (var ownedTicker in Properties.Settings.Default.OwnedTickers)
            {
                var owned = new DolarTradedInstrument(ownedTicker);

                foreach (var arbitrationTicker in Properties.Settings.Default.ArbitrationTickers)
                {
                    if (ownedTicker != arbitrationTicker)
                    {
                        if (arbitrationTicker.ContainsMultipleTickers())
                        {
                            var arbitration = new DolarTradedInstrument(arbitrationTicker.GetPesosTicker(), arbitrationTicker.GetDolarTicker(), arbitrationTicker.GetCableTicker());

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
                    item.UpdateData(instrument, data);
                }
            }
            catch (Exception ex)
            {
                Telemetry.LogError(nameof(OnMarketData), ex);
            }
        }
    }
}
