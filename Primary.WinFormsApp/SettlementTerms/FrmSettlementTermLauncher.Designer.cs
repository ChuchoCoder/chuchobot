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
            rdoBuy48H = new System.Windows.Forms.RadioButton();
            rdoBuy24H = new System.Windows.Forms.RadioButton();
            rdoBuyCI = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rdoSell48H = new System.Windows.Forms.RadioButton();
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
            groupBox1.Controls.Add(rdoBuy48H);
            groupBox1.Controls.Add(rdoBuy24H);
            groupBox1.Controls.Add(rdoBuyCI);
            groupBox1.Location = new System.Drawing.Point(14, 470);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(276, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plazo de liquidación de compra";
            // 
            // rdoBuy48H
            // 
            rdoBuy48H.AutoSize = true;
            rdoBuy48H.Checked = true;
            rdoBuy48H.Location = new System.Drawing.Point(7, 75);
            rdoBuy48H.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoBuy48H.Name = "rdoBuy48H";
            rdoBuy48H.Size = new System.Drawing.Size(69, 19);
            rdoBuy48H.TabIndex = 2;
            rdoBuy48H.TabStop = true;
            rdoBuy48H.Text = "48 horas";
            rdoBuy48H.UseVisualStyleBackColor = true;
            // 
            // rdoBuy24H
            // 
            rdoBuy24H.AutoSize = true;
            rdoBuy24H.Location = new System.Drawing.Point(7, 48);
            rdoBuy24H.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoBuy24H.Name = "rdoBuy24H";
            rdoBuy24H.Size = new System.Drawing.Size(69, 19);
            rdoBuy24H.TabIndex = 1;
            rdoBuy24H.Text = "24 horas";
            rdoBuy24H.UseVisualStyleBackColor = true;
            // 
            // rdoBuyCI
            // 
            rdoBuyCI.AutoSize = true;
            rdoBuyCI.Location = new System.Drawing.Point(7, 22);
            rdoBuyCI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoBuyCI.Name = "rdoBuyCI";
            rdoBuyCI.Size = new System.Drawing.Size(128, 19);
            rdoBuyCI.TabIndex = 0;
            rdoBuyCI.Text = "Contado Inmediato";
            rdoBuyCI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox2.Controls.Add(rdoSell48H);
            groupBox2.Controls.Add(rdoSell24H);
            groupBox2.Controls.Add(rdoSellCI);
            groupBox2.Location = new System.Drawing.Point(298, 470);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(276, 110);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plazo de liquidación de venta";
            // 
            // rdoSell48H
            // 
            rdoSell48H.AutoSize = true;
            rdoSell48H.Location = new System.Drawing.Point(7, 75);
            rdoSell48H.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoSell48H.Name = "rdoSell48H";
            rdoSell48H.Size = new System.Drawing.Size(69, 19);
            rdoSell48H.TabIndex = 2;
            rdoSell48H.Text = "48 horas";
            rdoSell48H.UseVisualStyleBackColor = true;
            // 
            // rdoSell24H
            // 
            rdoSell24H.AutoSize = true;
            rdoSell24H.Location = new System.Drawing.Point(7, 48);
            rdoSell24H.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoSell24H.Name = "rdoSell24H";
            rdoSell24H.Size = new System.Drawing.Size(69, 19);
            rdoSell24H.TabIndex = 1;
            rdoSell24H.Text = "24 horas";
            rdoSell24H.UseVisualStyleBackColor = true;
            // 
            // rdoSellCI
            // 
            rdoSellCI.AutoSize = true;
            rdoSellCI.Checked = true;
            rdoSellCI.Location = new System.Drawing.Point(7, 22);
            rdoSellCI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoSellCI.Name = "rdoSellCI";
            rdoSellCI.Size = new System.Drawing.Size(128, 19);
            rdoSellCI.TabIndex = 0;
            rdoSellCI.TabStop = true;
            rdoSellCI.Text = "Contado Inmediato";
            rdoSellCI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(instrumentSearchList1);
            groupBox3.Location = new System.Drawing.Point(14, 14);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(560, 449);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seleccionar Instrumento";
            // 
            // instrumentSearchList1
            // 
            instrumentSearchList1.Location = new System.Drawing.Point(7, 22);
            instrumentSearchList1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            instrumentSearchList1.Name = "instrumentSearchList1";
            instrumentSearchList1.SettlementsVisible = false;
            instrumentSearchList1.Size = new System.Drawing.Size(553, 427);
            instrumentSearchList1.TabIndex = 3;
            // 
            // btnLaunch
            // 
            btnLaunch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnLaunch.Location = new System.Drawing.Point(14, 586);
            btnLaunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new System.Drawing.Size(560, 27);
            btnLaunch.TabIndex = 6;
            btnLaunch.Text = "Ejecutar Arbitraje de Plazos";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // FrmSettlementTermLauncher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(588, 627);
            Controls.Add(btnLaunch);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.RadioButton rdoBuy48H;
        private System.Windows.Forms.RadioButton rdoBuy24H;
        private System.Windows.Forms.RadioButton rdoBuyCI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSell48H;
        private System.Windows.Forms.RadioButton rdoSell24H;
        private System.Windows.Forms.RadioButton rdoSellCI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLaunch;
        private Shared.InstrumentSearchList instrumentSearchList1;
    }
}