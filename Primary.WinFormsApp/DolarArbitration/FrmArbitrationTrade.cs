using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmArbitrationTrade : Form
    {
        private DolarArbitrationTrade _trade;
        private decimal _ownedVentaImporte;
        private decimal _ownedVentaComision;
        private decimal _ownedCompraImporte;
        private decimal _ownedCompraComision;
        private decimal _arbitrationVentaImporte;
        private decimal _arbitrationVentaComision;
        private decimal _arbitrationCompraImporte;
        private decimal _arbitrationCompraComision;
        private decimal _ownedQuantityPerPrice;
        private decimal _arbitrationQuantityPerPrice;

        public FrmArbitrationTrade()
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
            if (_trade == null)
                return;

            lblOwnedLast.Text = _trade.Owned.Last.ToCurrency();
            if ( _trade.Owned.Last > 0)
            {
                lblArbitrationDiff.Text = (_trade.Arbitration.Last / _trade.Owned.Last - 1m).ToString("P");
                lblArbitrationLast.Text = _trade.Arbitration.Last.ToCurrency();
            }

            OwnedVentaBidsOffers.LoadData(_trade.Owned.Sell.Data);
            OwnedCompraBidsOffers.LoadData(_trade.Owned.Buy.Data);

            ArbitrationCompraBidsOffers.LoadData(_trade.Arbitration.Sell.Data);
            ArbitrationVentaBidsOffers.LoadData(_trade.Arbitration.Buy.Data);

            if (OwnedVentaPriceAutoUpdate)
            {
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.GetTopBidPrice();
            }

            if (ArbitrationCompraPriceAutoUpdate)
            {
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.GetTopOfferPrice();
            }

            if (ArbitrationVentaPriceAutoUpdate)
            {
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.GetTopBidPrice();
            }

            if (OwnedCompraPriceAutoUpdate)
            {
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.GetTopOfferPrice();
            }

        }

        internal void Init(DolarArbitrationTrade trade)
        {
            _trade = trade;

            OwnedVentaBidsOffers.InstrumentDetail= trade.Owned.Sell.Instrument;
            OwnedCompraBidsOffers.InstrumentDetail = trade.Owned.Buy.Instrument;
            ArbitrationVentaBidsOffers.InstrumentDetail = trade.Arbitration.Buy.Instrument;
            ArbitrationCompraBidsOffers.InstrumentDetail = trade.Arbitration.Sell.Instrument;

            OwnedVentaBidsOffers.ClickPrice += OwnedVentaBidsOffers_ClickPrice;
            OwnedVentaBidsOffers.ClickSize += OwnedVentaBidsOffers_ClickSize;

            OwnedCompraBidsOffers.ClickPrice += OwnedCompraBidsOffers_ClickPrice;
            OwnedCompraBidsOffers.ClickSize += OwnedCompraBidsOffers_ClickSize;

            ArbitrationCompraBidsOffers.ClickPrice += ArbitrationCompraBidsOffers_ClickPrice;
            ArbitrationCompraBidsOffers.ClickSize += ArbitrationCompraBidsOffers_ClickSize;

            ArbitrationVentaBidsOffers.ClickPrice += ArbitrationVentaBidsOffers_ClickPrice;
            ArbitrationVentaBidsOffers.ClickSize += ArbitrationVentaBidsOffers_ClickSize;

            var ownedSuffix = _trade.Owned.Sell.Instrument.IsCEDEAR() ? " (CEDEAR)" : "";
            var arbitrationSuffix = _trade.Arbitration.Sell.Instrument.IsCEDEAR() ? " (CEDEAR)" : "";
            grpOwnedVenta.Text += " - " + _trade.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + ownedSuffix;
            grpArbitrationCompra.Text += " - " + _trade.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
            grpArbitrationVenta.Text += " - " + _trade.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
            grpOwnedCompra.Text += " - " + _trade.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + ownedSuffix;

            _ownedQuantityPerPrice = _trade.Owned.Buy.Instrument.PriceConvertionFactor;
            _arbitrationQuantityPerPrice = _trade.Arbitration.Buy.Instrument.PriceConvertionFactor;

            numOwnedVentaSize.Value = 10000; // TODO: Get Max Size
            if (_trade.Owned.Sell.Data.Last != null)
                numOwnedVentaPrice.Value = _trade.Owned.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Sell.Data.Last != null)
                numArbitrationCompraPrice.Value = _trade.Arbitration.Sell.Data.Last.Price.Value;

            if (_trade.Arbitration.Buy.Data.Last != null)
                numArbitrationVentaPrice.Value = _trade.Arbitration.Buy.Data.Last.Price.Value;

            if (_trade.Owned.Buy.Data.Last != null)
                numOwnedCompraPrice.Value = _trade.Owned.Buy.Data.Last.Price.Value;

            this.Text = $"Venta {_trade.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Venta {_trade.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()}";
            lnkArbitration.Text = Text;

            numOwnedVentaPrice.Increment = _trade.Owned.Sell.Instrument.GetIncrement();
            numOwnedCompraPrice.Increment = _trade.Owned.Buy.Instrument.GetIncrement();
            numArbitrationVentaPrice.Increment = _trade.Arbitration.Buy.Instrument.GetIncrement();
            numArbitrationCompraPrice.Increment = _trade.Arbitration.Sell.Instrument.GetIncrement();

            numOwnedVentaPrice.DecimalPlaces = _trade.Owned.Sell.Instrument.InstrumentPricePrecision;
            numOwnedCompraPrice.DecimalPlaces = _trade.Owned.Buy.Instrument.InstrumentPricePrecision;
            numArbitrationVentaPrice.DecimalPlaces = _trade.Arbitration.Buy.Instrument.InstrumentPricePrecision;
            numArbitrationCompraPrice.DecimalPlaces = _trade.Arbitration.Sell.Instrument.InstrumentPricePrecision;

            lblDolarSell.Text = $"{_trade.Owned.Sell.Instrument.InstrumentId.Ticker()}";
            lblDolarBuy.Text = $"{_trade.Arbitration.Sell.Instrument.InstrumentId.Ticker()}";
        }

        public bool ArbitrationVentaPriceAutoUpdate
        {
            get
            {
                return numArbitrationVentaPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numArbitrationVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool ArbitrationCompraPriceAutoUpdate
        {
            get
            {
                return numArbitrationCompraPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numArbitrationCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool OwnedVentaPriceAutoUpdate
        {
            get
            {
                return numOwnedVentaPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numOwnedVentaPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        public bool OwnedCompraPriceAutoUpdate
        {
            get
            {
                return numOwnedCompraPrice.ForeColor == System.Drawing.Color.Red;
            }
            set
            {
                if (value)
                {
                    numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    numOwnedCompraPrice.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            }
        }

        private void ArbitrationCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numArbitrationCompraSize.Value = e.Value;
            // Calcular el size en base al Arbitration Compra Size
            var amount = numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value * _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numArbitrationCompraPrice.Value = e.Value;
            ArbitrationCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
        {
            var amount = numArbitrationCompraSize.Value * numArbitrationCompraPrice.Value * _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numArbitrationVentaSize.Value = e.Value;
            // Calcular el size en base al Arbitration Venta usando el precio de Arbitration Compra 
            var amount = numArbitrationCompraPrice.Value * numArbitrationVentaSize.Value * _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numArbitrationVentaPrice.Value = e.Value;
            ArbitrationVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        private void OwnedVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numOwnedVentaSize.Value = e.Value;
        }

        private void OwnedVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numOwnedVentaPrice.Value = e.Value;
            OwnedVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        private void OwnedCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            // Ajusto el Owned Venta Size y dejo que el Owned Compra se calcule solo
            numOwnedVentaSize.Value = e.Value;
        }

        private void OwnedCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            numOwnedCompraPrice.Value = e.Value;
            OwnedCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        public void UpdateOwnedVentaSizeBasedOnAmount(decimal amount)
        {
            if (numOwnedVentaPrice.Value > 0)
            {
                var ownedSellSize = amount / numOwnedVentaPrice.Value / _ownedQuantityPerPrice;
                if (ownedSellSize < numOwnedVentaSize.Maximum)
                {
                    numOwnedVentaSize.Value = Math.Ceiling(ownedSellSize);
                }
            }
        }

        public void CompleteOwnedVenta()
        {
            txtOwnedVenta.Text = $"VENDER {numOwnedVentaSize.Value:#,##0} nominales de {_trade.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.Owned.Sell.Instrument.FormatPrice(numOwnedVentaPrice.Value)}";
        }

        public void CompleteOwnedCompra()
        {
            txtOwnedCompra.Text = $"COMPRAR {numOwnedCompraSize.Value:#,##0} nominales de {_trade.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.Owned.Buy.Instrument.FormatPrice(numOwnedCompraPrice.Value)}";
        }

        public void CompleteArbitrationVenta()
        {
            txtArbitrationVenta.Text = $"VENDER {numArbitrationVentaSize.Value:#,##0} nominales de {_trade.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.Arbitration.Buy.Instrument.FormatPrice(numArbitrationVentaPrice.Value)}";
        }

        public void CompleteArbitrationCompra()
        {
            txtArbitrationCompra.Text = $"COMPRAR {numArbitrationCompraSize.Value:#,##0} nominales de {_trade.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.Arbitration.Sell.Instrument.FormatPrice(numArbitrationCompraPrice.Value)}";
        }

        public void CalculateOwnedVenta()
        {
            CompleteOwnedVenta();
            if (_ownedQuantityPerPrice > 0)
            {
                _ownedVentaImporte = numOwnedVentaSize.Value * numOwnedVentaPrice.Value * _ownedQuantityPerPrice;
                if (_trade.Owned.Sell.Instrument.IsPesos())
                {
                    _ownedVentaComision = _trade.Owned.Sell.Instrument.CalculateComisionDerechosMercado(_ownedVentaImporte);
                }
                else
                {
                    _ownedVentaComision = _trade.Owned.Sell.Instrument.CalculateComisionDerechosMercado(_ownedVentaImporte * numDolar.Value);
                }

                lblOwnedVentaImporte.Text = "Importe: " + _trade.Owned.Sell.Instrument.FormatCurrency(_ownedVentaImporte);
                lblOwnedComision.Text = "Comisión: " + _ownedVentaComision.ToCurrency();

                CalculateArbitrationCompraSize();
            }
        }

        public void CalculateOwnedCompraSize()
        {
            if (!chkComprarNominales.Checked)
            {
                numOwnedCompraSize.Value = numOwnedVentaSize.Value;
            }
            else
            {
                if (numOwnedCompraPrice.Value > 0)
                {
                    if (_trade.Arbitration.Buy.Instrument.IsPesos())
                    {
                        //var comisionUSD = (_arbtrationVentaComision + _ownedVentaComision) * numDolar.Value;
                        var size = Math.Floor((_arbitrationVentaImporte - _arbitrationVentaComision - _ownedVentaComision) / numOwnedCompraPrice.Value / _ownedQuantityPerPrice);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                    else
                    {
                        var size = Math.Floor((_arbitrationVentaImporte) / numOwnedCompraPrice.Value / _ownedQuantityPerPrice);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                }
            }

            CalculateOwnedCompraTotalAndProfit();
        }

        public void CalculateArbitrationCompraSize()
        {
            if (numArbitrationCompraPrice.Value > 0)
            {
                numArbitrationCompraSize.Value = Math.Floor((_ownedVentaImporte) / numArbitrationCompraPrice.Value / _arbitrationQuantityPerPrice);
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
            CompleteArbitrationCompra();
        }

        public void CalculateArbitrationCompraTotal()
        {
            _arbitrationCompraImporte = (numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value * _arbitrationQuantityPerPrice);

            if (_trade.Arbitration.Sell.Instrument.IsPesos())
            {
                _arbitrationCompraComision = _trade.Arbitration.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationCompraImporte);
            }
            else
            {
                _arbitrationCompraComision = _trade.Arbitration.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationCompraImporte * numDolar.Value);
            }

            lblArbirtationCompraComision.Text = "Comisión: " + _arbitrationCompraComision.ToCurrency();
            lblArbitrationCompraImporte.Text = "Importe: " + _trade.Arbitration.Sell.Instrument.FormatCurrency(_arbitrationCompraImporte);
        }

        public void CalculateArbitrationVentaSize()
        {
            numArbitrationVentaSize.Value = numArbitrationCompraSize.Value;

            CalculateArbitrationVentaTotal();
        }

        public void CalculateArbitrationVentaTotal()
        {
            _arbitrationVentaImporte = numArbitrationVentaSize.Value * numArbitrationVentaPrice.Value * _arbitrationQuantityPerPrice;
            if (_trade.Arbitration.Buy.Instrument.IsPesos())
            {
                _arbitrationVentaComision = _trade.Arbitration.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationVentaImporte);
            }
            else
            {
                _arbitrationVentaComision = _trade.Arbitration.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationVentaImporte * numDolar.Value);
            }

            lblArbitrationComision.Text = "Comisión: " + _arbitrationVentaComision.ToCurrency();
            lblArbitrationVentaImporte.Text = "Importe: " + _trade.Arbitration.Buy.Instrument.FormatCurrency(_arbitrationVentaImporte);

            CompleteArbitrationVenta();
            CalculateOwnedCompraSize();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            _ownedCompraImporte = numOwnedCompraSize.Value * numOwnedCompraPrice.Value * _ownedQuantityPerPrice;

            if (_trade.Owned.Buy.Instrument.IsPesos())
            {
                _ownedCompraComision = _trade.Owned.Buy.Instrument.CalculateComisionDerechosMercado(_ownedCompraImporte);
            }
            else
            {
                _ownedCompraComision = _trade.Owned.Buy.Instrument.CalculateComisionDerechosMercado(_ownedCompraImporte * numDolar.Value);
            }

            lblOwnedCompraImporte.Text = "Importe: " + _trade.Owned.Buy.Instrument.FormatCurrency(_ownedCompraImporte);
            lblOwnedCompraComision.Text = "Comisión: " + _arbitrationVentaComision.ToCurrency();

            var comisionTotal = _ownedVentaComision + _arbitrationVentaComision + _arbitrationCompraComision + _ownedCompraComision;

            var dolarCompra = numOwnedVentaPrice.Value > 0 ? numOwnedCompraPrice.Value / numOwnedVentaPrice.Value : 0;
            var dolarVenta = numArbitrationCompraPrice.Value > 0 ? numArbitrationVentaPrice.Value / numArbitrationCompraPrice.Value : 0;
            var dolarDiff = dolarCompra > 0 ? dolarVenta / dolarCompra - 1 : 0;

            decimal profit;

            
            if (_trade.Owned.Buy.Instrument.IsPesos())
            {
                profit = _arbitrationVentaImporte - _ownedCompraImporte - comisionTotal;
            }
            else
            {
                profit = (_arbitrationVentaImporte - _ownedCompraImporte) * numDolar.Value - comisionTotal;
            }

            lblComisionTotal.Text = "Total Comision: " + (comisionTotal).ToCurrency();
            lblTotalProfit.Text = "Total: " + _trade.Owned.Buy.Instrument.FormatCurrency(_arbitrationVentaImporte - _ownedCompraImporte);

            lblHeader.Text = "Profit: " + profit.ToCurrency();
            lblHeader.Text += Environment.NewLine + $"Dolar Compra: {dolarCompra:C2}     {dolarVenta - dolarCompra:C2} ({dolarDiff:P})     Dolar Venta: {dolarVenta:C2}";

            if (chkComprarNominales.Checked)
            {
                lblProfitPesos.Text = "Profit Nominales : " + (numOwnedCompraSize.Value - numOwnedVentaSize.Value) + " Dif. " + (profit).ToCurrency();
            }
            else
            {
                lblProfitPesos.Text = "Profit: " + profit.ToCurrency();
            }

            if (profit < 0)
            {
                lblHeader.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblHeader.ForeColor = System.Drawing.Color.DarkGreen;
            }


            CompleteOwnedCompra();
        }

        private void numOwnedVentaSize_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedVenta();
        }

        private void numOwnedVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedVenta();

        }

        private void numArbitrationCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationCompraSize();
        }

        private void numArbitrationVentaPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateArbitrationVentaSize();
        }

        private void numOwnedCompraPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateOwnedCompraSize();
        }

        private void numOwnedVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OwnedVentaPriceAutoUpdate = false;
        }

        private void numArbitrationCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArbitrationCompraPriceAutoUpdate = false;
        }

        private void numArbitrationVentaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArbitrationVentaPriceAutoUpdate = false;
        }

        private void numOwnedCompraPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OwnedCompraPriceAutoUpdate = false;
        }

        private void chkComprarNominales_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOwnedCompraSize();
        }

        private void txtOwnedVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtOwnedVenta.Text);
        }

        private void txtArbitrationCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtArbitrationCompra.Text);
        }

        private void txtArbitrationVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtArbitrationVenta.Text);
        }

        private void txtOwnedCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtOwnedCompra.Text);
        }

        private void lnkArbitration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(lnkArbitration.Text);
        }

        private void numDolar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USDARS = numDolar.Value;
            Properties.Settings.Default.Save();
            CalculateOwnedVenta();
        }

        private void numComision_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Comision = numComision.Value;
            Properties.Settings.Default.Save();
            CalculateOwnedVenta();
        }
    }
}
