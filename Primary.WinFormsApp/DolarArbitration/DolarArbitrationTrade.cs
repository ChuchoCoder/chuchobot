using System.Diagnostics;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite calcular la ganancia al realizar una operación de arbitraje de dolar (MEP o CCL)
    /// </summary>
    [DebuggerDisplay("{Owned.Buy.Instrument.InstrumentId.Symbol} / {Arbitration.Buy.Instrument.InstrumentId.Symbol}")]
    public class DolarArbitrationTrade
    {
        public DolarTrade Owned { get; set; }
        public DolarTrade Arbitration { get; set; }

        public DolarArbitrationTrade(DolarTrade owned, DolarTrade arbitration)
        {
            Owned = owned;
            Arbitration = arbitration;
        }

        public decimal Profit
        {
            get {
                if (Arbitration.SellPrice > 0 && Owned.BuyPrice > 0)
                {
                    return (Arbitration.SellPrice / Owned.BuyPrice) - 1;
                }

                return -100;
            }
        }

        public decimal ProfitLast
        {
            get {
                if (Arbitration.Last > 0 && Owned.Last > 0)
                {
                    return (Arbitration.Last / Owned.Last) - 1;
                }

                return -100;
            }
        }

        /// <summary>
        /// Evalua la disponibilidad de nominales en cada una de las cajas de puntas y devuelve la máxima cantidad actualmente disponible
        /// </summary>
        /// <returns></returns>
        public int GetOwnedVentaMaxSize()
        {
            var ownedCompraSize = Owned.Buy.Data.GetTopBidSize();
            var ownedCompraPrice = Owned.Buy.Data.GetTopBidPrice();
            var ownedCompra = ownedCompraSize * ownedCompraPrice;

            var arbitrationVentaSize = Arbitration.Buy.Data.GetTopBidSize();
            var arbitrationVentaPrice = Arbitration.Buy.Data.GetTopBidPrice();
            var arbitrationVenta = arbitrationVentaSize * arbitrationVentaPrice;

            var arbitrationCompraSize = Arbitration.Sell.Data.GetTopBidSize();
            var arbitrationCompraPrice = Arbitration.Sell.Data.GetTopBidPrice();

            var ownedVentaSize = Owned.Buy.Data.GetTopBidSize();
            var ownedVentaPrice = Owned.Buy.Data.GetTopBidPrice();

            return 0;
        }
    }
}
