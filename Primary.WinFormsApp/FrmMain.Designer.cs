namespace Primary.WinFormsApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorDeArbitrajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolarPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbInstruments = new System.Windows.Forms.ToolStripComboBox();
            this.buscadorArbitrajesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrConnection = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.historicDataToolStripMenuItem,
            this.buscadorDeArbitrajesToolStripMenuItem,
            this.dolarPricesToolStripMenuItem,
            this.marketDataToolStripMenuItem,
            this.buscadorArbitrajesSimplesToolStripMenuItem,
            this.refreshDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Visible = false;
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // historicDataToolStripMenuItem
            // 
            this.historicDataToolStripMenuItem.Name = "historicDataToolStripMenuItem";
            this.historicDataToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.historicDataToolStripMenuItem.Text = "Historic Data";
            this.historicDataToolStripMenuItem.Visible = false;
            this.historicDataToolStripMenuItem.Click += new System.EventHandler(this.historicDataToolStripMenuItem_Click);
            // 
            // buscadorDeArbitrajesToolStripMenuItem
            // 
            this.buscadorDeArbitrajesToolStripMenuItem.Name = "buscadorDeArbitrajesToolStripMenuItem";
            this.buscadorDeArbitrajesToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.buscadorDeArbitrajesToolStripMenuItem.Text = "Arbitrajes Dolar";
            this.buscadorDeArbitrajesToolStripMenuItem.Click += new System.EventHandler(this.buscadorDeArbitrajesToolStripMenuItem_Click);
            // 
            // dolarPricesToolStripMenuItem
            // 
            this.dolarPricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraMEPToolStripMenuItem,
            this.ventaMEPToolStripMenuItem,
            this.compraCCLToolStripMenuItem,
            this.ventaCCLToolStripMenuItem});
            this.dolarPricesToolStripMenuItem.Name = "dolarPricesToolStripMenuItem";
            this.dolarPricesToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.dolarPricesToolStripMenuItem.Text = "Dolar Prices";
            this.dolarPricesToolStripMenuItem.Click += new System.EventHandler(this.dolarPricesToolStripMenuItem_Click);
            // 
            // compraMEPToolStripMenuItem
            // 
            this.compraMEPToolStripMenuItem.Name = "compraMEPToolStripMenuItem";
            this.compraMEPToolStripMenuItem.Size = new System.Drawing.Size(285, 44);
            this.compraMEPToolStripMenuItem.Text = "Compra MEP";
            this.compraMEPToolStripMenuItem.Click += new System.EventHandler(this.compraMEPToolStripMenuItem_Click);
            // 
            // ventaMEPToolStripMenuItem
            // 
            this.ventaMEPToolStripMenuItem.Name = "ventaMEPToolStripMenuItem";
            this.ventaMEPToolStripMenuItem.Size = new System.Drawing.Size(285, 44);
            this.ventaMEPToolStripMenuItem.Text = "Venta MEP";
            this.ventaMEPToolStripMenuItem.Click += new System.EventHandler(this.ventaMEPToolStripMenuItem_Click);
            // 
            // compraCCLToolStripMenuItem
            // 
            this.compraCCLToolStripMenuItem.Name = "compraCCLToolStripMenuItem";
            this.compraCCLToolStripMenuItem.Size = new System.Drawing.Size(285, 44);
            this.compraCCLToolStripMenuItem.Text = "Compra CCL";
            this.compraCCLToolStripMenuItem.Click += new System.EventHandler(this.compraCCLToolStripMenuItem_Click);
            // 
            // ventaCCLToolStripMenuItem
            // 
            this.ventaCCLToolStripMenuItem.Name = "ventaCCLToolStripMenuItem";
            this.ventaCCLToolStripMenuItem.Size = new System.Drawing.Size(285, 44);
            this.ventaCCLToolStripMenuItem.Text = "Venta CCL";
            this.ventaCCLToolStripMenuItem.Click += new System.EventHandler(this.ventaCCLToolStripMenuItem_Click);
            // 
            // marketDataToolStripMenuItem
            // 
            this.marketDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbInstruments});
            this.marketDataToolStripMenuItem.Name = "marketDataToolStripMenuItem";
            this.marketDataToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.marketDataToolStripMenuItem.Text = "MarketData";
            this.marketDataToolStripMenuItem.Visible = false;
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(121, 40);
            this.cmbInstruments.SelectedIndexChanged += new System.EventHandler(this.cmbInstruments_SelectedIndexChanged);
            // 
            // buscadorArbitrajesSimplesToolStripMenuItem
            // 
            this.buscadorArbitrajesSimplesToolStripMenuItem.Name = "buscadorArbitrajesSimplesToolStripMenuItem";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Size = new System.Drawing.Size(231, 36);
            this.buscadorArbitrajesSimplesToolStripMenuItem.Text = "Arbitrajes de Plazo";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Click += new System.EventHandler(this.buscadorArbitrajesSimplesToolStripMenuItem_Click);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Visible = false;
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // tmrConnection
            // 
            this.tmrConnection.Interval = 3000;
            this.tmrConnection.Tick += new System.EventHandler(this.tmrConnection_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Arbitrador de Peronia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorDeArbitrajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbInstruments;
        private System.Windows.Forms.ToolStripMenuItem dolarPricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorArbitrajesSimplesToolStripMenuItem;
        private System.Windows.Forms.Timer tmrConnection;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraMEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraCCLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaCCLToolStripMenuItem;
    }
}

