using Primary.Data;
using System;
using System.Diagnostics;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

/// <summary>
/// Permite calcular la ganancia al realizar una operación de arbitraje de dolar (MEP o CCL)
/// </summary>
[DebuggerDisplay("{SellThenBuy.Buy.Instrument.InstrumentId.Symbol} / {BuyThenSell.Buy.Instrument.InstrumentId.Symbol}")]
public class RatioTrade
{
    /// <summary>
    /// Instrumento que está relativamente más caro
    /// </summary>
    public BuySellTrade SellThenBuy { get; set; }

    /// <summary>
    /// Instrumento que está relativamente más barato
    /// </summary>
    public BuySellTrade BuyThenSell { get; set; }

    public RatioTrade(BuySellTrade sellThenBuy, BuySellTrade buyThenSell)
    {
        SellThenBuy = sellThenBuy;
        BuyThenSell = buyThenSell;
    }

    public decimal Profit => BuyThenSell.SellPrice > 0 && SellThenBuy.BuyPrice > 0 ? (BuyThenSell.SellPrice / SellThenBuy.BuyPrice) - 1 : -100;

    public decimal ProfitLast => BuyThenSell.Last > 0 && SellThenBuy.Last > 0 ? (BuyThenSell.Last / SellThenBuy.Last) - 1 : -100;

    /// <summary>
    /// Ratio de compra de SellThenBuy ($ Dolar MEP/CCL o %)
    /// </summary>
    public decimal SellThenBuyRatio => SellThenBuy.BuyPrice;

    /// <summary>
    /// Ratio de compra de SellThenBuy ($ Dolar MEP/CCL o %)
    /// </summary>
    public decimal BuyThenSellRatio => BuyThenSell.InverseBuyPrice;

    /// <summary>
    /// Evalua la disponibilidad de nominales en cada una de las cajas de puntas y devuelve la máxima cantidad actualmente disponible
    /// </summary>
    /// <returns></returns>
    public decimal GetAvailableMaxSize()
    {
        var sellThenBuyMinSize = SellThenBuy.GetMinSellOfferOrBuyBidSize();

        var buyThenSellMinSize = BuyThenSell.GetMinBuyOfferOrSellBidSize();

        return Math.Min(sellThenBuyMinSize, buyThenSellMinSize);
    }

    internal void RefreshData()
    {
        BuyThenSell.RefreshData();
        SellThenBuy.RefreshData();
    }

    public RatioTradeOperation CalculateTrade() {

        // Calcular minima cantidad de nominales que tengo que operar
        var ownedTradeSize = SellThenBuy.GetMinSellOfferOrBuyBidSize();

        var arbitrationTradeSize = BuyThenSell.GetMinBuyOfferOrSellBidSize();

        if (ownedTradeSize == 0 || arbitrationTradeSize == 0)
        {
            return null;
        }

        var currencyRate = 1m;

        if (SellThenBuy.IsSameCurrency() == false)
        {
            // Obtengo el tipo de cambio más bajo para calcular menor profit
            currencyRate = Math.Min(SellThenBuyRatio, BuyThenSellRatio);
        }

        // Uso operacion en pesos
        var ownedBuyOperation = SellThenBuy.Buy.BuyOperation(ownedTradeSize, currencyRate);
        var arbitrationSellOperation = BuyThenSell.Sell.SellOperation(arbitrationTradeSize, currencyRate);

        if (ownedBuyOperation.NetTotalInPesos > arbitrationSellOperation.NetTotalInPesos)
        {
            arbitrationTradeSize = Math.Truncate(ownedBuyOperation.NetTotalInPesos / BuyThenSell.Sell.BidPrice().Value / BuyThenSell.Sell.Instrument.PriceConvertionFactor);
            arbitrationSellOperation = BuyThenSell.Sell.SellOperation(arbitrationTradeSize, currencyRate);
        }
        else
        {
            ownedTradeSize = Math.Truncate(arbitrationSellOperation.NetTotalInPesos / SellThenBuy.Buy.OfferPrice().Value / BuyThenSell.Buy.Instrument.PriceConvertionFactor);
            ownedBuyOperation = SellThenBuy.Buy.BuyOperation(ownedTradeSize, currencyRate);
        }

        if (ownedTradeSize == 0m && arbitrationTradeSize == 0m)
        {
            // El minimo de nominales de alguno de los lados no cubre el total de la operación
            return null;
        }

        // Dolar
        var ownedSellOperation = SellThenBuy.Sell.SellOperation(ownedTradeSize, currencyRate);
        var arbitrationBuyOperation = BuyThenSell.Buy.BuyOperation(arbitrationTradeSize, currencyRate);

        var ratioTrade = new RatioTradeOperation
        {
            RatioTrade = this,
            CurrencyRate = currencyRate,
            OwnedSell = ownedSellOperation,
            OwnedBuy = ownedBuyOperation,
            ArbitrationBuy = arbitrationBuyOperation,
            ArbitrationSell = arbitrationSellOperation
        };

        return ratioTrade;

    }
}
