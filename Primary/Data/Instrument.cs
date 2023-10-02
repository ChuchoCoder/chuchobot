using Newtonsoft.Json;
using System.Diagnostics;

namespace Primary.Data
{
    [DebuggerDisplay("{MarketSegmentId}:{MarketId}")]
    public class Segment
    {
        public string MarketSegmentId { get; set; }
        public string MarketId { get; set; }
    }

    [DebuggerDisplay("{InstrumentId.Market}:{InstrumentId.Symbol} {Currency}")]
    public class InstrumentDetail
    {
        public Segment Segment { get; set; }
        public Instrument InstrumentId { get; set; }

        public decimal LowLimitPrice { get; set; }
        public decimal HighLimitPrice { get; set; }
        public decimal MinPriceIncrement { get; set; }
        public decimal MinTradevol { get; set; }
        public decimal MaxTradeVol { get; set; }
        public decimal TickSize { get; set; }
        public string MaturityDate { get; set; }
        public decimal ContractMultiplier { get; set; }
        public decimal RoundLot { get; set; }
        public decimal PriceConvertionFactor { get; set; }
        public string Currency { get; set; }
        public int InstrumentPricePrecision { get; set; }
        public int InstrumentSizePrecision { get; set; }
        public string CfiCode { get; set; }


        public override string ToString()
        {
            return InstrumentId?.SymbolWithoutPrefix();
        }

    }

    /// <summary>Identifies a market instrument.</summary>
    [DebuggerDisplay("{Market}:{Symbol}")]
    public class Instrument
    {
        public const string MervalPrefix = "MERV - XMEV - ";

        /// <summary>Market where the instruments belongs to.</summary>
        /// <remarks>Only accepted value is **ROFX**.</remarks>
        [JsonProperty("marketId")]
        public string Market { get; set; }

        /// <summary>Ticker of the instrument.</summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        public string SymbolWithoutPrefix()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                return Symbol.Substring(MervalPrefix.Length).Trim();
            }
            return Symbol;
        }

        public string Ticker()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                int tickerLength = Symbol.LastIndexOf('-') - MervalPrefix.Length;
                if (tickerLength > 0)
                {
                    return Symbol.Substring(MervalPrefix.Length, tickerLength).Trim();
                }
                return Symbol.Substring(MervalPrefix.Length).Trim();
            }
            return Symbol;
        }

        public string SettlementTerm()
        {
            if (Symbol.StartsWith(MervalPrefix))
            {
                if (Symbol.LastIndexOf('-') > MervalPrefix.Length)
                {
                    return Symbol.Substring(Symbol.LastIndexOf('-')).Trim();
                }
            }
            return string.Empty;

        }

        public override string ToString()
        {
            return SymbolWithoutPrefix();
        }
    }
}
