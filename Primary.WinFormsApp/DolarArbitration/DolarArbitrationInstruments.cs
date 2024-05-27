using Primary.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener las posibles operaciones de arbitraje de dolar (MEP o CCL) teniendo en cuenta los diferentes plazos de liquidación habilitados en BYMA
    /// </summary>
    [DebuggerDisplay("{SellThenBuy.Ticker} / {BuyThenSell.Ticker}")]
    public class DolarArbitrationInstruments
    {
        public DolarTradedInstrument Owned { get; set; }
        public DolarTradedInstrument Arbitration { get; set; }

        public DolarArbitrationInstruments(DolarTradedInstrument owned, DolarTradedInstrument arbitration)
        {
            Owned = owned;
            Arbitration = arbitration;
        }

        public bool UpdateData(Instrument instrument, Entries data)
        {
            return Owned.UpdateData(instrument, data) || Arbitration.UpdateData(instrument, data);
        }



        public IEnumerable<RatioTrade> GetTradesBasedOnSettlementTerm(
            BuySellTrade owned_SellCI_BuyCI,
            BuySellTrade owned_SellCI_Buy24,

            BuySellTrade owned_Sell24_Buy24,
            BuySellTrade arbitration_BuyCI_SellCI,
            BuySellTrade arbitration_BuyCI_Sell24,
            BuySellTrade arbitration_Buy24_Sell24
            )
        {
            /*
            Op  1	Op 4	Op 2	Op 3	
            Venta	Compra	Compra 	Venta	
            AL30D	AL30	GD30D	GD30	
            CI		CI		CI		CI		
            CI		24		CI		CI		
            CI		24		CI		24		
            CI		24		24		24		
            24		24		24		24		
            */

            if (Argentina.IsCIOpen())
            {
                yield return new RatioTrade(owned_SellCI_BuyCI, arbitration_BuyCI_SellCI);

                yield return new RatioTrade(owned_SellCI_Buy24, arbitration_BuyCI_SellCI);

                yield return new RatioTrade(owned_SellCI_Buy24, arbitration_BuyCI_Sell24);


                yield return new RatioTrade(owned_SellCI_Buy24, arbitration_Buy24_Sell24);

            }

            yield return new RatioTrade(owned_Sell24_Buy24, arbitration_Buy24_Sell24);

        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en dolares C en Cartera (ejemplo: Venta AL30D / Compra AL30C)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RatioTrade> GetSellDolarBuyCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new BuySellTrade(Owned.Cable.TCI, Owned.Dolar.TCI);
            var owned_SellCI_Buy24 = new BuySellTrade(Owned.Cable.T24, Owned.Dolar.TCI);
            var owned_Sell24_Buy24 = new BuySellTrade(Owned.Cable.T24, Owned.Dolar.T24);

            var arbitrarion_BuyCI_SellCI = new BuySellTrade(Arbitration.Cable.TCI, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell24 = new BuySellTrade(Arbitration.Cable.T24, Arbitration.Dolar.TCI);
            var arbitrarion_Buy24_Sell24 = new BuySellTrade(Arbitration.Cable.T24, Arbitration.Dolar.T24);


            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_Sell24_Buy24,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_Buy24_Sell24
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en dolares en Cartera (ejemplo: Venta AL30C / Compra AL30D)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RatioTrade> GetBuyDolarSellCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new BuySellTrade(Owned.Dolar.TCI, Owned.Cable.TCI);
            var owned_SellCI_Buy24 = new BuySellTrade(Owned.Dolar.T24, Owned.Cable.TCI);
            var owned_Sell24_Buy24 = new BuySellTrade(Owned.Dolar.T24, Owned.Cable.T24);

            var arbitrarion_BuyCI_SellCI = new BuySellTrade(Arbitration.Dolar.TCI, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell24 = new BuySellTrade(Arbitration.Dolar.T24, Arbitration.Cable.TCI);
            var arbitrarion_Buy24_Sell24 = new BuySellTrade(Arbitration.Dolar.T24, Arbitration.Cable.T24);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_Sell24_Buy24,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_Buy24_Sell24
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RatioTrade> GetDolarCableArbitrations()
        {
            var owned_SellCI_BuyCI = new BuySellTrade(Owned.TCI, Owned.Cable.TCI);
            var owned_SellCI_Buy24 = new BuySellTrade(Owned.T24, Owned.Cable.TCI);

            var owned_Sell24_Buy24 = new BuySellTrade(Owned.T24, Owned.Cable.T24);

            var arbitrarion_BuyCI_SellCI = new BuySellTrade(Arbitration.TCI, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell24 = new BuySellTrade(Arbitration.T24, Arbitration.Cable.TCI);

            var arbitrarion_Buy24_Sell24 = new BuySellTrade(Arbitration.T24, Arbitration.Cable.T24);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_Sell24_Buy24,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_Buy24_Sell24
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RatioTrade> GetDolarMEPArbitrations()
        {
            var owned_SellCI_BuyCI = new BuySellTrade(Owned.TCI, Owned.Dolar.TCI);
            var owned_SellCI_Buy24 = new BuySellTrade(Owned.T24, Owned.Dolar.TCI);
            var owned_Sell24_Buy24 = new BuySellTrade(Owned.T24, Owned.Dolar.T24);

            var arbitrarion_BuyCI_SellCI = new BuySellTrade(Arbitration.TCI, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell24 = new BuySellTrade(Arbitration.T24, Arbitration.Dolar.TCI);
            var arbitrarion_Buy24_Sell24 = new BuySellTrade(Arbitration.T24, Arbitration.Dolar.T24);

            return GetTradesBasedOnSettlementTerm(
                 owned_SellCI_BuyCI,
                 owned_SellCI_Buy24,
                 owned_Sell24_Buy24,
                 arbitrarion_BuyCI_SellCI,
                 arbitrarion_BuyCI_Sell24,
                 arbitrarion_Buy24_Sell24
                 );
        }

    }
}
