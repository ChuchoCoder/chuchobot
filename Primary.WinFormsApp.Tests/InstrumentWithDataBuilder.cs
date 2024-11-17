using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;

namespace ChuchoBot.WinFormsApp.Tests;

public class InstrumentWithDataBuilder
{
    public static InstrumentWithData Create(string ticker, decimal priceConversionFactor, decimal size, decimal bidPrice, decimal offerPrice)
    {
        var instrument = new InstrumentDetail()
        {
            InstrumentId = new Instrument() { Symbol = ticker },
            PriceConvertionFactor = priceConversionFactor
        };
        var data = new InstrumentWithData(instrument)
        {
            Data = EntriesBuilder.Create(size, bidPrice, offerPrice)
        };

        return data;
    }
}
