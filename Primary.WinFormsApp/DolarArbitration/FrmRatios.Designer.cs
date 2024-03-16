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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatios));
            this.grdRatios = new System.Windows.Forms.DataGridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioYesterday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioVariacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRatios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRatios
            // 
            this.grdRatios.AllowUserToAddRows = false;
            this.grdRatios.AllowUserToDeleteRows = false;
            this.grdRatios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRatios.CausesValidation = false;
            this.grdRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRatios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ratio,
            this.GDBid,
            this.ALOffer,
            this.RatioCompra,
            this.GDOffer,
            this.ALBid,
            this.RatioVenta,
            this.RatioLast,
            this.RatioYesterday,
            this.RatioVariacion});
            this.grdRatios.Location = new System.Drawing.Point(12, 12);
            this.grdRatios.Name = "grdRatios";
            this.grdRatios.ReadOnly = true;
            this.grdRatios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRatios.ShowCellErrors = false;
            this.grdRatios.ShowEditingIcon = false;
            this.grdRatios.ShowRowErrors = false;
            this.grdRatios.Size = new System.Drawing.Size(1217, 483);
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
            // 
            // GDBid
            // 
            this.GDBid.DataPropertyName = "GDBid";
            dataGridViewCellStyle10.Format = "C2";
            this.GDBid.DefaultCellStyle = dataGridViewCellStyle10;
            this.GDBid.HeaderText = "GD Bid";
            this.GDBid.Name = "GDBid";
            this.GDBid.ReadOnly = true;
            // 
            // ALOffer
            // 
            this.ALOffer.DataPropertyName = "ALOffer";
            dataGridViewCellStyle11.Format = "C2";
            this.ALOffer.DefaultCellStyle = dataGridViewCellStyle11;
            this.ALOffer.HeaderText = "AL Offer";
            this.ALOffer.Name = "ALOffer";
            this.ALOffer.ReadOnly = true;
            // 
            // RatioCompra
            // 
            this.RatioCompra.DataPropertyName = "RatioCompra";
            dataGridViewCellStyle12.Format = "P";
            this.RatioCompra.DefaultCellStyle = dataGridViewCellStyle12;
            this.RatioCompra.HeaderText = "Ratio Compra";
            this.RatioCompra.Name = "RatioCompra";
            this.RatioCompra.ReadOnly = true;
            // 
            // GDOffer
            // 
            this.GDOffer.DataPropertyName = "GDOffer";
            dataGridViewCellStyle13.Format = "C2";
            this.GDOffer.DefaultCellStyle = dataGridViewCellStyle13;
            this.GDOffer.HeaderText = "GD Offer";
            this.GDOffer.Name = "GDOffer";
            this.GDOffer.ReadOnly = true;
            // 
            // ALBid
            // 
            this.ALBid.DataPropertyName = "ALBid";
            dataGridViewCellStyle14.Format = "C2";
            this.ALBid.DefaultCellStyle = dataGridViewCellStyle14;
            this.ALBid.HeaderText = "AL Bid";
            this.ALBid.Name = "ALBid";
            this.ALBid.ReadOnly = true;
            // 
            // RatioVenta
            // 
            this.RatioVenta.DataPropertyName = "RatioVenta";
            dataGridViewCellStyle15.Format = "P";
            this.RatioVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.RatioVenta.HeaderText = "Ratio Venta";
            this.RatioVenta.Name = "RatioVenta";
            this.RatioVenta.ReadOnly = true;
            // 
            // RatioLast
            // 
            this.RatioLast.DataPropertyName = "RatioLast";
            dataGridViewCellStyle16.Format = "P";
            this.RatioLast.DefaultCellStyle = dataGridViewCellStyle16;
            this.RatioLast.HeaderText = "Ratio Last";
            this.RatioLast.Name = "RatioLast";
            this.RatioLast.ReadOnly = true;
            // 
            // RatioYesterday
            // 
            this.RatioYesterday.DataPropertyName = "RatioYesterday";
            dataGridViewCellStyle17.Format = "P";
            this.RatioYesterday.DefaultCellStyle = dataGridViewCellStyle17;
            this.RatioYesterday.HeaderText = "Ratio Ayer";
            this.RatioYesterday.Name = "RatioYesterday";
            this.RatioYesterday.ReadOnly = true;
            // 
            // RatioVariacion
            // 
            this.RatioVariacion.DataPropertyName = "RatioVariacion";
            dataGridViewCellStyle18.Format = "P";
            this.RatioVariacion.DefaultCellStyle = dataGridViewCellStyle18;
            this.RatioVariacion.HeaderText = "RatioVariacion";
            this.RatioVariacion.Name = "RatioVariacion";
            this.RatioVariacion.ReadOnly = true;
            // 
            // FrmRatios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.grdRatios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn GDBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioYesterday;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioVariacion;
    }
}