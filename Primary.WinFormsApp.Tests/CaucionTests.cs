using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primary.WinFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary.WinFormsApp.Tests
{
    [TestClass]
    public class CaucionTests
    {
        public const decimal CurrencyErrorMargin = 0.01m;

        [TestMethod]
        public void Caucion_Colocadora_3_Dias_Sin_Arancel()
        {
            Settings.Default.ArancelCaucionColocadora = 0;

            var caucion = new Caucion(-3, 102.38m, 62473000);

            caucion.GastosGarantia.Should().BeApproximately(0, CurrencyErrorMargin);
            caucion.DerechosMercado.Should().BeApproximately(944.98m, CurrencyErrorMargin);
            caucion.Arancel.Should().BeApproximately(0, CurrencyErrorMargin);
            caucion.IVAGastos.Should().BeApproximately(198.45m, CurrencyErrorMargin);

            caucion.ImporteConInteres.Should().BeApproximately(62998700.40m, 3m);
            caucion.ImporteNeto.Should().BeApproximately(62997556.97m, 3m);
        }

        [TestMethod]
        public void Caucion_Colocadora_1_Dia()
        {
            Settings.Default.ArancelCaucionColocadora = 1.5m;

            var caucion = new Caucion(-1, 106.39m, 445358.89m);

            caucion.GastosGarantia.Should().BeApproximately(0, CurrencyErrorMargin);
            caucion.DerechosMercado.Should().BeApproximately(2.23m, CurrencyErrorMargin);
            caucion.Arancel.Should().BeApproximately(18.36m, CurrencyErrorMargin);
            caucion.IVAGastos.Should().BeApproximately(4.32m, CurrencyErrorMargin);

            caucion.ImporteConInteres.Should().BeApproximately(446657.02m, CurrencyErrorMargin);
            caucion.ImporteNeto.Should().BeApproximately(446632.11m, CurrencyErrorMargin);
        }

        [TestMethod]
        public void Caucion_Colocadora_1_Dia_11M()
        {
            Settings.Default.ArancelCaucionColocadora = 1.5m;

            var caucion = new Caucion(-1, 107.68m, 11641000m);

            caucion.GastosGarantia.Should().BeApproximately(0, CurrencyErrorMargin);
            caucion.DerechosMercado.Should().BeApproximately(58.38m, CurrencyErrorMargin);
            caucion.Arancel.Should().BeApproximately(479.81m, CurrencyErrorMargin);
            caucion.IVAGastos.Should().BeApproximately(113.02m, CurrencyErrorMargin);

            caucion.ImporteConInteres.Should().BeApproximately(11675342.93m, 3m);
            caucion.ImporteNeto.Should().BeApproximately(11674691.72m, 3m);
        }

        [TestMethod]
        public void Caucion_Tomadora_3_Dias_Sin_Arancel()
        {
            Settings.Default.ArancelCaucionTomadora = 0;

            var caucion = new Caucion(3, 102.38m, 62473000);

            caucion.GastosGarantia.Should().BeApproximately(944.98m, CurrencyErrorMargin);
            caucion.DerechosMercado.Should().BeApproximately(944.98m, CurrencyErrorMargin);
            caucion.Arancel.Should().BeApproximately(0, CurrencyErrorMargin);
            caucion.IVAGastos.Should().BeApproximately(396.9m, CurrencyErrorMargin);

            caucion.ImporteConInteres.Should().BeApproximately(62998700.40m, 3m);
            caucion.ImporteNeto.Should().BeApproximately(63000984.31m, 3m);
        }

        [TestMethod]
        public void Caucion_Tomadora_1_Dia()
        {
            Settings.Default.ArancelCaucionTomadora = 2.5m;

            var caucion = new Caucion(1, 99m, 170000m);

            caucion.GastosGarantia.Should().BeApproximately(0.85m, CurrencyErrorMargin);
            caucion.DerechosMercado.Should().BeApproximately(0.85m, CurrencyErrorMargin);
            caucion.Arancel.Should().BeApproximately(11.68m, CurrencyErrorMargin);
            caucion.IVAGastos.Should().BeApproximately(2.81m, CurrencyErrorMargin);

            caucion.ImporteConInteres.Should().BeApproximately(170461.10m, 0.5m);
            caucion.ImporteNeto.Should().BeApproximately(170477.29m, CurrencyErrorMargin);
        }
    }
}
