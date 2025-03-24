using ChuchoBot.WinFormsApp.DolarArbitration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

public partial class FrmDolarPrices : Form
{
    private DolarCalculatorProcessor _processor;
    private DataTable _mepTrades1;
    private DataTable _mepTrades2;
    private DataTable _cclTrades1;
    private DataTable _cclTrades2;

    public FrmDolarPrices()
    {
        InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        _processor.RefreshData();

        var mepTrades = _processor.GetDolarMEPTrades();
        UpdateDataTable(mepTrades, _mepTrades1);
        UpdateDataTable(mepTrades, _mepTrades2);

        var cclTrades = _processor.GetDolarCableTrades();
        UpdateDataTable(cclTrades, _cclTrades1);
        UpdateDataTable(cclTrades, _cclTrades2);

    }

    private static void UpdateDataTable(List<BuySellTrade> mepTrades, DataTable dataTable)
    {
        var processedRows = new List<DataRow>();

        //IEnumerable<BuySellTrade> trades = mepTrades.Where(x => x.Trade.Contains("S31O3"));
        var trades = new BuySellTrade[mepTrades.Count];
        mepTrades.CopyTo(trades);

        if (dataTable.Columns.Contains("Compra"))
        {
            trades = trades.Where(x => x.BuyPrice > 1).OrderBy(x => x.BuyPrice).Take(500).ToArray();
        }
        if (dataTable.Columns.Contains("Venta"))
        {
            trades = trades.Where(x => x.SellPrice > 1).OrderByDescending(x => x.SellPrice).Take(500).ToArray();
        }

        foreach (var trade in trades)
        {
            var tradeKey = trade.TradeText;

            DataRow row;
            var existingRow = dataTable.Rows.Find(new[] { tradeKey });

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
            if (dataTable.Columns.Contains("Compra"))
            {
                row["Compra"] = trade.BuyPrice;
            }
            if (dataTable.Columns.Contains("Venta"))
            {
                row["Venta"] = trade.SellPrice;
            }

            if (existingRow == null)
            {
                dataTable.Rows.Add(row);
            }
            processedRows.Add(row);
        }

        var rowsToRemove = new List<DataRow>();
        foreach (DataRow dataRow in dataTable.Rows)
        {
            if (!processedRows.Contains(dataRow))
            {
                rowsToRemove.Add(dataRow);
            }
        }
        foreach (var dataRow in rowsToRemove)
        {
            dataTable.Rows.Remove(dataRow);

        }
    }

    private void FrmDolarPrices_Load(object sender, EventArgs e)
    {
        _processor = new DolarCalculatorProcessor();

        _processor.Init();

        grdMEPLeft.AutoGenerateColumns = false;
        grdMEPRight.AutoGenerateColumns = false;
        grdCCLLeft.AutoGenerateColumns = false;
        grdCCLRight.AutoGenerateColumns = false;

        _mepTrades1 = GetDataTable();
        _mepTrades2 = GetDataTable();
        _cclTrades1 = GetDataTable();
        _cclTrades2 = GetDataTable();

        grdMEPLeft.DataSource = _mepTrades1;
        grdMEPRight.DataSource = _mepTrades2;
        grdCCLLeft.DataSource = _cclTrades1;
        grdCCLRight.DataSource = _cclTrades2;
    }

    public DataTable GetDataTable()
    {

        var dataTable = new DataTable();
        var trade = dataTable.Columns.Add("Trade", typeof(string));

        dataTable.PrimaryKey = new DataColumn[] { trade };

        _ = dataTable.Columns.Add("Last", typeof(decimal));
        _ = dataTable.Columns.Add("Compra", typeof(decimal));
        _ = dataTable.Columns.Add("Venta", typeof(decimal));

        return dataTable;
    }
}
