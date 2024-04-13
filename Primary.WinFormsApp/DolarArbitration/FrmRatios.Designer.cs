namespace ChuchoBot.WinFormsApp.DolarArbitration
{
    partial class FrmRatios
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatios));
            grdRatios = new System.Windows.Forms.DataGridView();
            tmr = new System.Windows.Forms.Timer(components);
            Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RatioLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RatioVariacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RatioYesterday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AlertLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AlertGreater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GDBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ALOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RatioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GDOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ALBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RatioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdRatios).BeginInit();
            SuspendLayout();
            // 
            // grdRatios
            // 
            grdRatios.AllowUserToAddRows = false;
            grdRatios.AllowUserToDeleteRows = false;
            grdRatios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            grdRatios.CausesValidation = false;
            grdRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRatios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Ratio, RatioLast, RatioVariacion, RatioYesterday, AlertLower, AlertGreater, GDBid, ALOffer, RatioCompra, GDOffer, ALBid, RatioVenta });
            grdRatios.Dock = System.Windows.Forms.DockStyle.Fill;
            grdRatios.Location = new System.Drawing.Point(0, 0);
            grdRatios.Margin = new System.Windows.Forms.Padding(2);
            grdRatios.Name = "grdRatios";
            grdRatios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdRatios.ShowCellErrors = false;
            grdRatios.ShowRowErrors = false;
            grdRatios.Size = new System.Drawing.Size(1087, 256);
            grdRatios.TabIndex = 0;
            grdRatios.CellValueChanged += grdRatios_CellValueChanged;
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Interval = 3000;
            tmr.Tick += tmr_Tick;
            // 
            // Ratio
            // 
            Ratio.DataPropertyName = "Ratio";
            Ratio.HeaderText = "Ratio";
            Ratio.Name = "Ratio";
            Ratio.ReadOnly = true;
            Ratio.Width = 59;
            // 
            // RatioLast
            // 
            RatioLast.DataPropertyName = "RatioLast";
            dataGridViewCellStyle1.Format = "P";
            RatioLast.DefaultCellStyle = dataGridViewCellStyle1;
            RatioLast.HeaderText = "Ult.";
            RatioLast.Name = "RatioLast";
            RatioLast.ReadOnly = true;
            RatioLast.Width = 50;
            // 
            // RatioVariacion
            // 
            RatioVariacion.DataPropertyName = "RatioVariacion";
            dataGridViewCellStyle2.Format = "P";
            RatioVariacion.DefaultCellStyle = dataGridViewCellStyle2;
            RatioVariacion.HeaderText = "Variacion";
            RatioVariacion.Name = "RatioVariacion";
            RatioVariacion.ReadOnly = true;
            RatioVariacion.Width = 80;
            // 
            // RatioYesterday
            // 
            RatioYesterday.DataPropertyName = "RatioYesterday";
            dataGridViewCellStyle3.Format = "P";
            RatioYesterday.DefaultCellStyle = dataGridViewCellStyle3;
            RatioYesterday.HeaderText = "Cierre";
            RatioYesterday.Name = "RatioYesterday";
            RatioYesterday.ReadOnly = true;
            RatioYesterday.Width = 63;
            // 
            // AlertLower
            // 
            AlertLower.DataPropertyName = "AlertLower";
            AlertLower.HeaderText = "Alert <=";
            AlertLower.Name = "AlertLower";
            AlertLower.Width = 76;
            // 
            // AlertGreater
            // 
            AlertGreater.DataPropertyName = "AlertGreater";
            AlertGreater.HeaderText = "Alert >=";
            AlertGreater.Name = "AlertGreater";
            AlertGreater.Width = 76;
            // 
            // GDBid
            // 
            GDBid.DataPropertyName = "GDBid";
            dataGridViewCellStyle4.Format = "C2";
            GDBid.DefaultCellStyle = dataGridViewCellStyle4;
            GDBid.HeaderText = "GD Bid";
            GDBid.Name = "GDBid";
            GDBid.ReadOnly = true;
            GDBid.Width = 68;
            // 
            // ALOffer
            // 
            ALOffer.DataPropertyName = "ALOffer";
            dataGridViewCellStyle5.Format = "C2";
            ALOffer.DefaultCellStyle = dataGridViewCellStyle5;
            ALOffer.HeaderText = "AL Offer";
            ALOffer.Name = "ALOffer";
            ALOffer.ReadOnly = true;
            ALOffer.Width = 76;
            // 
            // RatioCompra
            // 
            RatioCompra.DataPropertyName = "RatioCompra";
            dataGridViewCellStyle6.Format = "P";
            RatioCompra.DefaultCellStyle = dataGridViewCellStyle6;
            RatioCompra.HeaderText = "Ratio Compra";
            RatioCompra.Name = "RatioCompra";
            RatioCompra.ReadOnly = true;
            RatioCompra.Width = 105;
            // 
            // GDOffer
            // 
            GDOffer.DataPropertyName = "GDOffer";
            dataGridViewCellStyle7.Format = "C2";
            GDOffer.DefaultCellStyle = dataGridViewCellStyle7;
            GDOffer.HeaderText = "GD Offer";
            GDOffer.Name = "GDOffer";
            GDOffer.ReadOnly = true;
            GDOffer.Width = 78;
            // 
            // ALBid
            // 
            ALBid.DataPropertyName = "ALBid";
            dataGridViewCellStyle8.Format = "C2";
            ALBid.DefaultCellStyle = dataGridViewCellStyle8;
            ALBid.HeaderText = "AL Bid";
            ALBid.Name = "ALBid";
            ALBid.ReadOnly = true;
            ALBid.Width = 66;
            // 
            // RatioVenta
            // 
            RatioVenta.DataPropertyName = "RatioVenta";
            dataGridViewCellStyle9.Format = "P";
            RatioVenta.DefaultCellStyle = dataGridViewCellStyle9;
            RatioVenta.HeaderText = "Ratio Venta";
            RatioVenta.Name = "RatioVenta";
            RatioVenta.ReadOnly = true;
            RatioVenta.Width = 91;
            // 
            // FrmRatios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1087, 256);
            Controls.Add(grdRatios);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FrmRatios";
            Text = "Ratios";
            Load += FrmRatios_Load;
            ((System.ComponentModel.ISupportInitialize)grdRatios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView grdRatios;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVariacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioYesterday;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertGreater;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVenta;
    }
}