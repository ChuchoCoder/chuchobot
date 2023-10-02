using System;

namespace Primary.WinFormsApp
{
    public static class Settlement
    {
        public static int GetDiasLiquidacion24H()
        {
            return DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 3 : 1;
        }

        public static int GetDiasLiquidacion48H()
        {
            return DateTime.Today.DayOfWeek == DayOfWeek.Thursday || DateTime.Today.DayOfWeek == DayOfWeek.Friday ? 4 : 2;
        }
    }
}
