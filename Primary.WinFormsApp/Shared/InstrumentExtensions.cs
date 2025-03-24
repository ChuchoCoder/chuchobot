using Primary.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace ChuchoBot.WinFormsApp.Shared;

public static class InstrumentExtensions
{
    public const string CfiCodeFuturos = "FXXXSX";
    public const string CfiCodePases = "FXXXXX";
    public const string CfiCodePutsMatbaRofex = "OPAFXS";
    public const string CfiCodeCallsMatbaRofex = "OCAFXS";
    public const string CfiCodeIndices = "MRIXXX";
    public const string CfiCodeCalls = "OCASPS";
    public const string CfiCodePuts = "OPASPS";
    public const string CfiCodeBonos = "DBXXXX";
    public const string CfiCodeCedears = "EMXXXX";
    public const string CfiCodeONs = "DBXXFR";
    public const string CfiCodeAcciones = "ESXXXX";
    public const string CfiCodeLetras = "DYXTXR";
    public const string CfiCodeCauciones = "RPXXXX";

    public static IEnumerable<Instrument> FilterByTicker(this IEnumerable<Instrument> instruments, string ticker)
    {
        var tickerSymbols = ticker.GetAllMervalSymbols();
        return instruments.Where(x => tickerSymbols.Contains(x.Symbol));
    }

    public static bool TickerExists(this StringCollection instruments, string ticker)
    {
        return instruments.Cast<string>().Any(x => string.Equals(x, ticker, StringComparison.OrdinalIgnoreCase));
    }

    public static bool IsPesos(this InstrumentDetail instrumentDetail)
    {
        return string.Equals(instrumentDetail.Currency, "ARS", StringComparison.OrdinalIgnoreCase);
    }

    public static decimal GetIncrement(this InstrumentDetail instrumentDetail)
    {
        return instrumentDetail.MinPriceIncrement;
    }

    public static bool IsCEDEAR(this InstrumentDetail instrumentDetail)
    {
        return instrumentDetail.CfiCode == CfiCodeCedears;
    }

    public static bool IsAccion(this InstrumentDetail instrumentDetail)
    {
        return instrumentDetail.CfiCode == CfiCodeAcciones;
    }

    public static bool IsLetra(this InstrumentDetail instrumentDetail)
    {
        var exists = instrumentDetail.CfiCode == CfiCodeLetras;
        return exists;
    }

    /// <summary>
    /// Letras y Bonos no pagan IVA sobre Derechos de Mercado
    /// </summary>
    /// <param name="instrumentDetail"></param>
    /// <returns></returns>
    public static decimal GetDerechosDeMercado(this InstrumentDetail instrumentDetail)
    {
        decimal ddm = Properties.Settings.Default.DerechoMercado;

        // https://www.byma.com.ar/que-es-byma/derechos-membresias-2/
        if (instrumentDetail.IsCEDEAR() || instrumentDetail.IsAccion())
        {
            var comision = Properties.Settings.Default.Comision / 100m;
            var derMer = Properties.Settings.Default.DerechoMercadoAccionCEDEAR / 100m;
            var ivaSobreDerMer = Properties.Settings.Default.DerechoMercadoAccionCEDEAR * 0.21m / 100m;
            return comision + derMer + ivaSobreDerMer;
        }
        else
        {
            // Letras y Bonos no pagan IVA sobre Derechos de Mercado
            return instrumentDetail.IsLetra()
                ? (Properties.Settings.Default.Comision + Properties.Settings.Default.DerechoMercadoLetra) / 100m
                : (Properties.Settings.Default.Comision + Properties.Settings.Default.DerechoMercado) / 100m;
        }
    }

    public static decimal CalculateComisionDerechosMercado(this InstrumentDetail instrumentDetail, decimal amountInPesos)
    {
        var comision = instrumentDetail.GetDerechosDeMercado();
        return amountInPesos * comision;
    }

    public static string FormatCurrency(this InstrumentDetail instrumentDetail, decimal amount)
    {
        return instrumentDetail.IsPesos() ? amount.ToCurrency() : amount.ToUSD();
    }

    public static string FormatPrice(this InstrumentDetail instrumentDetail, decimal value)
    {
        var decimalPlacesFormat = string.Empty.PadRight(instrumentDetail.InstrumentPricePrecision, '0');
        var format = $"#,##0.{decimalPlacesFormat}";

        return value.ToString(format);
    }

    public static int CalculateSettlementDays(this InstrumentDetail buy, InstrumentDetail sell, int diasLiq24H)
    {
        int buyDiasLiq = buy.GetSettlementDays(diasLiq24H);
        int sellDiasLiq = sell.GetSettlementDays(diasLiq24H);

        var days = buyDiasLiq - sellDiasLiq;

        return days;
    }
}
