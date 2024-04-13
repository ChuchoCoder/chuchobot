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

    /// <summary>
    /// Obtiene la cantidad de dias del plazo de 48H en base a las cauciones que se encuentran en la lista de instrumentos.
    /// </summary>
    /// <param name="diasLiquidacion24H">Días de liquidación para el plazo de 24H utilizado como base para buscar el próximo instrumento de caución</param>
    /// <returns></returns>
    public static int GetDiasLiquidacion48H(int diasLiquidacion24H)
    {

        for (var caucionDiasLiq = diasLiquidacion24H + 1; caucionDiasLiq < 10; caucionDiasLiq++)
        {
            var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
            var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
            if (caucionInstrument != null)
            {
                return caucionDiasLiq;
            }
        }

        var diasLiq = DateTime.Today.DayOfWeek is DayOfWeek.Thursday or DayOfWeek.Friday ? 4 : 2;
        return diasLiq;
    }

    public static string GetCaucionPesosTicker(int liquidacion)
    {
        var caucionTicker = Instrument.MervalPrefix + $"PESOS - {liquidacion}D";

        return caucionTicker;
    }
}
