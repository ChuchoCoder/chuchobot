using Primary.Data;
using System;

namespace Primary.WinFormsApp
{
    public static class Settlement
    {
        public static int GetDiasLiquidacion24H()
        {
            var diasLiq = DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 3 : 1;

            for (int i = 0; i < 5; i++)
            {
                var caucionDiasLiq = diasLiq + i;
                var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
                var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
                if (caucionInstrument != null)
                    return caucionDiasLiq;
            }

            return diasLiq;
        }

        public static int GetDiasLiquidacion48H()
        {
            var diasLiq = DateTime.Today.DayOfWeek == DayOfWeek.Thursday || DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 4 : 2;

            for (int i = 0; i < 5; i++)
            {
                var caucionDiasLiq = diasLiq + i;
                var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
                var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
                if (caucionInstrument != null)
                    return caucionDiasLiq;
            }

            return diasLiq;
        }

        public static string GetCaucionPesosTicker(int liquidacion)
        {
            var caucionTicker = Instrument.MervalPrefix + $"PESOS - {liquidacion}D";

            return caucionTicker;
        }
    }
}
