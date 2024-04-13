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
    /// Evalua la disponibilidad de nominales en cada una de las cajas de puntas y devuelve la máxima cantidad actualmente disponible
    /// </summary>
    /// <returns></returns>
    public int GetOwnedVentaMaxSize()
    {
        var ownedCompraSize = SellThenBuy.Buy.Data.GetTopBidSize();
        var ownedCompraPrice = SellThenBuy.Buy.Data.GetTopBidPrice();
        _ = ownedCompraSize * ownedCompraPrice;

        var arbitrationVentaSize = BuyThenSell.Buy.Data.GetTopBidSize();
        var arbitrationVentaPrice = BuyThenSell.Buy.Data.GetTopBidPrice();
        _ = arbitrationVentaSize * arbitrationVentaPrice;
        _ = BuyThenSell.Sell.Data.GetTopBidSize();
        _ = BuyThenSell.Sell.Data.GetTopBidPrice();
        _ = SellThenBuy.Buy.Data.GetTopBidSize();
        _ = SellThenBuy.Buy.Data.GetTopBidPrice();

        return 0;
    }

    internal void RefreshData()
    {
        BuyThenSell.RefreshData();
        SellThenBuy.RefreshData();
    }
}
