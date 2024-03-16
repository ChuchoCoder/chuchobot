namespace Primary.WinFormsApp
{
    partial class FrmArbitrationAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArbitrationAnalyzer));
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyOwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numMinProfit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMEP = new System.Windows.Forms.CheckBox();
            this.chkCCL = new System.Windows.Forms.CheckBox();
            this.chkDolarDC = new System.Windows.Forms.CheckBox();
            this.chkDolarCD = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAlert = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExclude = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlert)).BeginInit();
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
            this.KeyArbitrationVenta,
            this.KeyOwnedCompra,
            this.Profit,
            this.ProfitLast,
            this.OwnedVenta,
            this.ArbitrationCompra,
            this.ArbitrationVenta,
            this.OwnedCompra,
            this.DolarCompra,
            this.DolarVenta,
            this.DolarCompraLast,
            this.DolarVentaLast});
            this.grdArbitration.Location = new System.Drawing.Point(3, 28);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.RowHeadersWidth = 51;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(1310, 422);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdArbitration_CellFormatting);
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // KeyOwnedVenta
            // 
            this.KeyOwnedVenta.DataPropertyName = "KeyOwnedVenta";
            this.KeyOwnedVenta.HeaderText = "1 Venta";
            this.KeyOwnedVenta.MinimumWidth = 6;
            this.KeyOwnedVenta.Name = "KeyOwnedVenta";
            this.KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            this.KeyArbitrationCompra.DataPropertyName = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.HeaderText = "2 Compra";
            this.KeyArbitrationCompra.MinimumWidth = 6;
            this.KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.ReadOnly = true;
            // 
            // KeyArbitrationVenta
            // 
            this.KeyArbitrationVenta.DataPropertyName = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.HeaderText = "3 Venta";
            this.KeyArbitrationVenta.MinimumWidth = 6;
            this.KeyArbitrationVenta.Name = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.ReadOnly = true;
            // 
            // KeyOwnedCompra
            // 
            this.KeyOwnedCompra.DataPropertyName = "KeyOwnedCompra";
            this.KeyOwnedCompra.HeaderText = "4 Compra";
            this.KeyOwnedCompra.MinimumWidth = 6;
            this.KeyOwnedCompra.Name = "KeyOwnedCompra";
            this.KeyOwnedCompra.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle1.Format = "P";
            dataGridViewCellStyle1.NullValue = null;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // ProfitLast
            // 
            this.ProfitLast.DataPropertyName = "ProfitLast";
            dataGridViewCellStyle2.Format = "P";
            this.ProfitLast.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProfitLast.HeaderText = "Profit Last";
            this.ProfitLast.MinimumWidth = 6;
            this.ProfitLast.Name = "ProfitLast";
            this.ProfitLast.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "OwnedVenta";
            dataGridViewCellStyle3.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.OwnedVenta.HeaderText = "SellThenBuy Venta";
            this.OwnedVenta.MinimumWidth = 6;
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "ArbitrationCompra";
            dataGridViewCellStyle4.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle4;
            this.ArbitrationCompra.HeaderText = "BuyThenSell Compra";
            this.ArbitrationCompra.MinimumWidth = 6;
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // ArbitrationVenta
            // 
            this.ArbitrationVenta.DataPropertyName = "ArbitrationVenta";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ArbitrationVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.ArbitrationVenta.HeaderText = "BuyThenSell Venta";
            this.ArbitrationVenta.MinimumWidth = 6;
            this.ArbitrationVenta.Name = "ArbitrationVenta";
            this.ArbitrationVenta.ReadOnly = true;
            // 
            // OwnedCompra
            // 
            this.OwnedCompra.DataPropertyName = "OwnedCompra";
            dataGridViewCellStyle6.Format = "C2";
            this.OwnedCompra.DefaultCellStyle = dataGridViewCellStyle6;
            this.OwnedCompra.HeaderText = "SellThenBuy Compra";
            this.OwnedCompra.MinimumWidth = 6;
            this.OwnedCompra.Name = "OwnedCompra";
            this.OwnedCompra.ReadOnly = true;
            // 
            // DolarCompra
            // 
            this.DolarCompra.DataPropertyName = "DolarCompra";
            dataGridViewCellStyle7.Format = "C2";
            this.DolarCompra.DefaultCellStyle = dataGridViewCellStyle7;
            this.DolarCompra.HeaderText = "Compra";
            this.DolarCompra.MinimumWidth = 6;
            this.DolarCompra.Name = "DolarCompra";
            this.DolarCompra.ReadOnly = true;
            // 
            // DolarVenta
            // 
            this.DolarVenta.DataPropertyName = "DolarVenta";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.DolarVenta.DefaultCellStyle = dataGridViewCellStyle8;
            this.DolarVenta.HeaderText = "Venta";
            this.DolarVenta.MinimumWidth = 6;
            this.DolarVenta.Name = "DolarVenta";
            this.DolarVenta.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "DolarCompraLast";
            dataGridViewCellStyle9.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle9;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.MinimumWidth = 6;
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "DolarVentaLast";
            dataGridViewCellStyle10.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle10;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.MinimumWidth = 6;
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numMinProfit
            // 
            this.numMinProfit.DecimalPlaces = 2;
            this.numMinProfit.Location = new System.Drawing.Point(99, 4);
            this.numMinProfit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMinProfit.Name = "numMinProfit";
            this.numMinProfit.Size = new System.Drawing.Size(56, 20);
            this.numMinProfit.TabIndex = 3;
            this.numMinProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinProfit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min Profit %:";
            // 
            // chkMEP
            // 
            this.chkMEP.AutoSize = true;
            this.chkMEP.Checked = true;
            this.chkMEP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMEP.Location = new System.Drawing.Point(172, 4);
            this.chkMEP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkMEP.Name = "chkMEP";
            this.chkMEP.Size = new System.Drawing.Size(129, 17);
            this.chkMEP.TabIndex = 5;
            this.chkMEP.Text = "Arbitrajes MEP ($ / D)";
            this.chkMEP.UseVisualStyleBackColor = true;
            // 
            // chkCCL
            // 
            this.chkCCL.AutoSize = true;
            this.chkCCL.Location = new System.Drawing.Point(302, 4);
            this.chkCCL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCCL.Name = "chkCCL";
            this.chkCCL.Size = new System.Drawing.Size(125, 17);
            this.chkCCL.TabIndex = 6;
            this.chkCCL.Text = "Arbitrajes CCL (C / $)";
            this.chkCCL.UseVisualStyleBackColor = true;
            // 
            // chkDolarDC
            // 
            this.chkDolarDC.AutoSize = true;
            this.chkDolarDC.Location = new System.Drawing.Point(428, 4);
            this.chkDolarDC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkDolarDC.Name = "chkDolarDC";
            this.chkDolarDC.Size = new System.Drawing.Size(98, 17);
            this.chkDolarDC.TabIndex = 7;
            this.chkDolarDC.Text = "Arbitrajes D / C";
            this.chkDolarDC.UseVisualStyleBackColor = true;
            // 
            // chkDolarCD
            // 
            this.chkDolarCD.AutoSize = true;
            this.chkDolarCD.Location = new System.Drawing.Point(526, 4);
            this.chkDolarCD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkDolarCD.Name = "chkDolarCD";
            this.chkDolarCD.Size = new System.Drawing.Size(98, 17);
            this.chkDolarCD.TabIndex = 8;
            this.chkDolarCD.Text = "Arbitrajes C / D";
            this.chkDolarCD.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(1136, 4);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 20);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alert %:";
            // 
            // numAlert
            // 
            this.numAlert.DecimalPlaces = 2;
            this.numAlert.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAlert.Location = new System.Drawing.Point(736, 5);
            this.numAlert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numAlert.Name = "numAlert";
            this.numAlert.Size = new System.Drawing.Size(51, 20);
            this.numAlert.TabIndex = 10;
            this.numAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAlert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlert.ValueChanged += new System.EventHandler(this.numAlert_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1090, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Exclude:";
            // 
            // txtExclude
            // 
            this.txtExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExclude.Location = new System.Drawing.Point(976, 4);
            this.txtExclude.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExclude.Name = "txtExclude";
            this.txtExclude.Size = new System.Drawing.Size(110, 20);
            this.txtExclude.TabIndex = 13;
            // 
            // FrmArbitrationAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExclude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAlert);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.chkDolarCD);
            this.Controls.Add(this.chkDolarDC);
            this.Controls.Add(this.chkCCL);
            this.Controls.Add(this.chkMEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinProfit);
            this.Controls.Add(this.grdArbitration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArbitrationAnalyzer";
            this.Text = "Scanner de arbitrajes";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
        private System.Windows.Forms.NumericUpDown numMinProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMEP;
        private System.Windows.Forms.CheckBox chkCCL;
        private System.Windows.Forms.CheckBox chkDolarDC;
        private System.Windows.Forms.CheckBox chkDolarCD;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAlert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExclude;
    }
}