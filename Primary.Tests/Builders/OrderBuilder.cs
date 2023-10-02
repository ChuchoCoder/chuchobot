using System;
using System.Linq;
using Primary.Data;
using Primary.Data.Orders;

namespace Primary.Tests.Builders
{
    public class OrderBuilder
    {
        public OrderBuilder(Api api)
        {
            _api = api;
        }

        private readonly Api _api;

        private Order Build()
        {
            var instruments = _api.GetAllInstruments().Result;
            var instrument = instruments.Last( i => i.Symbol == Tests.Build.DollarFutureSymbol() );

            // Get a valid price
            var today = DateTime.Today;
            var prices = _api.GetHistoricalTrades(instrument, today.AddDays(-5), today).Result;

            return new Order
            {
                Instrument = instrument,
                Expiration = Expiration.Day,
                Type = Data.Orders.Type.Limit,
                Side = Side.Buy,
                Quantity = 1000,
                Price = prices.Last().Price - 1m
            };
        }

        public static implicit operator Order(OrderBuilder builder)
        {
            return builder.Build();
        }
    }
}
