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
            AOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LongRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ABid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ShortRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            grdRatios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Ratio, RatioLast, RatioVariacion, RatioYesterday, AlertLower, AlertGreater, AOffer, BBid, LongRatio, ABid, BOffer, ShortRatio });
            grdRatios.Dock = System.Windows.Forms.DockStyle.Fill;
            grdRatios.Location = new System.Drawing.Point(0, 0);
            grdRatios.Margin = new System.Windows.Forms.Padding(2);
            grdRatios.Name = "grdRatios";
            grdRatios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdRatios.ShowCellErrors = false;
            grdRatios.ShowRowErrors = false;
            grdRatios.Size = new System.Drawing.Size(910, 256);
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
            Ratio.HeaderText = "Ratio (A/B)";
            Ratio.Name = "Ratio";
            Ratio.ReadOnly = true;
            Ratio.Width = 90;
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
            RatioVariacion.HeaderText = "Var.";
            RatioVariacion.Name = "RatioVariacion";
            RatioVariacion.ReadOnly = true;
            RatioVariacion.Width = 51;
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
            // AOffer
            // 
            AOffer.DataPropertyName = "AOffer";
            dataGridViewCellStyle4.Format = "C2";
            AOffer.DefaultCellStyle = dataGridViewCellStyle4;
            AOffer.HeaderText = "A Offer";
            AOffer.Name = "AOffer";
            AOffer.ReadOnly = true;
            AOffer.Width = 70;
            // 
            // BBid
            // 
            BBid.DataPropertyName = "BBid";
            dataGridViewCellStyle5.Format = "C2";
            BBid.DefaultCellStyle = dataGridViewCellStyle5;
            BBid.HeaderText = "B Bid";
            BBid.Name = "BBid";
            BBid.ReadOnly = true;
            BBid.Width = 59;
            // 
            // LongRatio
            // 
            LongRatio.DataPropertyName = "LongRatio";
            dataGridViewCellStyle6.Format = "P";
            LongRatio.DefaultCellStyle = dataGridViewCellStyle6;
            LongRatio.HeaderText = "Long Ratio";
            LongRatio.Name = "LongRatio";
            LongRatio.ReadOnly = true;
            LongRatio.ToolTipText = "Comprar A / Vender B";
            LongRatio.Width = 89;
            // 
            // ABid
            // 
            ABid.DataPropertyName = "ABid";
            dataGridViewCellStyle7.Format = "C2";
            ABid.DefaultCellStyle = dataGridViewCellStyle7;
            ABid.HeaderText = "A Bid";
            ABid.Name = "ABid";
            ABid.ReadOnly = true;
            ABid.Width = 60;
            // 
            // BOffer
            // 
            BOffer.DataPropertyName = "BOffer";
            dataGridViewCellStyle8.Format = "C2";
            BOffer.DefaultCellStyle = dataGridViewCellStyle8;
            BOffer.HeaderText = "B Offer";
            BOffer.Name = "BOffer";
            BOffer.ReadOnly = true;
            BOffer.Width = 69;
            // 
            // ShortRatio
            // 
            ShortRatio.DataPropertyName = "ShortRatio";
            dataGridViewCellStyle9.Format = "P";
            ShortRatio.DefaultCellStyle = dataGridViewCellStyle9;
            ShortRatio.HeaderText = "Short Ratio";
            ShortRatio.Name = "ShortRatio";
            ShortRatio.ReadOnly = true;
            ShortRatio.ToolTipText = "Vender A / Comprar B";
            ShortRatio.Width = 90;
            // 
            // FrmRatios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 256);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortRatio;
    }
}