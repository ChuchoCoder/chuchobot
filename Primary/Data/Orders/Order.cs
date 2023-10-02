using System;
using Newtonsoft.Json;

namespace Primary.Data.Orders
{
    /// <summary>
    /// Has all the necesary information to submit an order.
    /// </summary>
    public class Order : OrderId
    {
        /// <summary>Cancel previous order to the instrument.</summary>
        [JsonProperty("cancelPrevious")]
        public bool CancelPrevious { get; set; }

        /// <summary>Is this an iceberg order?</summary>
        [JsonProperty("iceberg")]
        public bool Iceberg { get; set; }

        /// <summary>How much of the order quantity is shown.</summary>
        [JsonProperty("displayQty")]
        public uint DisplayQuantity { get; set; }

        /// <summary>Which instrument is the order for.</summary>
        [JsonProperty("instrumentId")]
        public Instrument Instrument { get; set; }

        /// <summary>Instrument price.</summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        
        /// <summary>Order size.</summary>
        [JsonProperty("orderQty")]
        public int Quantity { get; set; }
        
        /// <summary>Market or limit.</summary>
        [JsonProperty("ordType")]
        public Orders.Type Type { get; set; }
        
        /// <summary>Buy or sell.</summary>
        [JsonProperty("side")]
        public Side Side { get; set; }

        /// <summary>How long the order will last if not filled.</summary>
        [JsonProperty("timeInForce")]
        public Expiration Expiration { get; set; }
        
        /// <summary>Order expiration date.</summary>
        /// <remarks>Only valid when `Expiration` is `GoodTillDate`.</remarks>
        [JsonProperty("expireDate")]
        public DateTime ExpirationDate { get; set; }
    }
}
