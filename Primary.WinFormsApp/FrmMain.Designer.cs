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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            instrumentosParaArbitrajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tickersDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ratiosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            historicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dolarPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            compraMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ventaMEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            compraCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ventaCCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buscadorDeArbitrajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buscadorArbitrajesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seleccionarInstrumentoYPlazosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            marketDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cmbInstruments = new System.Windows.Forms.ToolStripComboBox();
            refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            arbitrajeRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            longGD30ShortAL30 = new System.Windows.Forms.ToolStripMenuItem();
            longAL30ShortGD30 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            longGD35ShortAL35 = new System.Windows.Forms.ToolStripMenuItem();
            shortGD35LongAL35ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            longAL30ShortGD35ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            longGD35ShortAL30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            longAL30ShortAL35ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            shortAL30LongAL35ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ratiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            caucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tmrConnection = new System.Windows.Forms.Timer(components);
            statusBar = new System.Windows.Forms.StatusStrip();
            connected = new System.Windows.Forms.ToolStripStatusLabel();
            disconnected = new System.Windows.Forms.ToolStripStatusLabel();
            statusInformation = new System.Windows.Forms.ToolStripStatusLabel();
            appVersion = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { loginToolStripMenuItem, configuraciónToolStripMenuItem, connectToolStripMenuItem, historicDataToolStripMenuItem, dolarPricesToolStripMenuItem, buscadorDeArbitrajesToolStripMenuItem, buscadorArbitrajesSimplesToolStripMenuItem, marketDataToolStripMenuItem, refreshDataToolStripMenuItem, toolStripMenuItem1, arbitrajeRatioToolStripMenuItem, caucionToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1547, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { instrumentosParaArbitrajeToolStripMenuItem, tickersDCToolStripMenuItem, ratiosToolStripMenuItem1 });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // instrumentosParaArbitrajeToolStripMenuItem
            // 
            instrumentosParaArbitrajeToolStripMenuItem.Name = "instrumentosParaArbitrajeToolStripMenuItem";
            instrumentosParaArbitrajeToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            instrumentosParaArbitrajeToolStripMenuItem.Text = "Instrumentos a monitorear";
            instrumentosParaArbitrajeToolStripMenuItem.Click += instrumentosParaArbitrajeToolStripMenuItem_Click;
            // 
            // tickersDCToolStripMenuItem
            // 
            tickersDCToolStripMenuItem.Name = "tickersDCToolStripMenuItem";
            tickersDCToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            tickersDCToolStripMenuItem.Text = "Excepciones de instrumentos $;D;C";
            tickersDCToolStripMenuItem.Click += tickersDCToolStripMenuItem_Click;
            // 
            // ratiosToolStripMenuItem1
            // 
            ratiosToolStripMenuItem1.Name = "ratiosToolStripMenuItem1";
            ratiosToolStripMenuItem1.Size = new System.Drawing.Size(321, 26);
            ratiosToolStripMenuItem1.Text = "Ratios";
            ratiosToolStripMenuItem1.Click += ratiosToolStripMenuItem1_Click;
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Visible = false;
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // historicDataToolStripMenuItem
            // 
            historicDataToolStripMenuItem.Name = "historicDataToolStripMenuItem";
            historicDataToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            historicDataToolStripMenuItem.Text = "Historic Data";
            historicDataToolStripMenuItem.Visible = false;
            historicDataToolStripMenuItem.Click += historicDataToolStripMenuItem_Click;
            // 
            // dolarPricesToolStripMenuItem
            // 
            dolarPricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { compraMEPToolStripMenuItem, ventaMEPToolStripMenuItem, toolStripSeparator1, compraCCLToolStripMenuItem, ventaCCLToolStripMenuItem });
            dolarPricesToolStripMenuItem.Name = "dolarPricesToolStripMenuItem";
            dolarPricesToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            dolarPricesToolStripMenuItem.Text = "Precios Dolar MEP/CCL";
            dolarPricesToolStripMenuItem.Click += dolarPricesToolStripMenuItem_Click;
            // 
            // compraMEPToolStripMenuItem
            // 
            compraMEPToolStripMenuItem.Name = "compraMEPToolStripMenuItem";
            compraMEPToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            compraMEPToolStripMenuItem.Text = "Ver Precios para Compra MEP";
            compraMEPToolStripMenuItem.Click += compraMEPToolStripMenuItem_Click;
            // 
            // ventaMEPToolStripMenuItem
            // 
            ventaMEPToolStripMenuItem.Name = "ventaMEPToolStripMenuItem";
            ventaMEPToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            ventaMEPToolStripMenuItem.Text = "Ver Precios para Venta MEP";
            ventaMEPToolStripMenuItem.Click += ventaMEPToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // compraCCLToolStripMenuItem
            // 
            compraCCLToolStripMenuItem.Name = "compraCCLToolStripMenuItem";
            compraCCLToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            compraCCLToolStripMenuItem.Text = "Ver Precios para Compra CCL";
            compraCCLToolStripMenuItem.Click += compraCCLToolStripMenuItem_Click;
            // 
            // ventaCCLToolStripMenuItem
            // 
            ventaCCLToolStripMenuItem.Name = "ventaCCLToolStripMenuItem";
            ventaCCLToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            ventaCCLToolStripMenuItem.Text = "Ver Precios para Venta CCL";
            ventaCCLToolStripMenuItem.Click += ventaCCLToolStripMenuItem_Click;
            // 
            // buscadorDeArbitrajesToolStripMenuItem
            // 
            buscadorDeArbitrajesToolStripMenuItem.Name = "buscadorDeArbitrajesToolStripMenuItem";
            buscadorDeArbitrajesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            buscadorDeArbitrajesToolStripMenuItem.Text = "Arbitrajes Dolar";
            buscadorDeArbitrajesToolStripMenuItem.Click += buscadorDeArbitrajesToolStripMenuItem_Click;
            // 
            // buscadorArbitrajesSimplesToolStripMenuItem
            // 
            buscadorArbitrajesSimplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { abrirScannerToolStripMenuItem, seleccionarInstrumentoYPlazosToolStripMenuItem });
            buscadorArbitrajesSimplesToolStripMenuItem.Name = "buscadorArbitrajesSimplesToolStripMenuItem";
            buscadorArbitrajesSimplesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            buscadorArbitrajesSimplesToolStripMenuItem.Text = "Arbitrajes de Plazo";
            buscadorArbitrajesSimplesToolStripMenuItem.Click += buscadorArbitrajesSimplesToolStripMenuItem_Click;
            // 
            // abrirScannerToolStripMenuItem
            // 
            abrirScannerToolStripMenuItem.Name = "abrirScannerToolStripMenuItem";
            abrirScannerToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            abrirScannerToolStripMenuItem.Text = "Abrir scanner";
            abrirScannerToolStripMenuItem.Click += abrirScannerToolStripMenuItem_Click;
            // 
            // seleccionarInstrumentoYPlazosToolStripMenuItem
            // 
            seleccionarInstrumentoYPlazosToolStripMenuItem.Name = "seleccionarInstrumentoYPlazosToolStripMenuItem";
            seleccionarInstrumentoYPlazosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            seleccionarInstrumentoYPlazosToolStripMenuItem.Text = "Seleccionar Instrumento y Plazos";
            seleccionarInstrumentoYPlazosToolStripMenuItem.Click += seleccionarInstrumentoYPlazosToolStripMenuItem_Click;
            // 
            // marketDataToolStripMenuItem
            // 
            marketDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cmbInstruments });
            marketDataToolStripMenuItem.Name = "marketDataToolStripMenuItem";
            marketDataToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            marketDataToolStripMenuItem.Text = "MarketData";
            marketDataToolStripMenuItem.Visible = false;
            // 
            // cmbInstruments
            // 
            cmbInstruments.Name = "cmbInstruments";
            cmbInstruments.Size = new System.Drawing.Size(121, 28);
            cmbInstruments.SelectedIndexChanged += cmbInstruments_SelectedIndexChanged;
            // 
            // refreshDataToolStripMenuItem
            // 
            refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            refreshDataToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            refreshDataToolStripMenuItem.Text = "Refresh Data";
            refreshDataToolStripMenuItem.Visible = false;
            refreshDataToolStripMenuItem.Click += refreshDataToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // arbitrajeRatioToolStripMenuItem
            // 
            arbitrajeRatioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { longGD30ShortAL30, longAL30ShortGD30, toolStripSeparator4, longGD35ShortAL35, shortGD35LongAL35ToolStripMenuItem, toolStripSeparator5, longAL30ShortGD35ToolStripMenuItem, longGD35ShortAL30ToolStripMenuItem, toolStripSeparator6, longAL30ShortAL35ToolStripMenuItem, shortAL30LongAL35ToolStripMenuItem, toolStripSeparator2, seleccionarToolStripMenuItem, toolStripSeparator3, ratiosToolStripMenuItem });
            arbitrajeRatioToolStripMenuItem.Name = "arbitrajeRatioToolStripMenuItem";
            arbitrajeRatioToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            arbitrajeRatioToolStripMenuItem.Text = "Ratio";
            // 
            // longGD30ShortAL30
            // 
            longGD30ShortAL30.Name = "longGD30ShortAL30";
            longGD30ShortAL30.Size = new System.Drawing.Size(308, 26);
            longGD30ShortAL30.Text = "Long GD30 / Short AL30";
            longGD30ShortAL30.Click += longGD30ShortAL30ToolStripMenuItem_Click;
            // 
            // longAL30ShortGD30
            // 
            longAL30ShortGD30.Name = "longAL30ShortGD30";
            longAL30ShortGD30.Size = new System.Drawing.Size(308, 26);
            longAL30ShortGD30.Text = "Short GD30 / Long AL30";
            longAL30ShortGD30.Click += longAL30ShortGD30ToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(305, 6);
            // 
            // longGD35ShortAL35
            // 
            longGD35ShortAL35.Name = "longGD35ShortAL35";
            longGD35ShortAL35.Size = new System.Drawing.Size(308, 26);
            longGD35ShortAL35.Text = "Long GD35 / Short AL35";
            longGD35ShortAL35.Click += longGD35shortAL35_Click;
            // 
            // shortGD35LongAL35ToolStripMenuItem
            // 
            shortGD35LongAL35ToolStripMenuItem.Name = "shortGD35LongAL35ToolStripMenuItem";
            shortGD35LongAL35ToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            shortGD35LongAL35ToolStripMenuItem.Text = "Short GD35 / Long AL35";
            shortGD35LongAL35ToolStripMenuItem.Click += shortGD35LongAL35ToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(305, 6);
            // 
            // longAL30ShortGD35ToolStripMenuItem
            // 
            longAL30ShortGD35ToolStripMenuItem.Name = "longAL30ShortGD35ToolStripMenuItem";
            longAL30ShortGD35ToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            longAL30ShortGD35ToolStripMenuItem.Text = "Long AL30 / Short GD35";
            longAL30ShortGD35ToolStripMenuItem.Click += longAL30ShortGD35ToolStripMenuItem_Click;
            // 
            // longGD35ShortAL30ToolStripMenuItem
            // 
            longGD35ShortAL30ToolStripMenuItem.Name = "longGD35ShortAL30ToolStripMenuItem";
            longGD35ShortAL30ToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            longGD35ShortAL30ToolStripMenuItem.Text = "Short AL30 / Long GD35";
            longGD35ShortAL30ToolStripMenuItem.Click += longGD35ShortAL30ToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(305, 6);
            // 
            // longAL30ShortAL35ToolStripMenuItem
            // 
            longAL30ShortAL35ToolStripMenuItem.Name = "longAL30ShortAL35ToolStripMenuItem";
            longAL30ShortAL35ToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            longAL30ShortAL35ToolStripMenuItem.Text = "Long AL30 / Short AL35";
            longAL30ShortAL35ToolStripMenuItem.Click += longAL30ShortAL35ToolStripMenuItem_Click;
            // 
            // shortAL30LongAL35ToolStripMenuItem
            // 
            shortAL30LongAL35ToolStripMenuItem.Name = "shortAL30LongAL35ToolStripMenuItem";
            shortAL30LongAL35ToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            shortAL30LongAL35ToolStripMenuItem.Text = "Short AL30 / Long AL35";
            shortAL30LongAL35ToolStripMenuItem.Click += shortAL30LongAL35ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // seleccionarToolStripMenuItem
            // 
            seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            seleccionarToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            seleccionarToolStripMenuItem.Text = "Seleccionar Instrumentos y Plazo";
            seleccionarToolStripMenuItem.Click += seleccionarToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // ratiosToolStripMenuItem
            // 
            ratiosToolStripMenuItem.Name = "ratiosToolStripMenuItem";
            ratiosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            ratiosToolStripMenuItem.Text = "Ver Ratios de Bonos";
            ratiosToolStripMenuItem.Click += ratiosToolStripMenuItem_Click;
            // 
            // caucionToolStripMenuItem
            // 
            caucionToolStripMenuItem.Name = "caucionToolStripMenuItem";
            caucionToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            caucionToolStripMenuItem.Text = "Calculadora Caución";
            caucionToolStripMenuItem.Click += caucionToolStripMenuItem_Click;
            // 
            // tmrConnection
            // 
            tmrConnection.Interval = 3000;
            tmrConnection.Tick += tmrConnection_Tick;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { connected, disconnected, statusInformation, appVersion });
            statusBar.Location = new System.Drawing.Point(0, 666);
            statusBar.Name = "statusBar";
            statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            statusBar.Size = new System.Drawing.Size(1547, 26);
            statusBar.TabIndex = 3;
            // 
            // connected
            // 
            connected.Image = (System.Drawing.Image)resources.GetObject("connected.Image");
            connected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            connected.Name = "connected";
            connected.Size = new System.Drawing.Size(101, 20);
            connected.Text = "Conectado";
            connected.Visible = false;
            // 
            // disconnected
            // 
            disconnected.Image = (System.Drawing.Image)resources.GetObject("disconnected.Image");
            disconnected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            disconnected.Name = "disconnected";
            disconnected.Size = new System.Drawing.Size(124, 20);
            disconnected.Text = "Desconectado";
            disconnected.Visible = false;
            // 
            // statusInformation
            // 
            statusInformation.Name = "statusInformation";
            statusInformation.Size = new System.Drawing.Size(1430, 20);
            statusInformation.Spring = true;
            // 
            // appVersion
            // 
            appVersion.Name = "appVersion";
            appVersion.Size = new System.Drawing.Size(97, 20);
            appVersion.Text = "v2023.10.23.0";
            appVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1547, 692);
            Controls.Add(statusBar);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FrmMain";
            Text = "Chucho Bot ";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ratiosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem shortGD35LongAL35ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem longAL30ShortGD35ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longGD35ShortAL30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem longAL30ShortAL35ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortAL30LongAL35ToolStripMenuItem;
    }
}

