using Primary.Data;
using System.Collections.Generic;
using System.Linq;

namespace ChuchoBot.WinFormsApp.Shared;

public static class StringExtensions
{
    public const string DolarSuffix = "D";
    public const string CableSuffix = "C";
    public const string Settlement24H = "24hs";
    public const string SettlementCI = "CI";

        public static string[] AllSettlements = new[] { Settlement24H, SettlementCI };
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

    public static string RemoveSettlement(this string symbol)
    {
        var index = symbol.LastIndexOf(" - ");
        return index > 0 ? symbol[..index] : symbol;
    }

    public static string GetTicker(this string symbol)
    {
        var split = symbol.Split('-');
        return split[^2].Trim();
    }

        public static int GetSettlementDays(this InstrumentDetail instrumentDetail, int diasLiq24H)
    {
        return instrumentDetail.IsCI() ? 0 : diasLiq24H;
    }

    public static string RemoveMervalPrefix(this string ticker)
    {
        return ticker.Replace(Instrument.MervalPrefix, string.Empty);
    }

    public static string AddMervalPrefix(this string ticker)
    {
        return Instrument.MervalPrefix + ticker;
    }

    public static string AddDolarSuffix(this string ticker)
    {
        var tickersDC = TickersDC.FirstOrDefault(x => x.Contains(ticker));
        if (tickersDC != null)
        {
            var dc = tickersDC.Split(';');
            return dc[1];
        }


        return $"{ticker}D";
    }

    public static string AddCableSuffix(this string ticker)
    {
        var tickersDC = TickersDC.FirstOrDefault(x => x.Contains(ticker));
        if (tickersDC != null)
        {
            var dc = tickersDC.Split(';');
            return dc[2];
        }

        return $"{ticker}C";
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
        var tickerD = ticker.AddDolarSuffix();
        var tickerC = ticker.AddCableSuffix();

        return new[] {
            ticker.ToMervalSymbol24H(),
            ticker.ToMervalSymbolCI(),
            tickerD.ToMervalSymbol24H(),
            tickerD.ToMervalSymbolCI(),
            tickerC.ToMervalSymbol24H(),
            tickerC.ToMervalSymbolCI()
        };
    }

    public static string[] GetAllSettlements(this string ticker)
    {
        return new[] {
            ticker.ToMervalSymbol24H(),
            ticker.ToMervalSymbolCI()
        };
    }

    public static bool ContainsMultipleTickers(this string tickerLine)
    {
        var pesosDC = tickerLine.Split(' ');
        return pesosDC.Length > 1;
    }

    public static string[] GetMultipleTickers(this string tickerLine)
    {
        var pesosDC = tickerLine.Split(' ');
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
