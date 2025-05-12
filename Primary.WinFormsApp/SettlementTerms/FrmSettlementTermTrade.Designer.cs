namespace ChuchoBot.WinFormsApp
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermTrade));
            grpOwnedVenta = new System.Windows.Forms.GroupBox();
            lblSellPriceTarget = new System.Windows.Forms.Label();
            VentaBidsOffers = new BidsOffersControl();
            txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            lblVentaImporte = new System.Windows.Forms.Label();
            lblVentaComision = new System.Windows.Forms.Label();
            numVentaPrice = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            chkCuponUSD = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            numCupon = new System.Windows.Forms.NumericUpDown();
            lblBuyPriceTarget = new System.Windows.Forms.Label();
            lblCompraComision = new System.Windows.Forms.Label();
            CompraBidsOffers = new BidsOffersControl();
            txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            lblCompraImporte = new System.Windows.Forms.Label();
            numCompraPrice = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            numCompraSize = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHeader = new System.Windows.Forms.Label();
            lblDolar = new System.Windows.Forms.Label();
            numDolar = new System.Windows.Forms.NumericUpDown();
            lblComisionTotal = new System.Windows.Forms.Label();
            lblDifVentaCompra = new System.Windows.Forms.Label();
            lblProfitPesos = new System.Windows.Forms.Label();
            lnkArbitration = new System.Windows.Forms.LinkLabel();
            lblDiasCaucion = new System.Windows.Forms.Label();
            lblInteresCaucion = new System.Windows.Forms.Label();
            lblArancelCaucion = new System.Windows.Forms.Label();
            lblDerMerCaucion = new System.Windows.Forms.Label();
            lblGtoGtiaCaucion = new System.Windows.Forms.Label();
            lblIva = new System.Windows.Forms.Label();
            lblInteresNeto = new System.Windows.Forms.Label();
            grpCaucion = new System.Windows.Forms.GroupBox();
            lblMontoCaucion = new System.Windows.Forms.Label();
            lblGastosCaucion = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblNetoCaucion = new System.Windows.Forms.Label();
            settlementTermSettings1 = new SettlementTerms.SettlementTermSettings();
            chkWindowsToast = new System.Windows.Forms.CheckBox();
            numAlert = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVentaPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaSize).BeginInit();
            grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCupon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCompraPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCompraSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDolar).BeginInit();
            grpCaucion.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAlert).BeginInit();
            SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            grpOwnedVenta.Controls.Add(lblSellPriceTarget);
            grpOwnedVenta.Controls.Add(VentaBidsOffers);
            grpOwnedVenta.Controls.Add(txtOwnedVenta);
            grpOwnedVenta.Controls.Add(lblVentaImporte);
            grpOwnedVenta.Controls.Add(lblVentaComision);
            grpOwnedVenta.Controls.Add(numVentaPrice);
            grpOwnedVenta.Controls.Add(label2);
            grpOwnedVenta.Controls.Add(numOwnedVentaSize);
            grpOwnedVenta.Controls.Add(label1);
            grpOwnedVenta.Location = new System.Drawing.Point(26, 196);
            grpOwnedVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            grpOwnedVenta.Name = "grpOwnedVenta";
            grpOwnedVenta.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            grpOwnedVenta.Size = new System.Drawing.Size(778, 300);
            grpOwnedVenta.TabIndex = 4;
            grpOwnedVenta.TabStop = false;
            grpOwnedVenta.Text = "1. Venta de Bono en Cartera";
            // 
            // lblSellPriceTarget
            // 
            lblSellPriceTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSellPriceTarget.Location = new System.Drawing.Point(34, 168);
            lblSellPriceTarget.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSellPriceTarget.Name = "lblSellPriceTarget";
            lblSellPriceTarget.Size = new System.Drawing.Size(222, 29);
            lblSellPriceTarget.TabIndex = 30;
            lblSellPriceTarget.Text = "Precio Arbitrado:";
            lblSellPriceTarget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VentaBidsOffers
            // 
            VentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            VentaBidsOffers.InstrumentDetail = null;
            VentaBidsOffers.Location = new System.Drawing.Point(263, 24);
            VentaBidsOffers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            VentaBidsOffers.Name = "VentaBidsOffers";
            VentaBidsOffers.Size = new System.Drawing.Size(502, 224);
            VentaBidsOffers.TabIndex = 4;
            // 
            // txtOwnedVenta
            // 
            txtOwnedVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOwnedVenta.Location = new System.Drawing.Point(8, 259);
            txtOwnedVenta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            txtOwnedVenta.Name = "txtOwnedVenta";
            txtOwnedVenta.Size = new System.Drawing.Size(758, 37);
            txtOwnedVenta.TabIndex = 10;
            txtOwnedVenta.TabStop = true;
            txtOwnedVenta.Text = "Copiar";
            txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtOwnedVenta.LinkClicked += txtOwnedVenta_LinkClicked;
            // 
            // lblVentaImporte
            // 
            lblVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblVentaImporte.Location = new System.Drawing.Point(10, 112);
            lblVentaImporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblVentaImporte.Name = "lblVentaImporte";
            lblVentaImporte.Size = new System.Drawing.Size(246, 28);
            lblVentaImporte.TabIndex = 6;
            lblVentaImporte.Text = "Importe";
            lblVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVentaComision
            // 
            lblVentaComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblVentaComision.Location = new System.Drawing.Point(10, 140);
            lblVentaComision.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblVentaComision.Name = "lblVentaComision";
            lblVentaComision.Size = new System.Drawing.Size(246, 28);
            lblVentaComision.TabIndex = 5;
            lblVentaComision.Text = "Der.Mer./Comisión";
            lblVentaComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numVentaPrice
            // 
            numVentaPrice.DecimalPlaces = 2;
            numVentaPrice.ForeColor = System.Drawing.Color.Red;
            numVentaPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numVentaPrice.Location = new System.Drawing.Point(117, 69);
            numVentaPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numVentaPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numVentaPrice.Name = "numVentaPrice";
            numVentaPrice.Size = new System.Drawing.Size(139, 27);
            numVentaPrice.TabIndex = 3;
            numVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numVentaPrice.ValueChanged += numOwnedVentaPrice_ValueChanged;
            numVentaPrice.Enter += numVentaPrice_Enter;
            numVentaPrice.KeyPress += numOwnedVentaPrice_KeyPress;
            numVentaPrice.MouseClick += numVentaPrice_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 69);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // numOwnedVentaSize
            // 
            numOwnedVentaSize.Location = new System.Drawing.Point(117, 29);
            numOwnedVentaSize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numOwnedVentaSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numOwnedVentaSize.Name = "numOwnedVentaSize";
            numOwnedVentaSize.Size = new System.Drawing.Size(139, 27);
            numOwnedVentaSize.TabIndex = 1;
            numOwnedVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numOwnedVentaSize.ValueChanged += numOwnedVentaSize_ValueChanged;
            numOwnedVentaSize.Enter += numOwnedVentaSize_Enter;
            numOwnedVentaSize.KeyPress += numOwnedVentaSize_KeyPress;
            numOwnedVentaSize.MouseClick += numOwnedVentaSize_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 32);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Cant. Nom.:";
            // 
            // grpArbitrationCompra
            // 
            grpArbitrationCompra.Controls.Add(chkCuponUSD);
            grpArbitrationCompra.Controls.Add(label3);
            grpArbitrationCompra.Controls.Add(numCupon);
            grpArbitrationCompra.Controls.Add(lblBuyPriceTarget);
            grpArbitrationCompra.Controls.Add(lblCompraComision);
            grpArbitrationCompra.Controls.Add(CompraBidsOffers);
            grpArbitrationCompra.Controls.Add(txtArbitrationCompra);
            grpArbitrationCompra.Controls.Add(lblCompraImporte);
            grpArbitrationCompra.Controls.Add(numCompraPrice);
            grpArbitrationCompra.Controls.Add(label6);
            grpArbitrationCompra.Controls.Add(numCompraSize);
            grpArbitrationCompra.Controls.Add(label7);
            grpArbitrationCompra.Location = new System.Drawing.Point(814, 196);
            grpArbitrationCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            grpArbitrationCompra.Name = "grpArbitrationCompra";
            grpArbitrationCompra.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            grpArbitrationCompra.Size = new System.Drawing.Size(763, 300);
            grpArbitrationCompra.TabIndex = 5;
            grpArbitrationCompra.TabStop = false;
            grpArbitrationCompra.Text = "2. Compra de Bono a Arbitrar";
            // 
            // chkCuponUSD
            // 
            chkCuponUSD.AutoSize = true;
            chkCuponUSD.Location = new System.Drawing.Point(150, 232);
            chkCuponUSD.Name = "chkCuponUSD";
            chkCuponUSD.Size = new System.Drawing.Size(85, 24);
            chkCuponUSD.TabIndex = 33;
            chkCuponUSD.Text = "Es USD?";
            chkCuponUSD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(21, 205);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 29);
            label3.TabIndex = 32;
            label3.Text = "Cupón:";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCupon
            // 
            numCupon.DecimalPlaces = 2;
            numCupon.Location = new System.Drawing.Point(150, 201);
            numCupon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numCupon.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numCupon.Minimum = new decimal(new int[] { 10000000, 0, 0, int.MinValue });
            numCupon.Name = "numCupon";
            numCupon.Size = new System.Drawing.Size(106, 27);
            numCupon.TabIndex = 12;
            numCupon.ValueChanged += numCupon_ValueChanged;
            // 
            // lblBuyPriceTarget
            // 
            lblBuyPriceTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBuyPriceTarget.Location = new System.Drawing.Point(34, 168);
            lblBuyPriceTarget.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblBuyPriceTarget.Name = "lblBuyPriceTarget";
            lblBuyPriceTarget.Size = new System.Drawing.Size(222, 29);
            lblBuyPriceTarget.TabIndex = 31;
            lblBuyPriceTarget.Text = "Precio Arbitrado:";
            lblBuyPriceTarget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompraComision
            // 
            lblCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCompraComision.Location = new System.Drawing.Point(10, 140);
            lblCompraComision.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCompraComision.Name = "lblCompraComision";
            lblCompraComision.Size = new System.Drawing.Size(246, 28);
            lblCompraComision.TabIndex = 14;
            lblCompraComision.Text = "Der.Mer./Comisión";
            lblCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CompraBidsOffers
            // 
            CompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            CompraBidsOffers.InstrumentDetail = null;
            CompraBidsOffers.Location = new System.Drawing.Point(263, 24);
            CompraBidsOffers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CompraBidsOffers.Name = "CompraBidsOffers";
            CompraBidsOffers.Size = new System.Drawing.Size(496, 224);
            CompraBidsOffers.TabIndex = 4;
            // 
            // txtArbitrationCompra
            // 
            txtArbitrationCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArbitrationCompra.Location = new System.Drawing.Point(8, 259);
            txtArbitrationCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            txtArbitrationCompra.Name = "txtArbitrationCompra";
            txtArbitrationCompra.Size = new System.Drawing.Size(750, 37);
            txtArbitrationCompra.TabIndex = 12;
            txtArbitrationCompra.TabStop = true;
            txtArbitrationCompra.Text = "Copiar";
            txtArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtArbitrationCompra.LinkClicked += txtArbitrationCompra_LinkClicked;
            // 
            // lblCompraImporte
            // 
            lblCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCompraImporte.Location = new System.Drawing.Point(18, 112);
            lblCompraImporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCompraImporte.Name = "lblCompraImporte";
            lblCompraImporte.Size = new System.Drawing.Size(238, 28);
            lblCompraImporte.TabIndex = 6;
            lblCompraImporte.Text = "Importe";
            lblCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCompraPrice
            // 
            numCompraPrice.DecimalPlaces = 2;
            numCompraPrice.ForeColor = System.Drawing.Color.Red;
            numCompraPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numCompraPrice.Location = new System.Drawing.Point(112, 69);
            numCompraPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numCompraPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCompraPrice.Name = "numCompraPrice";
            numCompraPrice.Size = new System.Drawing.Size(144, 27);
            numCompraPrice.TabIndex = 3;
            numCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numCompraPrice.ValueChanged += numCompraPrice_ValueChanged;
            numCompraPrice.Enter += numCompraPrice_Enter;
            numCompraPrice.KeyPress += numArbitrationCompraPrice_KeyPress;
            numCompraPrice.MouseClick += numCompraPrice_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(34, 71);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 20);
            label6.TabIndex = 2;
            label6.Text = "Precio:";
            // 
            // numCompraSize
            // 
            numCompraSize.Location = new System.Drawing.Point(112, 29);
            numCompraSize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numCompraSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numCompraSize.Name = "numCompraSize";
            numCompraSize.Size = new System.Drawing.Size(144, 27);
            numCompraSize.TabIndex = 1;
            numCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numCompraSize.ValueChanged += numCompraSize_ValueChanged;
            numCompraSize.Enter += numCompraSize_Enter;
            numCompraSize.KeyPress += numCompraSize_KeyPress;
            numCompraSize.MouseClick += numCompraSize_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 32);
            label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(85, 20);
            label7.TabIndex = 0;
            label7.Text = "Cant. Nom.:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(1589, 67);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Profit: $ / %";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar
            // 
            lblDolar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblDolar.Location = new System.Drawing.Point(519, 92);
            lblDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new System.Drawing.Size(79, 28);
            lblDolar.TabIndex = 1;
            lblDolar.Text = "Dolar $:";
            lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            numDolar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numDolar.DecimalPlaces = 2;
            numDolar.Location = new System.Drawing.Point(606, 92);
            numDolar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numDolar.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDolar.Name = "numDolar";
            numDolar.Size = new System.Drawing.Size(106, 27);
            numDolar.TabIndex = 2;
            numDolar.Value = new decimal(new int[] { 98, 0, 0, 0 });
            numDolar.ValueChanged += numDolar_ValueChanged;
            // 
            // lblComisionTotal
            // 
            lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblComisionTotal.Location = new System.Drawing.Point(10, 33);
            lblComisionTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblComisionTotal.Name = "lblComisionTotal";
            lblComisionTotal.Size = new System.Drawing.Size(526, 28);
            lblComisionTotal.TabIndex = 12;
            lblComisionTotal.Text = "Total Comisión:";
            // 
            // lblDifVentaCompra
            // 
            lblDifVentaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDifVentaCompra.Location = new System.Drawing.Point(11, 120);
            lblDifVentaCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDifVentaCompra.Name = "lblDifVentaCompra";
            lblDifVentaCompra.Size = new System.Drawing.Size(513, 28);
            lblDifVentaCompra.TabIndex = 21;
            lblDifVentaCompra.Text = "Dif. Venta/Compra:";
            // 
            // lblProfitPesos
            // 
            lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblProfitPesos.Location = new System.Drawing.Point(11, 159);
            lblProfitPesos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblProfitPesos.Name = "lblProfitPesos";
            lblProfitPesos.Size = new System.Drawing.Size(513, 28);
            lblProfitPesos.TabIndex = 22;
            lblProfitPesos.Text = "Profit:";
            // 
            // lnkArbitration
            // 
            lnkArbitration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lnkArbitration.Location = new System.Drawing.Point(24, 91);
            lnkArbitration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lnkArbitration.Name = "lnkArbitration";
            lnkArbitration.Size = new System.Drawing.Size(487, 29);
            lnkArbitration.TabIndex = 0;
            lnkArbitration.TabStop = true;
            lnkArbitration.Text = "Copiar";
            lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkArbitration.LinkClicked += lnkArbitration_LinkClicked;
            // 
            // lblDiasCaucion
            // 
            lblDiasCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiasCaucion.Location = new System.Drawing.Point(16, 33);
            lblDiasCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDiasCaucion.Name = "lblDiasCaucion";
            lblDiasCaucion.Size = new System.Drawing.Size(341, 28);
            lblDiasCaucion.TabIndex = 23;
            lblDiasCaucion.Text = "Dias Caucion:";
            // 
            // lblInteresCaucion
            // 
            lblInteresCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInteresCaucion.Location = new System.Drawing.Point(16, 120);
            lblInteresCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblInteresCaucion.Name = "lblInteresCaucion";
            lblInteresCaucion.Size = new System.Drawing.Size(341, 28);
            lblInteresCaucion.TabIndex = 24;
            lblInteresCaucion.Text = "Interes Caucion:";
            // 
            // lblArancelCaucion
            // 
            lblArancelCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArancelCaucion.Location = new System.Drawing.Point(385, 33);
            lblArancelCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblArancelCaucion.Name = "lblArancelCaucion";
            lblArancelCaucion.Size = new System.Drawing.Size(375, 28);
            lblArancelCaucion.TabIndex = 25;
            lblArancelCaucion.Text = "Arancel";
            // 
            // lblDerMerCaucion
            // 
            lblDerMerCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDerMerCaucion.Location = new System.Drawing.Point(385, 77);
            lblDerMerCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDerMerCaucion.Name = "lblDerMerCaucion";
            lblDerMerCaucion.Size = new System.Drawing.Size(375, 28);
            lblDerMerCaucion.TabIndex = 26;
            lblDerMerCaucion.Text = "Der Mer";
            // 
            // lblGtoGtiaCaucion
            // 
            lblGtoGtiaCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGtoGtiaCaucion.Location = new System.Drawing.Point(385, 120);
            lblGtoGtiaCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblGtoGtiaCaucion.Name = "lblGtoGtiaCaucion";
            lblGtoGtiaCaucion.Size = new System.Drawing.Size(375, 28);
            lblGtoGtiaCaucion.TabIndex = 27;
            lblGtoGtiaCaucion.Text = "Gto Gtia";
            // 
            // lblIva
            // 
            lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIva.Location = new System.Drawing.Point(385, 159);
            lblIva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblIva.Name = "lblIva";
            lblIva.Size = new System.Drawing.Size(375, 28);
            lblIva.TabIndex = 28;
            lblIva.Text = "Iva";
            // 
            // lblInteresNeto
            // 
            lblInteresNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInteresNeto.Location = new System.Drawing.Point(16, 159);
            lblInteresNeto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblInteresNeto.Name = "lblInteresNeto";
            lblInteresNeto.Size = new System.Drawing.Size(341, 28);
            lblInteresNeto.TabIndex = 29;
            lblInteresNeto.Text = "Interes Neto";
            // 
            // grpCaucion
            // 
            grpCaucion.Controls.Add(lblMontoCaucion);
            grpCaucion.Controls.Add(lblGastosCaucion);
            grpCaucion.Controls.Add(lblDiasCaucion);
            grpCaucion.Controls.Add(lblIva);
            grpCaucion.Controls.Add(lblInteresNeto);
            grpCaucion.Controls.Add(lblGtoGtiaCaucion);
            grpCaucion.Controls.Add(lblInteresCaucion);
            grpCaucion.Controls.Add(lblDerMerCaucion);
            grpCaucion.Controls.Add(lblArancelCaucion);
            grpCaucion.Location = new System.Drawing.Point(27, 503);
            grpCaucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            grpCaucion.Name = "grpCaucion";
            grpCaucion.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            grpCaucion.Size = new System.Drawing.Size(774, 253);
            grpCaucion.TabIndex = 6;
            grpCaucion.TabStop = false;
            grpCaucion.Text = "Caucion";
            // 
            // lblMontoCaucion
            // 
            lblMontoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMontoCaucion.Location = new System.Drawing.Point(16, 77);
            lblMontoCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontoCaucion.Name = "lblMontoCaucion";
            lblMontoCaucion.Size = new System.Drawing.Size(341, 28);
            lblMontoCaucion.TabIndex = 31;
            lblMontoCaucion.Text = "Importe a Caucionar:";
            // 
            // lblGastosCaucion
            // 
            lblGastosCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGastosCaucion.Location = new System.Drawing.Point(385, 197);
            lblGastosCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblGastosCaucion.Name = "lblGastosCaucion";
            lblGastosCaucion.Size = new System.Drawing.Size(370, 28);
            lblGastosCaucion.TabIndex = 30;
            lblGastosCaucion.Text = "Total Gastos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNetoCaucion);
            groupBox2.Controls.Add(lblComisionTotal);
            groupBox2.Controls.Add(lblDifVentaCompra);
            groupBox2.Controls.Add(lblProfitPesos);
            groupBox2.Location = new System.Drawing.Point(814, 503);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Size = new System.Drawing.Size(763, 253);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Profit / Loss";
            // 
            // lblNetoCaucion
            // 
            lblNetoCaucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNetoCaucion.Location = new System.Drawing.Point(11, 77);
            lblNetoCaucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNetoCaucion.Name = "lblNetoCaucion";
            lblNetoCaucion.Size = new System.Drawing.Size(513, 28);
            lblNetoCaucion.TabIndex = 23;
            lblNetoCaucion.Text = "Caución:";
            // 
            // settlementTermSettings1
            // 
            settlementTermSettings1.Location = new System.Drawing.Point(720, 92);
            settlementTermSettings1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            settlementTermSettings1.Name = "settlementTermSettings1";
            settlementTermSettings1.Size = new System.Drawing.Size(857, 73);
            settlementTermSettings1.TabIndex = 3;
            // 
            // chkWindowsToast
            // 
            chkWindowsToast.AutoSize = true;
            chkWindowsToast.Checked = true;
            chkWindowsToast.CheckState = System.Windows.Forms.CheckState.Checked;
            chkWindowsToast.Location = new System.Drawing.Point(193, 135);
            chkWindowsToast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkWindowsToast.Name = "chkWindowsToast";
            chkWindowsToast.Size = new System.Drawing.Size(164, 24);
            chkWindowsToast.TabIndex = 31;
            chkWindowsToast.Text = "Mostrar notificacion";
            chkWindowsToast.UseVisualStyleBackColor = true;
            chkWindowsToast.CheckedChanged += chkWindowsToast_CheckedChanged;
            // 
            // numAlert
            // 
            numAlert.DecimalPlaces = 2;
            numAlert.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAlert.Location = new System.Drawing.Point(118, 133);
            numAlert.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numAlert.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numAlert.Name = "numAlert";
            numAlert.Size = new System.Drawing.Size(67, 27);
            numAlert.TabIndex = 30;
            numAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numAlert.Value = new decimal(new int[] { 15, 0, 0, 131072 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 136);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 20);
            label4.TabIndex = 32;
            label4.Text = "Alerta %:";
            // 
            // FrmSettlementTermTrade
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1589, 773);
            Controls.Add(label4);
            Controls.Add(chkWindowsToast);
            Controls.Add(numAlert);
            Controls.Add(settlementTermSettings1);
            Controls.Add(groupBox2);
            Controls.Add(grpCaucion);
            Controls.Add(lnkArbitration);
            Controls.Add(lblDolar);
            Controls.Add(numDolar);
            Controls.Add(lblHeader);
            Controls.Add(grpArbitrationCompra);
            Controls.Add(grpOwnedVenta);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FrmSettlementTermTrade";
            Text = "Operación de Arbitraje";
            Load += FrmArbitrationTrade_Load;
            grpOwnedVenta.ResumeLayout(false);
            grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVentaPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOwnedVentaSize).EndInit();
            grpArbitrationCompra.ResumeLayout(false);
            grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCupon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCompraPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCompraSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDolar).EndInit();
            grpCaucion.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAlert).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.CheckBox chkWindowsToast;
        private System.Windows.Forms.NumericUpDown numAlert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCuponUSD;
    }
}