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
        }


        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (instrumentSearchList1.ValidateSelectedInstrument() == false)
            { 
                return;
            }

            string buySymbol = instrumentSearchList1.SelectedTicker;

            if (Settings.Default.ArbitrationTickers.TickerExists(buySymbol) == false)
            {
                MessageBox.Show($"El instrumento '{buySymbol}' no se encuentra en la lista de instrumentos monitoreados. Agregar dicho instrumento en la Configuracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"No se encontró el instrumento '{buySymbol}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var buy = new InstrumentWithData(buyInstrument);

            string sellSymbol = instrumentSearchList1.SelectedTicker;
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
                MessageBox.Show($"No se encontró el instrumento '{sellInstrument}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sell = new InstrumentWithData(sellInstrument);

            var trade = new SettlementTermTrade(buy, sell);

            var frm = new FrmSettlementTermTrade();
            frm.Init(trade);
            frm.Show();
        }
    }
}
