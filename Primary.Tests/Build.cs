using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Primary.Tests.Builders;

namespace Primary.Tests
{
    public static class Build
    {
        public static async Task<Api> AnApi()
        {
            var api = new Api(Api.DemoEndpoint);
            await api.Login(Api.DemoUsername, Api.DemoPassword);
            return api;
        }

        public static OrderBuilder AnOrder(Api api) { return new OrderBuilder(api); }

        public static string DollarFutureSymbol()
        {
            const string symbolBase = "DO";

            var monthMapper = new Dictionary<int, string>
            {
                {1, "Ene"}, {2, "Feb"}, {3, "Mar"}, {4, "Abr"}, 
                {5, "May"}, {6, "Jun"}, {7, "Jul"}, {8, "Ago"}, 
                {9, "Sep"}, {10, "Oct"}, {11, "Nov"}, {12, "Dic"}
            };
            var nextMonth = DateTime.Today.AddMonths(1);
            var nextMonthNumber = nextMonth.Month;
                
            var nextMonthYear = DateTime.Today.AddMonths(1).ToString("yy");

            return symbolBase + monthMapper[nextMonthNumber] + nextMonthYear;
        }
    }
}
