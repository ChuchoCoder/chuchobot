using Primary.Data;
using Primary.WinFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener las posibles operaciones de arbitraje de dolar (MEP o CCL) teniendo en cuenta los diferentes plazos de liquidación habilitados en BYMA
    /// </summary>
    [DebuggerDisplay("{Owned.Ticker} / {Arbitration.Ticker}")]
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

        

        public IEnumerable<DolarArbitrationTrade> GetTradesBasedOnSettlementTerm(
            DolarTrade owned_SellCI_BuyCI,
            DolarTrade owned_SellCI_Buy24,
            DolarTrade owned_SellCI_Buy48,
            DolarTrade owned_Sell24_Buy24,
            DolarTrade owned_Sell24_Buy48,
            DolarTrade owned_Sell48_Buy48,
            DolarTrade arbitration_BuyCI_SellCI,
            DolarTrade arbitration_BuyCI_Sell24,
            DolarTrade arbitration_BuyCI_Sell48,
            DolarTrade arbitration_Buy24_Sell24,
            DolarTrade arbitration_Buy24_Sell48,
            DolarTrade arbitration_Buy48_Sell48)
        {
            /*
            Op  1	Op 4	Op 2	Op 3	
            Venta	Compra	Compra 	Venta	
            AL30D	AL30	GD30D	GD30	
            CI		CI		CI		CI		
            CI		24		CI		CI		
            CI		48		CI		CI		
            CI		24		CI		24		
            CI		48		CI		24		
            CI		48		CI		48		
            CI		24		24		24		
            CI		48		24		24		
            CI		48		24		48		
            CI		48		48		48		
            24		24		24		24		
            24		48		24		24		
            24		48		24		48		
            24		48		48		48		
            48		48		48		48		
            */

            if (Argentina.IsCIOpen())
            {
                yield return new DolarArbitrationTrade(owned_SellCI_BuyCI, arbitration_BuyCI_SellCI);
                if (Settings.Default.Enabled24Hours)
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_BuyCI_SellCI);
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_SellCI);
                if (Settings.Default.Enabled24Hours)
                {
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_BuyCI_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_Sell24);
                }
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_BuyCI_Sell48);
                if (Settings.Default.Enabled24Hours)
                {
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy24, arbitration_Buy24_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy24_Sell24);
                    yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy24_Sell48);
                }
                yield return new DolarArbitrationTrade(owned_SellCI_Buy48, arbitration_Buy48_Sell48);
            }

            if (Settings.Default.Enabled24Hours)
            {
                yield return new DolarArbitrationTrade(owned_Sell24_Buy24, arbitration_Buy24_Sell24);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy24_Sell24);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy24_Sell48);
                yield return new DolarArbitrationTrade(owned_Sell24_Buy48, arbitration_Buy48_Sell48);
            }
            yield return new DolarArbitrationTrade(owned_Sell48_Buy48, arbitration_Buy48_Sell48);
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en dolares C en Cartera (ejemplo: Venta AL30D / Compra AL30C)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetSellDolarBuyCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.Cable.TCI, Owned.Dolar.TCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Cable.T24, Owned.Dolar.TCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Cable.T48, Owned.Dolar.TCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Cable.T24, Owned.Dolar.T24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Cable.T48, Owned.Dolar.T24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Cable.T48, Owned.Dolar.T48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.Cable.TCI, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Cable.T24, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Cable.T48, Arbitration.Dolar.TCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Cable.T24, Arbitration.Dolar.T24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Cable.T48, Arbitration.Dolar.T24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Cable.T48, Arbitration.Dolar.T48);


            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en dolares en Cartera (ejemplo: Venta AL30C / Compra AL30D)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetBuyDolarSellCableArbitrationTrades()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.Dolar.TCI, Owned.Cable.TCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.Dolar.T24, Owned.Cable.TCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.Dolar.T48, Owned.Cable.TCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.Dolar.T24, Owned.Cable.T24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.Dolar.T48, Owned.Cable.T24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.Dolar.T48, Owned.Cable.T48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.Dolar.TCI, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.Dolar.T24, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.Dolar.T48, Arbitration.Cable.TCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.Dolar.T24, Arbitration.Cable.T24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.Dolar.T48, Arbitration.Cable.T24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.Dolar.T48, Arbitration.Cable.T48);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares CCL usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetDolarCableArbitrations()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.TCI, Owned.Cable.TCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.T24, Owned.Cable.TCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.T48, Owned.Cable.TCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.T24, Owned.Cable.T24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.T48, Owned.Cable.T24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.T48, Owned.Cable.T48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.TCI, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.T24, Arbitration.Cable.TCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Cable.TCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.T24, Arbitration.Cable.T24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Cable.T24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Cable.T48);

            return GetTradesBasedOnSettlementTerm(
                owned_SellCI_BuyCI,
                owned_SellCI_Buy24,
                owned_SellCI_Buy48,
                owned_Sell24_Buy24,
                owned_Sell24_Buy48,
                owned_Sell48_Buy48,
                arbitrarion_BuyCI_SellCI,
                arbitrarion_BuyCI_Sell24,
                arbitrarion_BuyCI_Sell48,
                arbitrarion_Buy24_Sell24,
                arbitrarion_Buy24_Sell48,
                arbitrarion_Buy48_Sell48
                );
        }

        /// <summary>
        /// Obtiene el arbitraje para Comprar Dolares MEP usando el bono en Cartera (ejemplo: Venta AL30D / Compra AL30)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DolarArbitrationTrade> GetDolarMEPArbitrations()
        {
            var owned_SellCI_BuyCI = new DolarTrade(Owned.TCI, Owned.Dolar.TCI);
            var owned_SellCI_Buy24 = new DolarTrade(Owned.T24, Owned.Dolar.TCI);
            var owned_SellCI_Buy48 = new DolarTrade(Owned.T48, Owned.Dolar.TCI);
            var owned_Sell24_Buy24 = new DolarTrade(Owned.T24, Owned.Dolar.T24);
            var owned_Sell24_Buy48 = new DolarTrade(Owned.T48, Owned.Dolar.T24);
            var owned_Sell48_Buy48 = new DolarTrade(Owned.T48, Owned.Dolar.T48);

            var arbitrarion_BuyCI_SellCI = new DolarTrade(Arbitration.TCI, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell24 = new DolarTrade(Arbitration.T24, Arbitration.Dolar.TCI);
            var arbitrarion_BuyCI_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Dolar.TCI);
            var arbitrarion_Buy24_Sell24 = new DolarTrade(Arbitration.T24, Arbitration.Dolar.T24);
            var arbitrarion_Buy24_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Dolar.T24);
            var arbitrarion_Buy48_Sell48 = new DolarTrade(Arbitration.T48, Arbitration.Dolar.T48);

            return GetTradesBasedOnSettlementTerm(
                 owned_SellCI_BuyCI,
                 owned_SellCI_Buy24,
                 owned_SellCI_Buy48,
                 owned_Sell24_Buy24,
                 owned_Sell24_Buy48,
                 owned_Sell48_Buy48,
                 arbitrarion_BuyCI_SellCI,
                 arbitrarion_BuyCI_Sell24,
                 arbitrarion_BuyCI_Sell48,
                 arbitrarion_Buy24_Sell24,
                 arbitrarion_Buy24_Sell48,
                 arbitrarion_Buy48_Sell48
                 );
        }

    }
}
