using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{
    public class TradedInstrumentWithSettlementTerms
    {
        public TradedInstrumentWithSettlementTerms(string ticker)
        {
            Ticker = ticker;

            try
            {
                T48 = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ticker.ToMervalSymbol48H()));
                T24 = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ticker.ToMervalSymbol24H()));
                TCI = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ticker.ToMervalSymbolCI()));

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occurred with ticker {ticker}: {ex.Message}", ex);
            }
        }

        public string Ticker { get; private set; }

        public InstrumentWithData T48 { get; set; }
        public InstrumentWithData T24 { get; set; }
        public InstrumentWithData TCI { get; set; }

        public override string ToString()
        {
            return Ticker + " " + base.ToString();
        }

        public virtual void RefreshData()
        {
            T48.RefreshData();
            T24.RefreshData();
            TCI.RefreshData();
        }

        public IEnumerable<SettlementTermTrade> GetSettlementTermTrades(decimal tasaCaucion, int diasLiq24H, int diasLiq48H, bool onlyShowTradesWithTickersOwned)
        {
            if (onlyShowTradesWithTickersOwned == false || 
                (T24?.Instrument?.InstrumentId != null && Argentina.Data.CanTickerBeSelledIn24H(T24.Instrument.InstrumentId.Symbol.GetTicker())))
            {
                var t48_24 = GetSettlementTermTrade(T48, T24, tasaCaucion, diasLiq24H, diasLiq48H);
                if (t48_24 != null)
                    yield return t48_24;
            }

            var t24_48 = GetSettlementTermTrade(T24, T48, tasaCaucion, diasLiq24H, diasLiq48H);
            if (t24_48 != null)
                yield return t24_48;

            if (Argentina.IsCIOpen())
            {
                if (onlyShowTradesWithTickersOwned == false || 
                    (TCI?.Instrument?.InstrumentId != null &&  Argentina.Data.CanTickerBeSelledInCI(TCI.Instrument.InstrumentId.Symbol.GetTicker())))
                {
                    var t48_CI = GetSettlementTermTrade(T48, TCI, tasaCaucion, diasLiq24H, diasLiq48H);
                    if (t48_CI != null)
                        yield return t48_CI;

                    var t24_CI = GetSettlementTermTrade(T24, TCI, tasaCaucion, diasLiq24H, diasLiq48H);
                    if (t24_CI != null)
                        yield return t24_CI;
                }

                var tCI_48 = GetSettlementTermTrade(TCI, T48, tasaCaucion, diasLiq24H, diasLiq48H);
                if (tCI_48 != null)
                    yield return tCI_48;

                var tCI_24 = GetSettlementTermTrade(TCI, T24, tasaCaucion, diasLiq24H, diasLiq48H);
                if (tCI_24 != null)
                    yield return tCI_24;
            }
        }

        public static SettlementTermTrade GetSettlementTermTrade(InstrumentWithData buy, InstrumentWithData sell, decimal tasaCaucion, int diasLiq24H, int diasLiq48H)
        {
            if (sell.HasBids() && buy.HasOffers())
            {
                var sellPrice = sell.Data.GetTopBidPrice();
                var buyPrice = buy.Data.GetTopOfferPrice();

                var days = buy.Instrument.CalculateSettlementDays(sell.Instrument, diasLiq24H, diasLiq48H);

                var caucion = tasaCaucion / 365m * days / 100m;
                var targetSellPrice = buyPrice * (1m - caucion * 1.1m);

                if (sellPrice >= targetSellPrice)
                {
                    return new SettlementTermTrade(buy, sell);
                }
            }

            return null;
        }
    }
}
