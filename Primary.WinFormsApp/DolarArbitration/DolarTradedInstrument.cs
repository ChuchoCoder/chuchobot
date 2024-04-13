using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System.Collections.Generic;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

/// <summary>
/// Permite construir a partir de un Ticker en Pesos (ej. AL30) los diferentes plazos de liquidación y dolar (D y C) en los que se puede operar
/// </summary>
public class DolarTradedInstrument : TradedInstrumentWithSettlementTerms
{
    public DolarTradedInstrument(string ticker)
        : this(ticker, ticker.AddDolarSuffix(), ticker.AddCableSuffix())
    {
    }

    public DolarTradedInstrument(string ticker, string tickerDolar, string tickerCable) : base(ticker)
    {
        Dolar = new TradedInstrumentWithSettlementTerms(tickerDolar);
        Cable = new TradedInstrumentWithSettlementTerms(tickerCable);

        RefreshData();
    }

    public TradedInstrumentWithSettlementTerms Dolar { get; set; }
    public TradedInstrumentWithSettlementTerms Cable { get; set; }

    public IEnumerable<InstrumentWithData> GetAll()
    {
        yield return T48;
        yield return T24;
        yield return TCI;
        yield return Dolar.T48;
        yield return Dolar.T24;
        yield return Dolar.TCI;
        yield return Cable.T48;
        yield return Cable.T24;
        yield return Cable.TCI;
    }

    public bool ContainsSymbol(string symbol)
    {
        var isMatch =
            T48.Instrument.InstrumentId.Symbol == symbol ||
            T24.Instrument.InstrumentId.Symbol == symbol ||
            TCI.Instrument.InstrumentId.Symbol == symbol ||
            Dolar.T48.Instrument.InstrumentId.Symbol == symbol ||
            Dolar.T24.Instrument.InstrumentId.Symbol == symbol ||
            Dolar.TCI.Instrument.InstrumentId.Symbol == symbol ||
            Cable.T48.Instrument.InstrumentId.Symbol == symbol ||
            Cable.T24.Instrument.InstrumentId.Symbol == symbol ||
            Cable.TCI.Instrument.InstrumentId.Symbol == symbol;

        return isMatch;
    }

    public override void RefreshData()
    {
        base.RefreshData();

        Dolar.RefreshData();

        Cable.RefreshData();
    }

    public bool UpdateData(Instrument instrument, Entries data)
    {
        return UpdateData(instrument.Symbol, data);
    }

    public bool UpdateData(string symbol, Entries data)
    {
        return
            T48.UpdateData(symbol, data) ||
            T24.UpdateData(symbol, data) ||
            TCI.UpdateData(symbol, data) ||
            Dolar.T48.UpdateData(symbol, data) ||
            Dolar.T24.UpdateData(symbol, data) ||
            Dolar.TCI.UpdateData(symbol, data) ||
            Cable.T48.UpdateData(symbol, data) ||
            Cable.T24.UpdateData(symbol, data) ||
            Cable.TCI.UpdateData(symbol, data);
    }


    public IEnumerable<BuySellTrade> GetDolarCableTrades()
    {
        if (Argentina.IsCIOpen())
        {
            yield return new BuySellTrade(TCI, Cable.TCI);
            yield return new BuySellTrade(T24, Cable.TCI);
            yield return new BuySellTrade(T48, Cable.TCI);
        }
        yield return new BuySellTrade(T24, Cable.T24);
        yield return new BuySellTrade(T48, Cable.T24);
        yield return new BuySellTrade(T48, Cable.T48);
    }

    public IEnumerable<BuySellTrade> GetDolarMEPTrades()
    {
        if (Argentina.IsCIOpen())
        {
            yield return new BuySellTrade(TCI, Dolar.TCI);
            yield return new BuySellTrade(TCI, Dolar.T24);
            yield return new BuySellTrade(TCI, Dolar.T48);

            yield return new BuySellTrade(T24, Dolar.TCI);

            yield return new BuySellTrade(T48, Dolar.TCI);
        }
        yield return new BuySellTrade(T24, Dolar.T24);
        yield return new BuySellTrade(T24, Dolar.T48);


        yield return new BuySellTrade(T48, Dolar.T24);
        yield return new BuySellTrade(T48, Dolar.T48);
    }

    public IEnumerable<BuySellTrade> GetDolarMEPCableTrades()
    {
        if (Argentina.IsCIOpen())
        {
            yield return new BuySellTrade(Dolar.TCI, Cable.TCI);
            yield return new BuySellTrade(Dolar.T24, Cable.TCI);
            yield return new BuySellTrade(Dolar.T48, Cable.TCI);
        }
        yield return new BuySellTrade(Dolar.T24, Cable.T24);
        yield return new BuySellTrade(Dolar.T48, Cable.T24);
        yield return new BuySellTrade(Dolar.T48, Cable.T48);
    }

    public IEnumerable<BuySellTrade> GetDolarCableMEPTrades()
    {
        if (Argentina.IsCIOpen())
        {
            yield return new BuySellTrade(Cable.TCI, Dolar.TCI);
            yield return new BuySellTrade(Cable.T24, Dolar.TCI);
            yield return new BuySellTrade(Cable.T48, Dolar.TCI);
        }
        yield return new BuySellTrade(Cable.T24, Dolar.T24);
        yield return new BuySellTrade(Cable.T48, Dolar.T24);
        yield return new BuySellTrade(Cable.T48, Dolar.T48);
    }

}
