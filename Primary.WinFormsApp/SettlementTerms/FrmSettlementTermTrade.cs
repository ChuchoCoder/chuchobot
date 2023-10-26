using Primary.WinFormsApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmSettlementTermTrade : Form
    {
        private static Color AutoColor = Color.Blue;
        private SettlementTermTrade _trade;

        public FrmSettlementTermTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
            numDolar.Value = Properties.Settings.Default.USDARS;
            SizeAutoUpdate = true;
            CompraPriceAutoUpdate = true;
            VentaPriceAutoUpdate = true;

            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_trade == null)
                return;

            settlementTermSettings1.RefreshValues();

            _trade.Buy.RefreshData();
            _trade.Sell.RefreshData();

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

            if (SizeAutoUpdate && _trade.Buy.Data != null && _trade.Sell.Data != null)
            {
                var topCompraSize = _trade.Buy.Data.GetTopOfferSize();
                var topVentaSize = _trade.Sell.Data.GetTopBidSize();
                var minSize = Math.Min(topCompraSize, topVentaSize);
                numCompraSize.Value = minSize;
                numOwnedVentaSize.Value = minSize;
            }

            timer1.Start();
        }

        internal void Init(SettlementTermTrade trade)
        {
            _trade = trade;

            _trade.Buy.RefreshData();
            _trade.Sell.RefreshData();

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

        public bool SizeAutoUpdate
        {
            get
            {
                return numCompraSize.ForeColor == AutoColor;
            }
            set
            {
                if (value)
                {
                    numCompraSize.ForeColor = AutoColor;
                    numOwnedVentaSize.ForeColor = AutoColor;
                }
                else
                {
                    numCompraSize.ForeColor = System.Drawing.SystemColors.WindowText;
                    numOwnedVentaSize.ForeColor = SystemColors.WindowText;
                }
            }
        }

        public bool CompraPriceAutoUpdate
        {
            get
            {
                return numCompraPrice.ForeColor == AutoColor;
            }
            set
            {
                if (value)
                {
                    numCompraPrice.ForeColor = AutoColor;
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
                return numVentaPrice.ForeColor == AutoColor;
            }
            set
            {
                if (value)
                {
                    numVentaPrice.ForeColor = AutoColor;
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
            SizeAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
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
            SizeAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
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
                _trade.Calculate(numOwnedVentaSize.Value, numVentaPrice.Value, numCompraPrice.Value, Settings.Default.TasaCaucion);

                lblVentaImporte.Text = $"Importe: {_trade.SellTotalSinComisiones:C2}";
                lblVentaComision.Text = $"DM. + Com.: {-_trade.SellComisionDerechos:C2}";

                lblCompraImporte.Text = $"Importe: {_trade.BuyTotalSinComisiones:C2}";
                lblCompraComision.Text = $"DM. + Com.: {-_trade.BuyComisionDerechos:C2}";

                lblComisionTotal.Text = $"Total Der.Mer. + Comisión: {-_trade.SellComisionDerechos - _trade.BuyComisionDerechos:C2}";

                lblBuyPriceTarget.Text = "Px Arbitrado: " + _trade.BuyPriceTarget.ToCurrency();
                lblSellPriceTarget.Text = "Px Arbitrado: " + _trade.SellPriceTarget.ToCurrency();

                var tipoCaucion = _trade.EsCaucionColocadora ? "Colocadora" : "Tomadora";
                this.groupBox1.Text = "Caución " + tipoCaucion;
                lblDiasCaucion.Text = "Días Caución: " + _trade.Caucion.Dias.ToString();

                lblMontoCaucion.Text = "Importe a caucionar: " + _trade.Caucion.ImporteBruto.ToCurrency();
                lblInteresCaucion.Text = "Interés: " + _trade.Caucion.Interes.ToCurrency();
                lblInteresNeto.Text = "Interés Neto: " + _trade.Caucion.InteresNeto.ToCurrency();

                lblIva.Text = "IVA: " + _trade.Caucion.IVAGastos.ToCurrency();

                lblDerMerCaucion.Text = $"Der. Mer. {_trade.Sell.Instrument.GetDerechosDeMercado():P}: " + _trade.Caucion.DerechosMercado.ToCurrency();
                lblGtoGtiaCaucion.Text = "Gtos. Gtias.: " + _trade.Caucion.GastosGarantia.ToCurrency();
                lblArancelCaucion.Text = "Arancel: " + _trade.Caucion.Arancel.ToCurrency();
                lblGastosCaucion.Text = "Total Gastos: " + _trade.Caucion.TotalGastos.ToCurrency();

                lblNetoCaucion.Text = "Interés Neto Caución: " + _trade.Caucion.InteresNeto.ToCurrency();

                var difVentaCompra = _trade.SellTotalSinComisiones - _trade.BuyTotalSinComisiones;
                lblDifVentaCompra.Text = "Venta - Compra: " + difVentaCompra.ToCurrency();

                lblProfitPesos.Text = $"Profit: {_trade.ProfitLoss:C2}";

                var percentage = _trade.BuyTotalSinComisiones != 0 ? _trade.ProfitLoss / _trade.BuyTotalSinComisiones : 0;
                lblHeader.Text = $"Profit: {_trade.ProfitLoss:C2} ({percentage:P2})";

                if (_trade.ProfitLoss > 0)
                {
                    lblHeader.ForeColor = Color.Green;
                    lblProfitPesos.ForeColor = Color.Green;
                }
                else
                {
                    lblHeader.ForeColor = Color.Red;
                    lblProfitPesos.ForeColor = Color.Red;
                }
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

        private void numOwnedVentaSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            SizeAutoUpdate = false;
        }

        private void numCompraSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            SizeAutoUpdate = false;
        }
    }
}
