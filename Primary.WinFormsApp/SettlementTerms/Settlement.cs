using Primary.Data;
using System;

namespace Primary.WinFormsApp
{
    public static class Settlement
    {
        public static int GetDiasLiquidacion24H()
        {
            for (int caucionDiasLiq = 1; caucionDiasLiq < 10; caucionDiasLiq++)
            {
                var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
                var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
                if (caucionInstrument != null)
                    return caucionDiasLiq;
            }

            var diasLiq = DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 3 : 1;
            return diasLiq;
        }

        public static int GetDiasLiquidacion48H(int diasLiquidacion24H)
        {

            for (int caucionDiasLiq = diasLiquidacion24H+1; caucionDiasLiq < 10; caucionDiasLiq++)
            {
                var caucionTicker = GetCaucionPesosTicker(caucionDiasLiq);
                var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
                if (caucionInstrument != null)
                    return caucionDiasLiq;
            }

            var diasLiq = DateTime.Today.DayOfWeek == DayOfWeek.Thursday || DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 4 : 2;
            return diasLiq;
        }

        public static string GetCaucionPesosTicker(int liquidacion)
        {
            var caucionTicker = Instrument.MervalPrefix + $"PESOS - {liquidacion}D";

            return caucionTicker;
        }
    }
}
