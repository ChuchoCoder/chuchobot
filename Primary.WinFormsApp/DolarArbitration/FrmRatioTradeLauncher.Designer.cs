namespace ChuchoBot.WinFormsApp.DolarArbitration
{
    partial class FrmRatioTradeLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatioTradeLauncher));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.instrumentSearchListSell = new ChuchoBot.WinFormsApp.Shared.InstrumentSearchList();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.instrumentSearchListBuy = new ChuchoBot.WinFormsApp.Shared.InstrumentSearchList();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.instrumentSearchListSell);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 458);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Instrumento a vender";
            // 
            // instrumentSearchListSell
            // 
            this.instrumentSearchListSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instrumentSearchListSell.Location = new System.Drawing.Point(3, 16);
            this.instrumentSearchListSell.Name = "instrumentSearchListSell";
            this.instrumentSearchListSell.Size = new System.Drawing.Size(320, 439);
            this.instrumentSearchListSell.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.instrumentSearchListBuy);
            this.groupBox1.Location = new System.Drawing.Point(332, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 458);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Instrumento a comprar";
            // 
            // instrumentSearchListBuy
            // 
            this.instrumentSearchListBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instrumentSearchListBuy.Location = new System.Drawing.Point(3, 16);
            this.instrumentSearchListBuy.Name = "instrumentSearchListBuy";
            this.instrumentSearchListBuy.Size = new System.Drawing.Size(317, 439);
            this.instrumentSearchListBuy.TabIndex = 1;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(3, 471);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(10);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(649, 40);
            this.btnLaunch.TabIndex = 10;
            this.btnLaunch.Text = "Abrir trade de ratio";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // FrmRatioTradeLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 515);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRatioTradeLauncher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Abrir trade de ratio";
            this.Load += new System.EventHandler(this.FrmRatioTradeLauncher_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Shared.InstrumentSearchList instrumentSearchListSell;
        private Shared.InstrumentSearchList instrumentSearchListBuy;
        private System.Windows.Forms.Button btnLaunch;
    }
}