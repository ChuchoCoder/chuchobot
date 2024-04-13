using Primary.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp
{
    public static class StringExtensions
    {
        public const string DolarSuffix = "D";
        public const string CableSuffix = "C";
        public const string Settlement48H = "48hs";
        public const string Settlement24H = "24hs";
        public const string SettlementCI = "CI";

        public static string[] AllSettlements = new[] { Settlement48H, Settlement24H, SettlementCI };
        public static IEnumerable<string> TickersDC = Properties.Settings.Default.TickersDC.Cast<string>();

        public static bool IsCI(this string ticker)
        {
            return ticker.EndsWith($" - {SettlementCI}");
        }
        public static bool IsCI(this InstrumentDetail instrumentDetail)
        {
            return instrumentDetail.InstrumentId.Symbol.EndsWith($" - {SettlementCI}");
        }

        public static bool Is24H(this InstrumentDetail instrumentDetail)
        {
            return instrumentDetail.InstrumentId.Symbol.EndsWith($" - {Settlement24H}");
        }

        public static bool Is48H(this InstrumentDetail instrumentDetail)
        {
            return instrumentDetail.InstrumentId.Symbol.EndsWith($" - {Settlement48H}");
        }

        public static string RemoveSettlement(this string symbol)
        {
            var index = symbol.LastIndexOf(" - ");
            if (index > 0)
            {
                return symbol.Substring(0, index);
            }

            return symbol;
        }

        public static string GetTicker(this string symbol)
        {
            var split = symbol.Split('-');
            return split[split.Length - 2];
        }

        public static int GetSettlementDays(this InstrumentDetail instrumentDetail, int diasLiq24H, int diasLiq48H)
        {
            if (instrumentDetail.IsCI())
            {
                return 0;
            }

            return instrumentDetail.Is24H() ? diasLiq24H : diasLiq48H;
        }

        public static string AddMervalPrefix(this string ticker)
        {
            return Instrument.MervalPrefix + ticker;
        }

            public static string AddDolarSuffix(this string ticker)
        {
            string tickersDC = TickersDC.FirstOrDefault(x => x.Contains(ticker));
            if (tickersDC != null)
            {
                string[] dc = tickersDC.Split(';');
                return dc[1];
            }


            return $"{ticker}D";
        }

        public static string AddCableSuffix(this string ticker)
        {
            string tickersDC = TickersDC.FirstOrDefault(x => x.Contains(ticker));
            if (tickersDC != null)
            {
                string[] dc = tickersDC.Split(';');
                return dc[2];
            }

            return $"{ticker}C";
        }

        public static string ToMervalSymbol48H(this string ticker)
        {
            return ticker.ToMervalSymbol(Settlement48H);
        }
        public static string ToMervalSymbol24H(this string ticker)
        {
            return ticker.ToMervalSymbol(Settlement24H);
        }
        public static string ToMervalSymbolCI(this string ticker)
        {
            return ticker.ToMervalSymbol(SettlementCI);
        }

        public static string ToMervalSymbol(this string ticker, string settlement)
        {
            return Instrument.MervalPrefix + $"{ticker} - {settlement}";
        }

        public static string[] GetAllMervalSymbols(this string ticker)
        {
            string tickerD = ticker.AddDolarSuffix();
            string tickerC = ticker.AddCableSuffix();

            return new[] {
                ticker.ToMervalSymbol48H(),
                ticker.ToMervalSymbol24H(),
                ticker.ToMervalSymbolCI(),
                tickerD.ToMervalSymbol48H(),
                tickerD.ToMervalSymbol24H(),
                tickerD.ToMervalSymbolCI(),
                tickerC.ToMervalSymbol48H(),
                tickerC.ToMervalSymbol24H(),
                tickerC.ToMervalSymbolCI()
            };
        }

        public static string[] GetAllSettlements(this string ticker)
        {
            return new[] {
                ticker.ToMervalSymbol48H(),
                ticker.ToMervalSymbol24H(),
                ticker.ToMervalSymbolCI()
            };
        }

        public static bool ContainsMultipleTickers(this string tickerLine)
        {
            string[] pesosDC = tickerLine.Split(' ');
            return pesosDC.Length > 1;
        }

        public static string[] GetMultipleTickers(this string tickerLine)
        {
            string[] pesosDC = tickerLine.Split(' ');
            return pesosDC.Length > 1 ? pesosDC.ToArray() : null;
        }

        public static string GetDolarTicker(this string tickerLine)
        {
            return tickerLine.Split(' ')[1];
        }
        public static string GetCableTicker(this string tickerLine)
        {
            return tickerLine.Split(' ')[2];
        }
        public static string GetPesosTicker(this string tickerLine)
        {
            return tickerLine.Split(' ')[0];
        }
    }
}
