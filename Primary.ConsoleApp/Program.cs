using Primary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Primary.ConsoleApp
{
    class Program
    {

        
        private static List<string> watchList;

        static void Main(string[] args)
        {
            string username = PromptForUsername();
            string password = PromptForPassword();

            Console.WriteLine("");

            var _api = new Api(Api.ProductionEndpoint);
            _api.Login(username, password).Wait();

            InitWatchList();
            var instruments = _api.GetAllInstruments().Result.ToArray();
            var instrument = instruments.Where(ShouldWatch).ToArray();

            // Subscribe to all entries
            using var socket = _api.CreateMarketDataSocket(instrument, Constants.AllEntries, 1, 1);

            socket.OnData = WriteData;
            socket.Start().Wait();

            // Wait until data arrives
            Console.ReadKey();
        }

        private static string PromptForPassword()
        {
            Console.Write("Password: ");

            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return password;
        }

        private static string PromptForUsername()
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            return username;
        }

        private static void WriteData(Api api, MarketData marketData)
        {
            if (marketData.Status == "ERROR")
            {
                Console.WriteLine(marketData.Status);
            }
            else
            {
                Console.WriteLine(marketData.Instrument.Symbol + ": " + marketData.Data?.Last?.Price);
            }
        }

        private static void InitWatchList()
        {
            var bonds = new[] { "AL29", "AL30", "AL35", "AE38", "AL41", "GD29", "GD30", "GD35", "GD38", "GD41", "GD46" };

            var allBonds = bonds.Concat(bonds.Select(x => x + "D"));

            watchList = new List<string>();
            foreach (var item in allBonds)
            {
                watchList.AddRange(ToMervalSymbol(item));
            }

        }

        private static bool ShouldWatch(Instrument instrument)
        {
            return watchList.Contains(instrument.Symbol);
        }

        private static string[] ToMervalSymbol(string ticker)
        {
            return new[] {$"MERV - XMEV - {ticker} - 48hs", $"MERV - XMEV - {ticker} - 24hs", $"MERV - XMEV - {ticker} - CI" };
        }
    }
}
