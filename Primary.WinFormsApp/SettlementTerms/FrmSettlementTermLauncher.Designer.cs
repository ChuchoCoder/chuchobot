﻿namespace Primary.WinFormsApp.SettlementTerms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBuy24H = new System.Windows.Forms.RadioButton();
            this.rdoBuyCI = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSell24H = new System.Windows.Forms.RadioButton();
            this.rdoSellCI = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.instrumentSearchList1 = new Primary.WinFormsApp.Shared.InstrumentSearchList();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rdoBuy24H);
            this.groupBox1.Controls.Add(this.rdoBuyCI);
            this.groupBox1.Location = new System.Drawing.Point(24, 783);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(474, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plazo de liquidación de compra";
            // 
            // rdoBuy24H
            // 
            this.rdoBuy24H.AutoSize = true;
            this.rdoBuy24H.Checked = true;
            this.rdoBuy24H.Location = new System.Drawing.Point(12, 81);
            this.rdoBuy24H.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoBuy24H.Name = "rdoBuy24H";
            this.rdoBuy24H.Size = new System.Drawing.Size(127, 29);
            this.rdoBuy24H.TabIndex = 1;
            this.rdoBuy24H.TabStop = true;
            this.rdoBuy24H.Text = "24 horas";
            this.rdoBuy24H.UseVisualStyleBackColor = true;
            // 
            // rdoBuyCI
            // 
            this.rdoBuyCI.AutoSize = true;
            this.rdoBuyCI.Location = new System.Drawing.Point(12, 37);
            this.rdoBuyCI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoBuyCI.Name = "rdoBuyCI";
            this.rdoBuyCI.Size = new System.Drawing.Size(223, 29);
            this.rdoBuyCI.TabIndex = 0;
            this.rdoBuyCI.Text = "Contado Inmediato";
            this.rdoBuyCI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rdoSell24H);
            this.groupBox2.Controls.Add(this.rdoSellCI);
            this.groupBox2.Location = new System.Drawing.Point(510, 783);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(474, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plazo de liquidación de venta";
            // 
            // rdoSell24H
            // 
            this.rdoSell24H.AutoSize = true;
            this.rdoSell24H.Location = new System.Drawing.Point(12, 81);
            this.rdoSell24H.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoSell24H.Name = "rdoSell24H";
            this.rdoSell24H.Size = new System.Drawing.Size(127, 29);
            this.rdoSell24H.TabIndex = 1;
            this.rdoSell24H.Text = "24 horas";
            this.rdoSell24H.UseVisualStyleBackColor = true;
            // 
            // rdoSellCI
            // 
            this.rdoSellCI.AutoSize = true;
            this.rdoSellCI.Checked = true;
            this.rdoSellCI.Location = new System.Drawing.Point(12, 37);
            this.rdoSellCI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoSellCI.Name = "rdoSellCI";
            this.rdoSellCI.Size = new System.Drawing.Size(223, 29);
            this.rdoSellCI.TabIndex = 0;
            this.rdoSellCI.TabStop = true;
            this.rdoSellCI.Text = "Contado Inmediato";
            this.rdoSellCI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.instrumentSearchList1);
            this.groupBox3.Location = new System.Drawing.Point(24, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(960, 748);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Instrumento";
            // 
            // instrumentSearchList1
            // 
            this.instrumentSearchList1.Location = new System.Drawing.Point(12, 37);
            this.instrumentSearchList1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.instrumentSearchList1.Name = "instrumentSearchList1";
            this.instrumentSearchList1.SettlementsVisible = false;
            this.instrumentSearchList1.Size = new System.Drawing.Size(936, 712);
            this.instrumentSearchList1.TabIndex = 3;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.Location = new System.Drawing.Point(24, 977);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(960, 44);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Ejecutar Arbitraje de Plazos";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // FrmSettlementTermLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 1044);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmSettlementTermLauncher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Abrir arbitraje de plazos para instrumento";
            this.Load += new System.EventHandler(this.FrmSettlementTermLauncher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

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