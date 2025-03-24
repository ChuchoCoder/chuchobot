using Primary.Data;
using System.Diagnostics;
using Primary.Data.Orders;
using System;

namespace ChuchoBot.WinFormsApp.Shared;

[DebuggerDisplay("{Instrument.InstrumentId.Market}:{Instrument.InstrumentId.Symbol} {Instrument.Currency}")]
public class InstrumentWithData
{
    public InstrumentDetail Instrument { get; set; }
    public Entries Data { get; set; }

    public void RefreshData()
    {
        if (Instrument == null)
        {
            return;
        }

        Data = Argentina.Data.GetLatestOrNull(Instrument.InstrumentId.Symbol);
    }

    public bool UpdateData(string symbol, Entries data)
    {
        if (Instrument.InstrumentId.Symbol == symbol)
        {
            Data = data;
            return true;
        }

        return false;
    }

    public InstrumentWithData(InstrumentDetail instrument)
    {
        Instrument = instrument;
    }

    public InstrumentWithData(InstrumentDetail instrument, Entries data)
    {
        Instrument = instrument;
        Data = data;
    }

    public override string ToString()
    {
        return Instrument.InstrumentId.SymbolWithoutPrefix();
    }

    public bool HasBids()
    {
        return Data != null && Data.HasBids();
    }

    public bool HasOffers()
    {
        return Data != null && Data.HasOffers();
    }

    public decimal? BidPrice()
    {
        return HasBids() ? Data.GetTopBidPrice() : null;
    }

    public decimal? OfferPrice()
    {
        return HasBids() ? Data.GetTopOfferPrice() : null;
    }

    public decimal CalculateOfferSize(decimal total)
    {
        var offerPrice = OfferPrice();
        if (offerPrice.HasValue == false)
            return decimal.Zero;

        var size = Math.Truncate(total / offerPrice.Value / Instrument.PriceConvertionFactor);
        return size;
    }

    public decimal CalculateBidSize(decimal total)
    {
        var bidPrice = BidPrice();
        if (bidPrice.HasValue == false)
            return decimal.Zero;

        var size = Math.Truncate(total / bidPrice.Value / Instrument.PriceConvertionFactor);
        return size;
    }

    public InstrumentOperation SellOperation(decimal size)
    {
        var price = BidPrice();

        if (price == null)
            price = decimal.MinValue;

        return new InstrumentOperation(Side.Sell, size, price.Value, Instrument);
    }

    public InstrumentOperation BuyOperation(decimal size)
    {
        var price = OfferPrice();

        if (price == null)
            price = decimal.MaxValue;

        return new InstrumentOperation(Side.Buy, size, price.Value, Instrument);
    }
}
