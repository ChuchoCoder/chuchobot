using System;
using Newtonsoft.Json;

namespace Primary.Data
{
    /// <summary>
    /// Contains the information about a trade.
    /// </summary>
    public class Trade
    {
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("servertime")]
        public long ServerTime { get; set; }

        [JsonProperty("date")]
        private long Date { set { DateTime = FromUnixTime(value); } }

        public static DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTime);
        }
    }

    /// <summary>
    /// Contains the information about a trade.
    /// </summary>
    public class NullableTrade
    {
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("size")]
        public decimal? Size { get; set; }

        [JsonProperty("datetime")]
        public DateTime? DateTime { get; set; }

        [JsonProperty("servertime")]
        public long ServerTime { get; set; }

        [JsonProperty("date")]
        private long? Date { 
            set {
                if (value != null)
                {
                    DateTime = FromUnixTime(value.Value);
                }
                else
                {
                    DateTime = null;
                }
            } 
        }

        public static DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTime);
        }
    }
}
