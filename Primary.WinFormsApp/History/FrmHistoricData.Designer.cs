namespace Primary.WinFormsApp
{
    partial class FrmHistoricData
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
            this.grdHistoricData = new System.Windows.Forms.DataGridView();
            this.cmbInstruments = new System.Windows.Forms.ComboBox();
            this.btnGetHistoricData = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHistoricData
            // 
            this.grdHistoricData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistoricData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdHistoricData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistoricData.Location = new System.Drawing.Point(16, 49);
            this.grdHistoricData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdHistoricData.Name = "grdHistoricData";
            this.grdHistoricData.RowHeadersWidth = 51;
            this.grdHistoricData.Size = new System.Drawing.Size(1035, 490);
            this.grdHistoricData.TabIndex = 0;
            this.grdHistoricData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.FormattingEnabled = true;
            this.cmbInstruments.Location = new System.Drawing.Point(16, 15);
            this.cmbInstruments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(543, 24);
            this.cmbInstruments.TabIndex = 1;
            this.cmbInstruments.SelectedValueChanged += new System.EventHandler(this.cmbInstruments_SelectedValueChanged);
            // 
            // btnGetHistoricData
            // 
            this.btnGetHistoricData.Location = new System.Drawing.Point(568, 12);
            this.btnGetHistoricData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetHistoricData.Name = "btnGetHistoricData";
            this.btnGetHistoricData.Size = new System.Drawing.Size(231, 28);
            this.btnGetHistoricData.TabIndex = 2;
            this.btnGetHistoricData.Text = "Obtener Datos";
            this.btnGetHistoricData.UseVisualStyleBackColor = true;
            this.btnGetHistoricData.Click += new System.EventHandler(this.btnGetHistoricData_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(820, 12);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(231, 28);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FrmHistoricData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGetHistoricData);
            this.Controls.Add(this.cmbInstruments);
            this.Controls.Add(this.grdHistoricData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHistoricData";
            this.Text = "FrmHistoricData";
            this.Load += new System.EventHandler(this.FrmHistoricData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistoricData;
        private System.Windows.Forms.ComboBox cmbInstruments;
        private System.Windows.Forms.Button btnGetHistoricData;
        private System.Windows.Forms.Button btnCopy;
    }
}