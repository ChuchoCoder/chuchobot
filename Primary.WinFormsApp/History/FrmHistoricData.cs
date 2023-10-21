using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmHistoricData : Form
    {
        public FrmHistoricData()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHistoricData_Load(object sender, EventArgs e)
        {
            cmbInstruments.DataSource = Argentina.Data.AllInstruments.OrderBy(x => x.InstrumentId.SymbolWithoutPrefix()).ToList();
        }

        private void cmbInstruments_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private async void btnGetHistoricData_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await Argentina.Data.Api.GetHistoricalTrades(((Primary.Data.InstrumentDetail)cmbInstruments.SelectedItem).InstrumentId, DateTime.Today.AddMonths(-3), DateTime.Now);

                var dataTable = new DataTable();
                dataTable.Columns.Add("DateTime", typeof(DateTime));
                dataTable.Columns.Add("Size", typeof(decimal));
                dataTable.Columns.Add("Price", typeof(decimal));

                foreach (var item in data)
                {
                    var row = dataTable.NewRow();
                    row["DateTime"] = item.DateTime;
                    row["Size"] = item.Size;
                    row["Price"] = item.Price;
                    dataTable.Rows.Add(row);
                }

                grdHistoricData.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Telemetry.LogError(nameof(btnGetHistoricData_Click), ex);
            }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            grdHistoricData.SelectAll();
            DataObject dataObj = grdHistoricData.GetClipboardContent();
            Clipboard.SetDataObject(dataObj, true);
        }
    }
}
