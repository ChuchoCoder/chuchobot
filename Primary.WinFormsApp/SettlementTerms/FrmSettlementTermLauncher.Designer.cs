namespace Primary.WinFormsApp.SettlementTerms
{
    partial class FrmSettlementTermLauncher
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
            this.listInstrumentos = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBuy48H = new System.Windows.Forms.RadioButton();
            this.rdoBuy24H = new System.Windows.Forms.RadioButton();
            this.rdoBuyCI = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSell48H = new System.Windows.Forms.RadioButton();
            this.rdoSell24H = new System.Windows.Forms.RadioButton();
            this.rdoSellCI = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInstrumentos
            // 
            this.listInstrumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInstrumentos.FormattingEnabled = true;
            this.listInstrumentos.Location = new System.Drawing.Point(6, 45);
            this.listInstrumentos.Name = "listInstrumentos";
            this.listInstrumentos.Size = new System.Drawing.Size(468, 329);
            this.listInstrumentos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(468, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBuy48H);
            this.groupBox1.Controls.Add(this.rdoBuy24H);
            this.groupBox1.Controls.Add(this.rdoBuyCI);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plazo de liquidación de compra";
            // 
            // rdoBuy48H
            // 
            this.rdoBuy48H.AutoSize = true;
            this.rdoBuy48H.Location = new System.Drawing.Point(6, 65);
            this.rdoBuy48H.Name = "rdoBuy48H";
            this.rdoBuy48H.Size = new System.Drawing.Size(66, 17);
            this.rdoBuy48H.TabIndex = 2;
            this.rdoBuy48H.Text = "48 horas";
            this.rdoBuy48H.UseVisualStyleBackColor = true;
            // 
            // rdoBuy24H
            // 
            this.rdoBuy24H.AutoSize = true;
            this.rdoBuy24H.Location = new System.Drawing.Point(6, 42);
            this.rdoBuy24H.Name = "rdoBuy24H";
            this.rdoBuy24H.Size = new System.Drawing.Size(66, 17);
            this.rdoBuy24H.TabIndex = 1;
            this.rdoBuy24H.Text = "24 horas";
            this.rdoBuy24H.UseVisualStyleBackColor = true;
            // 
            // rdoBuyCI
            // 
            this.rdoBuyCI.AutoSize = true;
            this.rdoBuyCI.Checked = true;
            this.rdoBuyCI.Location = new System.Drawing.Point(6, 19);
            this.rdoBuyCI.Name = "rdoBuyCI";
            this.rdoBuyCI.Size = new System.Drawing.Size(114, 17);
            this.rdoBuyCI.TabIndex = 0;
            this.rdoBuyCI.TabStop = true;
            this.rdoBuyCI.Text = "Contado Inmediato";
            this.rdoBuyCI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSell48H);
            this.groupBox2.Controls.Add(this.rdoSell24H);
            this.groupBox2.Controls.Add(this.rdoSellCI);
            this.groupBox2.Location = new System.Drawing.Point(255, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plazo de liquidación de venta";
            // 
            // rdoSell48H
            // 
            this.rdoSell48H.AutoSize = true;
            this.rdoSell48H.Checked = true;
            this.rdoSell48H.Location = new System.Drawing.Point(6, 65);
            this.rdoSell48H.Name = "rdoSell48H";
            this.rdoSell48H.Size = new System.Drawing.Size(66, 17);
            this.rdoSell48H.TabIndex = 2;
            this.rdoSell48H.TabStop = true;
            this.rdoSell48H.Text = "48 horas";
            this.rdoSell48H.UseVisualStyleBackColor = true;
            // 
            // rdoSell24H
            // 
            this.rdoSell24H.AutoSize = true;
            this.rdoSell24H.Location = new System.Drawing.Point(6, 42);
            this.rdoSell24H.Name = "rdoSell24H";
            this.rdoSell24H.Size = new System.Drawing.Size(66, 17);
            this.rdoSell24H.TabIndex = 1;
            this.rdoSell24H.Text = "24 horas";
            this.rdoSell24H.UseVisualStyleBackColor = true;
            // 
            // rdoSellCI
            // 
            this.rdoSellCI.AutoSize = true;
            this.rdoSellCI.Location = new System.Drawing.Point(6, 19);
            this.rdoSellCI.Name = "rdoSellCI";
            this.rdoSellCI.Size = new System.Drawing.Size(114, 17);
            this.rdoSellCI.TabIndex = 0;
            this.rdoSellCI.Text = "Contado Inmediato";
            this.rdoSellCI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.listInstrumentos);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 389);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Instrumento";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.Location = new System.Drawing.Point(12, 508);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(480, 23);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Ejecutar Arbitraje de Plazos";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // FrmSettlementTermLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 543);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSettlementTermLauncher";
            this.Text = "Abrir arbitraje de plazos para instrumento";
            this.Load += new System.EventHandler(this.FrmSettlementTermLauncher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listInstrumentos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBuy48H;
        private System.Windows.Forms.RadioButton rdoBuy24H;
        private System.Windows.Forms.RadioButton rdoBuyCI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSell48H;
        private System.Windows.Forms.RadioButton rdoSell24H;
        private System.Windows.Forms.RadioButton rdoSellCI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLaunch;
    }
}