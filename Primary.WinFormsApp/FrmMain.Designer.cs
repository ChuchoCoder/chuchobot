namespace ChuchoBot.WinFormsApp
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
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentosParaArbitrajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesCEDEARsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickersDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolarPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorDeArbitrajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorArbitrajesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarInstrumentoYPlazosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbInstruments = new System.Windows.Forms.ToolStripComboBox();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arbitrajeRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longGD30ShortAL30 = new System.Windows.Forms.ToolStripMenuItem();
            this.longAL30ShortGD30 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrConnection = new System.Windows.Forms.Timer(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.connected = new System.Windows.Forms.ToolStripStatusLabel();
            this.disconnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.appVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.longGD35ShortAL35 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.historicDataToolStripMenuItem,
            this.dolarPricesToolStripMenuItem,
            this.buscadorDeArbitrajesToolStripMenuItem,
            this.buscadorArbitrajesSimplesToolStripMenuItem,
            this.marketDataToolStripMenuItem,
            this.refreshDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.arbitrajeRatioToolStripMenuItem,
            this.caucionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1548, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentosParaArbitrajeToolStripMenuItem,
            this.accionesCEDEARsToolStripMenuItem,
            this.letrasToolStripMenuItem,
            this.tickersDCToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // instrumentosParaArbitrajeToolStripMenuItem
            // 
            this.instrumentosParaArbitrajeToolStripMenuItem.Name = "instrumentosParaArbitrajeToolStripMenuItem";
            this.instrumentosParaArbitrajeToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.instrumentosParaArbitrajeToolStripMenuItem.Text = "Instrumentos a monitorear";
            this.instrumentosParaArbitrajeToolStripMenuItem.Click += new System.EventHandler(this.instrumentosParaArbitrajeToolStripMenuItem_Click);
            // 
            // accionesCEDEARsToolStripMenuItem
            // 
            this.accionesCEDEARsToolStripMenuItem.Name = "accionesCEDEARsToolStripMenuItem";
            this.accionesCEDEARsToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.accionesCEDEARsToolStripMenuItem.Text = "Acciones && CEDEARs";
            this.accionesCEDEARsToolStripMenuItem.Click += new System.EventHandler(this.accionesCEDEARsToolStripMenuItem_Click);
            // 
            // letrasToolStripMenuItem
            // 
            this.letrasToolStripMenuItem.Name = "letrasToolStripMenuItem";
            this.letrasToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.letrasToolStripMenuItem.Text = "Letras";
            this.letrasToolStripMenuItem.Click += new System.EventHandler(this.letrasToolStripMenuItem_Click);
            // 
            // tickersDCToolStripMenuItem
            // 
            this.tickersDCToolStripMenuItem.Name = "tickersDCToolStripMenuItem";
            this.tickersDCToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.tickersDCToolStripMenuItem.Text = "Excepciones de instrumentos $;D;C";
            this.tickersDCToolStripMenuItem.Click += new System.EventHandler(this.tickersDCToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Visible = false;
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // historicDataToolStripMenuItem
            // 
            this.historicDataToolStripMenuItem.Name = "historicDataToolStripMenuItem";
            this.historicDataToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.historicDataToolStripMenuItem.Text = "Historic Data";
            this.historicDataToolStripMenuItem.Visible = false;
            this.historicDataToolStripMenuItem.Click += new System.EventHandler(this.historicDataToolStripMenuItem_Click);
            // 
            // dolarPricesToolStripMenuItem
            // 
            this.dolarPricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraMEPToolStripMenuItem,
            this.ventaMEPToolStripMenuItem,
            this.toolStripSeparator1,
            this.compraCCLToolStripMenuItem,
            this.ventaCCLToolStripMenuItem});
            this.dolarPricesToolStripMenuItem.Name = "dolarPricesToolStripMenuItem";
            this.dolarPricesToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.dolarPricesToolStripMenuItem.Text = "Precios Dolar MEP/CCL";
            this.dolarPricesToolStripMenuItem.Click += new System.EventHandler(this.dolarPricesToolStripMenuItem_Click);
            // 
            // compraMEPToolStripMenuItem
            // 
            this.compraMEPToolStripMenuItem.Name = "compraMEPToolStripMenuItem";
            this.compraMEPToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.compraMEPToolStripMenuItem.Text = "Ver Precios para Compra MEP";
            this.compraMEPToolStripMenuItem.Click += new System.EventHandler(this.compraMEPToolStripMenuItem_Click);
            // 
            // ventaMEPToolStripMenuItem
            // 
            this.ventaMEPToolStripMenuItem.Name = "ventaMEPToolStripMenuItem";
            this.ventaMEPToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ventaMEPToolStripMenuItem.Text = "Ver Precios para Venta MEP";
            this.ventaMEPToolStripMenuItem.Click += new System.EventHandler(this.ventaMEPToolStripMenuItem_Click);
            // 
            // compraCCLToolStripMenuItem
            // 
            this.compraCCLToolStripMenuItem.Name = "compraCCLToolStripMenuItem";
            this.compraCCLToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.compraCCLToolStripMenuItem.Text = "Ver Precios para Compra CCL";
            this.compraCCLToolStripMenuItem.Click += new System.EventHandler(this.compraCCLToolStripMenuItem_Click);
            // 
            // ventaCCLToolStripMenuItem
            // 
            this.ventaCCLToolStripMenuItem.Name = "ventaCCLToolStripMenuItem";
            this.ventaCCLToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ventaCCLToolStripMenuItem.Text = "Ver Precios para Venta CCL";
            this.ventaCCLToolStripMenuItem.Click += new System.EventHandler(this.ventaCCLToolStripMenuItem_Click);
            // 
            // buscadorDeArbitrajesToolStripMenuItem
            // 
            this.buscadorDeArbitrajesToolStripMenuItem.Name = "buscadorDeArbitrajesToolStripMenuItem";
            this.buscadorDeArbitrajesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.buscadorDeArbitrajesToolStripMenuItem.Text = "Arbitrajes Dolar";
            this.buscadorDeArbitrajesToolStripMenuItem.Click += new System.EventHandler(this.buscadorDeArbitrajesToolStripMenuItem_Click);
            // 
            // buscadorArbitrajesSimplesToolStripMenuItem
            // 
            this.buscadorArbitrajesSimplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirScannerToolStripMenuItem,
            this.seleccionarInstrumentoYPlazosToolStripMenuItem});
            this.buscadorArbitrajesSimplesToolStripMenuItem.Name = "buscadorArbitrajesSimplesToolStripMenuItem";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.buscadorArbitrajesSimplesToolStripMenuItem.Text = "Arbitrajes de Plazo";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Click += new System.EventHandler(this.buscadorArbitrajesSimplesToolStripMenuItem_Click);
            // 
            // abrirScannerToolStripMenuItem
            // 
            this.abrirScannerToolStripMenuItem.Name = "abrirScannerToolStripMenuItem";
            this.abrirScannerToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.abrirScannerToolStripMenuItem.Text = "Abrir scanner";
            this.abrirScannerToolStripMenuItem.Click += new System.EventHandler(this.abrirScannerToolStripMenuItem_Click);
            // 
            // seleccionarInstrumentoYPlazosToolStripMenuItem
            // 
            this.seleccionarInstrumentoYPlazosToolStripMenuItem.Name = "seleccionarInstrumentoYPlazosToolStripMenuItem";
            this.seleccionarInstrumentoYPlazosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.seleccionarInstrumentoYPlazosToolStripMenuItem.Text = "Seleccionar Instrumento y Plazos";
            this.seleccionarInstrumentoYPlazosToolStripMenuItem.Click += new System.EventHandler(this.seleccionarInstrumentoYPlazosToolStripMenuItem_Click);
            // 
            // marketDataToolStripMenuItem
            // 
            this.marketDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbInstruments});
            this.marketDataToolStripMenuItem.Name = "marketDataToolStripMenuItem";
            this.marketDataToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.marketDataToolStripMenuItem.Text = "MarketData";
            this.marketDataToolStripMenuItem.Visible = false;
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(121, 23);
            this.cmbInstruments.SelectedIndexChanged += new System.EventHandler(this.cmbInstruments_SelectedIndexChanged);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Visible = false;
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // arbitrajeRatioToolStripMenuItem
            // 
            this.arbitrajeRatioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.longGD30ShortAL30,
            this.longAL30ShortGD30,
            this.longGD35ShortAL35,
            this.toolStripSeparator2,
            this.seleccionarToolStripMenuItem,
            this.toolStripSeparator3,
            this.ratiosToolStripMenuItem});
            this.arbitrajeRatioToolStripMenuItem.Name = "arbitrajeRatioToolStripMenuItem";
            this.arbitrajeRatioToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arbitrajeRatioToolStripMenuItem.Text = "Ratio";
            // 
            // longGD30ShortAL30
            // 
            this.longGD30ShortAL30.Name = "longGD30ShortAL30";
            this.longGD30ShortAL30.Size = new System.Drawing.Size(247, 22);
            this.longGD30ShortAL30.Text = "Long GD30 / Short AL30";
            this.longGD30ShortAL30.Click += new System.EventHandler(this.longGD30ShortAL30ToolStripMenuItem_Click);
            // 
            // longAL30ShortGD30
            // 
            this.longAL30ShortGD30.Name = "longAL30ShortGD30";
            this.longAL30ShortGD30.Size = new System.Drawing.Size(247, 22);
            this.longAL30ShortGD30.Text = "Long AL30 / Short GD30";
            this.longAL30ShortGD30.Click += new System.EventHandler(this.longAL30ShortGD30ToolStripMenuItem_Click);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.seleccionarToolStripMenuItem.Text = "Seleccionar Instrumentos y Plazo";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.seleccionarToolStripMenuItem_Click);
            // 
            // ratiosToolStripMenuItem
            // 
            this.ratiosToolStripMenuItem.Name = "ratiosToolStripMenuItem";
            this.ratiosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ratiosToolStripMenuItem.Text = "Ver Ratios de Bonos";
            this.ratiosToolStripMenuItem.Click += new System.EventHandler(this.ratiosToolStripMenuItem_Click);
            // 
            // caucionToolStripMenuItem
            // 
            this.caucionToolStripMenuItem.Name = "caucionToolStripMenuItem";
            this.caucionToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.caucionToolStripMenuItem.Text = "Calculadora Caución";
            this.caucionToolStripMenuItem.Click += new System.EventHandler(this.caucionToolStripMenuItem_Click);
            // 
            // tmrConnection
            // 
            this.tmrConnection.Interval = 3000;
            this.tmrConnection.Tick += new System.EventHandler(this.tmrConnection_Tick);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connected,
            this.disconnected,
            this.statusInformation,
            this.appVersion});
            this.statusBar.Location = new System.Drawing.Point(0, 532);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1548, 22);
            this.statusBar.TabIndex = 3;
            // 
            // connected
            // 
            this.connected.Image = ((System.Drawing.Image)(resources.GetObject("connected.Image")));
            this.connected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(85, 20);
            this.connected.Text = "Conectado";
            this.connected.Visible = false;
            // 
            // disconnected
            // 
            this.disconnected.Image = ((System.Drawing.Image)(resources.GetObject("disconnected.Image")));
            this.disconnected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnected.Name = "disconnected";
            this.disconnected.Size = new System.Drawing.Size(102, 20);
            this.disconnected.Text = "Desconectado";
            this.disconnected.Visible = false;
            // 
            // statusInformation
            // 
            this.statusInformation.Name = "statusInformation";
            this.statusInformation.Size = new System.Drawing.Size(1452, 17);
            this.statusInformation.Spring = true;
            // 
            // appVersion
            // 
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(76, 17);
            this.appVersion.Text = "v2023.10.23.0";
            this.appVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
            // 
            // longGD35ShortAL35
            // 
            this.longGD35ShortAL35.Name = "longGD35ShortAL35";
            this.longGD35ShortAL35.Size = new System.Drawing.Size(247, 22);
            this.longGD35ShortAL35.Text = "Long GD35 / Short AL35";
            this.longGD35ShortAL35.Click += new System.EventHandler(this.longGD35shortAL35_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 554);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Chucho Bot ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraMEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraCCLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaCCLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentosParaArbitrajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesCEDEARsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickersDCToolStripMenuItem;
        private System.Windows.Forms.Timer tmrConnection;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel disconnected;
        private System.Windows.Forms.ToolStripStatusLabel statusInformation;
        private System.Windows.Forms.ToolStripStatusLabel appVersion;
        private System.Windows.Forms.ToolStripStatusLabel connected;
        private System.Windows.Forms.ToolStripMenuItem abrirScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarInstrumentoYPlazosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbitrajeRatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longGD30ShortAL30;
        private System.Windows.Forms.ToolStripMenuItem longAL30ShortGD30;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem longGD35ShortAL35;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

