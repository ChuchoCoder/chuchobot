using Primary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmArbitrationAnalyzer : Form
    {
        private DolarArbitrationProcessor _processor;
        private DataTable _dataTable;

        public FrmArbitrationAnalyzer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _processor.RefreshData();
                var minProfit = numMinProfit.Value / 100;
                
                string[] filteredTickers = null;
                if (!string.IsNullOrWhiteSpace(txtFilter.Text))
                {
                    filteredTickers = txtFilter.Text.ToUpper().Split(' ');
                    minProfit = -100;
                }

                string[] excludedTickers = null;
                if (!string.IsNullOrWhiteSpace(txtExclude.Text))
                {
                    excludedTickers = txtExclude.Text.ToUpper().Split(' ');
                }

                var trades = _processor.GetArbitrationTrades(minProfit, chkMEP.Checked, chkCCL.Checked, chkDolarDC.Checked, chkDolarCD.Checked);

                if (filteredTickers != null)
                {
                    trades = trades.Where(x => 
                        filteredTickers.Any(
                            y => x.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) ||
                                x.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) ||
                                x.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) ||
                                x.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y)
                            )
                        ).ToList();
                }

                if (excludedTickers != null)
                {
                    trades = trades.Where(x =>
                        excludedTickers.Any(
                            y => !x.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) &&
                                !x.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) &&
                                !x.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y) &&
                                !x.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y)                                
                            )
                        ).ToList();

                }

                var processedRows = new List<DataRow>();
                bool shouldFlash = false;

                foreach (var bestTrade in trades)
                {
                    var ownedVenta = bestTrade.Owned.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
                    var arbitrationCompra = bestTrade.Arbitration.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
                    var arbitrationVenta = bestTrade.Arbitration.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();
                    var ownedCompra = bestTrade.Owned.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();

                    DataRow row;
                    var existingRow = _dataTable.Rows.Find(new[] { ownedVenta, arbitrationCompra, arbitrationVenta, ownedCompra });

                    if (existingRow != null)
                    {
                        row = existingRow;
                    }
                    else
                    {
                        row = _dataTable.NewRow();

                        row["KeyOwnedVenta"] = ownedVenta;
                        row["KeyArbitrationCompra"] = arbitrationCompra;
                        row["KeyArbitrationVenta"] = arbitrationVenta;
                        row["KeyOwnedCompra"] = ownedCompra;
                    }

                    row["Profit"] = bestTrade.Profit;
                    if (bestTrade.Profit > numAlert.Value / 100m)
                    {
                        shouldFlash = true;
                    }
                    row["ProfitLast"] = bestTrade.ProfitLast;

                    row["OwnedVenta"] = bestTrade.Owned.Sell.Data.HasBids() ? (object)bestTrade.Owned.Sell.Data.Bids[0].Price : DBNull.Value;
                    row["ArbitrationCompra"] = bestTrade.Arbitration.Sell.Data.HasOffers() ? (object)bestTrade.Arbitration.Sell.Data.Offers[0].Price : DBNull.Value;
                    row["ArbitrationVenta"] = bestTrade.Arbitration.Buy.Data.HasBids() ? (object)bestTrade.Arbitration.Buy.Data.Bids[0].Price : DBNull.Value;
                    row["OwnedCompra"] = bestTrade.Owned.Buy.Data.HasOffers() ? (object)bestTrade.Owned.Buy.Data.Offers[0].Price : DBNull.Value;


                    row["DolarCompra"] = bestTrade.Owned.BuyPrice;
                    row["DolarCompraLast"] = bestTrade.Owned.Last;
                    row["DolarVenta"] = bestTrade.Arbitration.SellPrice;
                    row["DolarVentaLast"] = bestTrade.Arbitration.Last;

                    row["DolarArbitrationTrade"] = bestTrade;

                    if (existingRow == null)
                    {
                        _dataTable.Rows.Add(row);
                    }
                    processedRows.Add(row);
                }

                var rowsToRemove = new List<DataRow>();
                foreach (DataRow dataRow in _dataTable.Rows)
                {
                    if (!processedRows.Contains(dataRow))
                    {
                        rowsToRemove.Add(dataRow);
                    }
                }
                foreach (var dataRow in rowsToRemove)
                {
                    _dataTable.Rows.Remove(dataRow);
                }

                if (Argentina.IsMarketOpen() && shouldFlash && Form.ActiveForm != this)
                {
                    FlashWindow.Flash(this, 3);
                }

                //grdArbitration.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                Telemetry.LogError(nameof(timer1_Tick), ex);
            }
        }


        private void FrmArbitrationBestTrades_Load(object sender, EventArgs e)
        {
            _processor = new DolarArbitrationProcessor();

            _processor.Init();

            _dataTable = new DataTable();
            var ownedVentaColumn = _dataTable.Columns.Add("KeyOwnedVenta", typeof(string));
            var arbitrationCompraColumn = _dataTable.Columns.Add("KeyArbitrationCompra", typeof(string));
            var arbitrationVentaColumn = _dataTable.Columns.Add("KeyArbitrationVenta", typeof(string));
            var ownedCompraColumn = _dataTable.Columns.Add("KeyOwnedCompra", typeof(string));

            _dataTable.PrimaryKey = new DataColumn[] { ownedVentaColumn, arbitrationCompraColumn, arbitrationVentaColumn, ownedCompraColumn };

            _dataTable.Columns.Add("Profit", typeof(decimal));
            _dataTable.Columns.Add("ProfitLast", typeof(decimal));

            _dataTable.Columns.Add("OwnedVenta", typeof(decimal));
            _dataTable.Columns.Add("ArbitrationCompra", typeof(decimal));
            _dataTable.Columns.Add("ArbitrationVenta", typeof(decimal));
            _dataTable.Columns.Add("OwnedCompra", typeof(decimal));

            _dataTable.Columns.Add("DolarCompra", typeof(decimal));
            _dataTable.Columns.Add("DolarCompraLast", typeof(decimal));
            _dataTable.Columns.Add("DolarVenta", typeof(decimal));
            _dataTable.Columns.Add("DolarVentaLast", typeof(decimal));

            _dataTable.Columns.Add("DolarArbitrationTrade", typeof(DolarArbitrationTrade));

            grdArbitration.MultiSelect = false;
            grdArbitration.AutoGenerateColumns = false;
            grdArbitration.DataSource = _dataTable;

            numMinProfit.Increment = 0.1m;
            numMinProfit.Minimum = -10m;

            grdArbitration.Sort(grdArbitration.Columns["Profit"], System.ComponentModel.ListSortDirection.Descending);
        }

        private void grdArbitration_DoubleClick(object sender, EventArgs e)
        {
            if (grdArbitration.SelectedRows.Count > 0)
            {
                var frm = new FrmArbitrationTrade();
                var trade = ((DataRowView)grdArbitration.SelectedRows[0].DataBoundItem).Row["DolarArbitrationTrade"] as DolarArbitrationTrade;
                frm.Init(trade);
                frm.MdiParent = MdiParent;
                frm.Show();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
