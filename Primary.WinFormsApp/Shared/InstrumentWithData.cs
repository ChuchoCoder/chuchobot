using Primary.Data;
using System.Diagnostics;

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
}
