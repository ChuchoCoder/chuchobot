namespace Primary.WinFormsApp
{
    partial class FrmSettlementTermTrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermTrade));
            this.grpOwnedVenta = new System.Windows.Forms.GroupBox();
            this.lblSellPriceTarget = new System.Windows.Forms.Label();
            this.VentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            this.lblVentaImporte = new System.Windows.Forms.Label();
            this.lblVentaComision = new System.Windows.Forms.Label();
            this.numVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCupon = new System.Windows.Forms.NumericUpDown();
            this.lblBuyPriceTarget = new System.Windows.Forms.Label();
            this.lblCompraComision = new System.Windows.Forms.Label();
            this.CompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            this.lblCompraImporte = new System.Windows.Forms.Label();
            this.numCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.numDolar = new System.Windows.Forms.NumericUpDown();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lblDifVentaCompra = new System.Windows.Forms.Label();
            this.lblProfitPesos = new System.Windows.Forms.Label();
            this.lnkArbitration = new System.Windows.Forms.LinkLabel();
            this.lblDiasCaucion = new System.Windows.Forms.Label();
            this.lblInteresCaucion = new System.Windows.Forms.Label();
            this.lblArancelCaucion = new System.Windows.Forms.Label();
            this.lblDerMerCaucion = new System.Windows.Forms.Label();
            this.lblGtoGtiaCaucion = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblInteresNeto = new System.Windows.Forms.Label();
            this.grpCaucion = new System.Windows.Forms.GroupBox();
            this.lblMontoCaucion = new System.Windows.Forms.Label();
            this.lblGastosCaucion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNetoCaucion = new System.Windows.Forms.Label();
            this.settlementTermSettings1 = new Primary.WinFormsApp.SettlementTerms.SettlementTermSettings();
            this.grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).BeginInit();
            this.grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).BeginInit();
            this.grpCaucion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            this.grpOwnedVenta.Controls.Add(this.lblSellPriceTarget);
            this.grpOwnedVenta.Controls.Add(this.VentaBidsOffers);
            this.grpOwnedVenta.Controls.Add(this.txtOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.lblVentaImporte);
            this.grpOwnedVenta.Controls.Add(this.lblVentaComision);
            this.grpOwnedVenta.Controls.Add(this.numVentaPrice);
            this.grpOwnedVenta.Controls.Add(this.label2);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaSize);
            this.grpOwnedVenta.Controls.Add(this.label1);
            this.grpOwnedVenta.Location = new System.Drawing.Point(27, 156);
            this.grpOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOwnedVenta.Name = "grpOwnedVenta";
            this.grpOwnedVenta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOwnedVenta.Size = new System.Drawing.Size(779, 240);
            this.grpOwnedVenta.TabIndex = 4;
            this.grpOwnedVenta.TabStop = false;
            this.grpOwnedVenta.Text = "1. Venta de Bono en Cartera";
            // 
            // lblSellPriceTarget
            // 
            this.lblSellPriceTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPriceTarget.Location = new System.Drawing.Point(35, 143);
            this.lblSellPriceTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellPriceTarget.Name = "lblSellPriceTarget";
            this.lblSellPriceTarget.Size = new System.Drawing.Size(221, 23);
            this.lblSellPriceTarget.TabIndex = 30;
            this.lblSellPriceTarget.Text = "Precio Arbitrado:";
            this.lblSellPriceTarget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VentaBidsOffers
            // 
            this.VentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.VentaBidsOffers.InstrumentDetail = null;
            this.VentaBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.VentaBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VentaBidsOffers.Name = "VentaBidsOffers";
            this.VentaBidsOffers.Size = new System.Drawing.Size(501, 180);
            this.VentaBidsOffers.TabIndex = 4;
            // 
            // txtOwnedVenta
            // 
            this.txtOwnedVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnedVenta.Location = new System.Drawing.Point(8, 207);
            this.txtOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOwnedVenta.Name = "txtOwnedVenta";
            this.txtOwnedVenta.Size = new System.Drawing.Size(757, 30);
            this.txtOwnedVenta.TabIndex = 10;
            this.txtOwnedVenta.TabStop = true;
            this.txtOwnedVenta.Text = "Copiar";
            this.txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOwnedVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtOwnedVenta_LinkClicked);
            // 
            // lblVentaImporte
            // 
            this.lblVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaImporte.Location = new System.Drawing.Point(11, 98);
            this.lblVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentaImporte.Name = "lblVentaImporte";
            this.lblVentaImporte.Size = new System.Drawing.Size(245, 22);
            this.lblVentaImporte.TabIndex = 6;
            this.lblVentaImporte.Text = "Importe";
            this.lblVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVentaComision
            // 
            this.lblVentaComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaComision.Location = new System.Drawing.Point(11, 121);
            this.lblVentaComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentaComision.Name = "lblVentaComision";
            this.lblVentaComision.Size = new System.Drawing.Size(245, 22);
            this.lblVentaComision.TabIndex = 5;
            this.lblVentaComision.Text = "Der.Mer./Comisión";
            this.lblVentaComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numVentaPrice
            // 
            this.numVentaPrice.DecimalPlaces = 2;
            this.numVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numVentaPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVentaPrice.Location = new System.Drawing.Point(116, 55);
            this.numVentaPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numVentaPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numVentaPrice.Name = "numVentaPrice";
            this.numVentaPrice.Size = new System.Drawing.Size(140, 22);
            this.numVentaPrice.TabIndex = 3;
            this.numVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVentaPrice.ValueChanged += new System.EventHandler(this.numOwnedVentaPrice_ValueChanged);
            this.numVentaPrice.Enter += new System.EventHandler(this.numVentaPrice_Enter);
            this.numVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaPrice_KeyPress);
            this.numVentaPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numVentaPrice_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // numOwnedVentaSize
            // 
            this.numOwnedVentaSize.Location = new System.Drawing.Point(116, 23);
            this.numOwnedVentaSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numOwnedVentaSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numOwnedVentaSize.Name = "numOwnedVentaSize";
            this.numOwnedVentaSize.Size = new System.Drawing.Size(140, 22);
            this.numOwnedVentaSize.TabIndex = 1;
            this.numOwnedVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedVentaSize.ValueChanged += new System.EventHandler(this.numOwnedVentaSize_ValueChanged);
            this.numOwnedVentaSize.Enter += new System.EventHandler(this.numOwnedVentaSize_Enter);
            this.numOwnedVentaSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaSize_KeyPress);
            this.numOwnedVentaSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numOwnedVentaSize_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cant. Nom.:";
            // 
            // grpArbitrationCompra
            // 
            this.grpArbitrationCompra.Controls.Add(this.label3);
            this.grpArbitrationCompra.Controls.Add(this.numCupon);
            this.grpArbitrationCompra.Controls.Add(this.lblBuyPriceTarget);
            this.grpArbitrationCompra.Controls.Add(this.lblCompraComision);
            this.grpArbitrationCompra.Controls.Add(this.CompraBidsOffers);
            this.grpArbitrationCompra.Controls.Add(this.txtArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblCompraImporte);
            this.grpArbitrationCompra.Controls.Add(this.numCompraPrice);
            this.grpArbitrationCompra.Controls.Add(this.label6);
            this.grpArbitrationCompra.Controls.Add(this.numCompraSize);
            this.grpArbitrationCompra.Controls.Add(this.label7);
            this.grpArbitrationCompra.Location = new System.Drawing.Point(813, 156);
            this.grpArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpArbitrationCompra.Name = "grpArbitrationCompra";
            this.grpArbitrationCompra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpArbitrationCompra.Size = new System.Drawing.Size(764, 240);
            this.grpArbitrationCompra.TabIndex = 5;
            this.grpArbitrationCompra.TabStop = false;
            this.grpArbitrationCompra.Text = "2. Compra de Bono a Arbitrar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cupón:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCupon
            // 
            this.numCupon.Location = new System.Drawing.Point(149, 170);
            this.numCupon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCupon.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCupon.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numCupon.Name = "numCupon";
            this.numCupon.Size = new System.Drawing.Size(107, 22);
            this.numCupon.TabIndex = 12;
            // 
            // lblBuyPriceTarget
            // 
            this.lblBuyPriceTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPriceTarget.Location = new System.Drawing.Point(35, 143);
            this.lblBuyPriceTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyPriceTarget.Name = "lblBuyPriceTarget";
            this.lblBuyPriceTarget.Size = new System.Drawing.Size(221, 23);
            this.lblBuyPriceTarget.TabIndex = 31;
            this.lblBuyPriceTarget.Text = "Precio Arbitrado:";
            this.lblBuyPriceTarget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompraComision
            // 
            this.lblCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraComision.Location = new System.Drawing.Point(11, 121);
            this.lblCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraComision.Name = "lblCompraComision";
            this.lblCompraComision.Size = new System.Drawing.Size(245, 22);
            this.lblCompraComision.TabIndex = 14;
            this.lblCompraComision.Text = "Der.Mer./Comisión";
            this.lblCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CompraBidsOffers
            // 
            this.CompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.CompraBidsOffers.InstrumentDetail = null;
            this.CompraBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.CompraBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompraBidsOffers.Name = "CompraBidsOffers";
            this.CompraBidsOffers.Size = new System.Drawing.Size(496, 180);
            this.CompraBidsOffers.TabIndex = 4;
            // 
            // txtArbitrationCompra
            // 
            this.txtArbitrationCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbitrationCompra.Location = new System.Drawing.Point(8, 207);
            this.txtArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtArbitrationCompra.Name = "txtArbitrationCompra";
            this.txtArbitrationCompra.Size = new System.Drawing.Size(749, 30);
            this.txtArbitrationCompra.TabIndex = 12;
            this.txtArbitrationCompra.TabStop = true;
            this.txtArbitrationCompra.Text = "Copiar";
            this.txtArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArbitrationCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArbitrationCompra_LinkClicked);
            // 
            // lblCompraImporte
            // 
            this.lblCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraImporte.Location = new System.Drawing.Point(19, 98);
            this.lblCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraImporte.Name = "lblCompraImporte";
            this.lblCompraImporte.Size = new System.Drawing.Size(237, 22);
            this.lblCompraImporte.TabIndex = 6;
            this.lblCompraImporte.Text = "Importe";
            this.lblCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCompraPrice
            // 
            this.numCompraPrice.DecimalPlaces = 2;
            this.numCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numCompraPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCompraPrice.Location = new System.Drawing.Point(112, 55);
            this.numCompraPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCompraPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCompraPrice.Name = "numCompraPrice";
            this.numCompraPrice.Size = new System.Drawing.Size(144, 22);
            this.numCompraPrice.TabIndex = 3;
            this.numCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCompraPrice.ValueChanged += new System.EventHandler(this.numCompraPrice_ValueChanged);
            this.numCompraPrice.Enter += new System.EventHandler(this.numCompraPrice_Enter);
            this.numCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationCompraPrice_KeyPress);
            this.numCompraPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numCompraPrice_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio:";
            // 
            // numCompraSize
            // 
            this.numCompraSize.Location = new System.Drawing.Point(112, 23);
            this.numCompraSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCompraSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCompraSize.Name = "numCompraSize";
            this.numCompraSize.Size = new System.Drawing.Size(144, 22);
            this.numCompraSize.TabIndex = 1;
            this.numCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCompraSize.ValueChanged += new System.EventHandler(this.numCompraSize_ValueChanged);
            this.numCompraSize.Enter += new System.EventHandler(this.numCompraSize_Enter);
            this.numCompraSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCompraSize_KeyPress);
            this.numCompraSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numCompraSize_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cant. Nom.:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1588, 53);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Profit: $ / %";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar
            // 
            this.lblDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolar.Location = new System.Drawing.Point(519, 74);
            this.lblDolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(79, 22);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar $:";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            this.numDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numDolar.DecimalPlaces = 2;
            this.numDolar.Location = new System.Drawing.Point(605, 74);
            this.numDolar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDolar.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDolar.Name = "numDolar";
            this.numDolar.Size = new System.Drawing.Size(107, 22);
            this.numDolar.TabIndex = 2;
            this.numDolar.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.numDolar.ValueChanged += new System.EventHandler(this.numDolar_ValueChanged);
            // 
            // lblComisionTotal
            // 
            this.lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionTotal.Location = new System.Drawing.Point(11, 27);
            this.lblComisionTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(525, 22);
            this.lblComisionTotal.TabIndex = 12;
            this.lblComisionTotal.Text = "Total Comisión:";
            // 
            // lblDifVentaCompra
            // 
            this.lblDifVentaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifVentaCompra.Location = new System.Drawing.Point(12, 96);
            this.lblDifVentaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifVentaCompra.Name = "lblDifVentaCompra";
            this.lblDifVentaCompra.Size = new System.Drawing.Size(513, 22);
            this.lblDifVentaCompra.TabIndex = 21;
            this.lblDifVentaCompra.Text = "Dif. Venta/Compra:";
            // 
            // lblProfitPesos
            // 
            this.lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPesos.Location = new System.Drawing.Point(12, 127);
            this.lblProfitPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfitPesos.Name = "lblProfitPesos";
            this.lblProfitPesos.Size = new System.Drawing.Size(513, 22);
            this.lblProfitPesos.TabIndex = 22;
            this.lblProfitPesos.Text = "Profit:";
            // 
            // lnkArbitration
            // 
            this.lnkArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkArbitration.Location = new System.Drawing.Point(24, 73);
            this.lnkArbitration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkArbitration.Name = "lnkArbitration";
            this.lnkArbitration.Size = new System.Drawing.Size(487, 23);
            this.lnkArbitration.TabIndex = 0;
            this.lnkArbitration.TabStop = true;
            this.lnkArbitration.Text = "Copiar";
            this.lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArbitration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArbitration_LinkClicked);
            // 
            // lblDiasCaucion
            // 
            this.lblDiasCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasCaucion.Location = new System.Drawing.Point(16, 27);
            this.lblDiasCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasCaucion.Name = "lblDiasCaucion";
            this.lblDiasCaucion.Size = new System.Drawing.Size(340, 22);
            this.lblDiasCaucion.TabIndex = 23;
            this.lblDiasCaucion.Text = "Dias Caucion:";
            // 
            // lblInteresCaucion
            // 
            this.lblInteresCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresCaucion.Location = new System.Drawing.Point(16, 96);
            this.lblInteresCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteresCaucion.Name = "lblInteresCaucion";
            this.lblInteresCaucion.Size = new System.Drawing.Size(340, 22);
            this.lblInteresCaucion.TabIndex = 24;
            this.lblInteresCaucion.Text = "Interes Caucion:";
            // 
            // lblArancelCaucion
            // 
            this.lblArancelCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArancelCaucion.Location = new System.Drawing.Point(385, 27);
            this.lblArancelCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArancelCaucion.Name = "lblArancelCaucion";
            this.lblArancelCaucion.Size = new System.Drawing.Size(375, 22);
            this.lblArancelCaucion.TabIndex = 25;
            this.lblArancelCaucion.Text = "Arancel";
            // 
            // lblDerMerCaucion
            // 
            this.lblDerMerCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerMerCaucion.Location = new System.Drawing.Point(385, 62);
            this.lblDerMerCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDerMerCaucion.Name = "lblDerMerCaucion";
            this.lblDerMerCaucion.Size = new System.Drawing.Size(375, 22);
            this.lblDerMerCaucion.TabIndex = 26;
            this.lblDerMerCaucion.Text = "Der Mer";
            // 
            // lblGtoGtiaCaucion
            // 
            this.lblGtoGtiaCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGtoGtiaCaucion.Location = new System.Drawing.Point(385, 96);
            this.lblGtoGtiaCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGtoGtiaCaucion.Name = "lblGtoGtiaCaucion";
            this.lblGtoGtiaCaucion.Size = new System.Drawing.Size(375, 22);
            this.lblGtoGtiaCaucion.TabIndex = 27;
            this.lblGtoGtiaCaucion.Text = "Gto Gtia";
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(385, 127);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(375, 22);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "Iva";
            // 
            // lblInteresNeto
            // 
            this.lblInteresNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresNeto.Location = new System.Drawing.Point(16, 127);
            this.lblInteresNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteresNeto.Name = "lblInteresNeto";
            this.lblInteresNeto.Size = new System.Drawing.Size(340, 22);
            this.lblInteresNeto.TabIndex = 29;
            this.lblInteresNeto.Text = "Interes Neto";
            // 
            // grpCaucion
            // 
            this.grpCaucion.Controls.Add(this.lblMontoCaucion);
            this.grpCaucion.Controls.Add(this.lblGastosCaucion);
            this.grpCaucion.Controls.Add(this.lblDiasCaucion);
            this.grpCaucion.Controls.Add(this.lblIva);
            this.grpCaucion.Controls.Add(this.lblInteresNeto);
            this.grpCaucion.Controls.Add(this.lblGtoGtiaCaucion);
            this.grpCaucion.Controls.Add(this.lblInteresCaucion);
            this.grpCaucion.Controls.Add(this.lblDerMerCaucion);
            this.grpCaucion.Controls.Add(this.lblArancelCaucion);
            this.grpCaucion.Location = new System.Drawing.Point(28, 402);
            this.grpCaucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCaucion.Name = "grpCaucion";
            this.grpCaucion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCaucion.Size = new System.Drawing.Size(773, 203);
            this.grpCaucion.TabIndex = 6;
            this.grpCaucion.TabStop = false;
            this.grpCaucion.Text = "Caucion";
            // 
            // lblMontoCaucion
            // 
            this.lblMontoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCaucion.Location = new System.Drawing.Point(16, 62);
            this.lblMontoCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCaucion.Name = "lblMontoCaucion";
            this.lblMontoCaucion.Size = new System.Drawing.Size(340, 22);
            this.lblMontoCaucion.TabIndex = 31;
            this.lblMontoCaucion.Text = "Importe a Caucionar:";
            // 
            // lblGastosCaucion
            // 
            this.lblGastosCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosCaucion.Location = new System.Drawing.Point(385, 158);
            this.lblGastosCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosCaucion.Name = "lblGastosCaucion";
            this.lblGastosCaucion.Size = new System.Drawing.Size(371, 22);
            this.lblGastosCaucion.TabIndex = 30;
            this.lblGastosCaucion.Text = "Total Gastos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNetoCaucion);
            this.groupBox2.Controls.Add(this.lblComisionTotal);
            this.groupBox2.Controls.Add(this.lblDifVentaCompra);
            this.groupBox2.Controls.Add(this.lblProfitPesos);
            this.groupBox2.Location = new System.Drawing.Point(813, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(764, 203);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profit / Loss";
            // 
            // lblNetoCaucion
            // 
            this.lblNetoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoCaucion.Location = new System.Drawing.Point(12, 62);
            this.lblNetoCaucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetoCaucion.Name = "lblNetoCaucion";
            this.lblNetoCaucion.Size = new System.Drawing.Size(513, 22);
            this.lblNetoCaucion.TabIndex = 23;
            this.lblNetoCaucion.Text = "Caución:";
            // 
            // settlementTermSettings1
            // 
            this.settlementTermSettings1.Location = new System.Drawing.Point(720, 74);
            this.settlementTermSettings1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.settlementTermSettings1.Name = "settlementTermSettings1";
            this.settlementTermSettings1.Size = new System.Drawing.Size(857, 59);
            this.settlementTermSettings1.TabIndex = 3;
            // 
            // FrmSettlementTermTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 619);
            this.Controls.Add(this.settlementTermSettings1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCaucion);
            this.Controls.Add(this.lnkArbitration);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.numDolar);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpArbitrationCompra);
            this.Controls.Add(this.grpOwnedVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSettlementTermTrade";
            this.Text = "Operación de Arbitraje";
            this.Load += new System.EventHandler(this.FrmArbitrationTrade_Load);
            this.grpOwnedVenta.ResumeLayout(false);
            this.grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).EndInit();
            this.grpArbitrationCompra.ResumeLayout(false);
            this.grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).EndInit();
            this.grpCaucion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblVentaImporte;
        private System.Windows.Forms.Label lblVentaComision;
        private System.Windows.Forms.NumericUpDown numVentaPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblCompraImporte;
        private System.Windows.Forms.NumericUpDown numCompraPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.NumericUpDown numDolar;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Label lblDifVentaCompra;
        private System.Windows.Forms.Label lblProfitPesos;
        private System.Windows.Forms.LinkLabel txtOwnedVenta;
        private System.Windows.Forms.LinkLabel txtArbitrationCompra;
        private BidsOffersControl VentaBidsOffers;
        private BidsOffersControl CompraBidsOffers;
        private System.Windows.Forms.LinkLabel lnkArbitration;
        private System.Windows.Forms.Label lblCompraComision;
        private System.Windows.Forms.Label lblDiasCaucion;
        private System.Windows.Forms.Label lblInteresCaucion;
        private System.Windows.Forms.Label lblArancelCaucion;
        private System.Windows.Forms.Label lblDerMerCaucion;
        private System.Windows.Forms.Label lblGtoGtiaCaucion;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblInteresNeto;
        private System.Windows.Forms.GroupBox grpCaucion;
        private System.Windows.Forms.Label lblGastosCaucion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMontoCaucion;
        private System.Windows.Forms.Label lblNetoCaucion;
        private System.Windows.Forms.Label lblSellPriceTarget;
        private System.Windows.Forms.Label lblBuyPriceTarget;
        private SettlementTerms.SettlementTermSettings settlementTermSettings1;
        private System.Windows.Forms.NumericUpDown numCupon;
        private System.Windows.Forms.Label label3;
    }
}