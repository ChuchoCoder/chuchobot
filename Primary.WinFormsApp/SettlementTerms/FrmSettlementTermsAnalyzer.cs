using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmSettlementTermsAnalyzer : Form
    {
        private SettlementTermArbitrationProcessor _processor;
        private SettlementArbitrationDataTable _arbitrationDataTable = new SettlementArbitrationDataTable();

        public FrmSettlementTermsAnalyzer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                using (var track = Telemetry.TrackTime("Scanner arbitrajes de plazo"))
                {
                    // Deshabilitar si no existen posiciones
                    chkOnlyShowTradesWithTickersOwned.Enabled = Argentina.Data.Positions != null;
                    if (chkOnlyShowTradesWithTickersOwned.Enabled == false)
                    {
                        chkOnlyShowTradesWithTickersOwned.Checked = false;
                    }
                    _processor.RefreshData();

                    settlementTermSettings.RefreshValues();

                    var trades = _processor.GetSettlementTermTradesPesos(settlementTermSettings.CaucionTNA, settlementTermSettings.DiasLiq24H, settlementTermSettings.DiasLiq48H, chkOnlyShowTradesWithTickersOwned.Checked);

                    _arbitrationDataTable.Refresh(trades, settlementTermSettings.DiasLiq24H, settlementTermSettings.DiasLiq48H, settlementTermSettings.Comision, settlementTermSettings.ArancelCaucionTomadora, settlementTermSettings.ArancelCaucionColocadora, settlementTermSettings.CaucionTNA, chkOnlyProfitableTrades.Checked);
                }
                //grdArbitration.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            grdArbitration.Sort(grdArbitration.Columns["TNA"], System.ComponentModel.ListSortDirection.Descending);

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
    }
}
