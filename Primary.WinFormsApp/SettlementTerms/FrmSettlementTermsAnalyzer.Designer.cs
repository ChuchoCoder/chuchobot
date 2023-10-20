namespace Primary.WinFormsApp
{
    partial class FrmSettlementTermsAnalyzer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermsAnalyzer));
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpreadLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numComisionTomadora = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBuySellSize = new System.Windows.Forms.NumericUpDown();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTasa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkDolarD = new System.Windows.Forms.CheckBox();
            this.chkPesos = new System.Windows.Forms.CheckBox();
            this.numDiasLiq24H = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDiasLiq48H = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numComisionColocadora = new System.Windows.Forms.NumericUpDown();
            this.chkOnlyProfitableTrades = new System.Windows.Forms.CheckBox();
            this.chkOnlyShowTradesWithTickersOwned = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuySellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq24H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq48H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArbitration
            // 
            this.grdArbitration.AllowUserToAddRows = false;
            this.grdArbitration.AllowUserToDeleteRows = false;
            this.grdArbitration.AllowUserToOrderColumns = true;
            this.grdArbitration.AllowUserToResizeRows = false;
            this.grdArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArbitration.CausesValidation = false;
            this.grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyOwnedVenta,
            this.KeyArbitrationCompra,
            this.TNA,
            this.Spread,
            this.SpreadLast,
            this.PL,
            this.Caucion,
            this.Comision,
            this.OwnedVenta,
            this.SellTotal,
            this.BuyTotal,
            this.ArbitrationCompra,
            this.DolarCompraLast,
            this.DolarVentaLast});
            this.grdArbitration.Location = new System.Drawing.Point(12, 74);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.RowHeadersWidth = 51;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(1374, 364);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArbitration_CellContentClick);
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // KeyOwnedVenta
            // 
            this.KeyOwnedVenta.DataPropertyName = "KeyVenta";
            this.KeyOwnedVenta.HeaderText = "1 Venta";
            this.KeyOwnedVenta.MinimumWidth = 6;
            this.KeyOwnedVenta.Name = "KeyOwnedVenta";
            this.KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            this.KeyArbitrationCompra.DataPropertyName = "KeyCompra";
            this.KeyArbitrationCompra.HeaderText = "2 Compra";
            this.KeyArbitrationCompra.MinimumWidth = 6;
            this.KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.ReadOnly = true;
            // 
            // TNA
            // 
            this.TNA.DataPropertyName = "TNA";
            dataGridViewCellStyle1.Format = "P";
            this.TNA.DefaultCellStyle = dataGridViewCellStyle1;
            this.TNA.HeaderText = "Spread TNA";
            this.TNA.MinimumWidth = 10;
            this.TNA.Name = "TNA";
            this.TNA.ReadOnly = true;
            // 
            // Spread
            // 
            this.Spread.DataPropertyName = "Spread";
            dataGridViewCellStyle2.Format = "P";
            dataGridViewCellStyle2.NullValue = null;
            this.Spread.DefaultCellStyle = dataGridViewCellStyle2;
            this.Spread.HeaderText = "Spread";
            this.Spread.MinimumWidth = 6;
            this.Spread.Name = "Spread";
            this.Spread.ReadOnly = true;
            // 
            // SpreadLast
            // 
            this.SpreadLast.DataPropertyName = "SpreadLast";
            dataGridViewCellStyle3.Format = "P";
            this.SpreadLast.DefaultCellStyle = dataGridViewCellStyle3;
            this.SpreadLast.HeaderText = "Spread Last";
            this.SpreadLast.MinimumWidth = 6;
            this.SpreadLast.Name = "SpreadLast";
            this.SpreadLast.ReadOnly = true;
            // 
            // PL
            // 
            this.PL.DataPropertyName = "Profit";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.PL.DefaultCellStyle = dataGridViewCellStyle4;
            this.PL.HeaderText = "P&L";
            this.PL.MinimumWidth = 6;
            this.PL.Name = "PL";
            this.PL.ReadOnly = true;
            // 
            // Caucion
            // 
            this.Caucion.DataPropertyName = "Caucion";
            dataGridViewCellStyle5.Format = "C0";
            this.Caucion.DefaultCellStyle = dataGridViewCellStyle5;
            this.Caucion.HeaderText = "Caucion";
            this.Caucion.MinimumWidth = 6;
            this.Caucion.Name = "Caucion";
            this.Caucion.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            dataGridViewCellStyle6.Format = "C0";
            this.Comision.DefaultCellStyle = dataGridViewCellStyle6;
            this.Comision.HeaderText = "Comision";
            this.Comision.MinimumWidth = 6;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "Venta";
            dataGridViewCellStyle7.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.OwnedVenta.HeaderText = "Venta";
            this.OwnedVenta.MinimumWidth = 6;
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // SellTotal
            // 
            this.SellTotal.DataPropertyName = "SellTotal";
            dataGridViewCellStyle8.Format = "C0";
            this.SellTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.SellTotal.HeaderText = "Total Venta";
            this.SellTotal.MinimumWidth = 6;
            this.SellTotal.Name = "SellTotal";
            this.SellTotal.ReadOnly = true;
            this.SellTotal.Visible = false;
            // 
            // BuyTotal
            // 
            this.BuyTotal.DataPropertyName = "BuyTotal";
            dataGridViewCellStyle9.Format = "C0";
            this.BuyTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.BuyTotal.HeaderText = "Total Compra";
            this.BuyTotal.MinimumWidth = 6;
            this.BuyTotal.Name = "BuyTotal";
            this.BuyTotal.ReadOnly = true;
            this.BuyTotal.Visible = false;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "Compra";
            dataGridViewCellStyle10.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.ArbitrationCompra.HeaderText = "Compra";
            this.ArbitrationCompra.MinimumWidth = 6;
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "CompraLast";
            dataGridViewCellStyle11.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle11;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.MinimumWidth = 6;
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            this.DolarCompraLast.Visible = false;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "VentaLast";
            dataGridViewCellStyle12.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle12;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.MinimumWidth = 6;
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
            this.DolarVentaLast.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comision Operación%:";
            // 
            // numComisionTomadora
            // 
            this.numComisionTomadora.DecimalPlaces = 3;
            this.numComisionTomadora.Location = new System.Drawing.Point(264, 2);
            this.numComisionTomadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionTomadora.Name = "numComisionTomadora";
            this.numComisionTomadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionTomadora.TabIndex = 6;
            this.numComisionTomadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionTomadora.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numComisionTomadora.ValueChanged += new System.EventHandler(this.numComisionTomadora_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nominales a usar: ";
            this.label3.Visible = false;
            // 
            // numBuySellSize
            // 
            this.numBuySellSize.Location = new System.Drawing.Point(672, 28);
            this.numBuySellSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBuySellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBuySellSize.Name = "numBuySellSize";
            this.numBuySellSize.Size = new System.Drawing.Size(82, 20);
            this.numBuySellSize.TabIndex = 8;
            this.numBuySellSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBuySellSize.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBuySellSize.Visible = false;
            // 
            // numComision
            // 
            this.numComision.DecimalPlaces = 2;
            this.numComision.Location = new System.Drawing.Point(469, 28);
            this.numComision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(82, 20);
            this.numComision.TabIndex = 10;
            this.numComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComision.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numComision.ValueChanged += new System.EventHandler(this.numComision_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comision Tomadora (TNA):";
            // 
            // numTasa
            // 
            this.numTasa.DecimalPlaces = 2;
            this.numTasa.Location = new System.Drawing.Point(469, 2);
            this.numTasa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTasa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTasa.Name = "numTasa";
            this.numTasa.Size = new System.Drawing.Size(82, 20);
            this.numTasa.TabIndex = 14;
            this.numTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTasa.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.numTasa.ValueChanged += new System.EventHandler(this.numTasa_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tasa Caucion%: ";
            // 
            // chkDolarD
            // 
            this.chkDolarD.AutoSize = true;
            this.chkDolarD.Enabled = false;
            this.chkDolarD.Location = new System.Drawing.Point(12, 26);
            this.chkDolarD.Margin = new System.Windows.Forms.Padding(2);
            this.chkDolarD.Name = "chkDolarD";
            this.chkDolarD.Size = new System.Drawing.Size(104, 17);
            this.chkDolarD.TabIndex = 16;
            this.chkDolarD.Text = "Títulos en D o C";
            this.chkDolarD.UseVisualStyleBackColor = true;
            // 
            // chkPesos
            // 
            this.chkPesos.AutoSize = true;
            this.chkPesos.Checked = true;
            this.chkPesos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPesos.Location = new System.Drawing.Point(12, 5);
            this.chkPesos.Margin = new System.Windows.Forms.Padding(2);
            this.chkPesos.Name = "chkPesos";
            this.chkPesos.Size = new System.Drawing.Size(83, 17);
            this.chkPesos.TabIndex = 17;
            this.chkPesos.Text = "Títulos en $";
            this.chkPesos.UseVisualStyleBackColor = true;
            // 
            // numDiasLiq24H
            // 
            this.numDiasLiq24H.Location = new System.Drawing.Point(672, 3);
            this.numDiasLiq24H.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiasLiq24H.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDiasLiq24H.Name = "numDiasLiq24H";
            this.numDiasLiq24H.Size = new System.Drawing.Size(82, 20);
            this.numDiasLiq24H.TabIndex = 18;
            this.numDiasLiq24H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiasLiq24H.ValueChanged += new System.EventHandler(this.numFeriados24H_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dias para Liq. 24H: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dias para Liq. 48H:";
            // 
            // numDiasLiq48H
            // 
            this.numDiasLiq48H.Location = new System.Drawing.Point(866, 3);
            this.numDiasLiq48H.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiasLiq48H.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDiasLiq48H.Name = "numDiasLiq48H";
            this.numDiasLiq48H.Size = new System.Drawing.Size(82, 20);
            this.numDiasLiq48H.TabIndex = 20;
            this.numDiasLiq48H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Comision Colocadora (TNA):";
            // 
            // numComisionColocadora
            // 
            this.numComisionColocadora.DecimalPlaces = 3;
            this.numComisionColocadora.Location = new System.Drawing.Point(263, 27);
            this.numComisionColocadora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionColocadora.Name = "numComisionColocadora";
            this.numComisionColocadora.Size = new System.Drawing.Size(82, 20);
            this.numComisionColocadora.TabIndex = 23;
            this.numComisionColocadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionColocadora.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numComisionColocadora.ValueChanged += new System.EventHandler(this.numComisionColocadora_ValueChanged);
            // 
            // chkOnlyProfitableTrades
            // 
            this.chkOnlyProfitableTrades.Location = new System.Drawing.Point(12, 48);
            this.chkOnlyProfitableTrades.Name = "chkOnlyProfitableTrades";
            this.chkOnlyProfitableTrades.Size = new System.Drawing.Size(208, 19);
            this.chkOnlyProfitableTrades.TabIndex = 24;
            this.chkOnlyProfitableTrades.Text = "Ver sólo arbitrajes con profit";
            this.chkOnlyProfitableTrades.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowTradesWithTickersOwned
            // 
            this.chkOnlyShowTradesWithTickersOwned.Checked = true;
            this.chkOnlyShowTradesWithTickersOwned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyShowTradesWithTickersOwned.Location = new System.Drawing.Point(261, 49);
            this.chkOnlyShowTradesWithTickersOwned.Name = "chkOnlyShowTradesWithTickersOwned";
            this.chkOnlyShowTradesWithTickersOwned.Size = new System.Drawing.Size(405, 19);
            this.chkOnlyShowTradesWithTickersOwned.TabIndex = 25;
            this.chkOnlyShowTradesWithTickersOwned.Text = "Ver sólo arbitrajes según instrumentos en cartera";
            this.chkOnlyShowTradesWithTickersOwned.UseVisualStyleBackColor = true;
            // 
            // FrmSettlementTermsAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 450);
            this.Controls.Add(this.chkOnlyShowTradesWithTickersOwned);
            this.Controls.Add(this.chkOnlyProfitableTrades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numComisionColocadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDiasLiq48H);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDiasLiq24H);
            this.Controls.Add(this.chkPesos);
            this.Controls.Add(this.chkDolarD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numBuySellSize);
            this.Controls.Add(this.numComisionTomadora);
            this.Controls.Add(this.grdArbitration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettlementTermsAnalyzer";
            this.Text = "Arbitrajes de Plazo";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionTomadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuySellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq24H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasLiq48H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionColocadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComisionTomadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBuySellSize;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLast;
        private System.Windows.Forms.NumericUpDown numTasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDolarD;
        private System.Windows.Forms.CheckBox chkPesos;
        private System.Windows.Forms.NumericUpDown numDiasLiq24H;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDiasLiq48H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numComisionColocadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spread;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpreadLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn PL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
        private System.Windows.Forms.CheckBox chkOnlyProfitableTrades;
        private System.Windows.Forms.CheckBox chkOnlyShowTradesWithTickersOwned;
    }
}