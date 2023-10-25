using System;
using System.Diagnostics;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite obtener la cotización para comprar o vender Dolar
    /// </summary>
    [DebuggerDisplay("{Buy.Instrument.InstrumentId.Market}:{Buy.Instrument.InstrumentId.Symbol} {Buy.Instrument.Currency}")]
    public class BuySellTrade
    {
        public BuySellTrade(InstrumentWithData buy, InstrumentWithData sell)
        {
            Buy = buy;
            Sell = sell;
        }

        /// <summary>
        /// Obtiene el instrumento que se desea comprar
        /// </summary>
        public InstrumentWithData Buy { get; set; }

        /// <summary>
        /// Obtiene el instrumento que se desea vender
        /// </summary>
        public InstrumentWithData Sell { get; set; }

        public string Trade
        {
            get {
                return Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + " / " + Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
            }
        }

        /// <summary>
        /// Obtiene el ultimo tipo de cambio para el Dolar utilizando Pesos.Last / Dolar.Last
        /// </summary>
        public decimal Last
        {
            get {
                if (HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice())
                {
                    return Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value;
                }
                return default;
            }
        }

        /// <summary>
        /// Compra Dolar ($ Offer / USD Bid)
        /// Obtiene el tipo de cambio para Comprar Dolar utilizando Pesos.Offers / Dolar.Bids
        /// </summary>
        public decimal BuyPrice // Barato
        {
            get {
                if (HasData() && Buy.Data.HasOffers() && Sell.Data.HasBids())
                {
                    return Buy.Data.Offers[0].Price / Sell.Data.Bids[0].Price;
                }
                return default;
            }
        }

        /// <summary>
        /// Venta Dolar ($ Bid / USD Offer)
        /// Obtiene el tipo de cambio para Vender Dolar utilizando Pesos.Bids / Dolar.Offers
        /// </summary>
        public decimal SellPrice // Caro
        {
            get {
                if (HasData() && Buy.Data.HasBids() && Sell.Data.HasOffers())
                {
                    return Buy.Data.Bids[0].Price / Sell.Data.Offers[0].Price;
                }
                return default;
            }
        }

        public bool HasData()
        {
            return Buy.Data != null && Sell.Data != null;
        }

        internal void RefreshData()
        {
            Buy.RefreshData();
            Sell.RefreshData();
        }
    }
}
