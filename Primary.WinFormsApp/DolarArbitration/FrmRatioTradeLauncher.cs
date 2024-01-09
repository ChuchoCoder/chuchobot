using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp.DolarArbitration
{
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
    }
}
