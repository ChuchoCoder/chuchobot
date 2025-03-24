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
            var owned = instrumentSearchListSell.SelectedInstrument;

            var ownedBuySymbol = owned.AddMervalPrefix();
            var ownedSellDolar = owned.Replace(" -", "D -");
            var ownedSellSymbol = ownedSellDolar.AddMervalPrefix();

            var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedBuySymbol));
            var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedSellSymbol));

            var arbitration = instrumentSearchListBuy.SelectedInstrument;

            var arbitrationSellSymbol = arbitration.AddMervalPrefix();
            var arbitrationBuyDolar = arbitration.Replace(" -", "D -");
            var arbitrationBuySymbol = arbitrationBuyDolar.AddMervalPrefix();

            var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationBuySymbol));
            var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationSellSymbol));

            var sellThenBuyTrade = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
            var buyThenSellTrade = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
            var ratioTrade = new RatioTrade(sellThenBuyTrade, buyThenSellTrade);

            var frmRatioTrade = new FrmRatioTrade();
            frmRatioTrade.Init(ratioTrade);
            frmRatioTrade.Show();
        }
    }
}
