namespace ChuchoBot.WinFormsApp
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
            components = new System.ComponentModel.Container();
            var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArbitrationAnalyzer));
            grdArbitration = new System.Windows.Forms.DataGridView();
            KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KeyArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KeyOwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProfitLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            numMinProfit = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            chkMEP = new System.Windows.Forms.CheckBox();
            chkCCL = new System.Windows.Forms.CheckBox();
            chkDolarDC = new System.Windows.Forms.CheckBox();
            chkDolarCD = new System.Windows.Forms.CheckBox();
            txtFilter = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            numAlert = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtExclude = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)grdArbitration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinProfit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlert).BeginInit();
            SuspendLayout();
            // 
            // grdArbitration
            // 
            grdArbitration.AllowUserToAddRows = false;
            grdArbitration.AllowUserToDeleteRows = false;
            grdArbitration.AllowUserToOrderColumns = true;
            grdArbitration.AllowUserToResizeRows = false;
            grdArbitration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grdArbitration.CausesValidation = false;
            grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { KeyOwnedVenta, KeyArbitrationCompra, KeyArbitrationVenta, KeyOwnedCompra, Profit, ProfitLast, OwnedVenta, ArbitrationCompra, ArbitrationVenta, OwnedCompra, DolarCompra, DolarVenta, DolarCompraLast, DolarVentaLast });
            grdArbitration.Location = new System.Drawing.Point(4, 32);
            grdArbitration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grdArbitration.Name = "grdArbitration";
            grdArbitration.ReadOnly = true;
            grdArbitration.RowHeadersVisible = false;
            grdArbitration.RowHeadersWidth = 51;
            grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdArbitration.ShowCellErrors = false;
            grdArbitration.ShowEditingIcon = false;
            grdArbitration.ShowRowErrors = false;
            grdArbitration.Size = new System.Drawing.Size(1528, 487);
            grdArbitration.TabIndex = 2;
            grdArbitration.CellFormatting += grdArbitration_CellFormatting;
            grdArbitration.DoubleClick += grdArbitration_DoubleClick;
            // 
            // KeyOwnedVenta
            // 
            KeyOwnedVenta.DataPropertyName = "KeyOwnedVenta";
            KeyOwnedVenta.HeaderText = "1 Venta";
            KeyOwnedVenta.MinimumWidth = 6;
            KeyOwnedVenta.Name = "KeyOwnedVenta";
            KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            KeyArbitrationCompra.DataPropertyName = "KeyArbitrationCompra";
            KeyArbitrationCompra.HeaderText = "2 Compra";
            KeyArbitrationCompra.MinimumWidth = 6;
            KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            KeyArbitrationCompra.ReadOnly = true;
            // 
            // KeyArbitrationVenta
            // 
            KeyArbitrationVenta.DataPropertyName = "KeyArbitrationVenta";
            KeyArbitrationVenta.HeaderText = "3 Venta";
            KeyArbitrationVenta.MinimumWidth = 6;
            KeyArbitrationVenta.Name = "KeyArbitrationVenta";
            KeyArbitrationVenta.ReadOnly = true;
            // 
            // KeyOwnedCompra
            // 
            KeyOwnedCompra.DataPropertyName = "KeyOwnedCompra";
            KeyOwnedCompra.HeaderText = "4 Compra";
            KeyOwnedCompra.MinimumWidth = 6;
            KeyOwnedCompra.Name = "KeyOwnedCompra";
            KeyOwnedCompra.ReadOnly = true;
            // 
            // Profit
            // 
            Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle1.Format = "P";
            dataGridViewCellStyle1.NullValue = null;
            Profit.DefaultCellStyle = dataGridViewCellStyle1;
            Profit.HeaderText = "Profit";
            Profit.MinimumWidth = 6;
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            // 
            // ProfitLast
            // 
            ProfitLast.DataPropertyName = "ProfitLast";
            dataGridViewCellStyle2.Format = "P";
            ProfitLast.DefaultCellStyle = dataGridViewCellStyle2;
            ProfitLast.HeaderText = "Profit Last";
            ProfitLast.MinimumWidth = 6;
            ProfitLast.Name = "ProfitLast";
            ProfitLast.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            OwnedVenta.DataPropertyName = "OwnedVenta";
            dataGridViewCellStyle3.Format = "C2";
            OwnedVenta.DefaultCellStyle = dataGridViewCellStyle3;
            OwnedVenta.HeaderText = "SellThenBuy Venta";
            OwnedVenta.MinimumWidth = 6;
            OwnedVenta.Name = "OwnedVenta";
            OwnedVenta.ReadOnly = true;
            // 
            // ArbitrationCompra
            // 
            ArbitrationCompra.DataPropertyName = "ArbitrationCompra";
            dataGridViewCellStyle4.Format = "C2";
            ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle4;
            ArbitrationCompra.HeaderText = "BuyThenSell Compra";
            ArbitrationCompra.MinimumWidth = 6;
            ArbitrationCompra.Name = "ArbitrationCompra";
            ArbitrationCompra.ReadOnly = true;
            // 
            // ArbitrationVenta
            // 
            ArbitrationVenta.DataPropertyName = "ArbitrationVenta";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            ArbitrationVenta.DefaultCellStyle = dataGridViewCellStyle5;
            ArbitrationVenta.HeaderText = "BuyThenSell Venta";
            ArbitrationVenta.MinimumWidth = 6;
            ArbitrationVenta.Name = "ArbitrationVenta";
            ArbitrationVenta.ReadOnly = true;
            // 
            // OwnedCompra
            // 
            OwnedCompra.DataPropertyName = "OwnedCompra";
            dataGridViewCellStyle6.Format = "C2";
            OwnedCompra.DefaultCellStyle = dataGridViewCellStyle6;
            OwnedCompra.HeaderText = "SellThenBuy Compra";
            OwnedCompra.MinimumWidth = 6;
            OwnedCompra.Name = "OwnedCompra";
            OwnedCompra.ReadOnly = true;
            // 
            // DolarCompra
            // 
            DolarCompra.DataPropertyName = "DolarCompra";
            dataGridViewCellStyle7.Format = "C2";
            DolarCompra.DefaultCellStyle = dataGridViewCellStyle7;
            DolarCompra.HeaderText = "Compra";
            DolarCompra.MinimumWidth = 6;
            DolarCompra.Name = "DolarCompra";
            DolarCompra.ReadOnly = true;
            // 
            // DolarVenta
            // 
            DolarVenta.DataPropertyName = "DolarVenta";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            DolarVenta.DefaultCellStyle = dataGridViewCellStyle8;
            DolarVenta.HeaderText = "Venta";
            DolarVenta.MinimumWidth = 6;
            DolarVenta.Name = "DolarVenta";
            DolarVenta.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            DolarCompraLast.DataPropertyName = "DolarCompraLast";
            dataGridViewCellStyle9.Format = "C2";
            DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle9;
            DolarCompraLast.HeaderText = "Compra Last";
            DolarCompraLast.MinimumWidth = 6;
            DolarCompraLast.Name = "DolarCompraLast";
            DolarCompraLast.ReadOnly = true;
            // 
            // DolarVentaLast
            // 
            DolarVentaLast.DataPropertyName = "DolarVentaLast";
            dataGridViewCellStyle10.Format = "C2";
            DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle10;
            DolarVentaLast.HeaderText = "Venta Last";
            DolarVentaLast.MinimumWidth = 6;
            DolarVentaLast.Name = "DolarVentaLast";
            DolarVentaLast.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // numMinProfit
            // 
            numMinProfit.DecimalPlaces = 2;
            numMinProfit.Location = new System.Drawing.Point(115, 5);
            numMinProfit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numMinProfit.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numMinProfit.Name = "numMinProfit";
            numMinProfit.Size = new System.Drawing.Size(65, 23);
            numMinProfit.TabIndex = 3;
            numMinProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numMinProfit.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Min Profit %:";
            // 
            // chkMEP
            // 
            chkMEP.AutoSize = true;
            chkMEP.Checked = true;
            chkMEP.CheckState = System.Windows.Forms.CheckState.Checked;
            chkMEP.Location = new System.Drawing.Point(201, 5);
            chkMEP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkMEP.Name = "chkMEP";
            chkMEP.Size = new System.Drawing.Size(139, 19);
            chkMEP.TabIndex = 5;
            chkMEP.Text = "Arbitrajes MEP ($ / D)";
            chkMEP.UseVisualStyleBackColor = true;
            // 
            // chkCCL
            // 
            chkCCL.AutoSize = true;
            chkCCL.Location = new System.Drawing.Point(352, 5);
            chkCCL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkCCL.Name = "chkCCL";
            chkCCL.Size = new System.Drawing.Size(137, 19);
            chkCCL.TabIndex = 6;
            chkCCL.Text = "Arbitrajes CCL (C / $)";
            chkCCL.UseVisualStyleBackColor = true;
            // 
            // chkDolarDC
            // 
            chkDolarDC.AutoSize = true;
            chkDolarDC.Location = new System.Drawing.Point(499, 5);
            chkDolarDC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkDolarDC.Name = "chkDolarDC";
            chkDolarDC.Size = new System.Drawing.Size(106, 19);
            chkDolarDC.TabIndex = 7;
            chkDolarDC.Text = "Arbitrajes D / C";
            chkDolarDC.UseVisualStyleBackColor = true;
            // 
            // chkDolarCD
            // 
            chkDolarCD.AutoSize = true;
            chkDolarCD.Location = new System.Drawing.Point(614, 5);
            chkDolarCD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkDolarCD.Name = "chkDolarCD";
            chkDolarCD.Size = new System.Drawing.Size(106, 19);
            chkDolarCD.TabIndex = 8;
            chkDolarCD.Text = "Arbitrajes C / D";
            chkDolarCD.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtFilter.Location = new System.Drawing.Point(1325, 5);
            txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(196, 23);
            txtFilter.TabIndex = 9;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(789, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Alerta %:";
            // 
            // numAlert
            // 
            numAlert.DecimalPlaces = 2;
            numAlert.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAlert.Location = new System.Drawing.Point(859, 6);
            numAlert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numAlert.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numAlert.Name = "numAlert";
            numAlert.Size = new System.Drawing.Size(59, 23);
            numAlert.TabIndex = 10;
            numAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numAlert.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numAlert.ValueChanged += numAlert_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1272, 7);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Filtrar:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1066, 7);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 14;
            label4.Text = "Excluir:";
            // 
            // txtExclude
            // 
            txtExclude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtExclude.Location = new System.Drawing.Point(1139, 5);
            txtExclude.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtExclude.Name = "txtExclude";
            txtExclude.Size = new System.Drawing.Size(128, 23);
            txtExclude.TabIndex = 13;
            // 
            // FrmArbitrationAnalyzer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1532, 519);
            Controls.Add(label4);
            Controls.Add(txtExclude);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numAlert);
            Controls.Add(txtFilter);
            Controls.Add(chkDolarCD);
            Controls.Add(chkDolarDC);
            Controls.Add(chkCCL);
            Controls.Add(chkMEP);
            Controls.Add(label1);
            Controls.Add(numMinProfit);
            Controls.Add(grdArbitration);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmArbitrationAnalyzer";
            Text = "Scanner de arbitrajes";
            Load += FrmArbitrationBestTrades_Load;
            ((System.ComponentModel.ISupportInitialize)grdArbitration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinProfit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlert).EndInit();
            ResumeLayout(false);
            PerformLayout();
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