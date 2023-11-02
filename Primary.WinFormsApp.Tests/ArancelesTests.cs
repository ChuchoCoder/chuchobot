using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Primary.WinFormsApp.Tests
{
    [TestClass]
    public class Aranceles
    {
        [TestMethod]
        public void CEDEARs_Calcular_DerechosMercado()
        {
            var cedears = new string[] { "SPY", "QQQ", "KO", "INTC", "MSFT", "DIA", "AAPL", "AMZN" };

            foreach (var cedear in cedears)
            {
                cedear.GetDerechosDeMercado().Should().Be(0.0968m / 100m, cedear);
            }
        }

        [TestMethod]
        public void Letras_Calcular_DerechosMercado()
        {
            var cedears = new string[] { "X23N3" };

            foreach (var cedear in cedears)
            {
                cedear.GetDerechosDeMercado().Should().Be(0.001m / 100m, cedear);
            }
        }

        [TestMethod]
        public void Bonos_Calcular_DerechosMercado()
        {
            var cedears = new string[] { "AL30", "GD30", "AE38", "GD35" };

            foreach (var cedear in cedears)
            {
                cedear.GetDerechosDeMercado().Should().Be(0.01m / 100m, cedear);
            }
        }
    }
}
