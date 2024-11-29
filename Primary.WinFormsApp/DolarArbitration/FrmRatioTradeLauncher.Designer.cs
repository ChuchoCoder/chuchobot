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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatioTradeLauncher));
            groupBox3 = new System.Windows.Forms.GroupBox();
            instrumentSearchListSell = new Shared.InstrumentSearchList();
            groupBox1 = new System.Windows.Forms.GroupBox();
            instrumentSearchListBuy = new Shared.InstrumentSearchList();
            btnLaunch = new System.Windows.Forms.Button();
            btnArbitrajeDolar = new System.Windows.Forms.Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(instrumentSearchListSell);
            groupBox3.Location = new System.Drawing.Point(0, 0);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Size = new System.Drawing.Size(435, 705);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seleccionar Instrumento a vender (compra MEP Barato)";
            // 
            // instrumentSearchListSell
            // 
            instrumentSearchListSell.Dock = System.Windows.Forms.DockStyle.Fill;
            instrumentSearchListSell.Location = new System.Drawing.Point(4, 25);
            instrumentSearchListSell.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            instrumentSearchListSell.Name = "instrumentSearchListSell";
            instrumentSearchListSell.SettlementsVisible = false;
            instrumentSearchListSell.Size = new System.Drawing.Size(427, 675);
            instrumentSearchListSell.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(instrumentSearchListBuy);
            groupBox1.Location = new System.Drawing.Point(443, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(431, 705);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Instrumento a comprar (venta MEP Caro)";
            // 
            // instrumentSearchListBuy
            // 
            instrumentSearchListBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            instrumentSearchListBuy.Location = new System.Drawing.Point(4, 25);
            instrumentSearchListBuy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            instrumentSearchListBuy.Name = "instrumentSearchListBuy";
            instrumentSearchListBuy.SettlementsVisible = false;
            instrumentSearchListBuy.Size = new System.Drawing.Size(423, 675);
            instrumentSearchListBuy.TabIndex = 1;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new System.Drawing.Point(4, 711);
            btnLaunch.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new System.Drawing.Size(866, 39);
            btnLaunch.TabIndex = 10;
            btnLaunch.Text = "Abrir trade de ratio";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // btnArbitrajeDolar
            // 
            btnArbitrajeDolar.Location = new System.Drawing.Point(4, 751);
            btnArbitrajeDolar.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            btnArbitrajeDolar.Name = "btnArbitrajeDolar";
            btnArbitrajeDolar.Size = new System.Drawing.Size(866, 39);
            btnArbitrajeDolar.TabIndex = 11;
            btnArbitrajeDolar.Text = "Abrir trade de arbitraje dolar";
            btnArbitrajeDolar.UseVisualStyleBackColor = true;
            btnArbitrajeDolar.Click += btnArbitrajeDolar_Click;
            // 
            // FrmRatioTradeLauncher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(876, 792);
            Controls.Add(btnArbitrajeDolar);
            Controls.Add(btnLaunch);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmRatioTradeLauncher";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Abrir trade de ratio";
            Load += FrmRatioTradeLauncher_Load;
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Shared.InstrumentSearchList instrumentSearchListSell;
        private Shared.InstrumentSearchList instrumentSearchListBuy;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnArbitrajeDolar;
    }
}