using System.Collections.Generic;
using Newtonsoft.Json;
using Primary.Serialization;

namespace Primary.Data
{
    /// <summary>
    /// Market data information requested to the MarketDataWebSocket.
    /// </summary>
    public struct MarketDataInfo
    {
        /// <summary>Order type.</summary>
        [JsonProperty("type", Order=-2)] 
        public string Type => "smd";
        
        /// <summary>
        /// Real-time message update time.
        /// <list type="table">
        ///     <listheader> <term>Level</term> <description>Update time (ms)</description> </listheader>
        ///     <item> <term>1</term> <description>100</description> </item>
        ///     <item> <term>2</term> <description>500</description> </item>
        ///     <item> <term>3</term> <description>1000</description> </item>
        ///     <item> <term>4</term> <description>3000</description> </item>
        ///     <item> <term>5</term> <description>6000</description> </item>
        /// </list>
        /// </summary>
        [JsonProperty("level")]
        public uint Level;

        /// <summary>Book depth.</summary>
        /// <value>Default: 1</value>
        [JsonProperty("depth")]
        public uint Depth;

        /// <summary>Requested entries.</summary>
        [JsonProperty("entries")]
        public Entry[] Entries;

        /// <summary>Products to get the information for.</summary>
        [JsonProperty("products")]
        public Instrument[] Products;
    }

    public class MarketDataRestApi
    {
        public System.Net.HttpStatusCode Status { get; set; }

        public bool Aggregated { get; set; }

        /// <summary>Market data grouped by entry.</summary>
        [JsonProperty("marketData")]
        public Entries Data { get; set; }
    }

    public class Entries
    {
        [JsonProperty("BI")] public Trade[] Bids { get; set; }
        [JsonProperty("OF")] public Trade[] Offers { get; set; }

        [JsonProperty("LA")] public NullableTrade Last { get; set; }
        [JsonProperty("OP")] public decimal? Open { get; set; }
        [JsonProperty("CL")] public NullableTrade Close { get; set; }

        [JsonProperty("SE")] public NullableTrade SettlementPrice { get; set; }
        [JsonProperty("OI")] public NullableTrade OpenInterest { get; set; }

        [JsonProperty("HI")] public decimal? SessionHighPrice { get; set; }
        [JsonProperty("LO")] public decimal? SessionLowPrice { get; set; }
        [JsonProperty("IV")] public decimal? IndexValue { get; set; }

        [JsonProperty("TV")] public decimal? Volume { get; set; }
        [JsonProperty("NV")] public decimal? NominalVolume { get; set; }
        [JsonProperty("EV")] public decimal? EffectiveVolume { get; set; }

        public bool HasOffers()
        {
            return Offers != null && Offers.Length > 0 && Offers[0].Price > 0;
        }

        public decimal GetTopOfferSize()
        {
            if (HasOffers())
            {
                return Offers[0].Size;
            }

            return default;
        }

        public decimal GetTopOfferPrice()
        {
            if (HasOffers())
            {
                return Offers[0].Price;
            }

            return default;
        }

        public bool HasBids()
        {
            return Bids != null && Bids.Length > 0 && Bids[0].Price > 0;
        }

        public decimal GetTopBidSize()
        {
            if (HasBids())
            {
                return Bids[0].Size;
            }

            return default;
        }

        public decimal GetTopBidPrice()
        {
            if (HasBids())
            {
                return Bids[0].Price;
            }

            return default;
        }

        public bool HasLastPrice()
        {
            return Last != null && Last.Price.HasValue && Last.Price.Value != default;
        }
    }

    /// <summary>
    /// Real-time market data receive from the MarketDataWebSocket.
    /// </summary>
    public class MarketData
    {
        /// <summary>Server time in epoch format.</summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>Instrument id.</summary>
        [JsonProperty("instrumentId")]
        public Instrument Instrument { get; set; }

        /// <summary>Market data grouped by entry.</summary>
        [JsonProperty("marketData")]
        public Entries Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
