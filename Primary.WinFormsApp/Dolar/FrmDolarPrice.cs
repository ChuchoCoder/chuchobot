using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmDolarPrice : Form
    {
        private DolarCalculatorProcessor _processor;
        private DataTable _dolarTable;
        private Func<DolarCalculatorProcessor, List<DolarTrade>> _getDolarPrices;
        private bool _displayDolarVenta;

        public FrmDolarPrice()
        {
            InitializeComponent();
        }

        internal void Setup(Func<DolarCalculatorProcessor, List<DolarTrade>> getDolarPrices, bool displayDolarVenta)
        {
            _getDolarPrices = getDolarPrices;
            _displayDolarVenta = displayDolarVenta;
        }

        private void FrmDolarPrice_Load(object sender, EventArgs e)
        {
            _processor = new DolarCalculatorProcessor();

            _processor.Init();

            grdDolar.AutoGenerateColumns = false;

            _dolarTable = GetDataTable();

            grdDolar.DataSource = _dolarTable;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_getDolarPrices != null)
            {
                _processor.RefreshData();

                List<DolarTrade> mepTrades = _getDolarPrices(_processor);
                UpdateDataTable(mepTrades, _dolarTable);
            }

        }

        private void UpdateDataTable(List<DolarTrade> mepTrades, DataTable dataTable)
        {
            List<DataRow> processedRows = new List<DataRow>();

            //IEnumerable<DolarTrade> trades = mepTrades.Where(x => x.Trade.Contains("S31O3"));
            DolarTrade[] trades = new DolarTrade[mepTrades.Count];
            mepTrades.CopyTo(trades);

            trades = _displayDolarVenta == false
                ? trades.Where(x => x.BuyPrice > 1).OrderBy(x => x.BuyPrice).Take(50).ToArray()
                : trades.Where(x => x.SellPrice > 1).OrderByDescending(x => x.SellPrice).Take(50).ToArray();

            foreach (DolarTrade trade in trades)
            {
                string tradeKey = trade.Trade;

                DataRow row;
                DataRow existingRow = dataTable.Rows.Find(new[] { tradeKey });

                if (existingRow != null)
                {
                    row = existingRow;
                }
                else
                {
                    row = dataTable.NewRow();

                    row["Trade"] = tradeKey;
                }

                row["Last"] = trade.Last;
                row["Precio"] = _displayDolarVenta == false ? trade.BuyPrice : (object)trade.SellPrice;

                if (existingRow == null)
                {
                    dataTable.Rows.Add(row);
                }
                processedRows.Add(row);
            }

            List<DataRow> rowsToRemove = new List<DataRow>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (!processedRows.Contains(dataRow))
                {
                    rowsToRemove.Add(dataRow);
                }
            }
            foreach (DataRow dataRow in rowsToRemove)
            {
                dataTable.Rows.Remove(dataRow);

            }
        }

        public DataTable GetDataTable()
        {

            DataTable dataTable = new DataTable();
            DataColumn trade = dataTable.Columns.Add("Trade", typeof(string));

            dataTable.PrimaryKey = new DataColumn[] { trade };

            _ = dataTable.Columns.Add("Last", typeof(decimal));
            _ = dataTable.Columns.Add("Precio", typeof(decimal));

            return dataTable;
        }
    }
}
