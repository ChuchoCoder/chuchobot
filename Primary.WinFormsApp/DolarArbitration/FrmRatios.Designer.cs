namespace Primary.WinFormsApp.DolarArbitration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatios));
            this.grdRatios = new System.Windows.Forms.DataGridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioVariacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioYesterday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRatios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRatios
            // 
            this.grdRatios.AllowUserToAddRows = false;
            this.grdRatios.AllowUserToDeleteRows = false;
            this.grdRatios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdRatios.CausesValidation = false;
            this.grdRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRatios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ratio,
            this.RatioLast,
            this.RatioVariacion,
            this.RatioYesterday,
            this.GDBid,
            this.ALOffer,
            this.RatioCompra,
            this.GDOffer,
            this.ALBid,
            this.RatioVenta});
            this.grdRatios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRatios.Location = new System.Drawing.Point(0, 0);
            this.grdRatios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdRatios.Name = "grdRatios";
            this.grdRatios.ReadOnly = true;
            this.grdRatios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRatios.ShowCellErrors = false;
            this.grdRatios.ShowEditingIcon = false;
            this.grdRatios.ShowRowErrors = false;
            this.grdRatios.Size = new System.Drawing.Size(932, 222);
            this.grdRatios.TabIndex = 0;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 3000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Ratio
            // 
            this.Ratio.DataPropertyName = "Ratio";
            this.Ratio.HeaderText = "Ratio";
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            this.Ratio.Width = 57;
            // 
            // RatioLast
            // 
            this.RatioLast.DataPropertyName = "RatioLast";
            dataGridViewCellStyle1.Format = "P";
            this.RatioLast.DefaultCellStyle = dataGridViewCellStyle1;
            this.RatioLast.HeaderText = "Ult.";
            this.RatioLast.Name = "RatioLast";
            this.RatioLast.ReadOnly = true;
            this.RatioLast.Width = 48;
            // 
            // RatioVariacion
            // 
            this.RatioVariacion.DataPropertyName = "RatioVariacion";
            dataGridViewCellStyle2.Format = "P";
            this.RatioVariacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.RatioVariacion.HeaderText = "Variacion";
            this.RatioVariacion.Name = "RatioVariacion";
            this.RatioVariacion.ReadOnly = true;
            this.RatioVariacion.Width = 76;
            // 
            // RatioYesterday
            // 
            this.RatioYesterday.DataPropertyName = "RatioYesterday";
            dataGridViewCellStyle3.Format = "P";
            this.RatioYesterday.DefaultCellStyle = dataGridViewCellStyle3;
            this.RatioYesterday.HeaderText = "Cierre";
            this.RatioYesterday.Name = "RatioYesterday";
            this.RatioYesterday.ReadOnly = true;
            this.RatioYesterday.Width = 59;
            // 
            // GDBid
            // 
            this.GDBid.DataPropertyName = "GDBid";
            dataGridViewCellStyle4.Format = "C2";
            this.GDBid.DefaultCellStyle = dataGridViewCellStyle4;
            this.GDBid.HeaderText = "GD Bid";
            this.GDBid.Name = "GDBid";
            this.GDBid.ReadOnly = true;
            this.GDBid.Width = 66;
            // 
            // ALOffer
            // 
            this.ALOffer.DataPropertyName = "ALOffer";
            dataGridViewCellStyle5.Format = "C2";
            this.ALOffer.DefaultCellStyle = dataGridViewCellStyle5;
            this.ALOffer.HeaderText = "AL Offer";
            this.ALOffer.Name = "ALOffer";
            this.ALOffer.ReadOnly = true;
            this.ALOffer.Width = 71;
            // 
            // RatioCompra
            // 
            this.RatioCompra.DataPropertyName = "RatioCompra";
            dataGridViewCellStyle6.Format = "P";
            this.RatioCompra.DefaultCellStyle = dataGridViewCellStyle6;
            this.RatioCompra.HeaderText = "Ratio Compra";
            this.RatioCompra.Name = "RatioCompra";
            this.RatioCompra.ReadOnly = true;
            this.RatioCompra.Width = 96;
            // 
            // GDOffer
            // 
            this.GDOffer.DataPropertyName = "GDOffer";
            dataGridViewCellStyle7.Format = "C2";
            this.GDOffer.DefaultCellStyle = dataGridViewCellStyle7;
            this.GDOffer.HeaderText = "GD Offer";
            this.GDOffer.Name = "GDOffer";
            this.GDOffer.ReadOnly = true;
            this.GDOffer.Width = 74;
            // 
            // ALBid
            // 
            this.ALBid.DataPropertyName = "ALBid";
            dataGridViewCellStyle8.Format = "C2";
            this.ALBid.DefaultCellStyle = dataGridViewCellStyle8;
            this.ALBid.HeaderText = "AL Bid";
            this.ALBid.Name = "ALBid";
            this.ALBid.ReadOnly = true;
            this.ALBid.Width = 63;
            // 
            // RatioVenta
            // 
            this.RatioVenta.DataPropertyName = "RatioVenta";
            dataGridViewCellStyle9.Format = "P";
            this.RatioVenta.DefaultCellStyle = dataGridViewCellStyle9;
            this.RatioVenta.HeaderText = "Ratio Venta";
            this.RatioVenta.Name = "RatioVenta";
            this.RatioVenta.ReadOnly = true;
            this.RatioVenta.Width = 88;
            // 
            // FrmRatios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 222);
            this.Controls.Add(this.grdRatios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRatios";
            this.Text = "Ratios";
            this.Load += new System.EventHandler(this.FrmRatios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRatios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRatios;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVariacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioYesterday;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVenta;
    }
}