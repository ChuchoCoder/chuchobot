using System;
using System.Drawing;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmRatioTrade : Form
    {
        private static Color AutoColor = Color.Blue;
        private RatioTrade _trade;
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

        public FrmRatioTrade()
        {
            InitializeComponent();
        }

        private void FrmArbitrationTrade_Load(object sender, EventArgs e)
        {
            numArbitrationCompraSize.Maximum =
                numArbitrationCompraPrice.Maximum =
                numArbitrationVentaSize.Maximum =
                numArbitrationVentaPrice.Maximum =
                numOwnedCompraSize.Maximum =
                numOwnedCompraPrice.Maximum =
                numOwnedVentaSize.Maximum =
                numOwnedVentaPrice.Maximum = decimal.MaxValue;

            numDolar.Value = Properties.Settings.Default.USDARS;
            numComision.Value = Properties.Settings.Default.Comision;

            OwnedVentaPriceAutoUpdate = true;
            OwnedSizeAutoUpdate = true;
            ArbitrationSizeAutoUpdate = true;
            OwnedCompraPriceAutoUpdate = true;
            ArbitrationCompraPriceAutoUpdate = true;
            ArbitrationVentaPriceAutoUpdate = true;

            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_trade == null)
            {
                return;
            }

            _trade.RefreshData();

            lblOwnedLast.Text = _trade.SellThenBuy.Last.ToCurrency();
            if (_trade.SellThenBuy.Last > 0)
            {
                lblArbitrationDiff.Text = ((_trade.BuyThenSell.Last / _trade.SellThenBuy.Last) - 1m).ToString("P");
                lblArbitrationLast.Text = _trade.BuyThenSell.Last.ToCurrency();
            }

            OwnedVentaBidsOffers.LoadData(_trade.SellThenBuy.Sell.Data);
            OwnedCompraBidsOffers.LoadData(_trade.SellThenBuy.Buy.Data);

            ArbitrationCompraBidsOffers.LoadData(_trade.BuyThenSell.Sell.Data);
            ArbitrationVentaBidsOffers.LoadData(_trade.BuyThenSell.Buy.Data);

            if (OwnedVentaPriceAutoUpdate)
            {
                OwnedVentaPrice = _trade.SellThenBuy.Sell.Data.GetTopBidPrice();
            }

            if (ArbitrationCompraPriceAutoUpdate)
            {
                ArbitrationCompraPrice = _trade.BuyThenSell.Sell.Data.GetTopOfferPrice();
            }

            if (ArbitrationVentaPriceAutoUpdate)
            {
                numArbitrationVentaPrice.Value = _trade.BuyThenSell.Buy.Data.GetTopBidPrice();
            }

            if (OwnedCompraPriceAutoUpdate)
            {
                numOwnedCompraPrice.Value = _trade.SellThenBuy.Buy.Data.GetTopOfferPrice();
            }

            CalculateOwnedAutoSize();

        }

        public decimal OwnedVentaPrice {
            get => numOwnedVentaPrice.Value;
            set
            {
                if (!numOwnedVentaPrice.Focused)
                {
                    numOwnedVentaPrice.Value = value;
                }
            }
        }

        public decimal ArbitrationCompraPrice
        {
            get => numArbitrationCompraPrice.Value;
            set
            {
                if (!numArbitrationCompraPrice.Focused)
                {
                    numArbitrationCompraPrice.Value = value;
                }
            }
        }

        internal void Init(RatioTrade trade)
        {
            _trade = trade;

            OwnedVentaBidsOffers.InstrumentDetail = trade.SellThenBuy.Sell.Instrument;
            OwnedCompraBidsOffers.InstrumentDetail = trade.SellThenBuy.Buy.Instrument;
            ArbitrationVentaBidsOffers.InstrumentDetail = trade.BuyThenSell.Buy.Instrument;
            ArbitrationCompraBidsOffers.InstrumentDetail = trade.BuyThenSell.Sell.Instrument;

            OwnedVentaBidsOffers.ClickPrice += OwnedVentaBidsOffers_ClickPrice;
            OwnedVentaBidsOffers.ClickSize += OwnedVentaBidsOffers_ClickSize;

            OwnedCompraBidsOffers.ClickPrice += OwnedCompraBidsOffers_ClickPrice;
            OwnedCompraBidsOffers.ClickSize += OwnedCompraBidsOffers_ClickSize;

            ArbitrationCompraBidsOffers.ClickPrice += ArbitrationCompraBidsOffers_ClickPrice;
            ArbitrationCompraBidsOffers.ClickSize += ArbitrationCompraBidsOffers_ClickSize;

            ArbitrationVentaBidsOffers.ClickPrice += ArbitrationVentaBidsOffers_ClickPrice;
            ArbitrationVentaBidsOffers.ClickSize += ArbitrationVentaBidsOffers_ClickSize;

            var ownedSuffix = _trade.SellThenBuy.Sell.Instrument.IsCEDEAR() ? " (CEDEAR)" : "";
            var arbitrationSuffix = _trade.BuyThenSell.Sell.Instrument.IsCEDEAR() ? " (CEDEAR)" : "";
            grpOwnedVenta.Text += " - " + _trade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + ownedSuffix;
            grpArbitrationCompra.Text += " - " + _trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
            grpArbitrationVenta.Text += " - " + _trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
            grpOwnedCompra.Text += " - " + _trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + ownedSuffix;

            _ownedQuantityPerPrice = _trade.SellThenBuy.Buy.Instrument.PriceConvertionFactor;
            _arbitrationQuantityPerPrice = _trade.BuyThenSell.Buy.Instrument.PriceConvertionFactor;

            numOwnedVentaSize.Value = 10000;
            CalculateOwnedAutoSize();

            if (_trade.SellThenBuy.Sell.Data?.Last != null)
            {
                OwnedVentaPrice = _trade.SellThenBuy.Sell.Data.Last.Price.Value;
            }

            if (_trade.BuyThenSell.Sell.Data?.Last != null)
            {
                ArbitrationCompraPrice = _trade.BuyThenSell.Sell.Data.Last.Price.Value;
            }

            if (_trade.BuyThenSell.Buy.Data?.Last != null)
            {
                numArbitrationVentaPrice.Value = _trade.BuyThenSell.Buy.Data.Last.Price.Value;
            }

            if (_trade.SellThenBuy.Buy.Data?.Last != null)
            {
                numOwnedCompraPrice.Value = _trade.SellThenBuy.Buy.Data.Last.Price.Value;
            }

            Text = $"Venta {_trade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Venta {_trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()}";
            lnkArbitration.Text = Text;

            numOwnedVentaPrice.Increment = _trade.SellThenBuy.Sell.Instrument.GetIncrement();
            numOwnedCompraPrice.Increment = _trade.SellThenBuy.Buy.Instrument.GetIncrement();
            numArbitrationVentaPrice.Increment = _trade.BuyThenSell.Buy.Instrument.GetIncrement();
            numArbitrationCompraPrice.Increment = _trade.BuyThenSell.Sell.Instrument.GetIncrement();

            numOwnedVentaPrice.DecimalPlaces = _trade.SellThenBuy.Sell.Instrument.InstrumentPricePrecision;
            numOwnedCompraPrice.DecimalPlaces = _trade.SellThenBuy.Buy.Instrument.InstrumentPricePrecision;
            numArbitrationVentaPrice.DecimalPlaces = _trade.BuyThenSell.Buy.Instrument.InstrumentPricePrecision;
            numArbitrationCompraPrice.DecimalPlaces = _trade.BuyThenSell.Sell.Instrument.InstrumentPricePrecision;

            lblRatioSell.Text = $"{_trade.SellThenBuy.Sell.Instrument.InstrumentId.Ticker()}";
            lblDolarBuy.Text = $"{_trade.BuyThenSell.Sell.Instrument.InstrumentId.Ticker()}";

            lblCompraACurrency.Text = _trade.SellThenBuy.Buy.Instrument.IsPesos() ? "a $:" : "a USD:";
            lblVentaACurrency.Text = _trade.SellThenBuy.Sell.Instrument.IsPesos() ? "a $:" : "a USD:";
            lblCompraBCurrency.Text = _trade.BuyThenSell.Buy.Instrument.IsPesos() ? "a $:" : "a USD:";
            lblVentaBCurrency.Text = _trade.BuyThenSell.Sell.Instrument.IsPesos() ? "a $:" : "a USD:";

            numOwnedCompraPrice.Increment = _trade.SellThenBuy.Buy.Instrument.MinPriceIncrement;
            numOwnedVentaPrice.Increment = _trade.SellThenBuy.Sell.Instrument.MinPriceIncrement;
            numArbitrationCompraPrice.Increment = _trade.BuyThenSell.Buy.Instrument.MinPriceIncrement;
            numArbitrationVentaPrice.Increment = _trade.BuyThenSell.Sell.Instrument.MinPriceIncrement;

            numOwnedCompraPrice.DecimalPlaces = _trade.SellThenBuy.Buy.Instrument.IsPesos() ? 0 : 2;
            numOwnedVentaPrice.DecimalPlaces = _trade.SellThenBuy.Sell.Instrument.IsPesos() ? 0 : 2;
            numArbitrationCompraPrice.DecimalPlaces = _trade.BuyThenSell.Buy.Instrument.IsPesos() ? 0 : 2;
            numArbitrationVentaPrice.DecimalPlaces = _trade.BuyThenSell.Sell.Instrument.IsPesos() ? 0 : 2;

            if (lblCompraACurrency.Text == lblVentaACurrency.Text)
            {
                lblDolar.Visible = false;
                numDolar.Visible = false;
                lblRatioSell.Visible = false;
                lblOwnedLast.Visible = false;
                lblArbitrationDiff.Visible = false;
                lblArbitrationLast.Visible = false;
                lblDolarBuy.Visible = false;
            }
        }

        private void CalculateOwnedAutoSize()
        {
            if (OwnedSizeAutoUpdate)
            {
                if (ArbitrationSizeAutoUpdate == false)
                {
                    if (_trade.SellThenBuy.Buy.HasOffers())
                    {
                        var buyPrice = OwnedVentaPriceAutoUpdate ? _trade.SellThenBuy.Sell.Data.GetTopOfferPrice() : numOwnedVentaPrice.Value;
                        var compra = numArbitrationCompraSize.Value * (numArbitrationCompraPrice.Value * _trade.BuyThenSell.Buy.Instrument.PriceConvertionFactor);
                        var venta = compra / (buyPrice * _trade.SellThenBuy.Sell.Instrument.PriceConvertionFactor);
                        numOwnedVentaSize.Value = venta;
                    }
                }
                else
                {
                    var sellBid = 10000m;
                    var sellTotal = 1m;
                    if (_trade.SellThenBuy.Sell.HasBids())
                    {
                        sellBid = _trade.SellThenBuy.Sell.Data.GetTopBidSize();
                        var sellPrice = _trade.SellThenBuy.Sell.Data.GetTopBidPrice() * _trade.SellThenBuy.Sell.Instrument.PriceConvertionFactor;
                        sellTotal = sellBid * sellPrice;
                    }

                    var buyBid = 10000m;
                    var buyTotal = 1m;
                    if (_trade.BuyThenSell.Buy.HasOffers())
                    {
                        buyBid = _trade.BuyThenSell.Buy.Data.GetTopOfferSize();
                        var buyPrice = _trade.BuyThenSell.Buy.Data.GetTopOfferPrice() * _trade.BuyThenSell.Buy.Instrument.PriceConvertionFactor;
                        buyTotal = buyBid * buyPrice;
                    }

                    numOwnedVentaSize.Value = sellTotal > buyTotal ? buyBid : sellBid;
                }
            }
        }

        public bool ArbitrationVentaPriceAutoUpdate
        {
            get => numArbitrationVentaPrice.ForeColor == AutoColor;
            set => numArbitrationVentaPrice.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
        }

        public bool ArbitrationCompraPriceAutoUpdate
        {
            get => numArbitrationCompraPrice.ForeColor == AutoColor;
            set => numArbitrationCompraPrice.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
        }

        public bool OwnedSizeAutoUpdate
        {
            get => chkOwnedVenta.Checked;
            set
            {
                chkOwnedVenta.Checked = value;
                numOwnedVentaSize.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
            }
        }

        public bool ArbitrationSizeAutoUpdate
        {
            get => chkArbitrationCompra.Checked;
            set
            {
                chkArbitrationCompra.Checked = value;
                numArbitrationCompraSize.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
            }
        }

        public bool OwnedVentaPriceAutoUpdate
        {
            get => numOwnedVentaPrice.ForeColor == AutoColor;
            set => numOwnedVentaPrice.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
        }

        public bool OwnedCompraPriceAutoUpdate
        {
            get => numOwnedCompraPrice.ForeColor == AutoColor;
            set => numOwnedCompraPrice.ForeColor = value ? AutoColor : System.Drawing.SystemColors.WindowText;
        }

        private void ArbitrationCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            ArbitrationSizeAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
            numArbitrationCompraSize.Value = e.Value;
            // Calcular el size en base al BuyThenSell Compra Size
            var amount = numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value * _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            ArbitrationCompraPrice = e.Value;
            ArbitrationCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        }

        private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
        {
            var amount = numArbitrationCompraSize.Value * numArbitrationCompraPrice.Value * _arbitrationQuantityPerPrice;
            UpdateOwnedVentaSizeBasedOnAmount(amount);
        }

        private void ArbitrationVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            numArbitrationCompraSize.Value = e.Value;
            // Calcular el size en base al BuyThenSell Venta usando el precio de BuyThenSell Compra 
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
            OwnedSizeAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;

            numOwnedVentaSize.Value = e.Value;
        }

        private void OwnedVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
        {
            OwnedVentaPrice = e.Value;
            OwnedVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
        }

        private void OwnedCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
        {
            // Ajusto el SellThenBuy Venta Size y dejo que el SellThenBuy Compra se calcule solo
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
            txtOwnedVenta.Text = $"VENDER {numOwnedVentaSize.Value:#,##0} nominales de {_trade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.SellThenBuy.Sell.Instrument.FormatPrice(numOwnedVentaPrice.Value)}";
        }

        public void CompleteOwnedCompra()
        {
            txtOwnedCompra.Text = $"COMPRAR {numOwnedCompraSize.Value:#,##0} nominales de {_trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.SellThenBuy.Buy.Instrument.FormatPrice(numOwnedCompraPrice.Value)}";
        }

        public void CompleteArbitrationVenta()
        {
            txtArbitrationVenta.Text = $"VENDER {numArbitrationVentaSize.Value:#,##0} nominales de {_trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.BuyThenSell.Buy.Instrument.FormatPrice(numArbitrationVentaPrice.Value)}";
        }

        public void CompleteArbitrationCompra()
        {
            txtArbitrationCompra.Text = $"COMPRAR {numArbitrationCompraSize.Value:#,##0} nominales de {_trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.BuyThenSell.Sell.Instrument.FormatPrice(numArbitrationCompraPrice.Value)}";
        }

        public void CalculateOwnedVenta()
        {
            CompleteOwnedVenta();
            if (_ownedQuantityPerPrice > 0)
            {
                _ownedVentaImporte = numOwnedVentaSize.Value * numOwnedVentaPrice.Value * _ownedQuantityPerPrice;
                _ownedVentaComision = _trade.SellThenBuy.Sell.Instrument.IsPesos()
                    ? _trade.SellThenBuy.Sell.Instrument.CalculateComisionDerechosMercado(_ownedVentaImporte)
                    : _trade.SellThenBuy.Sell.Instrument.CalculateComisionDerechosMercado(_ownedVentaImporte * numDolar.Value);

                lblOwnedVentaImporte.Text = "Importe: " + _trade.SellThenBuy.Sell.Instrument.FormatCurrency(_ownedVentaImporte);
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
                    if (_trade.BuyThenSell.Buy.Instrument.IsPesos())
                    {
                        //var comisionUSD = (_arbtrationVentaComision + _ownedVentaComision) * numDolar.Value;
                        var size = Math.Floor((_arbitrationVentaImporte - _arbitrationVentaComision - _ownedVentaComision) / numOwnedCompraPrice.Value / _ownedQuantityPerPrice);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                    else
                    {
                        var size = Math.Floor(_arbitrationVentaImporte / numOwnedCompraPrice.Value / _ownedQuantityPerPrice);
                        numOwnedCompraSize.Value = size <= 0 ? 0 : size;
                    }
                }
            }

            CalculateOwnedCompraTotalAndProfit();
        }

        public void CalculateArbitrationCompraSize()
        {
            if (numArbitrationCompraPrice.Value > 0 && ArbitrationSizeAutoUpdate)
            {
                numArbitrationCompraSize.Value = Math.Floor(_ownedVentaImporte / numArbitrationCompraPrice.Value / _arbitrationQuantityPerPrice);
            }
            CalculateArbitrationCompraTotal();
            CalculateArbitrationVentaSize();
            CompleteArbitrationCompra();
        }

        public void CalculateArbitrationCompraTotal()
        {
            _arbitrationCompraImporte = numArbitrationCompraPrice.Value * numArbitrationCompraSize.Value * _arbitrationQuantityPerPrice;

            _arbitrationCompraComision = _trade.BuyThenSell.Sell.Instrument.IsPesos()
                ? _trade.BuyThenSell.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationCompraImporte)
                : _trade.BuyThenSell.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationCompraImporte * numDolar.Value);

            lblArbirtationCompraComision.Text = "Comisión: " + _arbitrationCompraComision.ToCurrency();
            lblArbitrationCompraImporte.Text = "Importe: " + _trade.BuyThenSell.Sell.Instrument.FormatCurrency(_arbitrationCompraImporte);
        }

        public void CalculateArbitrationVentaSize()
        {
            numArbitrationVentaSize.Value = numArbitrationCompraSize.Value;

            CalculateArbitrationVentaTotal();
        }

        public void CalculateArbitrationVentaTotal()
        {
            _arbitrationVentaImporte = numArbitrationVentaSize.Value * numArbitrationVentaPrice.Value * _arbitrationQuantityPerPrice;
            _arbitrationVentaComision = _trade.BuyThenSell.Buy.Instrument.IsPesos()
                ? _trade.BuyThenSell.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationVentaImporte)
                : _trade.BuyThenSell.Buy.Instrument.CalculateComisionDerechosMercado(_arbitrationVentaImporte * numDolar.Value);

            lblArbitrationComision.Text = "Comisión: " + _arbitrationVentaComision.ToCurrency();
            lblArbitrationVentaImporte.Text = "Importe: " + _trade.BuyThenSell.Buy.Instrument.FormatCurrency(_arbitrationVentaImporte);

            CompleteArbitrationVenta();
            CalculateOwnedCompraSize();
        }

        public void CalculateOwnedCompraTotalAndProfit()
        {
            _ownedCompraImporte = numOwnedCompraSize.Value * numOwnedCompraPrice.Value * _ownedQuantityPerPrice;

            _ownedCompraComision = _trade.SellThenBuy.Buy.Instrument.IsPesos()
                ? _trade.SellThenBuy.Buy.Instrument.CalculateComisionDerechosMercado(_ownedCompraImporte)
                : _trade.SellThenBuy.Buy.Instrument.CalculateComisionDerechosMercado(_ownedCompraImporte * numDolar.Value);

            lblOwnedCompraImporte.Text = "Importe: " + _trade.SellThenBuy.Buy.Instrument.FormatCurrency(_ownedCompraImporte);
            lblOwnedCompraComision.Text = "Comisión: " + _arbitrationVentaComision.ToCurrency();

            var comisionTotal = _ownedVentaComision + _arbitrationVentaComision + _arbitrationCompraComision + _ownedCompraComision;


            decimal profit;

            var esArbitrajeMismaMoneda = _trade.SellThenBuy.Buy.Instrument.IsPesos() == _trade.SellThenBuy.Sell.Instrument.IsPesos();
            profit = _arbitrationVentaImporte - _ownedCompraImporte - comisionTotal;

            lblComisionTotal.Text = "Total Comision: " + comisionTotal.ToCurrency();
            lblTotalProfit.Text = "Total: " + _trade.SellThenBuy.Buy.Instrument.FormatCurrency(_arbitrationVentaImporte - _ownedCompraImporte);

            lblHeader.Text = "Profit: " + profit.ToCurrency();


            if (esArbitrajeMismaMoneda)
            {
                var ratioCompra = GetRatioCompra();
                var ratioVenta = GetRatioVenta();
                lblHeader.Text += Environment.NewLine + $"Ratio Compra: {ratioCompra:P2}     {ratioVenta - ratioCompra:P}     Ratio Venta: {ratioVenta:P2}";
            }
            else
            {
                var dolarCompra = numOwnedVentaPrice.Value > 0 ? numOwnedCompraPrice.Value / numOwnedVentaPrice.Value : 0;
                var dolarVenta = numArbitrationCompraPrice.Value > 0 ? numArbitrationVentaPrice.Value / numArbitrationCompraPrice.Value : 0;
                var dolarDiff = dolarCompra > 0 ? (dolarVenta / dolarCompra) - 1 : 0;
                lblHeader.Text += Environment.NewLine + $"Dolar Compra: {dolarCompra:C2}     {dolarVenta - dolarCompra:C2} ({dolarDiff:P})     Dolar Venta: {dolarVenta:C2}";
            }
            lblProfitPesos.Text = chkComprarNominales.Checked
                ? "Profit Nominales : " + (numOwnedCompraSize.Value - numOwnedVentaSize.Value) + " Dif. " + profit.ToCurrency()
                : "Profit: " + profit.ToCurrency();

            lblHeader.ForeColor = profit < 0 ? Color.Red : Color.DarkGreen;


            CompleteOwnedCompra();
        }

        private decimal GetRatioVenta()
        {
            return numOwnedCompraPrice.Value > numArbitrationVentaPrice.Value
                ? numArbitrationVentaPrice.Value > 0 ? (numOwnedCompraPrice.Value / numArbitrationVentaPrice.Value) - 1 : 0
                : numOwnedCompraPrice.Value > 0 ? (numArbitrationVentaPrice.Value / numOwnedCompraPrice.Value) - 1 : 0;
        }

        private decimal GetRatioCompra()
        {
            return numArbitrationCompraPrice.Value > numOwnedVentaPrice.Value
                ? numOwnedVentaPrice.Value > 0 ? (numArbitrationCompraPrice.Value / numOwnedVentaPrice.Value) - 1 : 0
                : numArbitrationCompraPrice.Value > 0 ? (numOwnedVentaPrice.Value / numArbitrationCompraPrice.Value) - 1 : 0;
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

        private void numOwnedVentaSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            OwnedSizeAutoUpdate = false;
        }

        private void numOwnedVentaSize_Enter(object sender, EventArgs e)
        {
            OwnedSizeAutoUpdate = false;
        }

        private void numOwnedVentaSize_MouseClick(object sender, MouseEventArgs e)
        {
            OwnedSizeAutoUpdate = false;
        }

        private void numArbitrationCompraSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArbitrationSizeAutoUpdate = false;
        }

        private void numArbitrationCompraSize_MouseClick(object sender, MouseEventArgs e)
        {
            ArbitrationSizeAutoUpdate = false;
        }

        private void numArbitrationCompraSize_Enter(object sender, EventArgs e)
        {
            ArbitrationSizeAutoUpdate = false;
        }

        private void numOwnedVentaPrice_Enter(object sender, EventArgs e)
        {
            OwnedVentaPriceAutoUpdate = false;
        }

        private void numArbitrationCompraPrice_Enter(object sender, EventArgs e)
        {
            ArbitrationCompraPriceAutoUpdate = false;
        }

        private void chkOwnedVenta_CheckedChanged(object sender, EventArgs e)
        {
            OwnedSizeAutoUpdate = chkOwnedVenta.Checked;
        }

        private void chkArbitrationCompra_CheckedChanged(object sender, EventArgs e)
        {
            ArbitrationSizeAutoUpdate = chkArbitrationCompra.Checked;
        }
    }
}
