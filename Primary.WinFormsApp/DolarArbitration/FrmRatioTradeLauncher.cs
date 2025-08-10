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
            var type = sellTrade.IsSameCurrency() ? RatioTradeType.Ratio : RatioTradeType.MEP;

            var ratioTrade = new RatioTrade(type, sellTrade, buyTrade);


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
        try
        {
            if (instrumentSearchListSell.ValidateSelectedInstrument()
               && instrumentSearchListBuy.ValidateSelectedInstrument())
            {
                var owned = instrumentSearchListSell.SelectedInstrument;

                var ownedTicker = owned.Split(' ')[0];
                var ownedBuySymbol = owned.AddMervalPrefix();
                var ownedSellSymbol = ownedTicker.AddDolarSuffix().ToMervalSymbol24H();

                var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedBuySymbol));
                var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedSellSymbol));

                var arbitration = instrumentSearchListBuy.SelectedInstrument;

                var arbitrationTicker = arbitration.Split(' ')[0];
                var arbitrationSellSymbol = arbitration.AddMervalPrefix();
                var arbitrationBuySymbol = arbitrationTicker.AddDolarSuffix().ToMervalSymbol24H();

                var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationBuySymbol));
                var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationSellSymbol));

                var sellThenBuyTrade = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
                var buyThenSellTrade = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
                var ratioTrade = new RatioTrade(RatioTradeType.MEP, sellThenBuyTrade, buyThenSellTrade);

                var frmRatioTrade = new FrmRatioTrade();
                frmRatioTrade.Init(ratioTrade);
                frmRatioTrade.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCCL_Click(object sender, EventArgs e)
    {
        try
        {
            if (instrumentSearchListSell.ValidateSelectedInstrument()
               && instrumentSearchListBuy.ValidateSelectedInstrument())
            {
                var owned = instrumentSearchListSell.SelectedInstrument;

                var ownedTicker = owned.Split(' ')[0];
                var ownedBuySymbol = owned.AddMervalPrefix();
                var ownedSellSymbol = ownedTicker.AddCableSuffix().ToMervalSymbol24H();

                var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedBuySymbol));
                var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedSellSymbol));

                var arbitration = instrumentSearchListBuy.SelectedInstrument;

                var arbitrationTicker = arbitration.Split(' ')[0];
                var arbitrationSellSymbol = arbitration.AddMervalPrefix();
                var arbitrationBuySymbol = arbitrationTicker.AddCableSuffix().ToMervalSymbol24H();

                var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationBuySymbol));
                var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationSellSymbol));

                var sellThenBuyTrade = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
                var buyThenSellTrade = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
                var ratioTrade = new RatioTrade(RatioTradeType.CCL, sellThenBuyTrade, buyThenSellTrade);

                var frmRatioTrade = new FrmRatioTrade();
                frmRatioTrade.Init(ratioTrade);
                frmRatioTrade.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDC_Click(object sender, EventArgs e)
    {
        try
        {
            if (instrumentSearchListSell.ValidateSelectedInstrument()
               && instrumentSearchListBuy.ValidateSelectedInstrument())
            {
                var owned = instrumentSearchListSell.SelectedInstrument;

                var ownedTicker = owned.Split(' ')[0];
                var ownedBuySymbol = owned.AddDolarSuffix().ToMervalSymbol24H();
                var ownedSellSymbol = ownedTicker.AddCableSuffix().ToMervalSymbol24H();

                var ownedBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedBuySymbol));
                var ownedSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(ownedSellSymbol));

                var arbitration = instrumentSearchListBuy.SelectedInstrument;

                var arbitrationTicker = arbitration.Split(' ')[0];
                var arbitrationSellSymbol = arbitration.AddDolarSuffix().ToMervalSymbol24H();
                var arbitrationBuySymbol = arbitrationTicker.AddCableSuffix().ToMervalSymbol24H();

                var arbitrationBuyInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationBuySymbol));
                var arbitrationSellInstrumentWithData = new InstrumentWithData(Argentina.Data.GetInstrumentDetailOrNull(arbitrationSellSymbol));

                var sellThenBuyTrade = new BuySellTrade(ownedBuyInstrumentWithData, ownedSellInstrumentWithData);
                var buyThenSellTrade = new BuySellTrade(arbitrationBuyInstrumentWithData, arbitrationSellInstrumentWithData);
                var ratioTrade = new RatioTrade(RatioTradeType.DvsC, sellThenBuyTrade, buyThenSellTrade);

                var frmRatioTrade = new FrmRatioTrade();
                frmRatioTrade.Init(ratioTrade);
                frmRatioTrade.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
