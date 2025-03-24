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
            lblOwnedVentaCurrency = new System.Windows.Forms.Label();
            chkOwnedVenta = new System.Windows.Forms.CheckBox();
            OwnedVentaBidsOffers = new BidsOffersControl();
            txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            lblOwnedVentaImporte = new System.Windows.Forms.Label();
            lblOwnedComision = new System.Windows.Forms.Label();
            numOwnedVentaPrice = new System.Windows.Forms.NumericUpDown();
            numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            lblArbitrationCompraCurrency = new System.Windows.Forms.Label();
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
            lblArbitrationVentaCurrency = new System.Windows.Forms.Label();
            ArbitrationVentaBidsOffers = new BidsOffersControl();
            txtArbitrationVenta = new System.Windows.Forms.LinkLabel();
            lblArbitrationVentaImporte = new System.Windows.Forms.Label();
            lblArbitrationComision = new System.Windows.Forms.Label();
            numArbitrationVentaPrice = new System.Windows.Forms.NumericUpDown();
            numArbitrationVentaSize = new System.Windows.Forms.NumericUpDown();
            label12 = new System.Windows.Forms.Label();
            grpOwnedCompra = new System.Windows.Forms.GroupBox();
            lblOwnedCompraCurrency = new System.Windows.Forms.Label();
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
            label4 = new System.Windows.Forms.Label();
            chkWindowsToast = new System.Windows.Forms.CheckBox();
            numAlert = new System.Windows.Forms.NumericUpDown();
            txtAutoTrade = new System.Windows.Forms.TextBox();
            chkAutoTrade = new System.Windows.Forms.CheckBox();
            numAutoTradePercentage = new System.Windows.Forms.NumericUpDown();
            timerAutoTrade = new System.Windows.Forms.Timer(components);
            timerAutoTradeOperation = new System.Windows.Forms.Timer(components);
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
            ((System.ComponentModel.ISupportInitialize)numAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAutoTradePercentage).BeginInit();
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
            grpOwnedVenta.Location = new System.Drawing.Point(10, 112);
            grpOwnedVenta.Margin = new System.Windows.Forms.Padding(4);
            grpOwnedVenta.Name = "grpOwnedVenta";
            grpOwnedVenta.Padding = new System.Windows.Forms.Padding(4);
            grpOwnedVenta.Size = new System.Drawing.Size(689, 225);
            grpOwnedVenta.TabIndex = 1;
            grpOwnedVenta.TabStop = false;
            grpOwnedVenta.Text = "1. Venta de Instrumento A";
            // 
            // lblOwnedVentaCurrency
            // 
            lblOwnedVentaCurrency.AutoSize = true;
            lblOwnedVentaCurrency.Location = new System.Drawing.Point(94, 80);
            lblOwnedVentaCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedVentaCurrency.Name = "lblOwnedVentaCurrency";
            lblOwnedVentaCurrency.Size = new System.Drawing.Size(25, 13);
            lblOwnedVentaCurrency.TabIndex = 18;
            lblOwnedVentaCurrency.Text = "a $:";
            // 
            // chkOwnedVenta
            // 
            chkOwnedVenta.AutoSize = true;
            chkOwnedVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkOwnedVenta.Location = new System.Drawing.Point(80, 19);
            chkOwnedVenta.Margin = new System.Windows.Forms.Padding(4);
            chkOwnedVenta.Name = "chkOwnedVenta";
            chkOwnedVenta.Size = new System.Drawing.Size(124, 17);
            chkOwnedVenta.TabIndex = 17;
            chkOwnedVenta.Text = "Cantidad Automatica";
            chkOwnedVenta.UseVisualStyleBackColor = true;
            chkOwnedVenta.CheckedChanged += chkOwnedVenta_CheckedChanged;
            // 
            // OwnedVentaBidsOffers
            // 
            OwnedVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            OwnedVentaBidsOffers.InstrumentDetail = null;
            OwnedVentaBidsOffers.Location = new System.Drawing.Point(230, 19);
            OwnedVentaBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            OwnedVentaBidsOffers.Name = "OwnedVentaBidsOffers";
            OwnedVentaBidsOffers.Size = new System.Drawing.Size(452, 169);
            OwnedVentaBidsOffers.TabIndex = 11;
            // 
            // txtOwnedVenta
            // 
            txtOwnedVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOwnedVenta.Location = new System.Drawing.Point(7, 194);
            txtOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtOwnedVenta.Name = "txtOwnedVenta";
            txtOwnedVenta.Size = new System.Drawing.Size(662, 28);
            txtOwnedVenta.TabIndex = 10;
            txtOwnedVenta.TabStop = true;
            txtOwnedVenta.Text = "Copiar";
            txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtOwnedVenta.LinkClicked += txtOwnedVenta_LinkClicked;
            // 
            // lblOwnedVentaImporte
            // 
            lblOwnedVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedVentaImporte.Location = new System.Drawing.Point(10, 146);
            lblOwnedVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedVentaImporte.Name = "lblOwnedVentaImporte";
            lblOwnedVentaImporte.Size = new System.Drawing.Size(214, 21);
            lblOwnedVentaImporte.TabIndex = 6;
            lblOwnedVentaImporte.Text = "Importe";
            lblOwnedVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwnedComision
            // 
            lblOwnedComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedComision.Location = new System.Drawing.Point(10, 166);
            lblOwnedComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedComision.Name = "lblOwnedComision";
            lblOwnedComision.Size = new System.Drawing.Size(214, 21);
            lblOwnedComision.TabIndex = 5;
            lblOwnedComision.Text = "Comisión";
            lblOwnedComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedVentaPrice
            // 
            numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
            numOwnedVentaPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numOwnedVentaPrice.Location = new System.Drawing.Point(130, 79);
            numOwnedVentaPrice.Margin = new System.Windows.Forms.Padding(4);
            numOwnedVentaPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedVentaPrice.Name = "numOwnedVentaPrice";
            numOwnedVentaPrice.Size = new System.Drawing.Size(94, 20);
            numOwnedVentaPrice.TabIndex = 1;
            numOwnedVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedVentaPrice.ValueChanged += numOwnedVentaPrice_ValueChanged;
            numOwnedVentaPrice.Enter += numOwnedVentaPrice_Enter;
            numOwnedVentaPrice.KeyPress += numOwnedVentaPrice_KeyPress;
            // 
            // numOwnedVentaSize
            // 
            numOwnedVentaSize.Location = new System.Drawing.Point(130, 46);
            numOwnedVentaSize.Margin = new System.Windows.Forms.Padding(4);
            numOwnedVentaSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedVentaSize.Name = "numOwnedVentaSize";
            numOwnedVentaSize.Size = new System.Drawing.Size(94, 20);
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
            label1.Location = new System.Drawing.Point(63, 49);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
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
            grpArbitrationCompra.Location = new System.Drawing.Point(704, 112);
            grpArbitrationCompra.Margin = new System.Windows.Forms.Padding(4);
            grpArbitrationCompra.Name = "grpArbitrationCompra";
            grpArbitrationCompra.Padding = new System.Windows.Forms.Padding(4);
            grpArbitrationCompra.Size = new System.Drawing.Size(687, 225);
            grpArbitrationCompra.TabIndex = 8;
            grpArbitrationCompra.TabStop = false;
            grpArbitrationCompra.Text = "2. Compra de Instrumento B";
            // 
            // lblArbitrationCompraCurrency
            // 
            lblArbitrationCompraCurrency.AutoSize = true;
            lblArbitrationCompraCurrency.Location = new System.Drawing.Point(95, 79);
            lblArbitrationCompraCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationCompraCurrency.Name = "lblArbitrationCompraCurrency";
            lblArbitrationCompraCurrency.Size = new System.Drawing.Size(25, 15);
            lblArbitrationCompraCurrency.TabIndex = 17;
            lblArbitrationCompraCurrency.Text = "a $:";
            // 
            // chkArbitrationCompra
            // 
            chkArbitrationCompra.AutoSize = true;
            chkArbitrationCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkArbitrationCompra.Location = new System.Drawing.Point(80, 20);
            chkArbitrationCompra.Margin = new System.Windows.Forms.Padding(4);
            chkArbitrationCompra.Name = "chkArbitrationCompra";
            chkArbitrationCompra.Size = new System.Drawing.Size(139, 19);
            chkArbitrationCompra.TabIndex = 16;
            chkArbitrationCompra.Text = "Cantidad Automatica";
            chkArbitrationCompra.UseVisualStyleBackColor = true;
            chkArbitrationCompra.CheckedChanged += chkArbitrationCompra_CheckedChanged;
            // 
            // lblArbirtationCompraComision
            // 
            lblArbirtationCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbirtationCompraComision.Location = new System.Drawing.Point(10, 166);
            lblArbirtationCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbirtationCompraComision.Name = "lblArbirtationCompraComision";
            lblArbirtationCompraComision.Size = new System.Drawing.Size(214, 21);
            lblArbirtationCompraComision.TabIndex = 14;
            lblArbirtationCompraComision.Text = "Comisión";
            lblArbirtationCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ArbitrationCompraBidsOffers
            // 
            ArbitrationCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            ArbitrationCompraBidsOffers.InstrumentDetail = null;
            ArbitrationCompraBidsOffers.Location = new System.Drawing.Point(230, 19);
            ArbitrationCompraBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            ArbitrationCompraBidsOffers.Name = "ArbitrationCompraBidsOffers";
            ArbitrationCompraBidsOffers.Size = new System.Drawing.Size(452, 169);
            ArbitrationCompraBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationCompra
            // 
            txtArbitrationCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArbitrationCompra.Location = new System.Drawing.Point(7, 194);
            txtArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtArbitrationCompra.Name = "txtArbitrationCompra";
            txtArbitrationCompra.Size = new System.Drawing.Size(662, 28);
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
            lblArbitrationCompraImporte.Location = new System.Drawing.Point(7, 146);
            lblArbitrationCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationCompraImporte.Name = "lblArbitrationCompraImporte";
            lblArbitrationCompraImporte.Size = new System.Drawing.Size(217, 21);
            lblArbitrationCompraImporte.TabIndex = 6;
            lblArbitrationCompraImporte.Text = "Importe";
            lblArbitrationCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationCompraPrice
            // 
            numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
            numArbitrationCompraPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numArbitrationCompraPrice.Location = new System.Drawing.Point(130, 76);
            numArbitrationCompraPrice.Margin = new System.Windows.Forms.Padding(4);
            numArbitrationCompraPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationCompraPrice.Name = "numArbitrationCompraPrice";
            numArbitrationCompraPrice.Size = new System.Drawing.Size(94, 23);
            numArbitrationCompraPrice.TabIndex = 1;
            numArbitrationCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numArbitrationCompraPrice.ValueChanged += numArbitrationCompraPrice_ValueChanged;
            numArbitrationCompraPrice.Enter += numArbitrationCompraPrice_Enter;
            numArbitrationCompraPrice.KeyPress += numArbitrationCompraPrice_KeyPress;
            // 
            // numArbitrationCompraSize
            // 
            numArbitrationCompraSize.Location = new System.Drawing.Point(130, 46);
            numArbitrationCompraSize.Margin = new System.Windows.Forms.Padding(4);
            numArbitrationCompraSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationCompraSize.Name = "numArbitrationCompraSize";
            numArbitrationCompraSize.Size = new System.Drawing.Size(94, 23);
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
            label7.Location = new System.Drawing.Point(63, 49);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 15);
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
            grpArbitrationVenta.Location = new System.Drawing.Point(10, 356);
            grpArbitrationVenta.Margin = new System.Windows.Forms.Padding(4);
            grpArbitrationVenta.Name = "grpArbitrationVenta";
            grpArbitrationVenta.Padding = new System.Windows.Forms.Padding(4);
            grpArbitrationVenta.Size = new System.Drawing.Size(689, 225);
            grpArbitrationVenta.TabIndex = 12;
            grpArbitrationVenta.TabStop = false;
            grpArbitrationVenta.Text = "3. Venta de Instrumento B";
            // 
            // lblArbitrationVentaCurrency
            // 
            lblArbitrationVentaCurrency.AutoSize = true;
            lblArbitrationVentaCurrency.Location = new System.Drawing.Point(79, 53);
            lblArbitrationVentaCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationVentaCurrency.Name = "lblArbitrationVentaCurrency";
            lblArbitrationVentaCurrency.Size = new System.Drawing.Size(39, 15);
            lblArbitrationVentaCurrency.TabIndex = 14;
            lblArbitrationVentaCurrency.Text = "a U$S:";
            // 
            // ArbitrationVentaBidsOffers
            // 
            ArbitrationVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            ArbitrationVentaBidsOffers.InstrumentDetail = null;
            ArbitrationVentaBidsOffers.Location = new System.Drawing.Point(230, 21);
            ArbitrationVentaBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            ArbitrationVentaBidsOffers.Name = "ArbitrationVentaBidsOffers";
            ArbitrationVentaBidsOffers.Size = new System.Drawing.Size(452, 169);
            ArbitrationVentaBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationVenta
            // 
            txtArbitrationVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArbitrationVenta.Location = new System.Drawing.Point(7, 194);
            txtArbitrationVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtArbitrationVenta.Name = "txtArbitrationVenta";
            txtArbitrationVenta.Size = new System.Drawing.Size(662, 28);
            txtArbitrationVenta.TabIndex = 12;
            txtArbitrationVenta.TabStop = true;
            txtArbitrationVenta.Text = "Copiar";
            txtArbitrationVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtArbitrationVenta.LinkClicked += txtArbitrationVenta_LinkClicked;
            // 
            // lblArbitrationVentaImporte
            // 
            lblArbitrationVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationVentaImporte.Location = new System.Drawing.Point(18, 90);
            lblArbitrationVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationVentaImporte.Name = "lblArbitrationVentaImporte";
            lblArbitrationVentaImporte.Size = new System.Drawing.Size(206, 21);
            lblArbitrationVentaImporte.TabIndex = 6;
            lblArbitrationVentaImporte.Text = "Importe";
            lblArbitrationVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblArbitrationComision
            // 
            lblArbitrationComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationComision.Location = new System.Drawing.Point(10, 111);
            lblArbitrationComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationComision.Name = "lblArbitrationComision";
            lblArbitrationComision.Size = new System.Drawing.Size(214, 21);
            lblArbitrationComision.TabIndex = 5;
            lblArbitrationComision.Text = "Comisión";
            lblArbitrationComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationVentaPrice
            // 
            numArbitrationVentaPrice.DecimalPlaces = 2;
            numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
            numArbitrationVentaPrice.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numArbitrationVentaPrice.Location = new System.Drawing.Point(130, 52);
            numArbitrationVentaPrice.Margin = new System.Windows.Forms.Padding(4);
            numArbitrationVentaPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationVentaPrice.Name = "numArbitrationVentaPrice";
            numArbitrationVentaPrice.Size = new System.Drawing.Size(94, 23);
            numArbitrationVentaPrice.TabIndex = 1;
            numArbitrationVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numArbitrationVentaPrice.ValueChanged += numArbitrationVentaPrice_ValueChanged;
            numArbitrationVentaPrice.KeyPress += numArbitrationVentaPrice_KeyPress;
            // 
            // numArbitrationVentaSize
            // 
            numArbitrationVentaSize.Enabled = false;
            numArbitrationVentaSize.Location = new System.Drawing.Point(130, 22);
            numArbitrationVentaSize.Margin = new System.Windows.Forms.Padding(4);
            numArbitrationVentaSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numArbitrationVentaSize.Name = "numArbitrationVentaSize";
            numArbitrationVentaSize.Size = new System.Drawing.Size(94, 23);
            numArbitrationVentaSize.TabIndex = 0;
            numArbitrationVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(63, 24);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(58, 15);
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
            grpOwnedCompra.Location = new System.Drawing.Point(704, 356);
            grpOwnedCompra.Margin = new System.Windows.Forms.Padding(4);
            grpOwnedCompra.Name = "grpOwnedCompra";
            grpOwnedCompra.Padding = new System.Windows.Forms.Padding(4);
            grpOwnedCompra.Size = new System.Drawing.Size(687, 225);
            grpOwnedCompra.TabIndex = 9;
            grpOwnedCompra.TabStop = false;
            grpOwnedCompra.Text = "4. Compra de Instrumento A";
            // 
            // lblOwnedCompraCurrency
            // 
            lblOwnedCompraCurrency.AutoSize = true;
            lblOwnedCompraCurrency.Location = new System.Drawing.Point(80, 56);
            lblOwnedCompraCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraCurrency.Name = "lblOwnedCompraCurrency";
            lblOwnedCompraCurrency.Size = new System.Drawing.Size(39, 15);
            lblOwnedCompraCurrency.TabIndex = 16;
            lblOwnedCompraCurrency.Text = "a U$S:";
            // 
            // lblOwnedCompraComision
            // 
            lblOwnedCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedCompraComision.Location = new System.Drawing.Point(10, 111);
            lblOwnedCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraComision.Name = "lblOwnedCompraComision";
            lblOwnedCompraComision.Size = new System.Drawing.Size(214, 21);
            lblOwnedCompraComision.TabIndex = 15;
            lblOwnedCompraComision.Text = "Comisión";
            lblOwnedCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OwnedCompraBidsOffers
            // 
            OwnedCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            OwnedCompraBidsOffers.InstrumentDetail = null;
            OwnedCompraBidsOffers.Location = new System.Drawing.Point(230, 21);
            OwnedCompraBidsOffers.Margin = new System.Windows.Forms.Padding(0);
            OwnedCompraBidsOffers.Name = "OwnedCompraBidsOffers";
            OwnedCompraBidsOffers.Size = new System.Drawing.Size(452, 169);
            OwnedCompraBidsOffers.TabIndex = 14;
            // 
            // txtOwnedCompra
            // 
            txtOwnedCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOwnedCompra.Location = new System.Drawing.Point(10, 194);
            txtOwnedCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtOwnedCompra.Name = "txtOwnedCompra";
            txtOwnedCompra.Size = new System.Drawing.Size(662, 28);
            txtOwnedCompra.TabIndex = 13;
            txtOwnedCompra.TabStop = true;
            txtOwnedCompra.Text = "Copiar";
            txtOwnedCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtOwnedCompra.LinkClicked += txtOwnedCompra_LinkClicked;
            // 
            // lblOwnedCompraImporte
            // 
            lblOwnedCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedCompraImporte.Location = new System.Drawing.Point(14, 90);
            lblOwnedCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedCompraImporte.Name = "lblOwnedCompraImporte";
            lblOwnedCompraImporte.Size = new System.Drawing.Size(210, 21);
            lblOwnedCompraImporte.TabIndex = 6;
            lblOwnedCompraImporte.Text = "Importe";
            lblOwnedCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedCompraPrice
            // 
            numOwnedCompraPrice.DecimalPlaces = 2;
            numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
            numOwnedCompraPrice.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numOwnedCompraPrice.Location = new System.Drawing.Point(130, 54);
            numOwnedCompraPrice.Margin = new System.Windows.Forms.Padding(4);
            numOwnedCompraPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedCompraPrice.Name = "numOwnedCompraPrice";
            numOwnedCompraPrice.Size = new System.Drawing.Size(94, 23);
            numOwnedCompraPrice.TabIndex = 1;
            numOwnedCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedCompraPrice.ValueChanged += numOwnedCompraPrice_ValueChanged;
            numOwnedCompraPrice.KeyPress += numOwnedCompraPrice_KeyPress;
            // 
            // numOwnedCompraSize
            // 
            numOwnedCompraSize.Enabled = false;
            numOwnedCompraSize.Location = new System.Drawing.Point(130, 24);
            numOwnedCompraSize.Margin = new System.Windows.Forms.Padding(4);
            numOwnedCompraSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedCompraSize.Name = "numOwnedCompraSize";
            numOwnedCompraSize.Size = new System.Drawing.Size(94, 23);
            numOwnedCompraSize.TabIndex = 0;
            numOwnedCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(63, 26);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(58, 15);
            label17.TabIndex = 1;
            label17.Text = "Cantidad:";
            // 
            // lblOwnedLast
            // 
            lblOwnedLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOwnedLast.Location = new System.Drawing.Point(582, 75);
            lblOwnedLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnedLast.Name = "lblOwnedLast";
            lblOwnedLast.Size = new System.Drawing.Size(111, 24);
            lblOwnedLast.TabIndex = 9;
            lblOwnedLast.Text = "$ Last";
            lblOwnedLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationLast
            // 
            lblArbitrationLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationLast.Location = new System.Drawing.Point(778, 74);
            lblArbitrationLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationLast.Name = "lblArbitrationLast";
            lblArbitrationLast.Size = new System.Drawing.Size(108, 26);
            lblArbitrationLast.TabIndex = 13;
            lblArbitrationLast.Text = "$ Last";
            lblArbitrationLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numComision
            // 
            numComision.DecimalPlaces = 2;
            numComision.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numComision.Location = new System.Drawing.Point(1301, 77);
            numComision.Margin = new System.Windows.Forms.Padding(4);
            numComision.Name = "numComision";
            numComision.Size = new System.Drawing.Size(94, 23);
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
            lblHeader.Size = new System.Drawing.Size(1406, 64);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Profit: $ / %";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComision
            // 
            lblComision.Location = new System.Drawing.Point(1197, 79);
            lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(97, 21);
            lblComision.TabIndex = 15;
            lblComision.Text = "Comisión %:";
            lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationDiff
            // 
            lblArbitrationDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblArbitrationDiff.Location = new System.Drawing.Point(704, 76);
            lblArbitrationDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArbitrationDiff.Name = "lblArbitrationDiff";
            lblArbitrationDiff.Size = new System.Drawing.Size(70, 21);
            lblArbitrationDiff.TabIndex = 16;
            lblArbitrationDiff.Text = "%";
            lblArbitrationDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRatioSell
            // 
            lblRatioSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRatioSell.Location = new System.Drawing.Point(448, 76);
            lblRatioSell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRatioSell.Name = "lblRatioSell";
            lblRatioSell.Size = new System.Drawing.Size(127, 21);
            lblRatioSell.TabIndex = 17;
            lblRatioSell.Text = "Ratio Compra";
            lblRatioSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDolarBuy
            // 
            lblDolarBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDolarBuy.Location = new System.Drawing.Point(892, 77);
            lblDolarBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDolarBuy.Name = "lblDolarBuy";
            lblDolarBuy.Size = new System.Drawing.Size(122, 21);
            lblDolarBuy.TabIndex = 18;
            lblDolarBuy.Text = "Ratio Venta";
            lblDolarBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolar
            // 
            lblDolar.Location = new System.Drawing.Point(1021, 79);
            lblDolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new System.Drawing.Size(69, 21);
            lblDolar.TabIndex = 20;
            lblDolar.Text = "Dolar $:";
            lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            numDolar.DecimalPlaces = 2;
            numDolar.Location = new System.Drawing.Point(1096, 79);
            numDolar.Margin = new System.Windows.Forms.Padding(4);
            numDolar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDolar.Name = "numDolar";
            numDolar.Size = new System.Drawing.Size(94, 23);
            numDolar.TabIndex = 19;
            numDolar.Value = new decimal(new int[] { 98, 0, 0, 0 });
            numDolar.ValueChanged += numDolar_ValueChanged;
            // 
            // lblComisionTotal
            // 
            lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblComisionTotal.Location = new System.Drawing.Point(340, 586);
            lblComisionTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblComisionTotal.Name = "lblComisionTotal";
            lblComisionTotal.Size = new System.Drawing.Size(214, 21);
            lblComisionTotal.TabIndex = 12;
            lblComisionTotal.Text = "Total Comisión:";
            lblComisionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalProfit.Location = new System.Drawing.Point(561, 586);
            lblTotalProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new System.Drawing.Size(214, 21);
            lblTotalProfit.TabIndex = 21;
            lblTotalProfit.Text = "Total Ganancia:";
            lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitPesos
            // 
            lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblProfitPesos.Location = new System.Drawing.Point(781, 586);
            lblProfitPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProfitPesos.Name = "lblProfitPesos";
            lblProfitPesos.Size = new System.Drawing.Size(214, 21);
            lblProfitPesos.TabIndex = 22;
            lblProfitPesos.Text = "Total Ganancia:";
            lblProfitPesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkComprarNominales
            // 
            chkComprarNominales.AutoSize = true;
            chkComprarNominales.Location = new System.Drawing.Point(10, 587);
            chkComprarNominales.Margin = new System.Windows.Forms.Padding(4);
            chkComprarNominales.Name = "chkComprarNominales";
            chkComprarNominales.Size = new System.Drawing.Size(266, 19);
            chkComprarNominales.TabIndex = 23;
            chkComprarNominales.Text = "Utilizar ganancia para obtener más nominales";
            chkComprarNominales.UseVisualStyleBackColor = true;
            chkComprarNominales.CheckedChanged += chkComprarNominales_CheckedChanged;
            // 
            // lnkArbitration
            // 
            lnkArbitration.Location = new System.Drawing.Point(609, 328);
            lnkArbitration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnkArbitration.Name = "lnkArbitration";
            lnkArbitration.Size = new System.Drawing.Size(448, 24);
            lnkArbitration.TabIndex = 14;
            lnkArbitration.TabStop = true;
            lnkArbitration.Text = "Vender AL30D => Comprar LetraD => Vender Letra => Comprar AL30";
            lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkArbitration.LinkClicked += lnkArbitration_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label4.Location = new System.Drawing.Point(10, 13);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 35;
            label4.Text = "Alerta %:";
            // 
            // chkWindowsToast
            // 
            chkWindowsToast.AutoSize = true;
            chkWindowsToast.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chkWindowsToast.Checked = true;
            chkWindowsToast.CheckState = System.Windows.Forms.CheckState.Checked;
            chkWindowsToast.Location = new System.Drawing.Point(158, 12);
            chkWindowsToast.Name = "chkWindowsToast";
            chkWindowsToast.Size = new System.Drawing.Size(133, 19);
            chkWindowsToast.TabIndex = 34;
            chkWindowsToast.Text = "Mostrar notificacion";
            chkWindowsToast.UseVisualStyleBackColor = false;
            // 
            // numAlert
            // 
            numAlert.DecimalPlaces = 2;
            numAlert.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAlert.Location = new System.Drawing.Point(92, 11);
            numAlert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numAlert.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numAlert.Name = "numAlert";
            numAlert.Size = new System.Drawing.Size(59, 23);
            numAlert.TabIndex = 33;
            numAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numAlert.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtAutoTrade
            // 
            txtAutoTrade.Location = new System.Drawing.Point(10, 613);
            txtAutoTrade.Multiline = true;
            txtAutoTrade.Name = "txtAutoTrade";
            txtAutoTrade.Size = new System.Drawing.Size(1381, 173);
            txtAutoTrade.TabIndex = 36;
            // 
            // chkAutoTrade
            // 
            chkAutoTrade.AutoSize = true;
            chkAutoTrade.Location = new System.Drawing.Point(1111, 588);
            chkAutoTrade.Name = "chkAutoTrade";
            chkAutoTrade.Size = new System.Drawing.Size(214, 19);
            chkAutoTrade.TabIndex = 37;
            chkAutoTrade.Text = "Auto operar cuando % sea mayor a:";
            chkAutoTrade.UseVisualStyleBackColor = true;
            chkAutoTrade.CheckedChanged += chkAutoTrade_CheckedChanged;
            // 
            // numAutoTradePercentage
            // 
            numAutoTradePercentage.DecimalPlaces = 2;
            numAutoTradePercentage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAutoTradePercentage.Location = new System.Drawing.Point(1332, 586);
            numAutoTradePercentage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numAutoTradePercentage.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numAutoTradePercentage.Name = "numAutoTradePercentage";
            numAutoTradePercentage.Size = new System.Drawing.Size(59, 23);
            numAutoTradePercentage.TabIndex = 38;
            numAutoTradePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numAutoTradePercentage.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // timerAutoTrade
            // 
            timerAutoTrade.Interval = 3000;
            timerAutoTrade.Tick += timerAutoTrade_Tick;
            // 
            // timerAutoTradeOperation
            // 
            timerAutoTradeOperation.Interval = 1000;
            timerAutoTradeOperation.Tick += timerAutoTradeOperation_Tick;
            // 
            // FrmRatioTrade
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1406, 798);
            Controls.Add(numAutoTradePercentage);
            Controls.Add(chkAutoTrade);
            Controls.Add(txtAutoTrade);
            Controls.Add(label4);
            Controls.Add(chkWindowsToast);
            Controls.Add(numAlert);
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
            Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)numAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAutoTradePercentage).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkWindowsToast;
        private System.Windows.Forms.NumericUpDown numAlert;
        private System.Windows.Forms.TextBox txtAutoTrade;
        private System.Windows.Forms.CheckBox chkAutoTrade;
        private System.Windows.Forms.NumericUpDown numAutoTradePercentage;
        private System.Windows.Forms.Timer timerAutoTrade;
        private System.Windows.Forms.Timer timerAutoTradeOperation;
    }
}