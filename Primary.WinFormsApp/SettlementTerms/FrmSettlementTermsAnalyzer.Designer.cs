namespace ChuchoBot.WinFormsApp
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
            var dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            var dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermsAnalyzer));
            grdArbitration = new System.Windows.Forms.DataGridView();
            KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProfitPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SpreadCaucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Spread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SpreadLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Caucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BuyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            chkOnlyProfitableTrades = new System.Windows.Forms.CheckBox();
            chkOnlyShowTradesWithTickersOwned = new System.Windows.Forms.CheckBox();
            settlementTermSettings = new SettlementTerms.SettlementTermSettings();
            label2 = new System.Windows.Forms.Label();
            numAlert = new System.Windows.Forms.NumericUpDown();
            chkWindowsToast = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            txtExclude = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            numMinPL = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)grdArbitration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinPL).BeginInit();
            SuspendLayout();
            // 
            // grdArbitration
            // 
            grdArbitration.AllowUserToAddRows = false;
            grdArbitration.AllowUserToDeleteRows = false;
            grdArbitration.AllowUserToOrderColumns = true;
            grdArbitration.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            grdArbitration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdArbitration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grdArbitration.CausesValidation = false;
            grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { KeyOwnedVenta, KeyArbitrationCompra, PL, ProfitPercentage, SpreadCaucion, TNA, Spread, SpreadLast, Caucion, Comision, OwnedVenta, SellTotal, BuyTotal, ArbitrationCompra, DolarCompraLast, DolarVentaLast });
            grdArbitration.Location = new System.Drawing.Point(16, 99);
            grdArbitration.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            grdArbitration.Name = "grdArbitration";
            grdArbitration.ReadOnly = true;
            grdArbitration.RowHeadersVisible = false;
            grdArbitration.RowHeadersWidth = 51;
            grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdArbitration.ShowCellErrors = false;
            grdArbitration.ShowEditingIcon = false;
            grdArbitration.ShowRowErrors = false;
            grdArbitration.Size = new System.Drawing.Size(1832, 576);
            grdArbitration.TabIndex = 2;
            grdArbitration.CellContentClick += grdArbitration_CellContentClick;
            grdArbitration.CellFormatting += grdArbitration_CellFormatting;
            grdArbitration.DoubleClick += grdArbitration_DoubleClick;
            // 
            // KeyOwnedVenta
            // 
            KeyOwnedVenta.DataPropertyName = "KeyVenta";
            KeyOwnedVenta.HeaderText = "1 Venta";
            KeyOwnedVenta.MinimumWidth = 6;
            KeyOwnedVenta.Name = "KeyOwnedVenta";
            KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            KeyArbitrationCompra.DataPropertyName = "KeyCompra";
            KeyArbitrationCompra.HeaderText = "2 Compra";
            KeyArbitrationCompra.MinimumWidth = 6;
            KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            KeyArbitrationCompra.ReadOnly = true;
            // 
            // PL
            // 
            PL.DataPropertyName = "Profit";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            PL.DefaultCellStyle = dataGridViewCellStyle2;
            PL.HeaderText = "P&L $";
            PL.MinimumWidth = 6;
            PL.Name = "PL";
            PL.ReadOnly = true;
            // 
            // ProfitPercentage
            // 
            ProfitPercentage.DataPropertyName = "ProfitPercentage";
            dataGridViewCellStyle3.Format = "P";
            ProfitPercentage.DefaultCellStyle = dataGridViewCellStyle3;
            ProfitPercentage.HeaderText = "P&L %";
            ProfitPercentage.MinimumWidth = 6;
            ProfitPercentage.Name = "ProfitPercentage";
            ProfitPercentage.ReadOnly = true;
            // 
            // SpreadCaucion
            // 
            SpreadCaucion.DataPropertyName = "SpreadCaucion";
            dataGridViewCellStyle4.Format = "P";
            SpreadCaucion.DefaultCellStyle = dataGridViewCellStyle4;
            SpreadCaucion.HeaderText = "Spread TNA - Caucion";
            SpreadCaucion.MinimumWidth = 6;
            SpreadCaucion.Name = "SpreadCaucion";
            SpreadCaucion.ReadOnly = true;
            // 
            // TNA
            // 
            TNA.DataPropertyName = "TNA";
            dataGridViewCellStyle5.Format = "P";
            TNA.DefaultCellStyle = dataGridViewCellStyle5;
            TNA.HeaderText = "Spread TNA";
            TNA.MinimumWidth = 10;
            TNA.Name = "TNA";
            TNA.ReadOnly = true;
            // 
            // Spread
            // 
            Spread.DataPropertyName = "Spread";
            dataGridViewCellStyle6.Format = "P";
            dataGridViewCellStyle6.NullValue = null;
            Spread.DefaultCellStyle = dataGridViewCellStyle6;
            Spread.HeaderText = "Spread %";
            Spread.MinimumWidth = 6;
            Spread.Name = "Spread";
            Spread.ReadOnly = true;
            // 
            // SpreadLast
            // 
            SpreadLast.DataPropertyName = "SpreadLast";
            dataGridViewCellStyle7.Format = "P";
            SpreadLast.DefaultCellStyle = dataGridViewCellStyle7;
            SpreadLast.HeaderText = "Spread % Last";
            SpreadLast.MinimumWidth = 6;
            SpreadLast.Name = "SpreadLast";
            SpreadLast.ReadOnly = true;
            SpreadLast.Visible = false;
            // 
            // Caucion
            // 
            Caucion.DataPropertyName = "Caucion";
            dataGridViewCellStyle8.Format = "C0";
            Caucion.DefaultCellStyle = dataGridViewCellStyle8;
            Caucion.HeaderText = "Caucion";
            Caucion.MinimumWidth = 6;
            Caucion.Name = "Caucion";
            Caucion.ReadOnly = true;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Comision";
            dataGridViewCellStyle9.Format = "C0";
            Comision.DefaultCellStyle = dataGridViewCellStyle9;
            Comision.HeaderText = "Comision";
            Comision.MinimumWidth = 6;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            OwnedVenta.DataPropertyName = "Venta";
            dataGridViewCellStyle10.Format = "C2";
            OwnedVenta.DefaultCellStyle = dataGridViewCellStyle10;
            OwnedVenta.HeaderText = "Venta";
            OwnedVenta.MinimumWidth = 6;
            OwnedVenta.Name = "OwnedVenta";
            OwnedVenta.ReadOnly = true;
            // 
            // SellTotal
            // 
            SellTotal.DataPropertyName = "SellTotal";
            dataGridViewCellStyle11.Format = "C0";
            SellTotal.DefaultCellStyle = dataGridViewCellStyle11;
            SellTotal.HeaderText = "Total Venta";
            SellTotal.MinimumWidth = 6;
            SellTotal.Name = "SellTotal";
            SellTotal.ReadOnly = true;
            SellTotal.Visible = false;
            // 
            // BuyTotal
            // 
            BuyTotal.DataPropertyName = "BuyTotal";
            dataGridViewCellStyle12.Format = "C0";
            BuyTotal.DefaultCellStyle = dataGridViewCellStyle12;
            BuyTotal.HeaderText = "Total Compra";
            BuyTotal.MinimumWidth = 6;
            BuyTotal.Name = "BuyTotal";
            BuyTotal.ReadOnly = true;
            BuyTotal.Visible = false;
            // 
            // ArbitrationCompra
            // 
            ArbitrationCompra.DataPropertyName = "Compra";
            dataGridViewCellStyle13.Format = "C2";
            ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle13;
            ArbitrationCompra.HeaderText = "Compra";
            ArbitrationCompra.MinimumWidth = 6;
            ArbitrationCompra.Name = "ArbitrationCompra";
            ArbitrationCompra.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            DolarCompraLast.DataPropertyName = "CompraLast";
            dataGridViewCellStyle14.Format = "C2";
            DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle14;
            DolarCompraLast.HeaderText = "Compra Last";
            DolarCompraLast.MinimumWidth = 6;
            DolarCompraLast.Name = "DolarCompraLast";
            DolarCompraLast.ReadOnly = true;
            DolarCompraLast.Visible = false;
            // 
            // DolarVentaLast
            // 
            DolarVentaLast.DataPropertyName = "VentaLast";
            dataGridViewCellStyle15.Format = "C2";
            DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle15;
            DolarVentaLast.HeaderText = "Venta Last";
            DolarVentaLast.MinimumWidth = 6;
            DolarVentaLast.Name = "DolarVentaLast";
            DolarVentaLast.ReadOnly = true;
            DolarVentaLast.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // chkOnlyProfitableTrades
            // 
            chkOnlyProfitableTrades.Location = new System.Drawing.Point(16, 59);
            chkOnlyProfitableTrades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chkOnlyProfitableTrades.Name = "chkOnlyProfitableTrades";
            chkOnlyProfitableTrades.Size = new System.Drawing.Size(278, 29);
            chkOnlyProfitableTrades.TabIndex = 24;
            chkOnlyProfitableTrades.Text = "Ver sólo arbitrajes con profit";
            chkOnlyProfitableTrades.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowTradesWithTickersOwned
            // 
            chkOnlyShowTradesWithTickersOwned.Checked = true;
            chkOnlyShowTradesWithTickersOwned.CheckState = System.Windows.Forms.CheckState.Checked;
            chkOnlyShowTradesWithTickersOwned.Location = new System.Drawing.Point(16, 19);
            chkOnlyShowTradesWithTickersOwned.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chkOnlyShowTradesWithTickersOwned.Name = "chkOnlyShowTradesWithTickersOwned";
            chkOnlyShowTradesWithTickersOwned.Size = new System.Drawing.Size(398, 29);
            chkOnlyShowTradesWithTickersOwned.TabIndex = 25;
            chkOnlyShowTradesWithTickersOwned.Text = "Ver sólo arbitrajes según instrumentos en cartera";
            chkOnlyShowTradesWithTickersOwned.UseVisualStyleBackColor = true;
            // 
            // settlementTermSettings
            // 
            settlementTermSettings.Location = new System.Drawing.Point(422, 13);
            settlementTermSettings.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            settlementTermSettings.Name = "settlementTermSettings";
            settlementTermSettings.Size = new System.Drawing.Size(857, 73);
            settlementTermSettings.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1312, 17);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 20);
            label2.TabIndex = 28;
            label2.Text = "Alerta %:";
            // 
            // numAlert
            // 
            numAlert.DecimalPlaces = 2;
            numAlert.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAlert.Location = new System.Drawing.Point(1414, 13);
            numAlert.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numAlert.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numAlert.Name = "numAlert";
            numAlert.Size = new System.Drawing.Size(67, 27);
            numAlert.TabIndex = 27;
            numAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numAlert.Value = new decimal(new int[] { 15, 0, 0, 131072 });
            // 
            // chkWindowsToast
            // 
            chkWindowsToast.AutoSize = true;
            chkWindowsToast.Checked = true;
            chkWindowsToast.CheckState = System.Windows.Forms.CheckState.Checked;
            chkWindowsToast.Location = new System.Drawing.Point(1688, 14);
            chkWindowsToast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkWindowsToast.Name = "chkWindowsToast";
            chkWindowsToast.Size = new System.Drawing.Size(164, 24);
            chkWindowsToast.TabIndex = 29;
            chkWindowsToast.Text = "Mostrar notificacion";
            chkWindowsToast.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1312, 63);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 20);
            label1.TabIndex = 30;
            label1.Text = "Excluir tickers:";
            // 
            // txtExclude
            // 
            txtExclude.Location = new System.Drawing.Point(1414, 56);
            txtExclude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtExclude.Name = "txtExclude";
            txtExclude.Size = new System.Drawing.Size(434, 27);
            txtExclude.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1491, 17);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 20);
            label3.TabIndex = 33;
            label3.Text = "Min P&L $:";
            // 
            // numMinPL
            // 
            numMinPL.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMinPL.Location = new System.Drawing.Point(1569, 13);
            numMinPL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numMinPL.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMinPL.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numMinPL.Name = "numMinPL";
            numMinPL.Size = new System.Drawing.Size(107, 27);
            numMinPL.TabIndex = 32;
            numMinPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numMinPL.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // FrmSettlementTermsAnalyzer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1864, 692);
            Controls.Add(label3);
            Controls.Add(numMinPL);
            Controls.Add(txtExclude);
            Controls.Add(label1);
            Controls.Add(chkWindowsToast);
            Controls.Add(label2);
            Controls.Add(numAlert);
            Controls.Add(settlementTermSettings);
            Controls.Add(chkOnlyShowTradesWithTickersOwned);
            Controls.Add(chkOnlyProfitableTrades);
            Controls.Add(grdArbitration);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "FrmSettlementTermsAnalyzer";
            Text = "Arbitrajes de Plazo";
            Load += FrmArbitrationBestTrades_Load;
            ((System.ComponentModel.ISupportInitialize)grdArbitration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinPL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLast;
        private System.Windows.Forms.CheckBox chkOnlyProfitableTrades;
        private System.Windows.Forms.CheckBox chkOnlyShowTradesWithTickersOwned;
        private SettlementTerms.SettlementTermSettings settlementTermSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpreadCaucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spread;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpreadLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAlert;
        private System.Windows.Forms.CheckBox chkWindowsToast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMinPL;
    }
}