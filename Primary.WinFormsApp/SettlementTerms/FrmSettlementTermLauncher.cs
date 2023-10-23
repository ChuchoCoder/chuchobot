using Primary.Data;
using Primary.WinFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Primary.WinFormsApp.SettlementTerms
{
    public partial class FrmSettlementTermLauncher : Form
    {
        public string[] _instruments;

        public FrmSettlementTermLauncher()
        {
            InitializeComponent();
        }

        private void FrmSettlementTermLauncher_Load(object sender, EventArgs e)
        {
            if (Argentina.Data.HasPositions() == false)
            {
                chkOnlyCurrentPositions.Enabled = false;
                chkOnlyCurrentPositions.Text += " (No existen posiciones)";
            }

            _instruments = Argentina.Data.AllInstruments.Where(x => x.IsPesos()).Select(x => x.InstrumentId.Ticker()).Distinct().OrderBy(x => x).ToArray();

            foreach (var item in _instruments)
            {
                _ = listInstrumentos.Items.Add(item);
            }

            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FilterInstruments();
        }

        private void FilterInstruments()
        {
            IEnumerable<string> instruments = _instruments;

            Func<string, bool> onlyShowCurrentPositionFilter = x => true;

            if (chkOnlyCurrentPositions.Checked)
            {
                onlyShowCurrentPositionFilter = x => Argentina.Data.TickerExistsInPositions(Instrument.MervalPrefix + x);
            }

            Func<string, bool> textSearchFilter = x => true;

            if (string.IsNullOrWhiteSpace(txtBuscar.Text) == false)
            {
                textSearchFilter = x => x.IndexOf(txtBuscar.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            instruments = instruments.Where(x => textSearchFilter(x) && onlyShowCurrentPositionFilter(x));

            listInstrumentos.Items.Clear();
            foreach (var item in instruments)
            {
                _ = listInstrumentos.Items.Add(item);
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (listInstrumentos.SelectedItem == null)
            {
                MessageBox.Show("Seleccionar el intrumento");
                return;
            }

            string buySymbol = listInstrumentos.SelectedItem as string;

            if (Settings.Default.ArbitrationTickers.TickerExists(buySymbol) == false)
            {
                MessageBox.Show($"El instrumento '{buySymbol}' no se encuentra en la lista de instrumentos monitoreados. Agregar dicho instrumento en la Configuracion");
                return;
            }

            if (rdoBuyCI.Checked)
            {
                buySymbol = buySymbol.ToMervalSymbolCI();
            }
            else if (rdoBuy24H.Checked)
            {
                buySymbol = buySymbol.ToMervalSymbol24H();
            }
            else
            {
                buySymbol = buySymbol.ToMervalSymbol48H();
            }
            var buyInstrument = Argentina.Data.GetInstrumentDetailOrNull(buySymbol);

            if (buyInstrument == null)
            {
                MessageBox.Show($"No se encontró el instrumento '{buySymbol}'");
                return;
            }

            var buy = new InstrumentWithData(buyInstrument);

            string sellSymbol = listInstrumentos.SelectedItem as string;
            if (rdoSellCI.Checked)
            {
                sellSymbol = sellSymbol.ToMervalSymbolCI();
            }
            else if (rdoSell24H.Checked)
            {
                sellSymbol = sellSymbol.ToMervalSymbol24H();
            }
            else
            {
                sellSymbol = sellSymbol.ToMervalSymbol48H();
            }
            var sellInstrument = Argentina.Data.GetInstrumentDetailOrNull(sellSymbol);
            if (sellInstrument == null)
            {
                MessageBox.Show($"No se encontró el instrumento '{sellInstrument}'");
                return;
            }
            var sell = new InstrumentWithData(sellInstrument);

            var trade = new SettlementTermTrade(buy, sell);

            var frm = new FrmSettlementTermTrade();
            frm.Init(trade);
            frm.Show();
        }

        private void chkOnlyCurrentPositions_CheckedChanged(object sender, EventArgs e)
        {
            FilterInstruments();
        }
    }
}
