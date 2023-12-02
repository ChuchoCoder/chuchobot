namespace Primary.WinFormsApp
{
    partial class FrmRatioTrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatioTrade));
            this.grpOwnedVenta = new System.Windows.Forms.GroupBox();
            this.chkOwnedVenta = new System.Windows.Forms.CheckBox();
            this.OwnedVentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            this.lblOwnedVentaImporte = new System.Windows.Forms.Label();
            this.lblOwnedComision = new System.Windows.Forms.Label();
            this.numOwnedVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.lblVentaACurrency = new System.Windows.Forms.Label();
            this.numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            this.chkArbitrationCompra = new System.Windows.Forms.CheckBox();
            this.lblArbirtationCompraComision = new System.Windows.Forms.Label();
            this.ArbitrationCompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            this.lblArbitrationCompraImporte = new System.Windows.Forms.Label();
            this.numArbitrationCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCompraBCurrency = new System.Windows.Forms.Label();
            this.numArbitrationCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpArbitrationVenta = new System.Windows.Forms.GroupBox();
            this.ArbitrationVentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtArbitrationVenta = new System.Windows.Forms.LinkLabel();
            this.lblArbitrationVentaImporte = new System.Windows.Forms.Label();
            this.lblArbitrationComision = new System.Windows.Forms.Label();
            this.numArbitrationVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.lblVentaBCurrency = new System.Windows.Forms.Label();
            this.numArbitrationVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grpOwnedCompra = new System.Windows.Forms.GroupBox();
            this.lblOwnedCompraComision = new System.Windows.Forms.Label();
            this.OwnedCompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtOwnedCompra = new System.Windows.Forms.LinkLabel();
            this.lblOwnedCompraImporte = new System.Windows.Forms.Label();
            this.numOwnedCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCompraACurrency = new System.Windows.Forms.Label();
            this.numOwnedCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.lblOwnedLast = new System.Windows.Forms.Label();
            this.lblArbitrationLast = new System.Windows.Forms.Label();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblArbitrationDiff = new System.Windows.Forms.Label();
            this.lblRatioSell = new System.Windows.Forms.Label();
            this.lblDolarBuy = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.numDolar = new System.Windows.Forms.NumericUpDown();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblProfitPesos = new System.Windows.Forms.Label();
            this.chkComprarNominales = new System.Windows.Forms.CheckBox();
            this.lnkArbitration = new System.Windows.Forms.LinkLabel();
            this.grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).BeginInit();
            this.grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraSize)).BeginInit();
            this.grpArbitrationVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaSize)).BeginInit();
            this.grpOwnedCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            this.grpOwnedVenta.Controls.Add(this.chkOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.OwnedVentaBidsOffers);
            this.grpOwnedVenta.Controls.Add(this.txtOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedVentaImporte);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedComision);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaPrice);
            this.grpOwnedVenta.Controls.Add(this.lblVentaACurrency);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaSize);
            this.grpOwnedVenta.Controls.Add(this.label1);
            this.grpOwnedVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOwnedVenta.Location = new System.Drawing.Point(8, 97);
            this.grpOwnedVenta.Name = "grpOwnedVenta";
            this.grpOwnedVenta.Size = new System.Drawing.Size(590, 195);
            this.grpOwnedVenta.TabIndex = 1;
            this.grpOwnedVenta.TabStop = false;
            this.grpOwnedVenta.Text = "1. Venta de Instrumento A";
            // 
            // chkOwnedVenta
            // 
            this.chkOwnedVenta.AutoSize = true;
            this.chkOwnedVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOwnedVenta.Location = new System.Drawing.Point(68, 16);
            this.chkOwnedVenta.Name = "chkOwnedVenta";
            this.chkOwnedVenta.Size = new System.Drawing.Size(124, 17);
            this.chkOwnedVenta.TabIndex = 17;
            this.chkOwnedVenta.Text = "Cantidad Automatica";
            this.chkOwnedVenta.UseVisualStyleBackColor = true;
            this.chkOwnedVenta.CheckedChanged += new System.EventHandler(this.chkOwnedVenta_CheckedChanged);
            // 
            // OwnedVentaBidsOffers
            // 
            this.OwnedVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.OwnedVentaBidsOffers.InstrumentDetail = null;
            this.OwnedVentaBidsOffers.Location = new System.Drawing.Point(197, 16);
            this.OwnedVentaBidsOffers.Margin = new System.Windows.Forms.Padding(2);
            this.OwnedVentaBidsOffers.Name = "OwnedVentaBidsOffers";
            this.OwnedVentaBidsOffers.Size = new System.Drawing.Size(388, 146);
            this.OwnedVentaBidsOffers.TabIndex = 11;
            // 
            // txtOwnedVenta
            // 
            this.txtOwnedVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnedVenta.Location = new System.Drawing.Point(6, 168);
            this.txtOwnedVenta.Name = "txtOwnedVenta";
            this.txtOwnedVenta.Size = new System.Drawing.Size(568, 24);
            this.txtOwnedVenta.TabIndex = 10;
            this.txtOwnedVenta.TabStop = true;
            this.txtOwnedVenta.Text = "Copiar";
            this.txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOwnedVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtOwnedVenta_LinkClicked);
            // 
            // lblOwnedVentaImporte
            // 
            this.lblOwnedVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedVentaImporte.Location = new System.Drawing.Point(8, 126);
            this.lblOwnedVentaImporte.Name = "lblOwnedVentaImporte";
            this.lblOwnedVentaImporte.Size = new System.Drawing.Size(184, 18);
            this.lblOwnedVentaImporte.TabIndex = 6;
            this.lblOwnedVentaImporte.Text = "Importe";
            this.lblOwnedVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwnedComision
            // 
            this.lblOwnedComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedComision.Location = new System.Drawing.Point(8, 144);
            this.lblOwnedComision.Name = "lblOwnedComision";
            this.lblOwnedComision.Size = new System.Drawing.Size(184, 18);
            this.lblOwnedComision.TabIndex = 5;
            this.lblOwnedComision.Text = "Comisión";
            this.lblOwnedComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedVentaPrice
            // 
            this.numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numOwnedVentaPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numOwnedVentaPrice.Location = new System.Drawing.Point(112, 68);
            this.numOwnedVentaPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numOwnedVentaPrice.Name = "numOwnedVentaPrice";
            this.numOwnedVentaPrice.Size = new System.Drawing.Size(80, 20);
            this.numOwnedVentaPrice.TabIndex = 1;
            this.numOwnedVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedVentaPrice.ValueChanged += new System.EventHandler(this.numOwnedVentaPrice_ValueChanged);
            this.numOwnedVentaPrice.Enter += new System.EventHandler(this.numOwnedVentaPrice_Enter);
            this.numOwnedVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaPrice_KeyPress);
            // 
            // lblVentaACurrency
            // 
            this.lblVentaACurrency.AutoSize = true;
            this.lblVentaACurrency.Location = new System.Drawing.Point(66, 75);
            this.lblVentaACurrency.Name = "lblVentaACurrency";
            this.lblVentaACurrency.Size = new System.Drawing.Size(40, 13);
            this.lblVentaACurrency.TabIndex = 3;
            this.lblVentaACurrency.Text = "a U$S:";
            // 
            // numOwnedVentaSize
            // 
            this.numOwnedVentaSize.Location = new System.Drawing.Point(112, 40);
            this.numOwnedVentaSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numOwnedVentaSize.Name = "numOwnedVentaSize";
            this.numOwnedVentaSize.Size = new System.Drawing.Size(80, 20);
            this.numOwnedVentaSize.TabIndex = 0;
            this.numOwnedVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedVentaSize.ValueChanged += new System.EventHandler(this.numOwnedVentaSize_ValueChanged);
            this.numOwnedVentaSize.Enter += new System.EventHandler(this.numOwnedVentaSize_Enter);
            this.numOwnedVentaSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaSize_KeyPress);
            this.numOwnedVentaSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numOwnedVentaSize_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // grpArbitrationCompra
            // 
            this.grpArbitrationCompra.Controls.Add(this.chkArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblArbirtationCompraComision);
            this.grpArbitrationCompra.Controls.Add(this.ArbitrationCompraBidsOffers);
            this.grpArbitrationCompra.Controls.Add(this.txtArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblArbitrationCompraImporte);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraPrice);
            this.grpArbitrationCompra.Controls.Add(this.lblCompraBCurrency);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraSize);
            this.grpArbitrationCompra.Controls.Add(this.label7);
            this.grpArbitrationCompra.Location = new System.Drawing.Point(604, 97);
            this.grpArbitrationCompra.Name = "grpArbitrationCompra";
            this.grpArbitrationCompra.Size = new System.Drawing.Size(589, 195);
            this.grpArbitrationCompra.TabIndex = 8;
            this.grpArbitrationCompra.TabStop = false;
            this.grpArbitrationCompra.Text = "2. Compra de Instrumento B";
            // 
            // chkArbitrationCompra
            // 
            this.chkArbitrationCompra.AutoSize = true;
            this.chkArbitrationCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkArbitrationCompra.Location = new System.Drawing.Point(68, 17);
            this.chkArbitrationCompra.Name = "chkArbitrationCompra";
            this.chkArbitrationCompra.Size = new System.Drawing.Size(124, 17);
            this.chkArbitrationCompra.TabIndex = 16;
            this.chkArbitrationCompra.Text = "Cantidad Automatica";
            this.chkArbitrationCompra.UseVisualStyleBackColor = true;
            this.chkArbitrationCompra.CheckedChanged += new System.EventHandler(this.chkArbitrationCompra_CheckedChanged);
            // 
            // lblArbirtationCompraComision
            // 
            this.lblArbirtationCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbirtationCompraComision.Location = new System.Drawing.Point(8, 144);
            this.lblArbirtationCompraComision.Name = "lblArbirtationCompraComision";
            this.lblArbirtationCompraComision.Size = new System.Drawing.Size(184, 18);
            this.lblArbirtationCompraComision.TabIndex = 14;
            this.lblArbirtationCompraComision.Text = "Comisión";
            this.lblArbirtationCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ArbitrationCompraBidsOffers
            // 
            this.ArbitrationCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.ArbitrationCompraBidsOffers.InstrumentDetail = null;
            this.ArbitrationCompraBidsOffers.Location = new System.Drawing.Point(197, 16);
            this.ArbitrationCompraBidsOffers.Margin = new System.Windows.Forms.Padding(2);
            this.ArbitrationCompraBidsOffers.Name = "ArbitrationCompraBidsOffers";
            this.ArbitrationCompraBidsOffers.Size = new System.Drawing.Size(387, 146);
            this.ArbitrationCompraBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationCompra
            // 
            this.txtArbitrationCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbitrationCompra.Location = new System.Drawing.Point(6, 168);
            this.txtArbitrationCompra.Name = "txtArbitrationCompra";
            this.txtArbitrationCompra.Size = new System.Drawing.Size(567, 24);
            this.txtArbitrationCompra.TabIndex = 12;
            this.txtArbitrationCompra.TabStop = true;
            this.txtArbitrationCompra.Text = "Copiar";
            this.txtArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArbitrationCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArbitrationCompra_LinkClicked);
            // 
            // lblArbitrationCompraImporte
            // 
            this.lblArbitrationCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArbitrationCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationCompraImporte.Location = new System.Drawing.Point(6, 126);
            this.lblArbitrationCompraImporte.Name = "lblArbitrationCompraImporte";
            this.lblArbitrationCompraImporte.Size = new System.Drawing.Size(186, 18);
            this.lblArbitrationCompraImporte.TabIndex = 6;
            this.lblArbitrationCompraImporte.Text = "Importe";
            this.lblArbitrationCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationCompraPrice
            // 
            this.numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numArbitrationCompraPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numArbitrationCompraPrice.Location = new System.Drawing.Point(112, 66);
            this.numArbitrationCompraPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numArbitrationCompraPrice.Name = "numArbitrationCompraPrice";
            this.numArbitrationCompraPrice.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationCompraPrice.TabIndex = 1;
            this.numArbitrationCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationCompraPrice.ValueChanged += new System.EventHandler(this.numArbitrationCompraPrice_ValueChanged);
            this.numArbitrationCompraPrice.Enter += new System.EventHandler(this.numArbitrationCompraPrice_Enter);
            this.numArbitrationCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationCompraPrice_KeyPress);
            // 
            // lblCompraBCurrency
            // 
            this.lblCompraBCurrency.AutoSize = true;
            this.lblCompraBCurrency.Location = new System.Drawing.Point(66, 68);
            this.lblCompraBCurrency.Name = "lblCompraBCurrency";
            this.lblCompraBCurrency.Size = new System.Drawing.Size(40, 13);
            this.lblCompraBCurrency.TabIndex = 3;
            this.lblCompraBCurrency.Text = "a U$S:";
            // 
            // numArbitrationCompraSize
            // 
            this.numArbitrationCompraSize.Location = new System.Drawing.Point(112, 40);
            this.numArbitrationCompraSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numArbitrationCompraSize.Name = "numArbitrationCompraSize";
            this.numArbitrationCompraSize.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationCompraSize.TabIndex = 0;
            this.numArbitrationCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationCompraSize.ValueChanged += new System.EventHandler(this.numArbitrationCompraSize_ValueChanged);
            this.numArbitrationCompraSize.Enter += new System.EventHandler(this.numArbitrationCompraSize_Enter);
            this.numArbitrationCompraSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationCompraSize_KeyPress);
            this.numArbitrationCompraSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numArbitrationCompraSize_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpArbitrationVenta
            // 
            this.grpArbitrationVenta.Controls.Add(this.ArbitrationVentaBidsOffers);
            this.grpArbitrationVenta.Controls.Add(this.txtArbitrationVenta);
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationVentaImporte);
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationComision);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaPrice);
            this.grpArbitrationVenta.Controls.Add(this.lblVentaBCurrency);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaSize);
            this.grpArbitrationVenta.Controls.Add(this.label12);
            this.grpArbitrationVenta.Location = new System.Drawing.Point(8, 308);
            this.grpArbitrationVenta.Name = "grpArbitrationVenta";
            this.grpArbitrationVenta.Size = new System.Drawing.Size(590, 195);
            this.grpArbitrationVenta.TabIndex = 12;
            this.grpArbitrationVenta.TabStop = false;
            this.grpArbitrationVenta.Text = "3. Venta de Instrumento B";
            // 
            // ArbitrationVentaBidsOffers
            // 
            this.ArbitrationVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.ArbitrationVentaBidsOffers.InstrumentDetail = null;
            this.ArbitrationVentaBidsOffers.Location = new System.Drawing.Point(197, 18);
            this.ArbitrationVentaBidsOffers.Margin = new System.Windows.Forms.Padding(2);
            this.ArbitrationVentaBidsOffers.Name = "ArbitrationVentaBidsOffers";
            this.ArbitrationVentaBidsOffers.Size = new System.Drawing.Size(388, 146);
            this.ArbitrationVentaBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationVenta
            // 
            this.txtArbitrationVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbitrationVenta.Location = new System.Drawing.Point(6, 168);
            this.txtArbitrationVenta.Name = "txtArbitrationVenta";
            this.txtArbitrationVenta.Size = new System.Drawing.Size(568, 24);
            this.txtArbitrationVenta.TabIndex = 12;
            this.txtArbitrationVenta.TabStop = true;
            this.txtArbitrationVenta.Text = "Copiar";
            this.txtArbitrationVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArbitrationVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArbitrationVenta_LinkClicked);
            // 
            // lblArbitrationVentaImporte
            // 
            this.lblArbitrationVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationVentaImporte.Location = new System.Drawing.Point(15, 78);
            this.lblArbitrationVentaImporte.Name = "lblArbitrationVentaImporte";
            this.lblArbitrationVentaImporte.Size = new System.Drawing.Size(177, 18);
            this.lblArbitrationVentaImporte.TabIndex = 6;
            this.lblArbitrationVentaImporte.Text = "Importe";
            this.lblArbitrationVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblArbitrationComision
            // 
            this.lblArbitrationComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationComision.Location = new System.Drawing.Point(9, 96);
            this.lblArbitrationComision.Name = "lblArbitrationComision";
            this.lblArbitrationComision.Size = new System.Drawing.Size(183, 18);
            this.lblArbitrationComision.TabIndex = 5;
            this.lblArbitrationComision.Text = "Comisión";
            this.lblArbitrationComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationVentaPrice
            // 
            this.numArbitrationVentaPrice.DecimalPlaces = 2;
            this.numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numArbitrationVentaPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArbitrationVentaPrice.Location = new System.Drawing.Point(112, 45);
            this.numArbitrationVentaPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numArbitrationVentaPrice.Name = "numArbitrationVentaPrice";
            this.numArbitrationVentaPrice.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationVentaPrice.TabIndex = 1;
            this.numArbitrationVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationVentaPrice.ValueChanged += new System.EventHandler(this.numArbitrationVentaPrice_ValueChanged);
            this.numArbitrationVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationVentaPrice_KeyPress);
            // 
            // lblVentaBCurrency
            // 
            this.lblVentaBCurrency.AutoSize = true;
            this.lblVentaBCurrency.Location = new System.Drawing.Point(81, 47);
            this.lblVentaBCurrency.Name = "lblVentaBCurrency";
            this.lblVentaBCurrency.Size = new System.Drawing.Size(25, 13);
            this.lblVentaBCurrency.TabIndex = 3;
            this.lblVentaBCurrency.Text = "a $:";
            // 
            // numArbitrationVentaSize
            // 
            this.numArbitrationVentaSize.Enabled = false;
            this.numArbitrationVentaSize.Location = new System.Drawing.Point(112, 19);
            this.numArbitrationVentaSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numArbitrationVentaSize.Name = "numArbitrationVentaSize";
            this.numArbitrationVentaSize.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationVentaSize.TabIndex = 0;
            this.numArbitrationVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cantidad:";
            // 
            // grpOwnedCompra
            // 
            this.grpOwnedCompra.Controls.Add(this.lblOwnedCompraComision);
            this.grpOwnedCompra.Controls.Add(this.OwnedCompraBidsOffers);
            this.grpOwnedCompra.Controls.Add(this.txtOwnedCompra);
            this.grpOwnedCompra.Controls.Add(this.lblOwnedCompraImporte);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraPrice);
            this.grpOwnedCompra.Controls.Add(this.lblCompraACurrency);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraSize);
            this.grpOwnedCompra.Controls.Add(this.label17);
            this.grpOwnedCompra.Location = new System.Drawing.Point(604, 308);
            this.grpOwnedCompra.Name = "grpOwnedCompra";
            this.grpOwnedCompra.Size = new System.Drawing.Size(589, 195);
            this.grpOwnedCompra.TabIndex = 9;
            this.grpOwnedCompra.TabStop = false;
            this.grpOwnedCompra.Text = "4. Compra de Instrumento A";
            // 
            // lblOwnedCompraComision
            // 
            this.lblOwnedCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedCompraComision.Location = new System.Drawing.Point(8, 96);
            this.lblOwnedCompraComision.Name = "lblOwnedCompraComision";
            this.lblOwnedCompraComision.Size = new System.Drawing.Size(184, 18);
            this.lblOwnedCompraComision.TabIndex = 15;
            this.lblOwnedCompraComision.Text = "Comisión";
            this.lblOwnedCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OwnedCompraBidsOffers
            // 
            this.OwnedCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.OwnedCompraBidsOffers.InstrumentDetail = null;
            this.OwnedCompraBidsOffers.Location = new System.Drawing.Point(197, 18);
            this.OwnedCompraBidsOffers.Margin = new System.Windows.Forms.Padding(2);
            this.OwnedCompraBidsOffers.Name = "OwnedCompraBidsOffers";
            this.OwnedCompraBidsOffers.Size = new System.Drawing.Size(387, 146);
            this.OwnedCompraBidsOffers.TabIndex = 14;
            // 
            // txtOwnedCompra
            // 
            this.txtOwnedCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnedCompra.Location = new System.Drawing.Point(8, 168);
            this.txtOwnedCompra.Name = "txtOwnedCompra";
            this.txtOwnedCompra.Size = new System.Drawing.Size(567, 24);
            this.txtOwnedCompra.TabIndex = 13;
            this.txtOwnedCompra.TabStop = true;
            this.txtOwnedCompra.Text = "Copiar";
            this.txtOwnedCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOwnedCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtOwnedCompra_LinkClicked);
            // 
            // lblOwnedCompraImporte
            // 
            this.lblOwnedCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedCompraImporte.Location = new System.Drawing.Point(12, 78);
            this.lblOwnedCompraImporte.Name = "lblOwnedCompraImporte";
            this.lblOwnedCompraImporte.Size = new System.Drawing.Size(180, 18);
            this.lblOwnedCompraImporte.TabIndex = 6;
            this.lblOwnedCompraImporte.Text = "Importe";
            this.lblOwnedCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedCompraPrice
            // 
            this.numOwnedCompraPrice.DecimalPlaces = 2;
            this.numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numOwnedCompraPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOwnedCompraPrice.Location = new System.Drawing.Point(112, 47);
            this.numOwnedCompraPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numOwnedCompraPrice.Name = "numOwnedCompraPrice";
            this.numOwnedCompraPrice.Size = new System.Drawing.Size(80, 20);
            this.numOwnedCompraPrice.TabIndex = 1;
            this.numOwnedCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedCompraPrice.ValueChanged += new System.EventHandler(this.numOwnedCompraPrice_ValueChanged);
            this.numOwnedCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedCompraPrice_KeyPress);
            // 
            // lblCompraACurrency
            // 
            this.lblCompraACurrency.AutoSize = true;
            this.lblCompraACurrency.Location = new System.Drawing.Point(81, 49);
            this.lblCompraACurrency.Name = "lblCompraACurrency";
            this.lblCompraACurrency.Size = new System.Drawing.Size(25, 13);
            this.lblCompraACurrency.TabIndex = 3;
            this.lblCompraACurrency.Text = "a $:";
            // 
            // numOwnedCompraSize
            // 
            this.numOwnedCompraSize.Enabled = false;
            this.numOwnedCompraSize.Location = new System.Drawing.Point(112, 21);
            this.numOwnedCompraSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numOwnedCompraSize.Name = "numOwnedCompraSize";
            this.numOwnedCompraSize.Size = new System.Drawing.Size(80, 20);
            this.numOwnedCompraSize.TabIndex = 0;
            this.numOwnedCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cantidad:";
            // 
            // lblOwnedLast
            // 
            this.lblOwnedLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedLast.Location = new System.Drawing.Point(499, 65);
            this.lblOwnedLast.Name = "lblOwnedLast";
            this.lblOwnedLast.Size = new System.Drawing.Size(95, 21);
            this.lblOwnedLast.TabIndex = 9;
            this.lblOwnedLast.Text = "$ Last";
            this.lblOwnedLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationLast
            // 
            this.lblArbitrationLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationLast.Location = new System.Drawing.Point(667, 64);
            this.lblArbitrationLast.Name = "lblArbitrationLast";
            this.lblArbitrationLast.Size = new System.Drawing.Size(92, 23);
            this.lblArbitrationLast.TabIndex = 13;
            this.lblArbitrationLast.Text = "$ Last";
            this.lblArbitrationLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numComision
            // 
            this.numComision.DecimalPlaces = 2;
            this.numComision.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numComision.Location = new System.Drawing.Point(1115, 67);
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(80, 20);
            this.numComision.TabIndex = 0;
            this.numComision.Value = new decimal(new int[] {
            27,
            0,
            0,
            131072});
            this.numComision.ValueChanged += new System.EventHandler(this.numComision_ValueChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1205, 55);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Profit: $ / %";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(1026, 68);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(83, 18);
            this.lblComision.TabIndex = 15;
            this.lblComision.Text = "Comisión %:";
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationDiff
            // 
            this.lblArbitrationDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationDiff.Location = new System.Drawing.Point(604, 66);
            this.lblArbitrationDiff.Name = "lblArbitrationDiff";
            this.lblArbitrationDiff.Size = new System.Drawing.Size(60, 18);
            this.lblArbitrationDiff.TabIndex = 16;
            this.lblArbitrationDiff.Text = "%";
            this.lblArbitrationDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRatioSell
            // 
            this.lblRatioSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatioSell.Location = new System.Drawing.Point(384, 66);
            this.lblRatioSell.Name = "lblRatioSell";
            this.lblRatioSell.Size = new System.Drawing.Size(109, 18);
            this.lblRatioSell.TabIndex = 17;
            this.lblRatioSell.Text = "Ratio Compra";
            this.lblRatioSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDolarBuy
            // 
            this.lblDolarBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarBuy.Location = new System.Drawing.Point(765, 67);
            this.lblDolarBuy.Name = "lblDolarBuy";
            this.lblDolarBuy.Size = new System.Drawing.Size(104, 18);
            this.lblDolarBuy.TabIndex = 18;
            this.lblDolarBuy.Text = "Ratio Venta";
            this.lblDolarBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolar
            // 
            this.lblDolar.Location = new System.Drawing.Point(875, 68);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(59, 18);
            this.lblDolar.TabIndex = 20;
            this.lblDolar.Text = "Dolar $:";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            this.numDolar.DecimalPlaces = 2;
            this.numDolar.Location = new System.Drawing.Point(940, 68);
            this.numDolar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDolar.Name = "numDolar";
            this.numDolar.Size = new System.Drawing.Size(80, 20);
            this.numDolar.TabIndex = 19;
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
            this.lblComisionTotal.Location = new System.Drawing.Point(292, 508);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(183, 18);
            this.lblComisionTotal.TabIndex = 12;
            this.lblComisionTotal.Text = "Total Comisión:";
            this.lblComisionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(481, 508);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(183, 18);
            this.lblTotalProfit.TabIndex = 21;
            this.lblTotalProfit.Text = "Total Ganancia:";
            this.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitPesos
            // 
            this.lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPesos.Location = new System.Drawing.Point(670, 508);
            this.lblProfitPesos.Name = "lblProfitPesos";
            this.lblProfitPesos.Size = new System.Drawing.Size(183, 18);
            this.lblProfitPesos.TabIndex = 22;
            this.lblProfitPesos.Text = "Total Ganancia:";
            this.lblProfitPesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkComprarNominales
            // 
            this.chkComprarNominales.AutoSize = true;
            this.chkComprarNominales.Location = new System.Drawing.Point(8, 509);
            this.chkComprarNominales.Name = "chkComprarNominales";
            this.chkComprarNominales.Size = new System.Drawing.Size(239, 17);
            this.chkComprarNominales.TabIndex = 23;
            this.chkComprarNominales.Text = "Utilizar ganancia para obtener más nominales";
            this.chkComprarNominales.UseVisualStyleBackColor = true;
            this.chkComprarNominales.CheckedChanged += new System.EventHandler(this.chkComprarNominales_CheckedChanged);
            // 
            // lnkArbitration
            // 
            this.lnkArbitration.Location = new System.Drawing.Point(8, 67);
            this.lnkArbitration.Name = "lnkArbitration";
            this.lnkArbitration.Size = new System.Drawing.Size(384, 21);
            this.lnkArbitration.TabIndex = 14;
            this.lnkArbitration.TabStop = true;
            this.lnkArbitration.Text = "Vender AL30D => Comprar LetraD => Vender Letra => Comprar AL30";
            this.lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArbitration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArbitration_LinkClicked);
            // 
            // FrmRatioTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 535);
            this.Controls.Add(this.lnkArbitration);
            this.Controls.Add(this.chkComprarNominales);
            this.Controls.Add(this.lblProfitPesos);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblComisionTotal);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.numDolar);
            this.Controls.Add(this.lblDolarBuy);
            this.Controls.Add(this.lblRatioSell);
            this.Controls.Add(this.lblArbitrationDiff);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.lblArbitrationLast);
            this.Controls.Add(this.lblOwnedLast);
            this.Controls.Add(this.grpOwnedCompra);
            this.Controls.Add(this.grpArbitrationVenta);
            this.Controls.Add(this.grpArbitrationCompra);
            this.Controls.Add(this.grpOwnedVenta);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRatioTrade";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Operación de Arbitraje";
            this.Load += new System.EventHandler(this.FrmArbitrationTrade_Load);
            this.grpOwnedVenta.ResumeLayout(false);
            this.grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).EndInit();
            this.grpArbitrationCompra.ResumeLayout(false);
            this.grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraSize)).EndInit();
            this.grpArbitrationVenta.ResumeLayout(false);
            this.grpArbitrationVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaSize)).EndInit();
            this.grpOwnedCompra.ResumeLayout(false);
            this.grpOwnedCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblOwnedVentaImporte;
        private System.Windows.Forms.Label lblOwnedComision;
        private System.Windows.Forms.NumericUpDown numOwnedVentaPrice;
        private System.Windows.Forms.Label lblVentaACurrency;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblArbitrationCompraImporte;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraPrice;
        private System.Windows.Forms.Label lblCompraBCurrency;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpArbitrationVenta;
        private System.Windows.Forms.Label lblArbitrationVentaImporte;
        private System.Windows.Forms.Label lblArbitrationComision;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaPrice;
        private System.Windows.Forms.Label lblVentaBCurrency;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpOwnedCompra;
        private System.Windows.Forms.Label lblOwnedCompraImporte;
        private System.Windows.Forms.NumericUpDown numOwnedCompraPrice;
        private System.Windows.Forms.Label lblCompraACurrency;
        private System.Windows.Forms.NumericUpDown numOwnedCompraSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOwnedLast;
        private System.Windows.Forms.Label lblArbitrationLast;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblArbitrationDiff;
        private System.Windows.Forms.Label lblRatioSell;
        private System.Windows.Forms.Label lblDolarBuy;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.NumericUpDown numDolar;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblProfitPesos;
        private System.Windows.Forms.CheckBox chkComprarNominales;
        private System.Windows.Forms.LinkLabel txtOwnedVenta;
        private System.Windows.Forms.LinkLabel txtArbitrationCompra;
        private System.Windows.Forms.LinkLabel txtArbitrationVenta;
        private System.Windows.Forms.LinkLabel txtOwnedCompra;
        private BidsOffersControl OwnedVentaBidsOffers;
        private BidsOffersControl ArbitrationCompraBidsOffers;
        private BidsOffersControl ArbitrationVentaBidsOffers;
        private BidsOffersControl OwnedCompraBidsOffers;
        private System.Windows.Forms.LinkLabel lnkArbitration;
        private System.Windows.Forms.Label lblArbirtationCompraComision;
        private System.Windows.Forms.Label lblOwnedCompraComision;
        private System.Windows.Forms.CheckBox chkArbitrationCompra;
        private System.Windows.Forms.CheckBox chkOwnedVenta;
    }
}