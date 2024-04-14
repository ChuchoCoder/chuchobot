using ChuchoBot.WinFormsApp.SettlementTerms;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

public partial class FrmSettlementTermsAnalyzer : Form
{
    private SettlementTermArbitrationProcessor _processor;
    private readonly SettlementArbitrationDataTable _arbitrationDataTable = new();

    public FrmSettlementTermsAnalyzer()
    {
        InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        try
        {
            timer1.Enabled = false;

            // Deshabilitar si no existen posiciones
            chkOnlyShowTradesWithTickersOwned.Enabled = Argentina.Data.Positions != null;
            if (chkOnlyShowTradesWithTickersOwned.Enabled == false)
            {
                chkOnlyShowTradesWithTickersOwned.Checked = false;
            }
            _processor.RefreshData();

            settlementTermSettings.RefreshValues();

            var trades = _processor.GetSettlementTermTradesPesos(settlementTermSettings.CaucionTNA, settlementTermSettings.DiasLiq24H, settlementTermSettings.DiasLiq48H, chkOnlyShowTradesWithTickersOwned.Checked);

            var excludeTickers = txtExclude.Text.ToUpper().Split(" ");

            trades.RemoveAll(x => excludeTickers.Any(y => x.Buy.Instrument.InstrumentId.Symbol.Contains($" {y} ")));

            _arbitrationDataTable.Refresh(trades, settlementTermSettings.DiasLiq24H, settlementTermSettings.DiasLiq48H, settlementTermSettings.CaucionTNA, chkOnlyProfitableTrades.Checked);

            var alertTrades = trades.Where(x => x.ProfitLossPercentage > numAlert.Value / 100m).ToArray();
            var shouldAlert = alertTrades.Length > 0;

            if (Argentina.IsMarketOpen() && shouldAlert && Form.ActiveForm != this)
            {
                foreach (var alertTrade in alertTrades)
                {
                    Alerts.NotifySettlementTrade(alertTrade, null);
                }
                _ = FlashWindow.Flash(this, 3);
            }

            //grdArbitration.DataSource = _dataTable;
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Telemetry.LogError(nameof(timer1_Tick), ex);
        }
        finally
        {
            timer1.Enabled = true;
        }
    }


    private void FrmArbitrationBestTrades_Load(object sender, EventArgs e)
    {
        _processor = new SettlementTermArbitrationProcessor();

        _processor.Init();

        _arbitrationDataTable.Init();

        grdArbitration.MultiSelect = false;
        grdArbitration.AutoGenerateColumns = false;
        grdArbitration.DataSource = _arbitrationDataTable.DataTable;

        grdArbitration.Sort(grdArbitration.Columns["ProfitPercentage"], System.ComponentModel.ListSortDirection.Descending);

        timer1.Enabled = true;
    }

    private void grdArbitration_DoubleClick(object sender, EventArgs e)
    {
        var frm = new FrmSettlementTermTrade();
        var trade = ((DataRowView)grdArbitration.SelectedRows[0].DataBoundItem).Row["Trade"] as SettlementTermTrade;
        frm.Init(trade);
        frm.MdiParent = MdiParent;
        frm.Show();
    }

    private void grdArbitration_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void grdArbitration_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var dgv = sender as DataGridView;
        if (e.RowIndex < 0 || e.RowIndex == dgv.NewRowIndex)
        {
            return;
        }

        var cell = dgv["PL", e.RowIndex];
        if (cell.Value == null || cell.Value == DBNull.Value)
        {
            return;
        }

        var value = (decimal)cell.Value;
        var cellStyle = dgv.Rows[e.RowIndex].DefaultCellStyle;
        cellStyle.ForeColor = value == 0 ? Color.Black : value < 0 ? Color.Red : Color.Green;
        cellStyle.Font = value > 0 ? new Font(e.CellStyle.Font, FontStyle.Bold) : new Font(e.CellStyle.Font, FontStyle.Regular);
    }
}
