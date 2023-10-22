using Primary.WinFormsApp.Properties;
using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmSettlementTermTrade : Form
    {
        private SettlementTermTrade _trade;

        public decimal Comision => numComision.Value / 100;

        public FrmSettlementTermTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
            numDolar.Value = Properties.Settings.Default.USDARS;
            numComision.Value = Properties.Settings.Default.Comision;
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_trade == null)
                return;

            numComision.Value = Properties.Settings.Default.Comision;

            if (_trade.Sell.Data != null)
            {
                VentaBidsOffers.LoadData(_trade.Sell.Data);

                if (VentaPriceAutoUpdate)
                {
                    numVentaPrice.Value = _trade.Sell.Data.GetTopBidPrice();
                }
            }

            if (_trade.Buy.Data != null)
            {
                CompraBidsOffers.LoadData(_trade.Buy.Data);

                if (CompraPriceAutoUpdate)
                {
                    numCompraPrice.Value = _trade.Buy.Data.GetTopOfferPrice();
                }
            }

            timer1.Start();
        }

        internal void Init(SettlementTermTrade trade)
        {
            _trade = trade;

            VentaBidsOffers.InstrumentDetail = trade.Sell.Instrument;
            CompraBidsOffers.InstrumentDetail = trade.Buy.Instrument;

            VentaBidsOffers.ClickPrice += VentaBidsOffers_ClickPrice;
            VentaBidsOffers.ClickSize += VentaBidsOffers_ClickSize;

            CompraBidsOffers.ClickPrice += CompraBidsOffers_ClickPrice;
            CompraBidsOffers.ClickSize += CompraBidsOffers_ClickSize;

            var suffix = _trade.Sell.Instrument.IsCEDEAR() ? " (CEDEAR)" : "";
            grpOwnedVenta.Text = $"1. Vender {_trade.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + suffix} - Der. Mer.: ({_trade.Sell.Instrument.GetDerechosDeMercado():P})";
            grpArbitrationCompra.Text = $"2. Comprar {_trade.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + suffix} - Der. Mer.: ({_trade.Buy.Instrument.GetDerechosDeMercado():P})";

            var sellTopSize = trade.Sell.HasBids() ? trade.Sell.Data.GetTopBidSize() : 0;
            var buyTopSize = trade.Buy.HasOffers() ? trade.Buy.Data.GetTopOfferSize() : 0;

            numOwnedVentaSize.Value = Math.Min(sellTopSize, buyTopSize);
            if (_trade.Sell.Data?.Last != null)
                numVentaPrice.Value = _trade.Sell.Data.Last.Price.Value;

            if (_trade.Buy.Data?.Last != null)
                numCompraPrice.Value = _trade.Buy.Data.Last.Price.Value;


            this.Text = $"Venta {_trade.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()}";
            lnkArbitration.Text = Text;

            numVentaPrice.Increment = _trade.Sell.Instrument.IsPesos() ? 1 : 0.01m;
            numCompraPrice.Increment = _trade.Buy.Instrument.IsPesos() ? 1 : 0.01m;
        }


        public bool CompraPriceAutoUpdate
        {
            get
            {
                return numCompraPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numCompraPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool VentaPriceAutoUpdate
        {
            get
            {
                return numVentaPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numVentaPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        private void CompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numCompraSize.Value = e.Value;
        }

        private void CompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numCompraPrice.Value = e.Value;
            CompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        private void numCompraSize_ValueChanged(object sender, EventArgs e)
        {
            numOwnedVentaSize.Value = numCompraSize.Value;
            CompleteArbitrationCompra();
        }


        private void VentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numOwnedVentaSize.Value = e.Value;
        }

        private void VentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numVentaPrice.Value = e.Value;
            VentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        public void UpdateOwnedVentaSizeBasedOnAmount(decimal amount)
        {
            var ownedSellSize = amount / numVentaPrice.Value * _trade.Buy.Instrument.PriceConvertionFactor;
            if (ownedSellSize < numOwnedVentaSize.Maximum)
            {
                numOwnedVentaSize.Value = Math.Ceiling(ownedSellSize);
            }
        }

        public void CompleteOwnedVenta()
        {
            txtOwnedVenta.Text = $"VENDER {numOwnedVentaSize.Value:#,##0} nominales de {_trade.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {numVentaPrice.Value:#,##0.00}";
        }


        public void CompleteArbitrationCompra()
        {
            txtArbitrationCompra.Text = $"COMPRAR {numCompraSize.Value:#,##0} nominales de {_trade.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {numCompraPrice.Value:#,##0.00}";
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            if (numCompraPrice.Value > 0)
            {
                var neto = _trade.Calculate(numOwnedVentaSize.Value, numVentaPrice.Value, numCompraPrice.Value, Settings.Default.TasaCaucion, Settings.Default.ArancelCaucionColocadora, Settings.Default.ArancelCaucionTomadora);

                lblVentaImporte.Text = $"Importe: {neto.SellTotalSinComisiones:C2}";
                lblVentaComision.Text = $"DM. + Com.: {-neto.SellComisionDerechos:C2}";

                lblCompraImporte.Text = $"Importe: {neto.BuyTotalSinComisiones:C2}";
                lblCompraComision.Text = $"DM. + Com.: {-neto.BuyComisionDerechos:C2}";

                lblComisionTotal.Text = $"Total Der.Mer. + Comisión: {-neto.SellComisionDerechos - neto.BuyComisionDerechos:C2}";

                lblBuyPriceTarget.Text = "Px Arbitrado: " + neto.BuyPriceTarget.ToCurrency();
                lblSellPriceTarget.Text = "Px Arbitrado: " + neto.SellPriceTarget.ToCurrency();

                var tipoCaucion = neto.DiasCaucion > 0 ? "Tomadora" : "Colocadora";
                this.groupBox1.Text = "Caución " + tipoCaucion;
                lblDiasCaucion.Text = "Días Caución: " + neto.DiasCaucion.ToString();
                lblMontoCaucion.Text = "Monto Caución: " + neto.TotalACaucionar.ToCurrency();
                lblInteresNeto.Text = "Interés Neto: " + neto.InteresNeto.ToCurrency();
                lblInteresCaucion.Text = "Interés: " + neto.InteresCaucion.ToCurrency();
                lblIva.Text = "IVA: " + neto.IvaGastos.ToCurrency();
                lblDerMerCaucion.Text = $"Der. Mer. {_trade.Sell.Instrument.GetDerechosDeMercado():P}: " + neto.DerechosMercadoCaucion.ToCurrency();
                lblGtoGtiaCaucion.Text = "Gtos. Gtias.: " + neto.GastosGarantia.ToCurrency();
                lblArancelCaucion.Text = "Arancel: " + neto.ArancelCaucion.ToCurrency();
                lblGastosCaucion.Text = "Gastos: " + neto.ComisionCaucionTotal.ToCurrency();

                lblNetoCaucion.Text = "Caución: " + neto.InteresNeto.ToCurrency();

                var difVentaCompra = neto.SellTotalSinComisiones - neto.BuyTotalSinComisiones;
                lblDifVentaCompra.Text = "Venta - Compra: " + difVentaCompra.ToCurrency();

                lblProfitPesos.Text = $"Profit: {neto.ProfitLoss:C2}";

                var percentage = neto.ProfitLoss / neto.BuyTotalSinComisiones;
                lblHeader.Text = $"Profit: {neto.ProfitLoss:C2} ({percentage:P2})";
            }
        }

        public void CalculateArbitrationCompraTotal()
        {
            lblCompraImporte.Text = "Importe: " + (numCompraPrice.Value * numCompraSize.Value / _trade.Buy.Instrument.PriceConvertionFactor).ToUSD();
        }

        private void numOwnedVentaSize_ValueChanged(object sender, EventArgs e)
        {
            numCompraSize.Value = numOwnedVentaSize.Value;
            CompleteOwnedVenta();
            CalculateOwnedCompraTotalAndProfit();
        }

        private void numOwnedVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CompleteOwnedVenta();
            CalculateOwnedCompraTotalAndProfit();

        }

        private void numCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CompleteArbitrationCompra();
            CalculateOwnedCompraTotalAndProfit();
        }

        private void numOwnedVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            VentaPriceAutoUpdate = false;
        }

        private void numArbitrationCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CompraPriceAutoUpdate = false;
        }

        private void txtOwnedVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtOwnedVenta.Text);
        }

        private void txtArbitrationCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtArbitrationCompra.Text);
        }

        private void lnkArbitration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(lnkArbitration.Text);
        }

        private void numDolar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USDARS = numDolar.Value;
            Properties.Settings.Default.Save();
            CalculateOwnedCompraTotalAndProfit();
        }

        private void numComision_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Comision = numComision.Value;
            Properties.Settings.Default.Save();
            CalculateOwnedCompraTotalAndProfit();
        }
    }
}
