namespace Primary.WinFormsApp
{
    partial class FrmMarketData
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
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.BidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBook
            // 
            this.grdBook.AllowUserToAddRows = false;
            this.grdBook.AllowUserToDeleteRows = false;
            this.grdBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BidSize,
            this.BidPrice,
            this.OfferPrice,
            this.OfferSize});
            this.grdBook.Location = new System.Drawing.Point(12, 38);
            this.grdBook.Name = "grdBook";
            this.grdBook.ReadOnly = true;
            this.grdBook.RowHeadersVisible = false;
            this.grdBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdBook.Size = new System.Drawing.Size(235, 184);
            this.grdBook.TabIndex = 0;
            this.grdBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBook_CellContentClick);
            // 
            // BidSize
            // 
            this.BidSize.DataPropertyName = "BidSize";
            this.BidSize.HeaderText = "Size";
            this.BidSize.Name = "BidSize";
            this.BidSize.ReadOnly = true;
            // 
            // BidPrice
            // 
            this.BidPrice.DataPropertyName = "BidPrice";
            this.BidPrice.HeaderText = "Bid";
            this.BidPrice.Name = "BidPrice";
            this.BidPrice.ReadOnly = true;
            // 
            // OfferPrice
            // 
            this.OfferPrice.DataPropertyName = "OfferPrice";
            this.OfferPrice.HeaderText = "Offer";
            this.OfferPrice.Name = "OfferPrice";
            this.OfferPrice.ReadOnly = true;
            // 
            // OfferSize
            // 
            this.OfferSize.DataPropertyName = "OfferSize";
            this.OfferSize.HeaderText = "Size";
            this.OfferSize.Name = "OfferSize";
            this.OfferSize.ReadOnly = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 12);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(129, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(147, 12);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 2;
            // 
            // FrmMarketData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 233);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.grdBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMarketData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FrmMarketData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarketData_FormClosing);
            this.Load += new System.EventHandler(this.FrmMarketData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferSize;
    }
}