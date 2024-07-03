using ChuchoBot.WinFormsApp.Properties;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public partial class FrmSettlementTermLauncher : Form
{
    public string[] _instruments;

    public FrmSettlementTermLauncher()
    {
        InitializeComponent();
    }

    private void FrmSettlementTermLauncher_Load(object sender, EventArgs e)
    {
        instrumentSearchList1.InstrumentDoubleClick += InstrumentSearchList_InstrumentDoubleClick;
    }

    private void InstrumentSearchList_InstrumentDoubleClick(object sender, EventArgs e)
    {
        btnLaunch_Click(sender, e);
    }

    private void btnLaunch_Click(object sender, EventArgs e)
    {
        if (instrumentSearchList1.ValidateSelectedInstrument() == false)
        {
            return;
        }

        var buySymbol = instrumentSearchList1.SelectedTicker;

        if (Settings.Default.TickersToMonitor.TickerExists(buySymbol) == false)
        {
            _ = MessageBox.Show($"El instrumento '{buySymbol}' no se encuentra en la lista de instrumentos monitoreados. Agregar dicho instrumento en la Configuracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        buySymbol = rdoBuyCI.Checked
            ? buySymbol.ToMervalSymbolCI()
            : buySymbol.ToMervalSymbol24H();
        var buyInstrument = Argentina.Data.GetInstrumentDetailOrNull(buySymbol);

        if (buyInstrument == null)
        {
            _ = MessageBox.Show($"No se encontró el instrumento '{buySymbol}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var buy = new InstrumentWithData(buyInstrument);

        var sellSymbol = instrumentSearchList1.SelectedTicker;
        sellSymbol = rdoSellCI.Checked
            ? sellSymbol.ToMervalSymbolCI()
            : sellSymbol.ToMervalSymbol24H();
        var sellInstrument = Argentina.Data.GetInstrumentDetailOrNull(sellSymbol);
        if (sellInstrument == null)
        {
            _ = MessageBox.Show($"No se encontró el instrumento '{sellInstrument}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var sell = new InstrumentWithData(sellInstrument);

        var trade = new SettlementTermTrade(buy, sell);

        var frm = new FrmSettlementTermTrade();
        frm.Init(trade);
        frm.Show();
    }
}
