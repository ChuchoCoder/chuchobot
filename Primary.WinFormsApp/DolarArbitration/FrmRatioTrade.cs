using ChuchoBot.WinFormsApp.Components;
using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.Shared;
using Newtonsoft.Json.Linq;
using Primary.Data;
using Primary.Data.Orders;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChuchoBot.WinFormsApp;

public partial class FrmRatioTrade : Form
{
    private static readonly Color AutoColor = Color.Blue;
    private RatioTrade _trade;
    private RatioTradeOperation _tradeOperation;

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

        ArbitrationCompraBidsOffers.LoadData(_trade.BuyThenSell.Buy.Data);
        ArbitrationVentaBidsOffers.LoadData(_trade.BuyThenSell.Sell.Data);

        if (OwnedVentaPriceAutoUpdate)
        {
            OwnedVentaPrice = _trade.SellThenBuy.Sell.Data.GetTopBidPrice();
        }

        if (ArbitrationCompraPriceAutoUpdate)
        {
            ArbitrationCompraPrice = _trade.BuyThenSell.Buy.Data.GetTopOfferPrice();
        }

        if (ArbitrationVentaPriceAutoUpdate)
        {
            ArbitrationVentaPrice = _trade.BuyThenSell.Sell.Data.GetTopBidPrice();
        }

        if (OwnedCompraPriceAutoUpdate)
        {
            OwnedCompraPrice = _trade.SellThenBuy.Buy.Data.GetTopOfferPrice();
        }

        CalculateOwnedAutoSize();

