using Primary.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Primary.WinFormsApp
{
    public static class InstrumentExtensions
    {
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
            return 1m / Convert.ToDecimal("1".PadRight(instrumentDetail.InstrumentPricePrecision + 1, '0'));
        }

        public static bool IsCEDEAR(this InstrumentDetail instrumentDetail)
        {
            return IsCEDEAR(instrumentDetail.InstrumentId.Ticker());
        }

        public static bool IsCEDEAR(this string ticker)
        {
            var exists = Properties.Settings.Default.AccionesCEDEARs.Cast<string>().Any(x => string.Equals(x, ticker, StringComparison.OrdinalIgnoreCase));
            return exists;
        }

        public static bool IsLetra(this InstrumentDetail instrumentDetail)
        {
            var exists = IsLetra(instrumentDetail.InstrumentId.Ticker());
            return exists;
        }

        public static bool IsLetra(this string ticker)
        {
            var exists = Properties.Settings.Default.Letras.Cast<string>().Any(x => string.Equals(x, ticker, StringComparison.OrdinalIgnoreCase));
            return exists;
        }

        public static decimal GetDerechosDeMercado(this InstrumentDetail instrumentDetail)
        {
            var ticker = instrumentDetail.InstrumentId.Ticker();
            return GetDerechosDeMercado(ticker);
        }

        public static decimal GetDerechosDeMercado(this string ticker)
        {
            // https://www.byma.com.ar/que-es-byma/derechos-membresias-2/
            if (ticker.IsCEDEAR())
            {
                var comision = Properties.Settings.Default.Comision / 100m;
                var derMer = Properties.Settings.Default.DerechoMercadoAccionCEDEAR / 100m;
                var ivaSobreDerMer = Properties.Settings.Default.DerechoMercadoAccionCEDEAR * 0.21m / 100m;
                return comision + derMer + ivaSobreDerMer;
            }
            else if (ticker.IsLetra())
            {
                return (Properties.Settings.Default.Comision + Properties.Settings.Default.DerechoMercadoLetra) / 100m;
            }
            else
            {
                return (Properties.Settings.Default.Comision + Properties.Settings.Default.DerechoMercado) / 100m;
            }
        }

        public static decimal CalculateComisionDerechosMercado(this InstrumentDetail instrumentDetail, decimal amountInPesos)
        {
            var comision = instrumentDetail.GetDerechosDeMercado();
            return amountInPesos * comision;
        }

        public static string FormatCurrency(this InstrumentDetail instrumentDetail, decimal amount)
        {
            if (instrumentDetail.IsPesos())
            {
                return amount.ToCurrency();
            }
            else {
                return amount.ToUSD();
            }
        }

        public static string FormatPrice(this InstrumentDetail instrumentDetail, decimal value)
        {
            var decimalPlacesFormat = string.Empty.PadRight(instrumentDetail.InstrumentPricePrecision, '0');
            var format = $"#,##0.{decimalPlacesFormat}";

            return value.ToString(format);
        }

        public static int CalculateSettlementDays(this InstrumentDetail buy, InstrumentDetail sell, int diasLiq24H, int diasLiq48H)
        {
            int buyDiasLiq = buy.GetSettlementDays(diasLiq24H, diasLiq48H);
            int sellDiasLiq = sell.GetSettlementDays(diasLiq24H, diasLiq48H);

            var days = buyDiasLiq - sellDiasLiq;

            return days;
        }
    }
}
