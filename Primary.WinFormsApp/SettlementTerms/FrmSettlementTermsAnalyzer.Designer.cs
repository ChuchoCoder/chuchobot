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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermsAnalyzer));
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkOnlyProfitableTrades = new System.Windows.Forms.CheckBox();
            this.chkOnlyShowTradesWithTickersOwned = new System.Windows.Forms.CheckBox();
            this.settlementTermSettings = new Primary.WinFormsApp.SettlementTerms.SettlementTermSettings();
            this.KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpreadCaucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpreadLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArbitration
            // 
            this.grdArbitration.AllowUserToAddRows = false;
            this.grdArbitration.AllowUserToDeleteRows = false;
            this.grdArbitration.AllowUserToOrderColumns = true;
            this.grdArbitration.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdArbitration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArbitration.CausesValidation = false;
            this.grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyOwnedVenta,
            this.KeyArbitrationCompra,
            this.SpreadCaucion,
            this.TNA,
            this.Spread,
            this.SpreadLast,
            this.PL,
            this.ProfitPercentage,
            this.Caucion,
            this.Comision,
            this.OwnedVenta,
            this.SellTotal,
            this.BuyTotal,
            this.ArbitrationCompra,
            this.DolarCompraLast,
            this.DolarVentaLast});
            this.grdArbitration.Location = new System.Drawing.Point(12, 64);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.RowHeadersWidth = 51;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(1374, 374);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArbitration_CellContentClick);
            this.grdArbitration.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdArbitration_CellFormatting);
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkOnlyProfitableTrades
            // 
            this.chkOnlyProfitableTrades.Location = new System.Drawing.Point(12, 38);
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
            this.chkOnlyShowTradesWithTickersOwned.Location = new System.Drawing.Point(12, 12);
            this.chkOnlyShowTradesWithTickersOwned.Name = "chkOnlyShowTradesWithTickersOwned";
            this.chkOnlyShowTradesWithTickersOwned.Size = new System.Drawing.Size(298, 19);
            this.chkOnlyShowTradesWithTickersOwned.TabIndex = 25;
            this.chkOnlyShowTradesWithTickersOwned.Text = "Ver sólo arbitrajes según instrumentos en cartera";
            this.chkOnlyShowTradesWithTickersOwned.UseVisualStyleBackColor = true;
            // 
            // settlementTermSettings
            // 
            this.settlementTermSettings.Location = new System.Drawing.Point(316, 9);
            this.settlementTermSettings.Name = "settlementTermSettings";
            this.settlementTermSettings.Size = new System.Drawing.Size(643, 48);
            this.settlementTermSettings.TabIndex = 26;
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
            // SpreadCaucion
            // 
            this.SpreadCaucion.DataPropertyName = "SpreadCaucion";
            dataGridViewCellStyle2.Format = "P";
            this.SpreadCaucion.DefaultCellStyle = dataGridViewCellStyle2;
            this.SpreadCaucion.HeaderText = "Spread TNA - Caucion";
            this.SpreadCaucion.Name = "SpreadCaucion";
            this.SpreadCaucion.ReadOnly = true;
            // 
            // TNA
            // 
            this.TNA.DataPropertyName = "TNA";
            dataGridViewCellStyle3.Format = "P";
            this.TNA.DefaultCellStyle = dataGridViewCellStyle3;
            this.TNA.HeaderText = "Spread TNA";
            this.TNA.MinimumWidth = 10;
            this.TNA.Name = "TNA";
            this.TNA.ReadOnly = true;
            // 
            // Spread
            // 
            this.Spread.DataPropertyName = "Spread";
            dataGridViewCellStyle4.Format = "P";
            dataGridViewCellStyle4.NullValue = null;
            this.Spread.DefaultCellStyle = dataGridViewCellStyle4;
            this.Spread.HeaderText = "Spread %";
            this.Spread.MinimumWidth = 6;
            this.Spread.Name = "Spread";
            this.Spread.ReadOnly = true;
            // 
            // SpreadLast
            // 
            this.SpreadLast.DataPropertyName = "SpreadLast";
            dataGridViewCellStyle5.Format = "P";
            this.SpreadLast.DefaultCellStyle = dataGridViewCellStyle5;
            this.SpreadLast.HeaderText = "Spread % Last";
            this.SpreadLast.MinimumWidth = 6;
            this.SpreadLast.Name = "SpreadLast";
            this.SpreadLast.ReadOnly = true;
            this.SpreadLast.Visible = false;
            // 
            // PL
            // 
            this.PL.DataPropertyName = "Profit";
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            this.PL.DefaultCellStyle = dataGridViewCellStyle6;
            this.PL.HeaderText = "P&L $";
            this.PL.MinimumWidth = 6;
            this.PL.Name = "PL";
            this.PL.ReadOnly = true;
            // 
            // ProfitPercentage
            // 
            this.ProfitPercentage.DataPropertyName = "ProfitPercentage";
            dataGridViewCellStyle7.Format = "P";
            this.ProfitPercentage.DefaultCellStyle = dataGridViewCellStyle7;
            this.ProfitPercentage.HeaderText = "P&L %";
            this.ProfitPercentage.Name = "ProfitPercentage";
            this.ProfitPercentage.ReadOnly = true;
            // 
            // Caucion
            // 
            this.Caucion.DataPropertyName = "Caucion";
            dataGridViewCellStyle8.Format = "C0";
            this.Caucion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Caucion.HeaderText = "Caucion";
            this.Caucion.MinimumWidth = 6;
            this.Caucion.Name = "Caucion";
            this.Caucion.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            dataGridViewCellStyle9.Format = "C0";
            this.Comision.DefaultCellStyle = dataGridViewCellStyle9;
            this.Comision.HeaderText = "Comision";
            this.Comision.MinimumWidth = 6;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "Venta";
            dataGridViewCellStyle10.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle10;
            this.OwnedVenta.HeaderText = "Venta";
            this.OwnedVenta.MinimumWidth = 6;
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // SellTotal
            // 
            this.SellTotal.DataPropertyName = "SellTotal";
            dataGridViewCellStyle11.Format = "C0";
            this.SellTotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.SellTotal.HeaderText = "Total Venta";
            this.SellTotal.MinimumWidth = 6;
            this.SellTotal.Name = "SellTotal";
            this.SellTotal.ReadOnly = true;
            this.SellTotal.Visible = false;
            // 
            // BuyTotal
            // 
            this.BuyTotal.DataPropertyName = "BuyTotal";
            dataGridViewCellStyle12.Format = "C0";
            this.BuyTotal.DefaultCellStyle = dataGridViewCellStyle12;
            this.BuyTotal.HeaderText = "Total Compra";
            this.BuyTotal.MinimumWidth = 6;
            this.BuyTotal.Name = "BuyTotal";
            this.BuyTotal.ReadOnly = true;
            this.BuyTotal.Visible = false;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "Compra";
            dataGridViewCellStyle13.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle13;
            this.ArbitrationCompra.HeaderText = "Compra";
            this.ArbitrationCompra.MinimumWidth = 6;
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "CompraLast";
            dataGridViewCellStyle14.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle14;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.MinimumWidth = 6;
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            this.DolarCompraLast.Visible = false;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "VentaLast";
            dataGridViewCellStyle15.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle15;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.MinimumWidth = 6;
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
            this.DolarVentaLast.Visible = false;
            // 
            // FrmSettlementTermsAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 450);
            this.Controls.Add(this.settlementTermSettings);
            this.Controls.Add(this.chkOnlyShowTradesWithTickersOwned);
            this.Controls.Add(this.chkOnlyProfitableTrades);
            this.Controls.Add(this.grdArbitration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettlementTermsAnalyzer";
            this.Text = "Arbitrajes de Plazo";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn SpreadCaucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spread;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpreadLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn PL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
    }
}