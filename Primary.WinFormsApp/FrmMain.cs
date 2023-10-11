using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmMain : Form
    {
        private List<string> watchList;
        private List<Task> backgroundTasks = new List<Task>();
        private Instrument[] _watchedInstruments;
        private DateTime _lastUpdate;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            if (await Login())
            {
                //var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
                //frmArbitrationAnalyzer.MdiParent = this;
                //frmArbitrationAnalyzer.WindowState = FormWindowState.Maximized;
                //frmArbitrationAnalyzer.Show();

                var frmSettlementAnalyzer = new FrmSettlementTermsAnalyzer();
                frmSettlementAnalyzer.WindowState = FormWindowState.Maximized;
                frmSettlementAnalyzer.Show();
            }
        }

        private async Task<bool> Login()
        {
            var login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                var text = this.Text;
                this.Text = "Login user...";
                Refresh();
                Argentina.Data.Init(login.BaseUrl);
                var success = await Argentina.Data.Api.Login(login.UserName, login.Password);

                if (success == false)
                {
                    MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK);
                    return await Login();
                }
                else
                {
                    Properties.Settings.Default.ApiBaseUrl = login.BaseUrl;
                    Properties.Settings.Default.UserName = login.UserName;
                    Properties.Settings.Default.Password = login.Password;
                    Properties.Settings.Default.Save();

                    this.Text = "Initiliazing Data...";
                    Refresh();
                    await Argentina.Data.Init();
                    
                    this.Text = "Initiliazing Watchlist...";
                    Refresh();
                    InitWatchList();
                    _watchedInstruments = Argentina.Data.AllInstruments.Where(ShouldWatch).Select(x => x.InstrumentId).ToArray();

                    foreach (var item in Argentina.Data.AllInstruments.OrderBy(x => x.InstrumentId.SymbolWithoutPrefix()))
                    {
                        cmbInstruments.Items.Add(item);
                    }

                    Argentina.Data.OnMarketData += Data_OnMarketData;

                    backgroundTasks.Add(Argentina.Data.WatchWithWebSocket(_watchedInstruments));
                    //backgroundTasks.AddRange(Argentina.Data.WatchWithRestApi(_watchedInstruments));
                    tmrConnection.Enabled = true;
                }
                this.Text = text;
                return true;
            }
            return false;
        }

        private void Data_OnMarketData(Instrument instrument, Entries data)
        {
            _lastUpdate = DateTime.Now;
        }

        private void MarketDataClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void InitWatchList()
        {
            //var bonds = new[] { "AL29", "AL30", "AL35", "AE38", "AL41", "GD29", "GD30", "GD35", "GD38", "GD41", "GD46" };
            var owned = Properties.Settings.Default.OwnedTickers.Cast<string>().ToList();
            var arbitration = Properties.Settings.Default.ArbitrationTickers.Cast<string>().ToList();
            var watched = Properties.Settings.Default.WatchedTickers.Cast<string>().ToList();

            var bonds = arbitration.Concat(owned).Concat(watched).Distinct();

            this.watchList = new List<string>();
            foreach (var item in bonds)
            {
                if (item.ContainsMultipleTickers())
                {
                    var pesosDC = item.GetMultipleTickers();
                    foreach (var itemParsed in pesosDC)
                    {
                        var settlementItems = itemParsed.GetAllSettlements();
                        watchList.AddRange(settlementItems);
                    }
                }
                else
                {
                    var allSymbols = item.GetAllMervalSymbols();
                    watchList.AddRange(allSymbols);
                }
            }

            // Caucion
            for (int i = 1; i < 10; i++)
            {
                var caucionTicker = Settlement.GetCaucionPesosTicker(i);
                var caucionInstrument = Argentina.Data.GetInstrumentDetailOrNull(caucionTicker);
                if (caucionInstrument != null)
                {
                    watchList.Add(caucionTicker);
                }
            }

        }

        private bool ShouldWatch(InstrumentDetail instrument)
        {
            if (watchList.Contains(instrument.InstrumentId.Symbol))
            {
                return true;
            }

            return false;
        }

        private async void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private void historicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmHistoric = new FrmHistoricData();
            //frmHistoric.MdiParent = this;
            frmHistoric.Show();
        }

        private void buscadorDeArbitrajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
            //frmArbitrationAnalyzer.MdiParent = this;
            frmArbitrationAnalyzer.Show();

        }

        private void cmbInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var instrument = cmbInstruments.SelectedItem as Instrument;
            var frmMarketData = new FrmMarketData();
            frmMarketData.SetInstrument(instrument);
            //frmMarketData.MdiParent = this;
            frmMarketData.Show();
        }

        private void dolarPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Argentina.Data.RefreshMarketData(_watchedInstruments).ToArray();
        }

        private void buscadorArbitrajesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSettlementTermsAnalyzer = new FrmSettlementTermsAnalyzer();
            //frmSettlementTermsAnalyzer.MdiParent = this;
            frmSettlementTermsAnalyzer.Show();
        }

        private void tmrConnection_Tick(object sender, EventArgs e)
        {
            var dif = DateTime.Now - _lastUpdate;

            if (dif.TotalSeconds < 10)
            {
                this.Icon = Properties.Resources.green_wifi;
                this.Text = $"Connected - Last WebSocket Message: {_lastUpdate:HH:mm:ss} {dif.TotalSeconds:#0} seconds ago";
            }
            else
            {
                this.Icon = Properties.Resources.red_wifi;
                this.Text = $"DISCONNECTED - Last WebSocket Message: {_lastUpdate:HH:mm:ss} {dif.TotalSeconds:#0} seconds ago";
            }

            foreach (Form openedForm in Application.OpenForms)
            {
                openedForm.Icon = this.Icon;
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundTasks.Add(Argentina.Data.WatchWithWebSocket(_watchedInstruments));
        }

        private void compraMEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDolarPrice();
            frm.Text = "Compra Dolar MEP";
            frm.Setup(x => x.GetDolarMEPTrades(), false);
            frm.Show();

        }

        private void ventaMEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDolarPrice();
            frm.Text = "Venta Dolar MEP";
            frm.Setup(x => x.GetDolarMEPTrades(), true);
            frm.Show();

        }

        private void compraCCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDolarPrice();
            frm.Text = "Compra Dolar CCL";
            frm.Setup(x => x.GetDolarCableTrades(), false);
            frm.Show();

        }

        private void ventaCCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDolarPrice();
            frm.Text = "Venta Dolar CCL";
            frm.Setup(x => x.GetDolarCableTrades(), true);
            frm.Show();

        }
    }
}
