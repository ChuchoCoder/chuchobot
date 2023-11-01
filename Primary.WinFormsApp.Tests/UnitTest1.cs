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
            var derMer = "SPY".GetDerechosDeMercado();
            derMer.Should().Be(0.0968m / 100m);

        }
    }
}
