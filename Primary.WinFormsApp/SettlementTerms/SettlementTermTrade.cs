using Primary.Data;
using System;

namespace Primary.WinFormsApp
{
    public class SettlementTermTrade
    {
        public static int DiasLiq24H { get; private set; } = 1;
        public static int DiasLiq48H { get; private set; } = 2;
        public decimal BuyPrice { get; private set; }
        public decimal BuyTotalSinComisiones { get; private set; }
        public decimal BuyComisionDerechos { get; private set; }
        public decimal BuyTotalNeto { get; private set; }

        
        public int DiasCaucion { get; private set; }
        public bool EsCaucionColocadora { get; private set; }

        public decimal SellPrice { get; private set; }
        public decimal SellTotalSinComisiones { get; private set; }
        public decimal SellComisionDerechos { get; private set; }
        public decimal SellTotalNeto { get; private set; }

        public decimal TotalACaucionar { get; private set; }

        public Caucion Caucion { get; private set; }


        public decimal ProfitLoss { get; private set; } // => EsColocadora ? SellTotalNeto - BuyTotalNeto + InteresNeto : SellTotalNeto - BuyTotalNeto - InteresNeto;

        public decimal SellSize { get; private set; }
        public decimal BuySize { get; private set; }
        public decimal TradeSize { get; private set; }
        
        public decimal SellPriceTarget { get; private set; }
        public decimal BuyPriceTarget { get; private set; }

        public decimal SpreadTNA { get; private set; }

        /// <summary>
        /// TNA Spread - TNA Caucion
        /// </summary>
        public decimal SpreadCaucion { get; private set; }

        public SettlementTermTrade(InstrumentWithData buy, InstrumentWithData sell)
        {
            Buy = buy;
            Sell = sell;
        }
        public InstrumentWithData Sell { get; private set; }
        public InstrumentWithData Buy { get; private set; }

        public void Calculate(decimal nominales, decimal sellPrice, decimal buyPrice, decimal tasaCaucion)
        {
            Calculate(nominales, sellPrice, buyPrice, tasaCaucion, DiasLiq24H, DiasLiq48H);
        }

        public void Calculate(decimal nominales, decimal tasaCaucion, int diasLiq24H, int diasLiq48H)
        {
            DiasLiq24H = diasLiq24H;
            DiasLiq48H = diasLiq48H;

            if (HasData() && Sell.Data.HasBids() && Buy.Data.HasOffers())
            {

                SellSize = Sell.Data.GetTopBidSize();
                BuySize = Buy.Data.GetTopOfferSize();

                if (nominales <= 0)
                {
                    nominales = Math.Min(SellSize, BuySize);
                }

                Calculate(nominales, Sell.Data.GetTopBidPrice(), Buy.Data.GetTopOfferPrice(), tasaCaucion, diasLiq24H, diasLiq48H);

            }
        }

        public void Calculate(decimal nominales, decimal sellPrice, decimal buyPrice, decimal tasaCaucion, int diasLiq24H, int diasLiq48H)
        {
            DiasLiq24H = diasLiq24H;
            DiasLiq48H = diasLiq48H;

            SellSize = nominales;
            BuySize = nominales;

            TradeSize = nominales;

            SellPrice = sellPrice;
            SellTotalSinComisiones = SellPrice * TradeSize * Sell.Instrument.PriceConvertionFactor;
            SellComisionDerechos = Sell.Instrument.CalculateComisionDerechosMercado(SellTotalSinComisiones);
            SellTotalNeto = SellTotalSinComisiones - SellComisionDerechos;

            BuyPrice = buyPrice;
            BuyTotalSinComisiones = BuyPrice * TradeSize * Buy.Instrument.PriceConvertionFactor;
            BuyComisionDerechos = Buy.Instrument.CalculateComisionDerechosMercado(BuyTotalSinComisiones);
            BuyTotalNeto = BuyTotalSinComisiones + BuyComisionDerechos;

            DiasCaucion = Sell.Instrument.CalculateSettlementDays(Buy.Instrument, diasLiq24H, diasLiq48H);
            EsCaucionColocadora = DiasCaucion < 0;

            TotalACaucionar = EsCaucionColocadora ? SellTotalNeto : BuyTotalNeto;

            Caucion = new Caucion(DiasCaucion, tasaCaucion, TotalACaucionar);

            BuyPriceTarget = SellPrice * (1 + Caucion.Tasa);
            SellPriceTarget = BuyPrice * (1 - Caucion.Tasa);

            SpreadTNA = Math.Abs(((SellPrice/ BuyPrice) - 1m) / DiasCaucion * 365m);

            if (Caucion.EsColocadora)
            {
                ProfitLoss = SellTotalNeto - BuyTotalNeto + Caucion.InteresNeto;
            }
            else
            {
                ProfitLoss = SellTotalNeto - BuyTotalNeto - Caucion.InteresNeto;
            }
            var caucion = Caucion.TNA / 100m;
            SpreadCaucion = SpreadTNA - caucion;
        }

        public decimal Spread
        {
            get
            {
                if (HasData() && Sell.Data.HasBids() && Buy.Data.HasOffers())
                {
                    var sellPrice = Sell.Data.GetTopBidPrice();
                    var buyPrice = Buy.Data.GetTopOfferPrice();
                    var diffPct = (sellPrice / buyPrice) - 1m;
                    return diffPct;
                }
                return -100m;
            }
        }

        public decimal SpreadLast => HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice()
                    ? (Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value) - 1
                    : -100m;


        // Barato
        //public decimal BuyPrice => Buy.Data != null && Buy.Data.HasOffers() ? Buy.Data.Offers[0].Price : default;

        // Caro
        //public decimal SellPrice => Sell.Data != null && Sell.Data.HasBids() ? Sell.Data.Bids[0].Price : default;

        public bool HasData()
        {
            return Buy.Data != null && Sell.Data != null;
        }
    }
}

