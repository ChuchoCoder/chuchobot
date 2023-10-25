using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{
    internal class DolarCalculatorProcessor
    {
        public List<DolarTradedInstrument> dolarTradedInstruments = new List<DolarTradedInstrument>();

        internal void Init()
        {
            foreach (string arbitrationTicker in Properties.Settings.Default.ArbitrationTickers)
            {
                if (arbitrationTicker.ContainsMultipleTickers())
                {
                    DolarTradedInstrument arbitration = new DolarTradedInstrument(arbitrationTicker.GetPesosTicker(), arbitrationTicker.GetDolarTicker(), arbitrationTicker.GetCableTicker());

                    dolarTradedInstruments.Add(arbitration);
                }
                else
                {
                    DolarTradedInstrument arbitration = new DolarTradedInstrument(arbitrationTicker);

                    dolarTradedInstruments.Add(arbitration);
                }

            }
        }

        public void RefreshData()
        {
            foreach (DolarTradedInstrument dolarTradedInstrument in dolarTradedInstruments)
            {
                dolarTradedInstrument.RefreshData();
            }
        }

        public List<BuySellTrade> GetDolarMEPTrades()
        {
            List<BuySellTrade> trades = new List<BuySellTrade>();

            foreach (DolarTradedInstrument dolarArbitrationData in dolarTradedInstruments)
            {

                IEnumerable<BuySellTrade> dolarTrades = dolarArbitrationData.GetDolarMEPTrades().Where(x => x.Last > 0 || x.BuyPrice > 0 || x.SellPrice > 0);
                trades.AddRange(dolarTrades);

            }

            return trades;
        }

        public List<BuySellTrade> GetDolarCableTrades()
        {
            List<BuySellTrade> trades = new List<BuySellTrade>();

            foreach (DolarTradedInstrument dolarArbitrationData in dolarTradedInstruments)
            {
                IEnumerable<BuySellTrade> dolarTrades = dolarArbitrationData.GetDolarCableTrades().Where(x => x.Last > 0 || x.BuyPrice > 0 || x.SellPrice > 0);
                trades.AddRange(dolarTrades);
            }

            return trades;
        }
    }
}
