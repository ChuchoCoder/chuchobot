using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.SettlementTerms;
using ChuchoBot.WinFormsApp.Shared;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using Windows.Foundation.Collections;

namespace ChuchoBot.WinFormsApp;

internal static class Alerts
{
    private static TimeSpan _notificationThreshold = TimeSpan.FromSeconds(60);
    private static Dictionary<string, DateTime> _settlementTradeNotificationDate = new();


    private static Dictionary<string, DateTime> _ratioTradeLowerNotificationDate = new();
    private static Dictionary<string, DateTime> _ratioTradeGreaterNotificationDate = new();
    private static Dictionary<string, DateTime> _ratioTradeLossNotificationDate = new();

    public static void NotifySettlementTrade(SettlementTermTrade trade, nint? handle)
    {
        NotifySettlementTrade(trade.Sell.Instrument.InstrumentId.Symbol, trade.SellSize, trade.SellPrice, trade.Buy.Instrument.InstrumentId.Symbol, trade.BuySize, trade.BuyPrice, trade.ProfitLossPercentage, trade.ProfitLoss, handle);
    }

    public static void NotifySettlementTrade(string sellSymbol, decimal sellSize, decimal sellPrice, string buySymbol, decimal buySize, decimal buyPrice, decimal profitPercentage, decimal profit, nint? handle)
    {
        var lastDate = _settlementTradeNotificationDate.GetValueOrDefault(sellSymbol + buySymbol);
        var dif = DateTime.Now - lastDate;
        if (dif > _notificationThreshold)
        {
            var toastBuilder = new ToastContentBuilder()
                .AddArgument("action", "settlementTradeAlert")
                .AddArgument("sellSymbol", sellSymbol)
                .AddArgument("buySymbol", buySymbol)
                .AddText("Arbitraje de plazos detectado")
                .AddText($"Comprar {buySize} {buySymbol.RemoveMervalPrefix()} {buyPrice:C2}\r\nVender {sellSize} {sellSymbol.RemoveMervalPrefix()} {sellPrice:C2}\r\nProfit: {profit:c2} ({profitPercentage:P2})");

            if (handle != null) {
                toastBuilder.AddArgument("handle", handle.Value);
            }

            toastBuilder.Show();

            if (lastDate == default)
            {
                _settlementTradeNotificationDate.Add(sellSymbol + buySymbol, DateTime.Now);
            }
            else
            {
                _settlementTradeNotificationDate[sellSymbol + buySymbol]=  DateTime.Now;
            }
        }
    }

    public static void NotifyLongRatioTrade(string ratioFormat, string buySymbol, decimal buyPrice, string sellSymbol, decimal sellPrice, decimal ratio, nint? handle)
    {
        var lastDate = _ratioTradeLowerNotificationDate.GetValueOrDefault(sellSymbol + buySymbol);
        var dif = DateTime.Now - lastDate;
        if (dif > _notificationThreshold)
        {
            var ratioCurrent = (buyPrice / sellPrice) - 1;

            var toastBuilder = new ToastContentBuilder()
                .AddArgument("action", "ratioTradeAlert")
                .AddArgument("sellSymbol", sellSymbol)
                .AddArgument("buySymbol", buySymbol)
                .AddText("Rotación de activo (long ratio)")
                .AddText($"Comprar {buySymbol.RemoveMervalPrefix()} {buyPrice:C2}\r\nVender {sellSymbol.RemoveMervalPrefix()} {sellPrice:C2}\r\nRatio: {ratioCurrent.ToString(ratioFormat)} (Ult. {ratio.ToString(ratioFormat)})");

            if (handle != null)
            {
                toastBuilder.AddArgument("handle", handle.Value);
            }

            toastBuilder.Show();

            if (lastDate == default)
            {
                _ratioTradeLowerNotificationDate.Add(sellSymbol + buySymbol, DateTime.Now);
            }
            else
            {
                _ratioTradeLowerNotificationDate[sellSymbol + buySymbol] = DateTime.Now;
            }
        }
    }

    public static void NotifyShortRatioTrade(string ratioFormat, string buySymbol, decimal buyPrice, string sellSymbol, decimal sellPrice, decimal ratio, nint? handle)
    {
        var lastDate = _ratioTradeGreaterNotificationDate.GetValueOrDefault(sellSymbol + buySymbol);
        var dif = DateTime.Now - lastDate;
        if (dif > _notificationThreshold)
        {
            var ratioCurrent = (sellPrice / buyPrice) - 1;

            var toastBuilder = new ToastContentBuilder()
                .AddArgument("action", "ratioTradeAlert")
                .AddArgument("sellSymbol", sellSymbol)
                .AddArgument("buySymbol", buySymbol)
                .AddText("Rotación de activo (short ratio)")
                .AddText($"Comprar {buySymbol.RemoveMervalPrefix()} {buyPrice:C2}\r\nVender {sellSymbol.RemoveMervalPrefix()} {sellPrice:C2}\r\nRatio: {ratioCurrent.ToString(ratioFormat)} (Ult. {ratio.ToString(ratioFormat)})");

            if (handle != null)
            {
                toastBuilder.AddArgument("handle", handle.Value);
            }

            toastBuilder.Show();

            if (lastDate == default)
            {
                _ratioTradeGreaterNotificationDate.Add(sellSymbol + buySymbol, DateTime.Now);
            }
            else
            {
                _ratioTradeGreaterNotificationDate[sellSymbol + buySymbol] = DateTime.Now;
            }
        }
    }

    public static void NotifyRatioTradeLoss(RatioTrade trade, decimal profit, nint handle)
    {

        var sellSymbol = trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();
        var buySymbol = trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
        var lastDate = _ratioTradeLossNotificationDate.GetValueOrDefault(sellSymbol + buySymbol);

        var dif = DateTime.Now - lastDate;
        if (dif > _notificationThreshold)
        {
            var sellPrice = trade.SellThenBuy.SellPrice;
            var buyPrice = trade.BuyThenSell.BuyPrice;
            var ratioCurrent = buyPrice > 0 ? (sellPrice / buyPrice) - 1 : 0;

            var isSameCurrency = trade.SellThenBuy.Buy.Instrument.Currency == trade.SellThenBuy.Sell.Instrument.Currency;

            var ratioFormat = isSameCurrency ? "P" : "C2";

            var toastBuilder = new ToastContentBuilder()
                .AddArgument("action", "ratioTradeAlert")
                .AddArgument("sellSymbol", sellSymbol)
                .AddArgument("buySymbol", buySymbol)
                .AddText("Pérdida en ratio")
                .AddText($"Compra {buySymbol} {buyPrice:C2}\r\nVender {sellSymbol} {sellPrice:C2}\r\nPérdida: {profit:C2}");

            if (handle != null)
            {
                toastBuilder.AddArgument("handle", handle);
            }

            toastBuilder.Show();

            if (lastDate == default)
            {
                _ratioTradeLossNotificationDate.Add(sellSymbol + buySymbol, DateTime.Now);
            }
            else
            {
                _ratioTradeLossNotificationDate[sellSymbol + buySymbol] = DateTime.Now;
            }
        }
    }
}