        if (_tradeOperation.ProfitTotalInPesos < 0)
        {
            Alerts.NotifyRatioTradeLoss(_trade, _tradeOperation.ProfitTotalInPesos, Handle);
        }
    }

    public decimal OwnedCompraPrice
    {
        get => numOwnedCompraPrice.Value;
        set
        {
            if (!numOwnedCompraPrice.Focused)
            {
                _tradeOperation.OwnedBuy.Price = value;
                numOwnedCompraPrice.Value = value;
            }
        }
    }

    public decimal OwnedCompraSize
    {
        get => numOwnedCompraSize.Value;
        set
        {
            if (!numOwnedCompraSize.Focused)
            {
                _tradeOperation.OwnedBuy.Size = value;
                numOwnedCompraSize.Value = value;
            }
        }
    }

    public decimal OwnedVentaSize
    {
        get => numOwnedVentaSize.Value;
        set
        {
            if (!numOwnedVentaSize.Focused)
            {
                _tradeOperation.OwnedSell.Size = value;
                _tradeOperation.OwnedBuy.Size = value;
                numOwnedVentaSize.Value = value;
                numOwnedCompraSize.Value = value;
            }
        }
    }

    public decimal OwnedVentaPrice
    {
        get => numOwnedVentaPrice.Value;
        set
        {
            if (!numOwnedVentaPrice.Focused)
            {
                _tradeOperation.OwnedSell.Price = value;
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
                _tradeOperation.ArbitrationBuy.Price = value;
                numArbitrationCompraPrice.Value = value;
            }
        }
    }

    public decimal ArbitrationCompraSize
    {
        get => numArbitrationCompraSize.Value;
        set
        {
            if (!numArbitrationCompraSize.Focused)
            {
                _tradeOperation.ArbitrationBuy.Size = value;
                _tradeOperation.ArbitrationSell.Size = value;
                numArbitrationCompraSize.Value = value;
                numArbitrationVentaSize.Value = value;
            }
        }
    }

    public decimal ArbitrationVentaPrice
    {
        get => numArbitrationVentaPrice.Value;
        set
        {
            if (!numArbitrationVentaPrice.Focused)
            {
                _tradeOperation.ArbitrationSell.Price = value;
                numArbitrationVentaPrice.Value = value;
            }
        }
    }

    public decimal ArbitrationVentaSize
    {
        get => numArbitrationVentaSize.Value;
        set
        {
            if (!numArbitrationVentaSize.Focused)
            {
                _tradeOperation.ArbitrationSell.Size = value;
                numArbitrationVentaSize.Value = value;
            }
        }
    }

    internal void Init(RatioTrade trade)
    {
        _trade = trade;
        _tradeOperation = trade.CalculateTrade();

        OwnedVentaBidsOffers.InstrumentDetail = trade.SellThenBuy.Sell.Instrument;
        OwnedCompraBidsOffers.InstrumentDetail = trade.SellThenBuy.Buy.Instrument;
        ArbitrationVentaBidsOffers.InstrumentDetail = trade.BuyThenSell.Sell.Instrument;
        ArbitrationCompraBidsOffers.InstrumentDetail = trade.BuyThenSell.Buy.Instrument;

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
        grpArbitrationCompra.Text += " - " + _trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
        grpArbitrationVenta.Text += " - " + _trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix() + arbitrationSuffix;
        grpOwnedCompra.Text += " - " + _trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix() + ownedSuffix;

        numOwnedVentaSize.Value = _tradeOperation.OwnedSell.Size;
        CalculateOwnedAutoSize();

        if (_trade.SellThenBuy.Sell.Data?.Last != null)
        {
            OwnedVentaPrice = _trade.SellThenBuy.Sell.Data.Last.Price.Value;
        }

        if (_trade.BuyThenSell.Sell.Data?.Last != null)
        {
            ArbitrationCompraPrice = _trade.BuyThenSell.Buy.Data.Last.Price.Value;
        }

        if (_trade.BuyThenSell.Buy.Data?.Last != null)
        {
            ArbitrationVentaPrice = _trade.BuyThenSell.Sell.Data.Last.Price.Value;
        }

        if (_trade.SellThenBuy.Buy.Data?.Last != null)
        {
            OwnedCompraPrice = _trade.SellThenBuy.Buy.Data.Last.Price.Value;
        }

        Text = $"Venta {_trade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Venta {_trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} -> Compra {_trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()}";
        lnkArbitration.Text = Text;

        numOwnedVentaPrice.Increment = _trade.SellThenBuy.Sell.Instrument.GetIncrement();
        numOwnedCompraPrice.Increment = _trade.SellThenBuy.Buy.Instrument.GetIncrement();
        numArbitrationVentaPrice.Increment = _trade.BuyThenSell.Sell.Instrument.GetIncrement();
        numArbitrationCompraPrice.Increment = _trade.BuyThenSell.Buy.Instrument.GetIncrement();

        numOwnedVentaPrice.DecimalPlaces = _trade.SellThenBuy.Sell.Instrument.InstrumentPricePrecision;
        numOwnedCompraPrice.DecimalPlaces = _trade.SellThenBuy.Buy.Instrument.InstrumentPricePrecision;
        numArbitrationVentaPrice.DecimalPlaces = _trade.BuyThenSell.Sell.Instrument.InstrumentPricePrecision;
        numArbitrationCompraPrice.DecimalPlaces = _trade.BuyThenSell.Buy.Instrument.InstrumentPricePrecision;

        lblRatioSell.Text = $"{_trade.SellThenBuy.Sell.Instrument.InstrumentId.Ticker()}";
        lblDolarBuy.Text = $"{_trade.BuyThenSell.Sell.Instrument.InstrumentId.Ticker()}";

        lblOwnedVentaCurrency.Text = _trade.SellThenBuy.Sell.Instrument.IsPesos() ? "a $:" : "a USD:";
        lblOwnedCompraCurrency.Text = _trade.SellThenBuy.Buy.Instrument.IsPesos() ? "a $:" : "a USD:";
        lblArbitrationVentaCurrency.Text = _trade.BuyThenSell.Sell.Instrument.IsPesos() ? "a $:" : "a USD:";
        lblArbitrationCompraCurrency.Text = _trade.BuyThenSell.Buy.Instrument.IsPesos() ? "a $:" : "a USD:";

        if (lblArbitrationCompraCurrency.Text == lblArbitrationVentaCurrency.Text)
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
                var size = _trade.SellThenBuy.Sell.CalculateOfferSize(_tradeOperation.ArbitrationBuy.NetTotal);
                OwnedVentaSize = size;
            }
            else
            {
                //var sellTotal = 1m;
                //var sellBidPrice = 1m;
                //if (_trade.SellThenBuy.Sell.HasBids())
                //{
                //    var sellBidSize = _trade.SellThenBuy.Sell.Data.GetTopBidSize();
                //    sellBidPrice = _trade.SellThenBuy.Sell.Data.GetTopBidPrice() * _trade.SellThenBuy.Sell.Instrument.PriceConvertionFactor;
                //    sellTotal = sellBidSize * sellBidPrice;
                //}

                //var buyTotal = 1m;
                //if (_trade.BuyThenSell.Sell.HasOffers())
                //{
                //    var buyOfferSize = _trade.BuyThenSell.Sell.Data.GetTopOfferSize();
                //    var buyOfferPrice = _trade.BuyThenSell.Sell.Data.GetTopOfferPrice() * _trade.BuyThenSell.Sell.Instrument.PriceConvertionFactor;
                //    buyTotal = buyOfferSize * buyOfferPrice;
                //}
                //OwnedVentaSize = Math.Min(sellTotal, buyTotal) / sellBidPrice;
                var size = _trade.SellThenBuy.GetMinSellBidOrBuyOfferSize();
                OwnedVentaSize = size;
            }
        }
        else if (ArbitrationSizeAutoUpdate)
        {
            // var size = _trade.BuyThenSell.GetMinBuyOfferOrSellBidSize();
            // ArbitrationCompraSize = size;
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
        // ArbitrationSizeAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
        ArbitrationSizeAutoUpdate = false;
        ArbitrationCompraSize = e.Value;
        UpdateOwnedVentaSize();
    }

    private void ArbitrationCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
    {
        ArbitrationCompraPrice = e.Value;
        ArbitrationCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
    }

    private void ArbitrationVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
    {
        ArbitrationCompraSize = e.Value;
        UpdateOwnedVentaSize();
    }

    private void ArbitrationVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
    {
        ArbitrationVentaPrice = e.Value;
        ArbitrationVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
    }

    private void OwnedVentaBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
    {
        OwnedSizeAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;

        OwnedVentaSize = e.Value;
    }

    private void OwnedVentaBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
    {
        OwnedVentaPrice = e.Value;
        OwnedVentaPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopBid;
    }

    private void OwnedCompraBidsOffers_ClickSize(object sender, BidOffersEventArgs e)
    {
        // Ajusto el SellThenBuy Venta Size y dejo que el SellThenBuy Compra se calcule solo
        OwnedVentaSize = e.Value;
    }

    private void OwnedCompraBidsOffers_ClickPrice(object sender, BidOffersEventArgs e)
    {
        OwnedCompraPrice = e.Value;
        OwnedCompraPriceAutoUpdate = e.ClickType == BidsOffersClickType.TopOffer;
    }

    public void UpdateOwnedVentaSize()
    {
        if (OwnedSizeAutoUpdate)
        {
            // Calcular el size en base al BuyThenSell Compra Size
            var size = _tradeOperation.OwnedSell.UpdateSize(_tradeOperation.ArbitrationBuy.NetTotal);
            OwnedVentaSize = size;
        }
    }

    public void CompleteOwnedVenta()
    {
        txtOwnedVenta.Text = $"VENDER {OwnedVentaSize:#,##0} nominales de {_trade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.SellThenBuy.Sell.Instrument.FormatPrice(OwnedVentaPrice)}";
    }

    public void CompleteOwnedCompra()
    {
        txtOwnedCompra.Text = $"COMPRAR {OwnedCompraSize:#,##0} nominales de {_trade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.SellThenBuy.Buy.Instrument.FormatPrice(OwnedCompraPrice)}";
    }

    public void CompleteArbitrationVenta()
    {
        txtArbitrationVenta.Text = $"VENDER {ArbitrationVentaSize:#,##0} nominales de {_trade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.BuyThenSell.Buy.Instrument.FormatPrice(ArbitrationVentaPrice)}";
    }

    public void CompleteArbitrationCompra()
    {
        txtArbitrationCompra.Text = $"COMPRAR {ArbitrationCompraSize:#,##0} nominales de {_trade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix()} a {_trade.BuyThenSell.Sell.Instrument.FormatPrice(ArbitrationCompraPrice)}";
    }

    public void CalculateOwnedVenta()
    {
        CompleteOwnedVenta();
        if (_tradeOperation.OwnedSell.Size > 0)
        {
            lblOwnedVentaImporte.Text = "Importe: " + _tradeOperation.OwnedSell.InstrumentDetail.FormatCurrency(_tradeOperation.OwnedSell.Total);
            lblOwnedComision.Text = "Comisión: " + _tradeOperation.OwnedSell.InstrumentDetail.FormatCurrency(_tradeOperation.OwnedSell.Comision);

            CalculateArbitrationCompraSize();
        }
    }

    public void CalculateOwnedCompraSize()
    {
        if (!chkComprarNominales.Checked)
        {
            OwnedCompraSize = OwnedVentaSize;
        }
        else
        {
            if (OwnedCompraPrice > 0)
            {
                OwnedCompraSize = _tradeOperation.OwnedBuy.UpdateSize(_tradeOperation.ArbitrationSell.NetTotal);
            }
        }

        CalculateOwnedCompraTotalAndProfit();
    }

    public void CalculateArbitrationCompraSize()
    {
        if (ArbitrationCompraPrice > 0 && ArbitrationSizeAutoUpdate)
        {
            var size = _tradeOperation.ArbitrationBuy.UpdateSize(_tradeOperation.OwnedSell.NetTotal);
            ArbitrationCompraSize = size;
        }
        CalculateArbitrationCompraTotal();
        CalculateArbitrationVentaSize();
        CompleteArbitrationCompra();
    }

    public void CalculateArbitrationCompraTotal()
    {
        lblArbirtationCompraComision.Text = "Comisión: " + _trade.BuyThenSell.Buy.Instrument.FormatCurrency(_tradeOperation.ArbitrationBuy.Comision);
        lblArbitrationCompraImporte.Text = "Importe: " + _trade.BuyThenSell.Buy.Instrument.FormatCurrency(_tradeOperation.ArbitrationBuy.Total);
    }

    public void CalculateArbitrationVentaSize()
    {
        ArbitrationVentaSize = ArbitrationCompraSize;

        CalculateArbitrationVentaTotal();
    }

    public void CalculateArbitrationVentaTotal()
    {
        lblArbitrationComision.Text = "Comisión: " + _trade.BuyThenSell.Sell.Instrument.FormatCurrency(_tradeOperation.ArbitrationSell.Comision);
        lblArbitrationVentaImporte.Text = "Importe: " + _trade.BuyThenSell.Sell.Instrument.FormatCurrency(_tradeOperation.ArbitrationSell.Total);

        CompleteArbitrationVenta();
        CalculateOwnedCompraSize();
    }

    public void CalculateOwnedCompraTotalAndProfit()
    {
        lblOwnedCompraImporte.Text = "Importe: " + _trade.SellThenBuy.Buy.Instrument.FormatCurrency(_tradeOperation.OwnedBuy.Total);
        lblOwnedCompraComision.Text = "Comisión: " + _trade.SellThenBuy.Buy.Instrument.FormatCurrency(_tradeOperation.OwnedBuy.Comision);

        lblComisionTotal.Text = "Total Comision: " + _tradeOperation.ComisionTotalInPesos.ToCurrency();
        lblTotalProfit.Text = "Total: " + _tradeOperation.ProfitTotalInPesos.ToCurrency();

        lblHeader.Text = "Profit: " + _tradeOperation.ProfitTotalInPesos.ToCurrency();


        if (_trade.SellThenBuy.IsSameCurrency())
        {
            var ratioCompra = GetRatioCompra();
            var ratioVenta = GetRatioVenta();
            lblHeader.Text += Environment.NewLine + $"Ratio Compra: {ratioCompra:P2}     {ratioVenta - ratioCompra:P}     Ratio Venta: {ratioVenta:P2}";
        }
        else
        {
            var dolarCompra = OwnedVentaPrice > 0 ? OwnedCompraPrice / OwnedVentaPrice : 0;
            var dolarVenta = ArbitrationCompraPrice > 0 ? ArbitrationVentaPrice / ArbitrationCompraPrice : 0;
            var dolarDiff = dolarCompra > 0 ? (dolarVenta / dolarCompra) - 1 : 0;
            lblHeader.Text += Environment.NewLine + $"Dolar Compra: {dolarCompra:C2}     {dolarVenta - dolarCompra:C2} ({dolarDiff:P})     Dolar Venta: {dolarVenta:C2}";
        }
        lblProfitPesos.Text = chkComprarNominales.Checked
            ? "Profit Nominales : " + (OwnedCompraSize - OwnedVentaSize) + " Dif. " + _tradeOperation.ProfitTotalInPesos.ToCurrency()
            : "Profit: " + _tradeOperation.ProfitTotalInPesos.ToCurrency();

        lblHeader.ForeColor = _tradeOperation.ProfitTotalInPesos < 0 ? Color.Red : Color.DarkGreen;

        CompleteOwnedCompra();
    }

    private decimal GetRatioVenta()
    {
        return OwnedCompraPrice > ArbitrationVentaPrice
            ? ArbitrationVentaPrice > 0 ? (OwnedCompraPrice / ArbitrationVentaPrice) - 1 : 0
            : OwnedCompraPrice > 0 ? (ArbitrationVentaPrice / OwnedCompraPrice) - 1 : 0;
    }

    private decimal GetRatioCompra()
    {
        return ArbitrationCompraPrice > OwnedVentaPrice
            ? OwnedVentaPrice > 0 ? (ArbitrationCompraPrice / OwnedVentaPrice) - 1 : 0
            : ArbitrationCompraPrice > 0 ? (OwnedVentaPrice / ArbitrationCompraPrice) - 1 : 0;
    }

    private void numOwnedVentaSize_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.OwnedSell.Size = OwnedVentaSize;
        CalculateOwnedVenta();
    }

    private void numOwnedVentaPrice_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.OwnedSell.Price = OwnedVentaPrice;
        CalculateOwnedVenta();

    }

    private void numArbitrationCompraPrice_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.ArbitrationBuy.Price = ArbitrationCompraPrice;
        CalculateArbitrationCompraSize();
    }

    private void numArbitrationVentaPrice_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.ArbitrationSell.Price = ArbitrationVentaPrice;
        CalculateArbitrationVentaSize();
    }

    private void numOwnedCompraPrice_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.OwnedBuy.Price = OwnedCompraPrice;
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

    private void numArbitrationCompraSize_ValueChanged(object sender, EventArgs e)
    {
        _tradeOperation.ArbitrationBuy.Size = ArbitrationCompraSize;
        if (ArbitrationSizeAutoUpdate == false)
        {
            UpdateOwnedVentaSize();
        }
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

    private void chkAutoTrade_CheckedChanged(object sender, EventArgs e)
    {
        timerAutoTrade.Enabled = chkAutoTrade.Checked;
    }

    private RatioTradeOperation _autoTradeOperation;

    private async void timerAutoTrade_Tick(object sender, EventArgs e)
    {
        if (_autoTradeOperation == null)
        {
            _trade.RefreshData();
            var autoTrade = _trade.CalculateTrade();

            if (autoTrade == null || autoTrade.ProfitPercentage <= numAutoTradePercentage.Value / 100m)
            {
                return;
            }

            txtAutoTrade.Text += $"Profit: {autoTrade.ProfitTotalInPesos:c} ({autoTrade.ProfitPercentage:P}) ";
            _autoTradeOperation = autoTrade;
            // Trade con profit, empezamos a auto operar
            chkAutoTrade.Enabled = false;
            timerAutoTrade.Enabled = false;
            await _autoTradeOperation.Operate();
            timerAutoTradeOperation.Enabled = true;
            txtAutoTrade.Text += _autoTradeOperation.OperationLog;
        }

    }

    private async void timerAutoTradeOperation_Tick(object sender, EventArgs e)
    {
        _autoTradeOperation.Operate();
    }

}
