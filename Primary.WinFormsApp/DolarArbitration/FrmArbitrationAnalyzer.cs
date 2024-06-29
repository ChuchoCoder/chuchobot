using ChuchoBot.WinFormsApp.DolarArbitration;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

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
                        y => x.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) ||
                            x.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) ||
                            x.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) ||
                            x.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase)
                        )
                    ).ToList();
            }

            if (excludedTickers != null)
            {
                trades = trades.Where(x =>
                    !excludedTickers.Any(
                        y => x.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) &&
                            x.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) &&
                            x.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase) &&
                            x.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix().Contains(y, StringComparison.InvariantCultureIgnoreCase)
                        )
                    ).ToList();

            }

            var processedRows = new List<DataRow>();
            var shouldFlash = false;

            foreach (var bestTrade in trades)
            {
                var ownedVenta = bestTrade.SellThenBuy.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
                var arbitrationCompra = bestTrade.BuyThenSell.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
                var arbitrationVenta = bestTrade.BuyThenSell.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();
                var ownedCompra = bestTrade.SellThenBuy.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();

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

                if (bestTrade.SellThenBuy.HasData() && bestTrade.BuyThenSell.HasData())
                {
                    row["OwnedVenta"] = bestTrade.SellThenBuy.Sell.Data.HasBids() ? bestTrade.SellThenBuy.Sell.Data.Bids[0].Price : DBNull.Value;
                    row["ArbitrationCompra"] = bestTrade.BuyThenSell.Sell.Data.HasOffers() ? bestTrade.BuyThenSell.Sell.Data.Offers[0].Price : DBNull.Value;
                    row["ArbitrationVenta"] = bestTrade.BuyThenSell.Buy.Data.HasBids() ? bestTrade.BuyThenSell.Buy.Data.Bids[0].Price : DBNull.Value;
                    row["OwnedCompra"] = bestTrade.SellThenBuy.Buy.Data.HasOffers() ? bestTrade.SellThenBuy.Buy.Data.Offers[0].Price : DBNull.Value;
                }

                row["DolarCompra"] = bestTrade.SellThenBuy.BuyPrice;
                row["DolarCompraLast"] = bestTrade.SellThenBuy.Last;
                row["DolarVenta"] = bestTrade.BuyThenSell.SellPrice;
                row["DolarVentaLast"] = bestTrade.BuyThenSell.Last;

                row["RatioTrade"] = bestTrade;

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
                _ = FlashWindow.Flash(this, 3);
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

        _ = _dataTable.Columns.Add("Profit", typeof(decimal));
        _ = _dataTable.Columns.Add("ProfitLast", typeof(decimal));

        _ = _dataTable.Columns.Add("OwnedVenta", typeof(decimal));
        _ = _dataTable.Columns.Add("ArbitrationCompra", typeof(decimal));
        _ = _dataTable.Columns.Add("ArbitrationVenta", typeof(decimal));
        _ = _dataTable.Columns.Add("OwnedCompra", typeof(decimal));

        _ = _dataTable.Columns.Add("DolarCompra", typeof(decimal));
        _ = _dataTable.Columns.Add("DolarCompraLast", typeof(decimal));
        _ = _dataTable.Columns.Add("DolarVenta", typeof(decimal));
        _ = _dataTable.Columns.Add("DolarVentaLast", typeof(decimal));

        _ = _dataTable.Columns.Add("RatioTrade", typeof(RatioTrade));

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
            var frm = new FrmRatioTrade();
            var trade = ((DataRowView)grdArbitration.SelectedRows[0].DataBoundItem).Row["RatioTrade"] as RatioTrade;
            frm.Init(trade);
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }

    private void grdArbitration_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var dgv = sender as DataGridView;
        if (e.RowIndex < 0 || e.RowIndex == dgv.NewRowIndex)
        {
            return;
        }

        var cell = dgv["Profit", e.RowIndex];
        if (cell.Value == null || cell.Value == DBNull.Value)
        {
            return;
        }

        var value = (decimal)cell.Value;
        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = value == 0 ? Color.Blue : value < 0 ? Color.Red : Color.Green;
    }

    private void numAlert_ValueChanged(object sender, EventArgs e)
    {

    }
}
