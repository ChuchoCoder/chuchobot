using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Diagnostics;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

/// <summary>
/// Permite obtener la cotización para comprar o vender Dolar
/// </summary>
[DebuggerDisplay("{Buy.Instrument.InstrumentId.Market,nq}:{Buy.Instrument.InstrumentId.Symbol,nq} {Buy.Instrument.Currency,nq}")]
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

    public string TradeText => Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + " / " + Sell.Instrument.InstrumentId.SymbolWithoutPrefix();

    /// <summary>
    /// Obtiene el ultimo tipo de cambio para el Dolar utilizando Pesos.Last / Dolar.Last
    /// </summary>
    public decimal Last => HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice()
                ? Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value
                : default;

    /// <summary>
    /// Compra Dolar (Buy Offer $ / Sell Bid USD)
    /// Obtiene el tipo de cambio para Comprar Dolar utilizando Pesos.Offers / Dolar.Bids
    /// </summary>
    public decimal BuyPrice // Barato
=> HasData() && Buy.Data.HasOffers() && Sell.Data.HasBids() ? Buy.Data.Offers[0].Price / Sell.Data.Bids[0].Price : default;


    /// <summary>
    /// Compra Dolar (Sell Bid $ / USD Buy Offer)
    /// Obtiene el tipo de cambio para Comprar Dolar utilizando Sell.Bids.Price / Buy.Offers.Price
    /// </summary>
    public decimal InverseBuyPrice 
=> HasData() && Buy.Data.HasOffers() && Sell.Data.HasBids() ? Sell.Data.Bids[0].Price / Buy.Data.Offers[0].Price : default;

    /// <summary>
    /// Venta Dolar (Buy Bid $ / Sell Offer USD)
    /// Obtiene el tipo de cambio para Vender Dolar utilizando Pesos.Bids / Dolar.Offers
    /// </summary>
    public decimal SellPrice // Caro
=> HasData() && Buy.Data.HasBids() && Sell.Data.HasOffers() ? Buy.Data.Bids[0].Price / Sell.Data.Offers[0].Price : default;

    /// <summary>
    /// Venta Dolar (Sell Offer $ / USD Buy Bid)
    /// Obtiene el tipo de cambio para Vender Dolar utilizando Sell.Offers.Price / Buy.Bids.Price
    /// </summary>
    public decimal InverseSellPrice
=> HasData() && Buy.Data.HasBids() && Sell.Data.HasOffers() ? Sell.Data.Offers[0].Price / Buy.Data.Bids[0].Price : default;

    public decimal GetMinBuyOfferOrSellBidSize()
    {
        if (Buy.HasOffers() && Sell.HasBids())
        {
            return Math.Min(Buy.Data.GetTopOfferSize(), Sell.Data.GetTopBidSize());
        }

        return default;
    }

    public decimal GetMinSellOfferOrBuyBidSize()
    {
        if (Buy.HasBids() && Sell.HasOffers())
        {
            return Math.Min(Buy.Data.GetTopBidSize(), Sell.Data.GetTopOfferSize());
        }

        return default;
    }

    public bool IsSameCurrency()
    {
        return Buy.Instrument.Currency == Sell.Instrument.Currency;
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
