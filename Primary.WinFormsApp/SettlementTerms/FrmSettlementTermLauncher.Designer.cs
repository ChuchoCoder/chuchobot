namespace ChuchoBot.WinFormsApp.SettlementTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlementTermLauncher));
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoBuy24H = new System.Windows.Forms.RadioButton();
            rdoBuyCI = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rdoSell24H = new System.Windows.Forms.RadioButton();
            rdoSellCI = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            instrumentSearchList1 = new Shared.InstrumentSearchList();
            btnLaunch = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox1.Controls.Add(rdoBuy24H);
            groupBox1.Controls.Add(rdoBuyCI);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 95);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plazo de liquidación de compra";
            // 

            // rdoBuy24H
            // 
            rdoBuy24H.AutoSize = true;
            this.rdoBuy24H.Checked = true;
            this.rdoBuy24H.Location = new System.Drawing.Point(6, 42);
            rdoBuy24H.Name = "rdoBuy24H";
            this.rdoBuy24H.Size = new System.Drawing.Size(66, 17);
            rdoBuy24H.TabIndex = 1;
            this.rdoBuy24H.TabStop = true;
            rdoBuy24H.Text = "24 horas";
            rdoBuy24H.UseVisualStyleBackColor = true;
            // 
            // rdoBuyCI
            // 
            rdoBuyCI.AutoSize = true;
            this.rdoBuyCI.Location = new System.Drawing.Point(6, 19);
            rdoBuyCI.Name = "rdoBuyCI";
            this.rdoBuyCI.Size = new System.Drawing.Size(114, 17);
            rdoBuyCI.TabIndex = 0;
            rdoBuyCI.Text = "Contado Inmediato";
            rdoBuyCI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            
            groupBox2.Controls.Add(rdoSell24H);
            groupBox2.Controls.Add(rdoSellCI);
            this.groupBox2.Location = new System.Drawing.Point(255, 407);
            groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 95);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plazo de liquidación de venta";
            // 

            // rdoSell24H
            // 
            rdoSell24H.AutoSize = true;
            this.rdoSell24H.Location = new System.Drawing.Point(6, 42);
            rdoSell24H.Name = "rdoSell24H";
            this.rdoSell24H.Size = new System.Drawing.Size(66, 17);
            rdoSell24H.TabIndex = 1;
            rdoSell24H.Text = "24 horas";
            rdoSell24H.UseVisualStyleBackColor = true;
            // 
            // rdoSellCI
            // 
            rdoSellCI.AutoSize = true;
            rdoSellCI.Checked = true;
            this.rdoSellCI.Location = new System.Drawing.Point(6, 19);
            rdoSellCI.Name = "rdoSellCI";
            this.rdoSellCI.Size = new System.Drawing.Size(114, 17);
            rdoSellCI.TabIndex = 0;
            rdoSellCI.TabStop = true;
            rdoSellCI.Text = "Contado Inmediato";
            rdoSellCI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(instrumentSearchList1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 389);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seleccionar Instrumento";
            // 
            // instrumentSearchList1
            // 
            this.instrumentSearchList1.Location = new System.Drawing.Point(6, 19);
            instrumentSearchList1.Name = "instrumentSearchList1";
            instrumentSearchList1.SettlementsVisible = false;
            this.instrumentSearchList1.Size = new System.Drawing.Size(468, 370);
            instrumentSearchList1.TabIndex = 3;
            // 
            // btnLaunch
            // 
            btnLaunch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnLaunch.Location = new System.Drawing.Point(12, 508);
            btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(480, 23);
            btnLaunch.TabIndex = 6;
            btnLaunch.Text = "Ejecutar Arbitraje de Plazos";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // FrmSettlementTermLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 543);
            Controls.Add(btnLaunch);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSettlementTermLauncher";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Abrir arbitraje de plazos para instrumento";
            Load += FrmSettlementTermLauncher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBuy24H;
        private System.Windows.Forms.RadioButton rdoBuyCI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSell24H;
        private System.Windows.Forms.RadioButton rdoSellCI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLaunch;
        private Shared.InstrumentSearchList instrumentSearchList1;
    }
}