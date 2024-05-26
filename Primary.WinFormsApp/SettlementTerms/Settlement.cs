using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public static class Settlement
{
    /// <summary>
    /// Obtiene la cantidad de dias del plazo de 24H en base a las cauciones que se encuentran en la lista de instrumentos.
    /// </summary>
    /// <returns></returns>
    public static int GetDiasLiquidacion24H()
    {
        for (var caucionDiasLiq = 1; caucionDiasLiq < 10; caucionDiasLiq++)
        {
            var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
            var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
            if (caucionInstrument != null)
            {
                return caucionDiasLiq;
            }
        }

        var diasLiq = DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 3 : 1;
        return diasLiq;
    }
    public static string GetCaucionPesosTicker(int liquidacion)
    {
        var caucionTicker = Instrument.MervalPrefix + $"PESOS - {liquidacion}D";

        return caucionTicker;
    }
}
