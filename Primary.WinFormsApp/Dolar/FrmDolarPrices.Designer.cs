namespace ChuchoBot.WinFormsApp
{
    partial class FrmDolarPrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDolarPrices));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splMEP = new System.Windows.Forms.SplitContainer();
            this.grdMEPLeft = new System.Windows.Forms.DataGridView();
            this.Trade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMEPRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spliCCL = new System.Windows.Forms.SplitContainer();
            this.grdCCLLeft = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCCLRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMEP)).BeginInit();
            this.splMEP.Panel1.SuspendLayout();
            this.splMEP.Panel2.SuspendLayout();
            this.splMEP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMEPLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMEPRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spliCCL)).BeginInit();
            this.spliCCL.Panel1.SuspendLayout();
            this.spliCCL.Panel2.SuspendLayout();
            this.spliCCL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCCLLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCCLRight)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splMEP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.spliCCL);
            this.splitContainer2.Size = new System.Drawing.Size(1334, 970);
            this.splitContainer2.SplitterDistance = 481;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 3;
            // 
            // splMEP
            // 
            this.splMEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMEP.Location = new System.Drawing.Point(0, 0);
            this.splMEP.Margin = new System.Windows.Forms.Padding(6);
            this.splMEP.Name = "splMEP";
            // 
            // splMEP.Panel1
            // 
            this.splMEP.Panel1.Controls.Add(this.grdMEPLeft);
            // 
            // splMEP.Panel2
            // 
            this.splMEP.Panel2.Controls.Add(this.grdMEPRight);
            this.splMEP.Size = new System.Drawing.Size(1334, 481);
            this.splMEP.SplitterDistance = 634;
            this.splMEP.SplitterWidth = 8;
            this.splMEP.TabIndex = 5;
            // 
            // grdMEPLeft
            // 
            this.grdMEPLeft.AllowUserToAddRows = false;
            this.grdMEPLeft.AllowUserToDeleteRows = false;
            this.grdMEPLeft.AllowUserToOrderColumns = true;
            this.grdMEPLeft.AllowUserToResizeRows = false;
            this.grdMEPLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMEPLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMEPLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trade,
            this.Dolar,
            this.Compra});
            this.grdMEPLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMEPLeft.Location = new System.Drawing.Point(0, 0);
            this.grdMEPLeft.Margin = new System.Windows.Forms.Padding(6);
            this.grdMEPLeft.MultiSelect = false;
            this.grdMEPLeft.Name = "grdMEPLeft";
            this.grdMEPLeft.ReadOnly = true;
            this.grdMEPLeft.RowHeadersWidth = 51;
            this.grdMEPLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMEPLeft.Size = new System.Drawing.Size(634, 481);
            this.grdMEPLeft.TabIndex = 0;
            // 
            // Trade
            // 
            this.Trade.DataPropertyName = "Trade";
            this.Trade.HeaderText = "Compra Dolar";
            this.Trade.MinimumWidth = 6;
            this.Trade.Name = "Trade";
            this.Trade.ReadOnly = true;
            this.Trade.Width = 174;
            // 
            // Dolar
            // 
            this.Dolar.DataPropertyName = "Last";
            dataGridViewCellStyle1.Format = "C2";
            this.Dolar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dolar.HeaderText = "Last";
            this.Dolar.MinimumWidth = 6;
            this.Dolar.Name = "Dolar";
            this.Dolar.ReadOnly = true;
            this.Dolar.Width = 98;
            // 
            // Compra
            // 
            this.Compra.DataPropertyName = "Compra";
            dataGridViewCellStyle2.Format = "C2";
            this.Compra.DefaultCellStyle = dataGridViewCellStyle2;
            this.Compra.HeaderText = "Offer $ / Bid U$S";
            this.Compra.MinimumWidth = 6;
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            this.Compra.Width = 163;
            // 
            // grdMEPRight
            // 
            this.grdMEPRight.AllowUserToAddRows = false;
            this.grdMEPRight.AllowUserToDeleteRows = false;
            this.grdMEPRight.AllowUserToOrderColumns = true;
            this.grdMEPRight.AllowUserToResizeRows = false;
            this.grdMEPRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMEPRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMEPRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.grdMEPRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMEPRight.Location = new System.Drawing.Point(0, 0);
            this.grdMEPRight.Margin = new System.Windows.Forms.Padding(6);
            this.grdMEPRight.MultiSelect = false;
            this.grdMEPRight.Name = "grdMEPRight";
            this.grdMEPRight.ReadOnly = true;
            this.grdMEPRight.RowHeadersWidth = 51;
            this.grdMEPRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMEPRight.Size = new System.Drawing.Size(692, 481);
            this.grdMEPRight.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Trade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Venta Dolar";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 157;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Last";
            dataGridViewCellStyle3.Format = "C2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Last";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Venta";
            dataGridViewCellStyle4.Format = "C2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Offer U$S / Bid $";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 156;
            // 
            // spliCCL
            // 
            this.spliCCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spliCCL.Location = new System.Drawing.Point(0, 0);
            this.spliCCL.Margin = new System.Windows.Forms.Padding(6);
            this.spliCCL.Name = "spliCCL";
            // 
            // spliCCL.Panel1
            // 
            this.spliCCL.Panel1.Controls.Add(this.grdCCLLeft);
            // 
            // spliCCL.Panel2
            // 
            this.spliCCL.Panel2.Controls.Add(this.grdCCLRight);
            this.spliCCL.Size = new System.Drawing.Size(1334, 481);
            this.spliCCL.SplitterDistance = 632;
            this.spliCCL.SplitterWidth = 8;
            this.spliCCL.TabIndex = 4;
            // 
            // grdCCLLeft
            // 
            this.grdCCLLeft.AllowUserToAddRows = false;
            this.grdCCLLeft.AllowUserToDeleteRows = false;
            this.grdCCLLeft.AllowUserToOrderColumns = true;
            this.grdCCLLeft.AllowUserToResizeRows = false;
            this.grdCCLLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCCLLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCCLLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grdCCLLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCCLLeft.Location = new System.Drawing.Point(0, 0);
            this.grdCCLLeft.Margin = new System.Windows.Forms.Padding(6);
            this.grdCCLLeft.MultiSelect = false;
            this.grdCCLLeft.Name = "grdCCLLeft";
            this.grdCCLLeft.ReadOnly = true;
            this.grdCCLLeft.RowHeadersWidth = 51;
            this.grdCCLLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCCLLeft.Size = new System.Drawing.Size(632, 481);
            this.grdCCLLeft.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Trade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Compra Dolar";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 174;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Last";
            dataGridViewCellStyle5.Format = "C2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Last";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Compra";
            dataGridViewCellStyle6.Format = "C2";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn7.HeaderText = "Offer $ / Bid U$S";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 163;
            // 
            // grdCCLRight
            // 
            this.grdCCLRight.AllowUserToAddRows = false;
            this.grdCCLRight.AllowUserToDeleteRows = false;
            this.grdCCLRight.AllowUserToOrderColumns = true;
            this.grdCCLRight.AllowUserToResizeRows = false;
            this.grdCCLRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCCLRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCCLRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.grdCCLRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCCLRight.Location = new System.Drawing.Point(0, 0);
            this.grdCCLRight.Margin = new System.Windows.Forms.Padding(6);
            this.grdCCLRight.MultiSelect = false;
            this.grdCCLRight.Name = "grdCCLRight";
            this.grdCCLRight.ReadOnly = true;
            this.grdCCLRight.RowHeadersWidth = 51;
            this.grdCCLRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCCLRight.Size = new System.Drawing.Size(694, 481);
            this.grdCCLRight.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Trade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Venta Dolar";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 157;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Last";
            dataGridViewCellStyle7.Format = "C2";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn10.HeaderText = "Last";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 98;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Venta";
            dataGridViewCellStyle8.Format = "C2";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn12.HeaderText = "Offer U$S / Bid $";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 156;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDolarPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 970);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDolarPrices";
            this.Text = "Dolar Prices";
            this.Load += new System.EventHandler(this.FrmDolarPrices_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splMEP.Panel1.ResumeLayout(false);
            this.splMEP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMEP)).EndInit();
            this.splMEP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMEPLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMEPRight)).EndInit();
            this.spliCCL.Panel1.ResumeLayout(false);
            this.spliCCL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spliCCL)).EndInit();
            this.spliCCL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCCLLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCCLRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer spliCCL;
        private System.Windows.Forms.DataGridView grdCCLLeft;
        private System.Windows.Forms.DataGridView grdCCLRight;
        private System.Windows.Forms.SplitContainer splMEP;
        private System.Windows.Forms.DataGridView grdMEPLeft;
        private System.Windows.Forms.DataGridView grdMEPRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}