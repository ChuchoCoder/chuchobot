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
                _processor.RefreshData();
                var diasLiq24H = ((int)numDiasLiq24H.Value);
                var diasLiq48H = ((int)numDiasLiq48H.Value);


                var trades = _processor.GetSettlementTermTrades(numTasa.Value, diasLiq24H, diasLiq48H);

                if (!chkDolarD.Checked)
                {
                    trades = trades.Where(x => x.Buy.Instrument.Currency != "USD").ToList();
                }

                if (!chkPesos.Checked)
                {
                    trades = trades.Where(x => x.Buy.Instrument.Currency != "ARS").ToList();
                }

                _arbitrationDataTable.Refresh(trades, diasLiq24H, diasLiq48H, numComision.Value, numComisionTomadora.Value, numComisionColocadora.Value, numTasa.Value, chkOnlyProfitableTrades.Checked);

                //grdArbitration.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void FrmArbitrationBestTrades_Load(object sender, EventArgs e)
        {
            numComision.Value = Properties.Settings.Default.Comision;
            numTasa.Value = Properties.Settings.Default.TasaCaucion;
            numComisionColocadora.Value = Properties.Settings.Default.ArancelCaucionColocadora;
            numComisionTomadora.Value = Properties.Settings.Default.ArancelCaucionTomadora;
            _processor = new SettlementTermArbitrationProcessor();

            _processor.Init();

            _arbitrationDataTable.Init();

            grdArbitration.MultiSelect = false;
            grdArbitration.AutoGenerateColumns = false;
            grdArbitration.DataSource = _arbitrationDataTable.DataTable;

            numDiasLiq24H.Value = Settlement.GetDiasLiquidacion24H();
            numDiasLiq48H.Value = Settlement.GetDiasLiquidacion48H();

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

        private void numFeriados24H_ValueChanged(object sender, EventArgs e)
        {
            numDiasLiq48H.Minimum = numDiasLiq24H.Value;

            if (numDiasLiq48H.Value < numDiasLiq24H.Value)
            {
                numDiasLiq48H.Value = numDiasLiq24H.Value;
            }
        }

        private void numTasa_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TasaCaucion = numTasa.Value;
            Properties.Settings.Default.Save();
        }

        private void numComision_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Comision = numComision.Value;
            Properties.Settings.Default.Save();
        }
    }
}
