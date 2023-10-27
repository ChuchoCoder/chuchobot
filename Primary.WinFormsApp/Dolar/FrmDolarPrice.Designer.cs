namespace Primary.WinFormsApp
{
    partial class FrmDolarPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDolarPrice));
            this.grdDolar = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Trade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDolar
            // 
            this.grdDolar.AllowUserToAddRows = false;
            this.grdDolar.AllowUserToDeleteRows = false;
            this.grdDolar.AllowUserToOrderColumns = true;
            this.grdDolar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDolar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trade,
            this.Precio,
            this.Last,
            this.Pesos,
            this.USD});
            this.grdDolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDolar.Location = new System.Drawing.Point(0, 0);
            this.grdDolar.MultiSelect = false;
            this.grdDolar.Name = "grdDolar";
            this.grdDolar.ReadOnly = true;
            this.grdDolar.RowHeadersWidth = 51;
            this.grdDolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDolar.Size = new System.Drawing.Size(642, 569);
            this.grdDolar.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Trade
            // 
            this.Trade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Trade.DataPropertyName = "Trade";
            this.Trade.HeaderText = "Instrumentos ($ / USD)";
            this.Trade.MinimumWidth = 6;
            this.Trade.Name = "Trade";
            this.Trade.ReadOnly = true;
            this.Trade.Width = 96;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio Dolar";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 83;
            // 
            // Last
            // 
            this.Last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Last.DataPropertyName = "Last";
            dataGridViewCellStyle2.Format = "C2";
            this.Last.DefaultCellStyle = dataGridViewCellStyle2;
            this.Last.HeaderText = "Last";
            this.Last.MinimumWidth = 6;
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Width = 52;
            // 
            // Pesos
            // 
            this.Pesos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pesos.DataPropertyName = "Pesos";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Pesos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pesos.HeaderText = "Pesos";
            this.Pesos.Name = "Pesos";
            this.Pesos.ReadOnly = true;
            this.Pesos.Width = 61;
            // 
            // USD
            // 
            this.USD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USD.DataPropertyName = "USD";
            dataGridViewCellStyle4.Format = "\"USD\" #0.##";
            dataGridViewCellStyle4.NullValue = null;
            this.USD.DefaultCellStyle = dataGridViewCellStyle4;
            this.USD.HeaderText = "USD";
            this.USD.Name = "USD";
            this.USD.ReadOnly = true;
            this.USD.Width = 55;
            // 
            // FrmDolarPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 569);
            this.Controls.Add(this.grdDolar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDolarPrice";
            this.Text = "Dolar";
            this.Load += new System.EventHandler(this.FrmDolarPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDolar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn USD;
    }
}