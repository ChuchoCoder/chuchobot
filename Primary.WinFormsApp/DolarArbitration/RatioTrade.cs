using Primary.Data;
using System;
using System.Diagnostics;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

public enum RatioTradeType
{
    MEP,
    CCL,
    DvsC,
    CvsD,
    Ratio
}
/// <summary>
/// Permite calcular la ganancia al realizar una operación de arbitraje de dolar (MEP o CCL)
/// </summary>
[DebuggerDisplay("{SellThenBuy.Buy.Instrument.InstrumentId.Symbol} / {BuyThenSell.Sell.Instrument.InstrumentId.Symbol}")]
public class RatioTrade
{
    public RatioTradeType Type { get; set; }

    /// <summary>
    /// Instrumento que está relativamente más caro
    /// </summary>
    public BuySellTrade SellThenBuy { get; set; }

    /// <summary>
    /// Instrumento que está relativamente más barato
    /// </summary>
    public BuySellTrade BuyThenSell { get; set; }

    public RatioTrade(RatioTradeType type, BuySellTrade sellThenBuy, BuySellTrade buyThenSell)
    {
        Type = type;
        SellThenBuy = sellThenBuy;
        BuyThenSell = buyThenSell;
    }

    public decimal Profit => BuyThenSellRatio > 0 && SellThenBuyRatio > 0 ? (BuyThenSellRatio / SellThenBuyRatio) - 1 : -100;

    public decimal ProfitLast => BuyThenSell.Last > 0 && SellThenBuy.Last > 0 ? (BuyThenSell.Last / SellThenBuy.Last) - 1 : -100;

    public bool IsInAuction => BuyThenSell.IsInAuction || SellThenBuy.IsInAuction;

    /// <summary>
    /// Ratio de compra de SellThenBuy ($ Dolar MEP/CCL o %)
    /// </summary>
    public decimal SellThenBuyRatio => SellThenBuy.BuyPrice;

    /// <summary>
    /// Ratio de compra de SellThenBuy ($ Dolar MEP/CCL o %)
    /// </summary>
    public decimal BuyThenSellRatio => BuyThenSell.InverseBuyPrice;

    public decimal CurrencyRate
    {
        get
        {
            var currencyRate = 1m;

            if (SellThenBuy.IsSameCurrency() == false)
            {
                // Obtengo el tipo de cambio más bajo para calcular menor profit
                currencyRate = Math.Min(SellThenBuyRatio, BuyThenSellRatio);
            }

            return currencyRate;
        }
    }

    internal void RefreshData()
    {
        BuyThenSell.RefreshData();
        SellThenBuy.RefreshData();
    }

    public RatioTradeOperation CalculateTrade() {

        // Calcular minima cantidad de nominales que tengo que operar
        var ownedTradeSize = SellThenBuy.GetMinSellBidOrBuyOfferSize();

        var arbitrationTradeSize = BuyThenSell.GetMinBuyOfferOrSellBidSize();

        Debug.Write($"ownedTradeSize: {ownedTradeSize}, arbitrationTradeSize: {arbitrationTradeSize}");

        //if (ownedTradeSize == 0 || arbitrationTradeSize == 0)
        //{
        //    return null;
        //}

        // Uso operacion en pesos
        var ownedBuyOperation = SellThenBuy.Buy.BuyOperation(ownedTradeSize);
        var arbitrationSellOperation = BuyThenSell.Sell.SellOperation(arbitrationTradeSize);

        if (ownedBuyOperation.NetTotal < arbitrationSellOperation.NetTotal)
        {
            arbitrationTradeSize = BuyThenSell.Sell.CalculateBidSize(ownedBuyOperation.NetTotal);
            arbitrationSellOperation = BuyThenSell.Sell.SellOperation(arbitrationTradeSize);
            Debug.WriteLine($"arbitrationTradeSize ajustado: {arbitrationTradeSize} para NetTotal: {ownedBuyOperation.NetTotal} > {arbitrationSellOperation.NetTotal}");
        }
        else
        {
            ownedTradeSize = SellThenBuy.Buy.CalculateOfferSize(arbitrationSellOperation.NetTotal);
            ownedBuyOperation = SellThenBuy.Buy.BuyOperation(ownedTradeSize);
            Debug.WriteLine($"ownedTradeSize ajustado: {ownedTradeSize} para NetTotal: {arbitrationSellOperation.NetTotal} > {ownedBuyOperation.NetTotal}");
        }

        //if (ownedTradeSize == 0m && arbitrationTradeSize == 0m)
        //{
        //    // El minimo de nominales de alguno de los lados no cubre el total de la operación
        //    return null;
        //}

        // Dolar
        var ownedSellOperation = SellThenBuy.Sell.SellOperation(ownedTradeSize);
        var arbitrationBuyOperation = BuyThenSell.Buy.BuyOperation(arbitrationTradeSize);

        var ratioTrade = new RatioTradeOperation
        {
            RatioTrade = this,
            OwnedSell = ownedSellOperation,
            OwnedBuy = ownedBuyOperation,
            ArbitrationBuy = arbitrationBuyOperation,
            ArbitrationSell = arbitrationSellOperation
        };

        return ratioTrade;

    }
}
