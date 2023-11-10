using Primary.Data;
using Primary.WinFormsApp.DolarArbitration;
using Primary.WinFormsApp.Properties;
using Primary.WinFormsApp.SettlementTerms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmMain : Form
    {
        private List<string> watchList;
        private Instrument[] _watchedInstruments;
        private DateTime _lastUpdate;
        private Task primaryWebSocket;
        private readonly System.Timers.Timer AccountsTimer = new System.Timers.Timer(1000);
        private readonly System.Timers.Timer PositionsTimer = new System.Timers.Timer(1000);
        private bool LoginSuccessfull;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            Telemetry.InitializeLogging();
            Telemetry.LogInformation("Application started");
            Application.ThreadException += Application_ThreadException;
            Application.ApplicationExit += Application_ApplicationExit;
            AccountsTimer.Elapsed += tmrAccounts_Tick;
            PositionsTimer.Elapsed += tmrPositions_Tick;

            Settings.Default.Upgrade();
            Settings.Default.Save();

            ShowVersion();

            if (await Login())
            {
                //var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
                //frmArbitrationAnalyzer.MdiParent = this;
                //frmArbitrationAnalyzer.WindowState = FormWindowState.Maximized;
                //frmArbitrationAnalyzer.Show();

                var frmSettlementAnalyzer = new FrmSettlementTermsAnalyzer
                {
                    WindowState = FormWindowState.Maximized
                };
                frmSettlementAnalyzer.Show();
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            Telemetry.LogInformation("Application Exit");
        }

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Telemetry.LogError("Application ThreadException", e.Exception, true);
        }

        public bool ValidateIsConnected()
        {
            if (connected.Visible == false)
            {
                _ = MessageBox.Show("La aplicación esta desconectada. El usuario debe hacer Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool ValidateUserHasLogin()
        {
            if (LoginSuccessfull == false)
            {
                _ = MessageBox.Show("El usuario debe hacer Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void SetConnectionStatus(bool isConnected = true)
        {
            connected.Visible = isConnected;
            disconnected.Visible = !isConnected;
        }

        public void ShowVersion()
        {
            appVersion.Text = $"v{Telemetry.Version}";
        }

        private async Task<bool> Login()
        {
            var login = new FrmLogin();
            try
            {

                if (login.ShowDialog() == DialogResult.OK)
                {
                    var text = Text;
                    Text = "Login user...";
                    Refresh();
                    Argentina.Data.Init(login.BaseUrl);
                    LoginSuccessfull = await Argentina.Data.Api.Login(login.UserName, login.Password);

                    if (LoginSuccessfull == false)
                    {
                        Telemetry.Log($"Login Failed {login.BaseUrl}", logLevel: LogLevel.Warning);
                        _ = MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK);
                        Text = text;
                        return await Login();
                    }
                    else
                    {
                        Telemetry.Log($"Login Successfull {login.BaseUrl}", logLevel: LogLevel.Information);
                        Properties.Settings.Default.ApiBaseUrl = login.BaseUrl;
                        Properties.Settings.Default.UserName = login.UserName;
                        Properties.Settings.Default.Password = login.Password;
                        Properties.Settings.Default.Save();
                        SetConnectionStatus();

                        Text = "Initiliazing Data...";
                        Refresh();
                        await Argentina.Data.Init();

                        Text = "Initiliazing Watchlist...";
                        Refresh();

                        foreach (var item in Argentina.Data.AllInstruments.OrderBy(x => x.InstrumentId.SymbolWithoutPrefix()))
                        {
                            _ = cmbInstruments.Items.Add(item);
                        }

                        WatchInstrumentsWithWebSocket();
                        //backgroundTasks.AddRange(Argentina.Data.WatchWithRestApi(_watchedInstruments));
                        tmrConnection.Enabled = true;
                        AccountsTimer.Start();
                    }
                    Text = text;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Telemetry.LogError($"Login Error - {login.BaseUrl}", ex);
            }

            return false;
        }

        private void WatchInstrumentsWithWebSocket()
        {
            if (LoginSuccessfull)
            {
                InitWatchList();
                _watchedInstruments = Argentina.Data.AllInstruments.Where(ShouldWatch).Select(x => x.InstrumentId).ToArray();

                Argentina.Data.OnMarketData += Data_OnMarketData;

                primaryWebSocket = Argentina.Data.WatchWithWebSocket(_watchedInstruments);
            }
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

            var bonds = arbitration.Concat(owned).Distinct();

            watchList = new List<string>();
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
            for (var i = 1; i < 10; i++)
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
            return watchList.Contains(instrument.InstrumentId.Symbol);
        }

        private async void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = await Login();
        }

        private void historicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmHistoric = new FrmHistoricData();
            //frmHistoric.MdiParent = this;
            frmHistoric.Show();
        }

        private void buscadorDeArbitrajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frmArbitrationAnalyzer = new FrmArbitrationAnalyzer();
                //frmArbitrationAnalyzer.MdiParent = this;
                frmArbitrationAnalyzer.Show();
            }

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
            _ = Argentina.Data.RefreshMarketData(_watchedInstruments).ToArray();
        }

        private void buscadorArbitrajesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tmrConnection_Tick(object sender, EventArgs e)
        {
            var dif = DateTime.Now - _lastUpdate;

            var connected = dif.TotalSeconds < 15;

            SetConnectionStatus(connected);
            if (connected)
            {
                Icon = Properties.Resources.Robot;
                statusInformation.Text = "";
            }
            else
            {
                Icon = Properties.Resources.red_wifi;
                statusInformation.Text = $"Ultimo mensaje recibido hace {dif.TotalSeconds:#0} segundos";
                if (Argentina.IsMarketOpen())
                {
                    Telemetry.LogWarning(statusInformation.Text);
                }
            }

            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            primaryWebSocket = Argentina.Data.WatchWithWebSocket(_watchedInstruments);
        }

        private void compraMEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frm = new FrmDolarPrice
                {
                    Text = "Compra Dolar MEP"
                };
                frm.Setup(x => x.GetDolarMEPTrades(), false, System.ComponentModel.ListSortDirection.Ascending);
                frm.Show();
            }
        }

        private void ventaMEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frm = new FrmDolarPrice
                {
                    Text = "Venta Dolar MEP"
                };
                frm.Setup(x => x.GetDolarMEPTrades(), true, System.ComponentModel.ListSortDirection.Descending);
                frm.Show();
            }
        }

        private void compraCCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frm = new FrmDolarPrice
                {
                    Text = "Compra Dolar CCL"
                };
                frm.Setup(x => x.GetDolarCableTrades(), false, System.ComponentModel.ListSortDirection.Ascending);
                frm.Show();
            }
        }

        private void ventaCCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frm = new FrmDolarPrice
                {
                    Text = "Venta Dolar CCL"
                };
                frm.Setup(x => x.GetDolarCableTrades(), true, System.ComponentModel.ListSortDirection.Descending);
                frm.Show();
            }
        }

        private bool ValidateInstrument(string[] settings)
        {
            if (Argentina.Data.AllInstruments != null)
            {
                foreach (var setting in settings)
                {
                    var tickers = setting.Split(' ', ';');
                    foreach (var ticker in tickers)
                    {
                        if (Argentina.Data.AllInstruments.Any(x => x.InstrumentId.Symbol.Contains(ticker)) == false)
                        {
                            _ = MessageBox.Show($"El instrumento {ticker} no existe.", "Instrumento no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Telemetry.LogWarning($"El instrumento {ticker} no existe.");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void instrumentosParaArbitrajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Configuration.FrmStringCollectionEditor
            {
                Text = instrumentosParaArbitrajeToolStripMenuItem.Text,
                Setting = Properties.Settings.Default.ArbitrationTickers,
                Validator = ValidateInstrument
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                WatchInstrumentsWithWebSocket();
            }
        }

        private void tickersDCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Configuration.FrmStringCollectionEditor
            {
                Text = tickersDCToolStripMenuItem.Text,
                Setting = Properties.Settings.Default.TickersDC,
                Validator = ValidateInstrument
            };
            _ = frm.ShowDialog();

        }

        private void accionesCEDEARsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Configuration.FrmStringCollectionEditor
            {
                Text = accionesCEDEARsToolStripMenuItem.Text,
                Setting = Properties.Settings.Default.AccionesCEDEARs
            };
            _ = frm.ShowDialog();
        }

        private void letrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Configuration.FrmStringCollectionEditor
            {
                Text = letrasToolStripMenuItem.Text,
                Setting = Properties.Settings.Default.Letras,
                Validator = ValidateInstrument
            };
            _ = frm.ShowDialog();

        }

        private void tmrPositions_Tick(object sender, EventArgs e)
        {
            try
            {
                PositionsTimer.Stop();
                Argentina.Data.RefreshPositions();

                if (Argentina.Data.HasPositions() == false)
                {
                    statusInformation.Text = $"No se encontraron posiciones para ninguna de las cuentas asociadas";
                }

                PositionsTimer.Interval = Convert.ToInt32(TimeSpan.FromMinutes(1).TotalMilliseconds);
                PositionsTimer.Start();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Telemetry.LogError(nameof(tmrPositions_Tick), ex);
            }
        }

        private void tmrAccounts_Tick(object sender, EventArgs e)
        {
            try
            {
                AccountsTimer.Stop();
                Argentina.Data.RefreshAccounts();
                AccountsTimer.Interval = Convert.ToInt32(TimeSpan.FromMinutes(30).TotalMilliseconds);
                AccountsTimer.Start();
                PositionsTimer.Start();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Telemetry.LogError(nameof(tmrAccounts_Tick), ex);
            }
        }

        private void abrirScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frmSettlementTermsAnalyzer = new FrmSettlementTermsAnalyzer();
                //frmSettlementTermsAnalyzer.MdiParent = this;
                frmSettlementTermsAnalyzer.Show();
            }
        }

        private void seleccionarInstrumentoYPlazosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frmSettlementTermsLauncher = new FrmSettlementTermLauncher();
                //frmSettlementTermsAnalyzer.MdiParent = this;
                frmSettlementTermsLauncher.Show();
            }
        }

        private void longGD30ShortAL30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var al30InstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("AL30".ToMervalSymbol48H()));
                var gd30InstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("GD30".ToMervalSymbol48H()));

                var al30Trade = new BuySellTrade(al30InstrumentWithData, al30InstrumentWithData);
                var gd30Trade = new BuySellTrade(gd30InstrumentWithData, gd30InstrumentWithData);
                var ratioTrade = new RatioTrade(al30Trade, gd30Trade);

                var frmRatioTrade = new FrmRatioTrade();
                frmRatioTrade.Init(ratioTrade);
                frmRatioTrade.Show();
            }
        }

        private void longAL30ShortGD30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var al30InstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("AL30".ToMervalSymbol48H()));
                var gd30InstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull("GD30".ToMervalSymbol48H()));

                var al30Trade = new BuySellTrade(al30InstrumentWithData, al30InstrumentWithData);
                var gd30Trade = new BuySellTrade(gd30InstrumentWithData, gd30InstrumentWithData);
                var ratioTrade = new RatioTrade(gd30Trade, al30Trade);

                var frmRatioTrade = new FrmRatioTrade();
                frmRatioTrade.Init(ratioTrade);
                frmRatioTrade.Show();
            }

        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateUserHasLogin())
            {
                var frmRatioTradeLauncher = new FrmRatioTradeLauncher();
                //frmSettlementTermsAnalyzer.MdiParent = this;
                frmRatioTradeLauncher.Show();
            }

        }
    }
}
