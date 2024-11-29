using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

public partial class FrmRatioTradeLauncher : Form
{
    public FrmRatioTradeLauncher()
    {
        InitializeComponent();
        instrumentSearchListBuy.SettlementsVisible = true;
        instrumentSearchListSell.SettlementsVisible = true;
    }

    private void btnLaunch_Click(object sender, EventArgs e)
    {
        if (instrumentSearchListSell.ValidateSelectedInstrument()
            && instrumentSearchListBuy.ValidateSelectedInstrument())
        {
            var buy = instrumentSearchListBuy.SelectedInstrument;
            var sell = instrumentSearchListSell.SelectedInstrument;

            var sellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(sell.AddMervalPrefix()));
            var buyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(buy.AddMervalPrefix()));

            var sellTrade = new BuySellTrade(sellInstrumentWithData, sellInstrumentWithData);
            var buyTrade = new BuySellTrade(buyInstrumentWithData, buyInstrumentWithData);
            var ratioTrade = new RatioTrade(sellTrade, buyTrade);

            var frmRatioTrade = new FrmRatioTrade();
            frmRatioTrade.Init(ratioTrade);
            frmRatioTrade.Show();
        }



    }

    private void FrmRatioTradeLauncher_Load(object sender, EventArgs e)
    {
    }

    private void btnArbitrajeDolar_Click(object sender, EventArgs e)
    {
        if (instrumentSearchListSell.ValidateSelectedInstrument()
           && instrumentSearchListBuy.ValidateSelectedInstrument())
        {
            var sell = instrumentSearchListSell.SelectedInstrument;

            var sellSymbol = sell.AddMervalPrefix();
            var sellMep = sell.Replace(" -", "D -");
            var sellMepSymbol = sellMep.AddMervalPrefix();

            var sellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(sellSymbol));
            var sellMepInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(sellMepSymbol));

            var buy = instrumentSearchListBuy.SelectedInstrument;

            var buySymbol = buy.AddMervalPrefix();
            var buyMep = buy.Replace(" -", "D -");
            var buyMepSymbol = buyMep.AddMervalPrefix();
            var buyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(buySymbol));
            var buyMepInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(buyMepSymbol));

            var sellTrade = new BuySellTrade(sellInstrumentWithData, sellMepInstrumentWithData);
            var buyTrade = new BuySellTrade(buyInstrumentWithData, buyMepInstrumentWithData);
            var ratioTrade = new RatioTrade(sellTrade, buyTrade);

            var frmRatioTrade = new FrmRatioTrade();
            frmRatioTrade.Init(ratioTrade);
            frmRatioTrade.Show();
        }
    }
}
