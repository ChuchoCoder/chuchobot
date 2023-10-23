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
            this.chkOnlyProfitableTrades = new System.Windows.Forms.CheckBox();
            this.chkOnlyShowTradesWithTickersOwned = new System.Windows.Forms.CheckBox();
            this.settlementTermSettings = new Primary.WinFormsApp.SettlementTerms.SettlementTermSettings();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
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
        private SettlementTerms.SettlementTermSettings settlementTermSettings;
    }
}