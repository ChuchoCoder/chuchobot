namespace ChuchoBot.WinFormsApp
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatioTrade));
            grpOwnedVenta = new System.Windows.Forms.GroupBox();
            chkOwnedVenta = new System.Windows.Forms.CheckBox();
            OwnedVentaBidsOffers = new BidsOffersControl();
            txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            lblOwnedVentaImporte = new System.Windows.Forms.Label();
            lblOwnedComision = new System.Windows.Forms.Label();
            numOwnedVentaPrice = new System.Windows.Forms.NumericUpDown();
            numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            chkArbitrationCompra = new System.Windows.Forms.CheckBox();
            lblArbirtationCompraComision = new System.Windows.Forms.Label();
            ArbitrationCompraBidsOffers = new BidsOffersControl();
            txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            lblArbitrationCompraImporte = new System.Windows.Forms.Label();
            numArbitrationCompraPrice = new System.Windows.Forms.NumericUpDown();
            numArbitrationCompraSize = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            grpArbitrationVenta = new System.Windows.Forms.GroupBox();
            ArbitrationVentaBidsOffers = new BidsOffersControl();
            txtArbitrationVenta = new System.Windows.Forms.LinkLabel();
            lblArbitrationVentaImporte = new System.Windows.Forms.Label();
            lblArbitrationComision = new System.Windows.Forms.Label();
            numArbitrationVentaPrice = new System.Windows.Forms.NumericUpDown();
            numArbitrationVentaSize = new System.Windows.Forms.NumericUpDown();
            label12 = new System.Windows.Forms.Label();
            grpOwnedCompra = new System.Windows.Forms.GroupBox();
            lblOwnedCompraComision = new System.Windows.Forms.Label();
            OwnedCompraBidsOffers = new BidsOffersControl();
            txtOwnedCompra = new System.Windows.Forms.LinkLabel();
            lblOwnedCompraImporte = new System.Windows.Forms.Label();
            numOwnedCompraPrice = new System.Windows.Forms.NumericUpDown();
            numOwnedCompraSize = new System.Windows.Forms.NumericUpDown();
            label17 = new System.Windows.Forms.Label();
            lblOwnedLast = new System.Windows.Forms.Label();
            lblArbitrationLast = new System.Windows.Forms.Label();
            numComision = new System.Windows.Forms.NumericUpDown();
            lblHeader = new System.Windows.Forms.Label();
            lblComision = new System.Windows.Forms.Label();
            lblArbitrationDiff = new System.Windows.Forms.Label();
            lblRatioSell = new System.Windows.Forms.Label();
            lblDolarBuy = new System.Windows.Forms.Label();
            lblDolar = new System.Windows.Forms.Label();
            numDolar = new System.Windows.Forms.NumericUpDown();
            lblComisionTotal = new System.Windows.Forms.Label();
            lblTotalProfit = new System.Windows.Forms.Label();
            lblProfitPesos = new System.Windows.Forms.Label();
            chkComprarNominales = new System.Windows.Forms.CheckBox();
            lnkArbitration = new System.Windows.Forms.LinkLabel();
            lblOwnedCompraCurrency = new System.Windows.Forms.Label();
            lblArbitrationCompraCurrency = new System.Windows.Forms.Label();
            lblOwnedVentaCurrency = new System.Windows.Forms.Label();
            lblArbitrationVentaCurrency = new System.Windows.Forms.Label();
            grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaSize).BeginInit();
            grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numArbitrationCompraPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArbitrationCompraSize).BeginInit();
            grpArbitrationVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numArbitrationVentaPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArbitrationVentaSize).BeginInit();
            grpOwnedCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOwnedCompraPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedCompraSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDolar).BeginInit();
            SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            grpOwnedVenta.Controls.Add(lblOwnedVentaCurrency);
            grpOwnedVenta.Controls.Add(chkOwnedVenta);
            grpOwnedVenta.Controls.Add(OwnedVentaBidsOffers);
            grpOwnedVenta.Controls.Add(txtOwnedVenta);
            grpOwnedVenta.Controls.Add(lblOwnedVentaImporte);
            grpOwnedVenta.Controls.Add(lblOwnedComision);
            grpOwnedVenta.Controls.Add(numOwnedVentaPrice);
            grpOwnedVenta.Controls.Add(numOwnedVentaSize);
            grpOwnedVenta.Controls.Add(label1);
            grpOwnedVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpOwnedVenta.Location = new System.Drawing.Point(11, 149);
            grpOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpOwnedVenta.Name = "grpOwnedVenta";
            grpOwnedVenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpOwnedVenta.Size = new System.Drawing.Size(787, 300);
            grpOwnedVenta.TabIndex = 1;
            grpOwnedVenta.TabStop = false;
            grpOwnedVenta.Text = "1. Venta de Instrumento A";
            // 
            // chkOwnedVenta
            // 
            chkOwnedVenta.AutoSize = true;
            chkOwnedVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkOwnedVenta.Location = new System.Drawing.Point(91, 25);
            chkOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkOwnedVenta.Name = "chkOwnedVenta";
            chkOwnedVenta.Size = new System.Drawing.Size(160, 21);
            chkOwnedVenta.TabIndex = 17;
            chkOwnedVenta.Text = "Cantidad Automatica";
            chkOwnedVenta.UseVisualStyleBackColor = true;
            chkOwnedVenta.CheckedChanged += chkOwnedVenta_CheckedChanged;
            // 
            // OwnedVentaBidsOffers
            // 
            OwnedVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            OwnedVentaBidsOffers.InstrumentDetail = null;
            OwnedVentaBidsOffers.Location = new System.Drawing.Point(263, 25);
            OwnedVentaBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            OwnedVentaBidsOffers.Name = "OwnedVentaBidsOffers";
            OwnedVentaBidsOffers.Size = new System.Drawing.Size(517, 225);
            OwnedVentaBidsOffers.TabIndex = 11;
            // 
            // txtOwnedVenta
            // 
            txtOwnedVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOwnedVenta.Location = new System.Drawing.Point(8, 258);
            txtOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtOwnedVenta.Name = "txtOwnedVenta";
            txtOwnedVenta.Size = new System.Drawing.Size(757, 37);
            txtOwnedVenta.TabIndex = 10;
            txtOwnedVenta.TabStop = true;
            txtOwnedVenta.Text = "Copiar";
            txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtOwnedVenta.LinkClicked += txtOwnedVenta_LinkClicked;
            // 
            // lblOwnedVentaImporte
            // 
            lblOwnedVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedVentaImporte.Location = new System.Drawing.Point(11, 194);
            lblOwnedVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedVentaImporte.Name = "lblOwnedVentaImporte";
            lblOwnedVentaImporte.Size = new System.Drawing.Size(245, 28);
            lblOwnedVentaImporte.TabIndex = 6;
            lblOwnedVentaImporte.Text = "Importe";
            lblOwnedVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwnedComision
            // 
            lblOwnedComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedComision.Location = new System.Drawing.Point(11, 222);
            lblOwnedComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedComision.Name = "lblOwnedComision";
            lblOwnedComision.Size = new System.Drawing.Size(245, 28);
            lblOwnedComision.TabIndex = 5;
            lblOwnedComision.Text = "Comisión";
            lblOwnedComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedVentaPrice
            // 
            numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
            numOwnedVentaPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numOwnedVentaPrice.Location = new System.Drawing.Point(149, 105);
            numOwnedVentaPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numOwnedVentaPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedVentaPrice.Name = "numOwnedVentaPrice";
            numOwnedVentaPrice.Size = new System.Drawing.Size(107, 23);
            numOwnedVentaPrice.TabIndex = 1;
            numOwnedVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedVentaPrice.ValueChanged += numOwnedVentaPrice_ValueChanged;
            numOwnedVentaPrice.Enter += numOwnedVentaPrice_Enter;
            numOwnedVentaPrice.KeyPress += numOwnedVentaPrice_KeyPress;
            // 
            // numOwnedVentaSize
            // 
            numOwnedVentaSize.Location = new System.Drawing.Point(149, 62);
            numOwnedVentaSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numOwnedVentaSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedVentaSize.Name = "numOwnedVentaSize";
            numOwnedVentaSize.Size = new System.Drawing.Size(107, 23);
            numOwnedVentaSize.TabIndex = 0;
            numOwnedVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedVentaSize.ValueChanged += numOwnedVentaSize_ValueChanged;
            numOwnedVentaSize.Enter += numOwnedVentaSize_Enter;
            numOwnedVentaSize.KeyPress += numOwnedVentaSize_KeyPress;
            numOwnedVentaSize.MouseClick += numOwnedVentaSize_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(72, 65);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "Cantidad:";
            // 
            // grpArbitrationCompra
            // 
            grpArbitrationCompra.Controls.Add(lblArbitrationCompraCurrency);
            grpArbitrationCompra.Controls.Add(chkArbitrationCompra);
            grpArbitrationCompra.Controls.Add(lblArbirtationCompraComision);
            grpArbitrationCompra.Controls.Add(ArbitrationCompraBidsOffers);
            grpArbitrationCompra.Controls.Add(txtArbitrationCompra);
            grpArbitrationCompra.Controls.Add(lblArbitrationCompraImporte);
            grpArbitrationCompra.Controls.Add(numArbitrationCompraPrice);
            grpArbitrationCompra.Controls.Add(numArbitrationCompraSize);
            grpArbitrationCompra.Controls.Add(label7);
            grpArbitrationCompra.Location = new System.Drawing.Point(805, 149);
            grpArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpArbitrationCompra.Name = "grpArbitrationCompra";
            grpArbitrationCompra.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpArbitrationCompra.Size = new System.Drawing.Size(785, 300);
            grpArbitrationCompra.TabIndex = 8;
            grpArbitrationCompra.TabStop = false;
            grpArbitrationCompra.Text = "2. Compra de Instrumento B";
            // 
            // chkArbitrationCompra
            // 
            chkArbitrationCompra.AutoSize = true;
            chkArbitrationCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkArbitrationCompra.Location = new System.Drawing.Point(91, 26);
            chkArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkArbitrationCompra.Name = "chkArbitrationCompra";
            chkArbitrationCompra.Size = new System.Drawing.Size(172, 24);
            chkArbitrationCompra.TabIndex = 16;
            chkArbitrationCompra.Text = "Cantidad Automatica";
            chkArbitrationCompra.UseVisualStyleBackColor = true;
            chkArbitrationCompra.CheckedChanged += chkArbitrationCompra_CheckedChanged;
            // 
            // lblArbirtationCompraComision
            // 
            lblArbirtationCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbirtationCompraComision.Location = new System.Drawing.Point(11, 222);
            lblArbirtationCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbirtationCompraComision.Name = "lblArbirtationCompraComision";
            lblArbirtationCompraComision.Size = new System.Drawing.Size(245, 28);
            lblArbirtationCompraComision.TabIndex = 14;
            lblArbirtationCompraComision.Text = "Comisión";
            lblArbirtationCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ArbitrationCompraBidsOffers
            // 
            ArbitrationCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            ArbitrationCompraBidsOffers.InstrumentDetail = null;
            ArbitrationCompraBidsOffers.Location = new System.Drawing.Point(263, 25);
            ArbitrationCompraBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            ArbitrationCompraBidsOffers.Name = "ArbitrationCompraBidsOffers";
            ArbitrationCompraBidsOffers.Size = new System.Drawing.Size(516, 225);
            ArbitrationCompraBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationCompra
            // 
            txtArbitrationCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArbitrationCompra.Location = new System.Drawing.Point(8, 258);
            txtArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtArbitrationCompra.Name = "txtArbitrationCompra";
            txtArbitrationCompra.Size = new System.Drawing.Size(756, 37);
            txtArbitrationCompra.TabIndex = 12;
            txtArbitrationCompra.TabStop = true;
            txtArbitrationCompra.Text = "Copiar";
            txtArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtArbitrationCompra.LinkClicked += txtArbitrationCompra_LinkClicked;
            // 
            // lblArbitrationCompraImporte
            // 
            lblArbitrationCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblArbitrationCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationCompraImporte.Location = new System.Drawing.Point(8, 194);
            lblArbitrationCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationCompraImporte.Name = "lblArbitrationCompraImporte";
            lblArbitrationCompraImporte.Size = new System.Drawing.Size(248, 28);
            lblArbitrationCompraImporte.TabIndex = 6;
            lblArbitrationCompraImporte.Text = "Importe";
            lblArbitrationCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationCompraPrice
            // 
            numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
            numArbitrationCompraPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numArbitrationCompraPrice.Location = new System.Drawing.Point(149, 102);
            numArbitrationCompraPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numArbitrationCompraPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationCompraPrice.Name = "numArbitrationCompraPrice";
            numArbitrationCompraPrice.Size = new System.Drawing.Size(107, 27);
            numArbitrationCompraPrice.TabIndex = 1;
            numArbitrationCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numArbitrationCompraPrice.ValueChanged += numArbitrationCompraPrice_ValueChanged;
            numArbitrationCompraPrice.Enter += numArbitrationCompraPrice_Enter;
            numArbitrationCompraPrice.KeyPress += numArbitrationCompraPrice_KeyPress;
            // 
            // numArbitrationCompraSize
            // 
            numArbitrationCompraSize.Location = new System.Drawing.Point(149, 62);
            numArbitrationCompraSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numArbitrationCompraSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationCompraSize.Name = "numArbitrationCompraSize";
            numArbitrationCompraSize.Size = new System.Drawing.Size(107, 27);
            numArbitrationCompraSize.TabIndex = 0;
            numArbitrationCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numArbitrationCompraSize.ValueChanged += numArbitrationCompraSize_ValueChanged;
            numArbitrationCompraSize.Enter += numArbitrationCompraSize_Enter;
            numArbitrationCompraSize.KeyPress += numArbitrationCompraSize_KeyPress;
            numArbitrationCompraSize.MouseClick += numArbitrationCompraSize_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(72, 65);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Cantidad:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // grpArbitrationVenta
            // 
            grpArbitrationVenta.Controls.Add(lblArbitrationVentaCurrency);
            grpArbitrationVenta.Controls.Add(ArbitrationVentaBidsOffers);
            grpArbitrationVenta.Controls.Add(txtArbitrationVenta);
            grpArbitrationVenta.Controls.Add(lblArbitrationVentaImporte);
            grpArbitrationVenta.Controls.Add(lblArbitrationComision);
            grpArbitrationVenta.Controls.Add(numArbitrationVentaPrice);
            grpArbitrationVenta.Controls.Add(numArbitrationVentaSize);
            grpArbitrationVenta.Controls.Add(label12);
            grpArbitrationVenta.Location = new System.Drawing.Point(11, 474);
            grpArbitrationVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpArbitrationVenta.Name = "grpArbitrationVenta";
            grpArbitrationVenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpArbitrationVenta.Size = new System.Drawing.Size(787, 300);
            grpArbitrationVenta.TabIndex = 12;
            grpArbitrationVenta.TabStop = false;
            grpArbitrationVenta.Text = "3. Venta de Instrumento B";
            // 
            // ArbitrationVentaBidsOffers
            // 
            ArbitrationVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            ArbitrationVentaBidsOffers.InstrumentDetail = null;
            ArbitrationVentaBidsOffers.Location = new System.Drawing.Point(263, 28);
            ArbitrationVentaBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            ArbitrationVentaBidsOffers.Name = "ArbitrationVentaBidsOffers";
            ArbitrationVentaBidsOffers.Size = new System.Drawing.Size(517, 225);
            ArbitrationVentaBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationVenta
            // 
            txtArbitrationVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArbitrationVenta.Location = new System.Drawing.Point(8, 258);
            txtArbitrationVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtArbitrationVenta.Name = "txtArbitrationVenta";
            txtArbitrationVenta.Size = new System.Drawing.Size(757, 37);
            txtArbitrationVenta.TabIndex = 12;
            txtArbitrationVenta.TabStop = true;
            txtArbitrationVenta.Text = "Copiar";
            txtArbitrationVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtArbitrationVenta.LinkClicked += txtArbitrationVenta_LinkClicked;
            // 
            // lblArbitrationVentaImporte
            // 
            lblArbitrationVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationVentaImporte.Location = new System.Drawing.Point(20, 120);
            lblArbitrationVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationVentaImporte.Name = "lblArbitrationVentaImporte";
            lblArbitrationVentaImporte.Size = new System.Drawing.Size(236, 28);
            lblArbitrationVentaImporte.TabIndex = 6;
            lblArbitrationVentaImporte.Text = "Importe";
            lblArbitrationVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblArbitrationComision
            // 
            lblArbitrationComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationComision.Location = new System.Drawing.Point(12, 148);
            lblArbitrationComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationComision.Name = "lblArbitrationComision";
            lblArbitrationComision.Size = new System.Drawing.Size(244, 28);
            lblArbitrationComision.TabIndex = 5;
            lblArbitrationComision.Text = "Comisión";
            lblArbitrationComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationVentaPrice
            // 
            numArbitrationVentaPrice.DecimalPlaces = 2;
            numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
            numArbitrationVentaPrice.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numArbitrationVentaPrice.Location = new System.Drawing.Point(149, 69);
            numArbitrationVentaPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numArbitrationVentaPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationVentaPrice.Name = "numArbitrationVentaPrice";
            numArbitrationVentaPrice.Size = new System.Drawing.Size(107, 27);
            numArbitrationVentaPrice.TabIndex = 1;
            numArbitrationVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numArbitrationVentaPrice.ValueChanged += numArbitrationVentaPrice_ValueChanged;
            numArbitrationVentaPrice.KeyPress += numArbitrationVentaPrice_KeyPress;
            // 
            // numArbitrationVentaSize
            // 
            numArbitrationVentaSize.Enabled = false;
            numArbitrationVentaSize.Location = new System.Drawing.Point(149, 29);
            numArbitrationVentaSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numArbitrationVentaSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationVentaSize.Name = "numArbitrationVentaSize";
            numArbitrationVentaSize.Size = new System.Drawing.Size(107, 27);
            numArbitrationVentaSize.TabIndex = 0;
            numArbitrationVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(72, 32);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(72, 20);
            label12.TabIndex = 1;
            label12.Text = "Cantidad:";
            // 
            // grpOwnedCompra
            // 
            grpOwnedCompra.Controls.Add(lblOwnedCompraCurrency);
            grpOwnedCompra.Controls.Add(lblOwnedCompraComision);
            grpOwnedCompra.Controls.Add(OwnedCompraBidsOffers);
            grpOwnedCompra.Controls.Add(txtOwnedCompra);
            grpOwnedCompra.Controls.Add(lblOwnedCompraImporte);
            grpOwnedCompra.Controls.Add(numOwnedCompraPrice);
            grpOwnedCompra.Controls.Add(numOwnedCompraSize);
            grpOwnedCompra.Controls.Add(label17);
            grpOwnedCompra.Location = new System.Drawing.Point(805, 474);
            grpOwnedCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpOwnedCompra.Name = "grpOwnedCompra";
            grpOwnedCompra.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpOwnedCompra.Size = new System.Drawing.Size(785, 300);
            grpOwnedCompra.TabIndex = 9;
            grpOwnedCompra.TabStop = false;
            grpOwnedCompra.Text = "4. Compra de Instrumento A";
            // 
            // lblOwnedCompraComision
            // 
            lblOwnedCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedCompraComision.Location = new System.Drawing.Point(11, 148);
            lblOwnedCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraComision.Name = "lblOwnedCompraComision";
            lblOwnedCompraComision.Size = new System.Drawing.Size(245, 28);
            lblOwnedCompraComision.TabIndex = 15;
            lblOwnedCompraComision.Text = "Comisión";
            lblOwnedCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OwnedCompraBidsOffers
            // 
            OwnedCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            OwnedCompraBidsOffers.InstrumentDetail = null;
            OwnedCompraBidsOffers.Location = new System.Drawing.Point(263, 28);
            OwnedCompraBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            OwnedCompraBidsOffers.Name = "OwnedCompraBidsOffers";
            OwnedCompraBidsOffers.Size = new System.Drawing.Size(516, 225);
            OwnedCompraBidsOffers.TabIndex = 14;
            // 
            // txtOwnedCompra
            // 
            txtOwnedCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOwnedCompra.Location = new System.Drawing.Point(11, 258);
            txtOwnedCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtOwnedCompra.Name = "txtOwnedCompra";
            txtOwnedCompra.Size = new System.Drawing.Size(756, 37);
            txtOwnedCompra.TabIndex = 13;
            txtOwnedCompra.TabStop = true;
            txtOwnedCompra.Text = "Copiar";
            txtOwnedCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtOwnedCompra.LinkClicked += txtOwnedCompra_LinkClicked;
            // 
            // lblOwnedCompraImporte
            // 
            lblOwnedCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedCompraImporte.Location = new System.Drawing.Point(16, 120);
            lblOwnedCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraImporte.Name = "lblOwnedCompraImporte";
            lblOwnedCompraImporte.Size = new System.Drawing.Size(240, 28);
            lblOwnedCompraImporte.TabIndex = 6;
            lblOwnedCompraImporte.Text = "Importe";
            lblOwnedCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedCompraPrice
            // 
            numOwnedCompraPrice.DecimalPlaces = 2;
            numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
            numOwnedCompraPrice.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numOwnedCompraPrice.Location = new System.Drawing.Point(149, 72);
            numOwnedCompraPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numOwnedCompraPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedCompraPrice.Name = "numOwnedCompraPrice";
            numOwnedCompraPrice.Size = new System.Drawing.Size(107, 27);
            numOwnedCompraPrice.TabIndex = 1;
            numOwnedCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedCompraPrice.ValueChanged += numOwnedCompraPrice_ValueChanged;
            numOwnedCompraPrice.KeyPress += numOwnedCompraPrice_KeyPress;
            // 
            // numOwnedCompraSize
            // 
            numOwnedCompraSize.Enabled = false;
            numOwnedCompraSize.Location = new System.Drawing.Point(149, 32);
            numOwnedCompraSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numOwnedCompraSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedCompraSize.Name = "numOwnedCompraSize";
            numOwnedCompraSize.Size = new System.Drawing.Size(107, 27);
            numOwnedCompraSize.TabIndex = 0;
            numOwnedCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(72, 35);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(72, 20);
            label17.TabIndex = 1;
            label17.Text = "Cantidad:";
            // 
            // lblOwnedLast
            // 
            lblOwnedLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedLast.Location = new System.Drawing.Point(665, 100);
            lblOwnedLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedLast.Name = "lblOwnedLast";
            lblOwnedLast.Size = new System.Drawing.Size(127, 32);
            lblOwnedLast.TabIndex = 9;
            lblOwnedLast.Text = "$ Last";
            lblOwnedLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationLast
            // 
            lblArbitrationLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationLast.Location = new System.Drawing.Point(889, 98);
            lblArbitrationLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationLast.Name = "lblArbitrationLast";
            lblArbitrationLast.Size = new System.Drawing.Size(123, 35);
            lblArbitrationLast.TabIndex = 13;
            lblArbitrationLast.Text = "$ Last";
            lblArbitrationLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numComision
            // 
            numComision.DecimalPlaces = 2;
            numComision.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numComision.Location = new System.Drawing.Point(1487, 103);
            numComision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numComision.Name = "numComision";
            numComision.Size = new System.Drawing.Size(107, 27);
            numComision.TabIndex = 0;
            numComision.Value = new decimal(new int[] { 27, 0, 0, 131072 });
            numComision.ValueChanged += numComision_ValueChanged;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(1607, 85);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Profit: $ / %";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComision
            // 
            lblComision.Location = new System.Drawing.Point(1368, 105);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(111, 28);
            lblComision.TabIndex = 15;
            lblComision.Text = "Comisión %:";
            lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationDiff
            // 
            lblArbitrationDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationDiff.Location = new System.Drawing.Point(805, 102);
            lblArbitrationDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationDiff.Name = "lblArbitrationDiff";
            lblArbitrationDiff.Size = new System.Drawing.Size(80, 28);
            lblArbitrationDiff.TabIndex = 16;
            lblArbitrationDiff.Text = "%";
            lblArbitrationDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRatioSell
            // 
            lblRatioSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRatioSell.Location = new System.Drawing.Point(512, 102);
            lblRatioSell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRatioSell.Name = "lblRatioSell";
            lblRatioSell.Size = new System.Drawing.Size(145, 28);
            lblRatioSell.TabIndex = 17;
            lblRatioSell.Text = "Ratio Compra";
            lblRatioSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDolarBuy
            // 
            lblDolarBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDolarBuy.Location = new System.Drawing.Point(1020, 103);
            lblDolarBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDolarBuy.Name = "lblDolarBuy";
            lblDolarBuy.Size = new System.Drawing.Size(139, 28);
            lblDolarBuy.TabIndex = 18;
            lblDolarBuy.Text = "Ratio Venta";
            lblDolarBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolar
            // 
            lblDolar.Location = new System.Drawing.Point(1167, 105);
            lblDolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new System.Drawing.Size(79, 28);
            lblDolar.TabIndex = 20;
            lblDolar.Text = "Dolar $:";
            lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            numDolar.DecimalPlaces = 2;
            numDolar.Location = new System.Drawing.Point(1253, 105);
            numDolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numDolar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDolar.Name = "numDolar";
            numDolar.Size = new System.Drawing.Size(107, 27);
            numDolar.TabIndex = 19;
            numDolar.Value = new decimal(new int[] { 98, 0, 0, 0 });
            numDolar.ValueChanged += numDolar_ValueChanged;
            // 
            // lblComisionTotal
            // 
            lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblComisionTotal.Location = new System.Drawing.Point(389, 782);
            lblComisionTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComisionTotal.Name = "lblComisionTotal";
            lblComisionTotal.Size = new System.Drawing.Size(244, 28);
            lblComisionTotal.TabIndex = 12;
            lblComisionTotal.Text = "Total Comisión:";
            lblComisionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalProfit.Location = new System.Drawing.Point(641, 782);
            lblTotalProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new System.Drawing.Size(244, 28);
            lblTotalProfit.TabIndex = 21;
            lblTotalProfit.Text = "Total Ganancia:";
            lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitPesos
            // 
            lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblProfitPesos.Location = new System.Drawing.Point(893, 782);
            lblProfitPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProfitPesos.Name = "lblProfitPesos";
            lblProfitPesos.Size = new System.Drawing.Size(244, 28);
            lblProfitPesos.TabIndex = 22;
            lblProfitPesos.Text = "Total Ganancia:";
            lblProfitPesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkComprarNominales
            // 
            chkComprarNominales.AutoSize = true;
            chkComprarNominales.Location = new System.Drawing.Point(11, 783);
            chkComprarNominales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkComprarNominales.Name = "chkComprarNominales";
            chkComprarNominales.Size = new System.Drawing.Size(335, 24);
            chkComprarNominales.TabIndex = 23;
            chkComprarNominales.Text = "Utilizar ganancia para obtener más nominales";
            chkComprarNominales.UseVisualStyleBackColor = true;
            chkComprarNominales.CheckedChanged += chkComprarNominales_CheckedChanged;
            // 
            // lnkArbitration
            // 
            lnkArbitration.Location = new System.Drawing.Point(11, 103);
            lnkArbitration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnkArbitration.Name = "lnkArbitration";
            lnkArbitration.Size = new System.Drawing.Size(512, 32);
            lnkArbitration.TabIndex = 14;
            lnkArbitration.TabStop = true;
            lnkArbitration.Text = "Vender AL30D => Comprar LetraD => Vender Letra => Comprar AL30";
            lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkArbitration.LinkClicked += lnkArbitration_LinkClicked;
            // 
            // lblOwnedCompraCurrency
            // 
            lblOwnedCompraCurrency.AutoSize = true;
            lblOwnedCompraCurrency.Location = new System.Drawing.Point(91, 74);
            lblOwnedCompraCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraCurrency.Name = "lblOwnedCompraCurrency";
            lblOwnedCompraCurrency.Size = new System.Drawing.Size(50, 20);
            lblOwnedCompraCurrency.TabIndex = 16;
            lblOwnedCompraCurrency.Text = "a U$S:";
            // 
            // lblArbitrationCompraCurrency
            // 
            lblArbitrationCompraCurrency.AutoSize = true;
            lblArbitrationCompraCurrency.Location = new System.Drawing.Point(109, 105);
            lblArbitrationCompraCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationCompraCurrency.Name = "lblArbitrationCompraCurrency";
            lblArbitrationCompraCurrency.Size = new System.Drawing.Size(32, 20);
            lblArbitrationCompraCurrency.TabIndex = 17;
            lblArbitrationCompraCurrency.Text = "a $:";
            // 
            // lblOwnedVentaCurrency
            // 
            lblOwnedVentaCurrency.AutoSize = true;
            lblOwnedVentaCurrency.Location = new System.Drawing.Point(108, 106);
            lblOwnedVentaCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedVentaCurrency.Name = "lblOwnedVentaCurrency";
            lblOwnedVentaCurrency.Size = new System.Drawing.Size(32, 17);
            lblOwnedVentaCurrency.TabIndex = 18;
            lblOwnedVentaCurrency.Text = "a $:";
            // 
            // lblArbitrationVentaCurrency
            // 
            lblArbitrationVentaCurrency.AutoSize = true;
            lblArbitrationVentaCurrency.Location = new System.Drawing.Point(90, 71);
            lblArbitrationVentaCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationVentaCurrency.Name = "lblArbitrationVentaCurrency";
            lblArbitrationVentaCurrency.Size = new System.Drawing.Size(50, 20);
            lblArbitrationVentaCurrency.TabIndex = 14;
            lblArbitrationVentaCurrency.Text = "a U$S:";
            // 
            // FrmRatioTrade
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1607, 823);
            Controls.Add(lnkArbitration);
            Controls.Add(chkComprarNominales);
            Controls.Add(lblProfitPesos);
            Controls.Add(lblTotalProfit);
            Controls.Add(lblComisionTotal);
            Controls.Add(lblDolar);
            Controls.Add(numDolar);
            Controls.Add(lblDolarBuy);
            Controls.Add(lblRatioSell);
            Controls.Add(lblArbitrationDiff);
            Controls.Add(lblComision);
            Controls.Add(numComision);
            Controls.Add(lblArbitrationLast);
            Controls.Add(lblOwnedLast);
            Controls.Add(grpOwnedCompra);
            Controls.Add(grpArbitrationVenta);
            Controls.Add(grpArbitrationCompra);
            Controls.Add(grpOwnedVenta);
            Controls.Add(lblHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmRatioTrade";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Operación de Arbitraje";
            Load += FrmArbitrationTrade_Load;
            grpOwnedVenta.ResumeLayout(false);
            grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaSize).EndInit();
            grpArbitrationCompra.ResumeLayout(false);
            grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numArbitrationCompraPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArbitrationCompraSize).EndInit();
            grpArbitrationVenta.ResumeLayout(false);
            grpArbitrationVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numArbitrationVentaPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArbitrationVentaSize).EndInit();
            grpOwnedCompra.ResumeLayout(false);
            grpOwnedCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOwnedCompraPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedCompraSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDolar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblOwnedVentaImporte;
        private System.Windows.Forms.Label lblOwnedComision;
        private System.Windows.Forms.NumericUpDown numOwnedVentaPrice;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblArbitrationCompraImporte;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraPrice;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpArbitrationVenta;
        private System.Windows.Forms.Label lblArbitrationVentaImporte;
        private System.Windows.Forms.Label lblArbitrationComision;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaPrice;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpOwnedCompra;
        private System.Windows.Forms.Label lblOwnedCompraImporte;
        private System.Windows.Forms.NumericUpDown numOwnedCompraPrice;
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
        private System.Windows.Forms.Label lblOwnedVentaCurrency;
        private System.Windows.Forms.Label lblArbitrationCompraCurrency;
        private System.Windows.Forms.Label lblArbitrationVentaCurrency;
        private System.Windows.Forms.Label lblOwnedCompraCurrency;
    }
}