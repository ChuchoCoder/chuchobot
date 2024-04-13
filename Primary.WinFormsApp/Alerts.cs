using ChuchoBot.WinFormsApp.SettlementTerms;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using Windows.Foundation.Collections;

namespace ChuchoBot.WinFormsApp;

internal static class Alerts
{
    private static TimeSpan _settlementTradeNotificationThreshold = TimeSpan.FromSeconds(60);
    private static Dictionary<string, DateTime> _settlementTradeNotificationDate = new();

    public static void NotifySettlementTrade(SettlementTermTrade trade)
    {
        NotifySettlementTrade(trade.Sell.Instrument.InstrumentId.Symbol, trade.Buy.Instrument.InstrumentId.Symbol, trade.ProfitLossPercentage, trade.ProfitLoss);
    }

    public static void NotifySettlementTrade(string sellSymbol, string buySymbol, decimal profitPercentage, decimal profit)
    {
        var lastDate = _settlementTradeNotificationDate.GetValueOrDefault(sellSymbol + buySymbol);
        var dif = DateTime.Now - lastDate;
        if (dif > _settlementTradeNotificationThreshold)
        {
            new ToastContentBuilder()
                .AddArgument("action", "settlementTradeAlert")
                .AddArgument("sellSymbol", sellSymbol)
                .AddArgument("buySymbol", buySymbol)
                .AddText("Arbitraje de plazos detectado")
                .AddText($"Comprar {buySymbol} => Vender {sellSymbol}\r\nProfit: {profit:c2} ({profitPercentage:P2}")
                .Show();

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
}
