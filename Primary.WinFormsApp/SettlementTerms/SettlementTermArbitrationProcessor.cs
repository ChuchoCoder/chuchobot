using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class SettlementTermTradeCalculation
    {
        public decimal BuyPrice { get; set; }
        public decimal BuyTotalSinComisiones { get; set; }
        public decimal BuyComisionDerechos { get; set; }
        public decimal BuyTotalNeto => BuyTotalSinComisiones + BuyComisionDerechos;

        public decimal SellPrice { get; set; }
        public decimal SellTotalSinComisiones { get; set; }
        public decimal SellComisionDerechos { get; set; }
        public decimal SellTotalNeto => SellTotalSinComisiones - SellComisionDerechos;

        public decimal DiasCaucion { get; set; }

        public bool EsCaucionColocadora => DiasCaucion < 0;

        public decimal TotalACaucionar => EsCaucionColocadora ? SellTotalNeto : BuyTotalNeto;

        public decimal InteresCaucion { get; set; }

        public decimal TotalCaucionConInteres => TotalACaucionar + Math.Abs(InteresCaucion);

        public decimal ArancelCaucion { get; set; }

        public decimal ComisionCaucionTotal => TotalCaucionConInteres * (ArancelCaucion / 100m * DiasCaucion / 365m);
        public decimal DerechosMercadoCaucion => TotalCaucionConInteres * 0.045m / 100 / 90 * DiasCaucion;
        public decimal GastosGarantia => EsCaucionColocadora ? 0 : TotalCaucionConInteres * 0.045m / 100 / 90 * DiasCaucion;

        public decimal GastosSinIva => ComisionCaucionTotal + DerechosMercadoCaucion + GastosGarantia;

        public decimal IvaGastos => GastosSinIva * 0.21m;

        public decimal InteresNeto => InteresCaucion + GastosSinIva + IvaGastos;

        public decimal ProfitLoss => EsCaucionColocadora ? SellTotalNeto - BuyTotalNeto + InteresNeto : SellTotalNeto - BuyTotalNeto - InteresNeto;

        public decimal SellSize { get; internal set; }
        public decimal BuySize { get; internal set; }
        public decimal TradeSize { get; internal set; }
        public decimal CaucionTarget { get; internal set; }
        public decimal SellPriceTarget { get; internal set; }
        public decimal BuyPriceTarget { get; internal set; }

        public decimal SpreadTNA { get; internal set; }
    }

    public class SettlementTermTrade
    {
        public static int DiasLiq24H { get; set; } = 1;
        public static int DiasLiq48H { get; set; } = 2;

        public SettlementTermTrade(InstrumentWithData buy, InstrumentWithData sell)
        {
            Buy = buy;
            Sell = sell;
        }
        public InstrumentWithData Sell { get; private set; }
        public InstrumentWithData Buy { get; private set; }

        public SettlementTermTradeCalculation Calculate(decimal nominales, decimal tasaCaucion, decimal comisionColocadora, decimal comisionTomadora)
        {
            return Calculate(nominales, tasaCaucion, comisionColocadora, comisionTomadora, DiasLiq24H, DiasLiq48H);
        }

        public SettlementTermTradeCalculation Calculate(decimal nominales, decimal tasaCaucion, decimal comisionColocadora, decimal comisionTomadora, int diasLiq24H, int diasLiq48H)
        {
            DiasLiq24H = diasLiq24H;
            DiasLiq48H = diasLiq48H;

            if (HasData() && Sell.Data.HasBids() && Buy.Data.HasOffers())
            {
                var trade = new SettlementTermTradeCalculation();

                trade.SellSize = Sell.Data.GetTopBidSize();
                trade.BuySize = Buy.Data.GetTopOfferSize();

                if (nominales <= 0)
                {
                    trade.TradeSize = Math.Min(trade.SellSize, trade.BuySize);
                }
                else
                {
                    trade.TradeSize = nominales;
                }

                trade.SellPrice = Sell.Data.GetTopBidPrice();
                trade.SellTotalSinComisiones = trade.SellPrice * trade.TradeSize * Sell.Instrument.PriceConvertionFactor;
                trade.SellComisionDerechos = Sell.Instrument.CalculateComisionDerechosMercado(trade.SellTotalSinComisiones);

                trade.BuyPrice = Buy.Data.GetTopOfferPrice();
                trade.BuyTotalSinComisiones = trade.BuyPrice * trade.TradeSize * Buy.Instrument.PriceConvertionFactor;
                trade.BuyComisionDerechos = Buy.Instrument.CalculateComisionDerechosMercado(trade.BuyTotalSinComisiones);

                trade.DiasCaucion = Sell.Instrument.CalculateSettlementDays(Buy.Instrument, diasLiq24H, diasLiq48H);

                var caucion = (tasaCaucion / 100m * trade.DiasCaucion / 365m);
                trade.CaucionTarget = Math.Abs(caucion);
                trade.InteresCaucion = trade.TotalACaucionar * trade.CaucionTarget;

                trade.ArancelCaucion = trade.EsCaucionColocadora ? comisionColocadora : comisionTomadora;

                trade.BuyPriceTarget = trade.SellPrice * (1 + trade.CaucionTarget);
                trade.SellPriceTarget = trade.BuyPrice * (1 - trade.CaucionTarget);

                trade.SpreadTNA = Math.Abs(((trade.BuyPriceTarget / trade.SellPriceTarget) - 1) / trade.DiasCaucion * 365m);

                return trade;
            }

            return null;
        }

        public decimal Spread
        {
            get
            {
                if (HasData() && Sell.Data.HasBids() && Buy.Data.HasOffers())
                {
                    var sellPrice = Sell.Data.GetTopBidPrice();
                    var buyPrice = Buy.Data.GetTopOfferPrice();
                    var diffPct = sellPrice / buyPrice - 1m;
                    return diffPct;
                }
                return -100m;
            }
        }

        public decimal SpreadLast
        {
            get
            {
                if (HasData() && Buy.Data.HasLastPrice() && Sell.Data.HasLastPrice())
                {
                    return Buy.Data.Last.Price.Value / Sell.Data.Last.Price.Value -1;
                }
                return -100m;
            }
        }

        public decimal BuyPrice // Barato
        {
            get
            {
                if (Buy.Data != null && Buy.Data.HasOffers())
                {
                    return Buy.Data.Offers[0].Price ;
                }
                return default;
            }
        }

        public decimal SellPrice // Caro
        {
            get
            {
                if (Sell.Data != null && Sell.Data.HasBids())
                {
                    return Sell.Data.Bids[0].Price;
                }
                return default;
            }
        }

        public bool HasData()
        {
            return Buy.Data != null && Sell.Data != null;
        }
    }

    public class SettlementTermArbitrationProcessor
    {
        public List<DolarTradedInstrument> tradedInstruments = new List<DolarTradedInstrument>();

        internal void Init()
        {
            foreach (var ownedTicker in Properties.Settings.Default.ArbitrationTickers)
            {
                if (ownedTicker.ContainsMultipleTickers())
                {
                    var dolarTradedInstrument = new DolarTradedInstrument(ownedTicker.GetPesosTicker(), ownedTicker.GetDolarTicker(), ownedTicker.GetCableTicker());
                    tradedInstruments.Add(dolarTradedInstrument);
                }
                else
                {
                    var dolarTradedInstrument = new DolarTradedInstrument(ownedTicker);
                    tradedInstruments.Add(dolarTradedInstrument);
                }
            }
        }

        public void RefreshData()
        {
            foreach (var dolarTradedInstrument in tradedInstruments)
            {
                dolarTradedInstrument.RefreshData();
            }
        }

        public List<SettlementTermTrade> GetSettlementTermTrades(decimal tasaCaucion, int diasLiq24H, int diasLiq48H)
        {
            var allTrades = new List<SettlementTermTrade>();

            foreach (var tradedInstrument in tradedInstruments)
            {
                var trades = tradedInstrument.GetSettlementTermTrades(tasaCaucion, diasLiq24H, diasLiq48H);
                if (trades != null && trades.Count() > 0)
                    allTrades.AddRange(trades);

                var dolarTrades = tradedInstrument.Dolar.GetSettlementTermTrades(tasaCaucion, diasLiq24H, diasLiq48H);
                if (dolarTrades != null && dolarTrades.Count() > 0)
                    allTrades.AddRange(dolarTrades);

                var cableTrades = tradedInstrument.Cable.GetSettlementTermTrades(tasaCaucion, diasLiq24H, diasLiq48H);
                if (cableTrades != null && cableTrades.Count() > 0)
                    allTrades.AddRange(cableTrades);
            }

            return allTrades;
        }
    }
}

