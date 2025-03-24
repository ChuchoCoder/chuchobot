using ChuchoBot.WinFormsApp.DolarArbitration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

public partial class FrmDolarPrice : Form
{
    private DolarCalculatorProcessor _processor;
    private DataTable _dolarTable;
    private Func<DolarCalculatorProcessor, List<BuySellTrade>> _getDolarPrices;
    private bool _displayDolarVenta;
    private ListSortDirection _sortPrecio;

    public FrmDolarPrice()
    {
        InitializeComponent();
    }

    internal void Setup(Func<DolarCalculatorProcessor, List<BuySellTrade>> getDolarPrices, bool displayDolarVenta, ListSortDirection sortPrecio)
    {
        _getDolarPrices = getDolarPrices;
        _displayDolarVenta = displayDolarVenta;
        _sortPrecio = sortPrecio;
    }

    private void FrmDolarPrice_Load(object sender, EventArgs e)
    {
        _processor = new DolarCalculatorProcessor();

        _processor.Init();

        grdDolar.AutoGenerateColumns = false;

        _dolarTable = GetDataTable();

        grdDolar.DataSource = _dolarTable;

        grdDolar.Sort(grdDolar.Columns["Precio"], _sortPrecio);

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (_getDolarPrices != null)
        {
            _processor.RefreshData();

            var mepTrades = _getDolarPrices(_processor);
            UpdateDataTable(mepTrades, _dolarTable);
        }

    }

    private void UpdateDataTable(List<BuySellTrade> mepTrades, DataTable dataTable)
    {
        if (mepTrades == null || dataTable == null)
        {
            return;
        }

        List<DataRow> processedRows = [];

        //IEnumerable<BuySellTrade> trades = mepTrades.Where(x => x.Trade.Contains("S31O3"));
        var trades = new BuySellTrade[mepTrades.Count];
        mepTrades.CopyTo(trades);

        trades = _displayDolarVenta == false
            ? trades.Where(x => x.BuyPrice > 1).OrderBy(x => x.BuyPrice).Take(50).ToArray()
            : trades.Where(x => x.SellPrice > 1).OrderByDescending(x => x.SellPrice).Take(50).ToArray();

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
            if (_displayDolarVenta)
            {
                row["Precio"] = trade.SellPrice;
                row["Pesos"] = (object)trade.Buy.BidPrice() ?? DBNull.Value;
                row["USD"] = (object)trade.Sell.OfferPrice() ?? DBNull.Value;
            }
            else
            {
                row["Precio"] = trade.BuyPrice;
                row["Pesos"] = (object)trade.Buy.OfferPrice() ?? DBNull.Value;
                row["USD"] = (object)trade.Sell.BidPrice() ?? DBNull.Value;
            }
            row["Precio"] = _displayDolarVenta == false ? trade.BuyPrice : (object)trade.SellPrice;

            if (existingRow == null)
            {
                dataTable.Rows.Add(row);
            }
            processedRows.Add(row);
        }

        List<DataRow> rowsToRemove = [];
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

    public DataTable GetDataTable()
    {

        var dataTable = new DataTable();
        var trade = dataTable.Columns.Add("Trade", typeof(string));

        dataTable.PrimaryKey = new DataColumn[] { trade };

        _ = dataTable.Columns.Add("Last", typeof(decimal));
        _ = dataTable.Columns.Add("Precio", typeof(decimal));
        _ = dataTable.Columns.Add("Pesos", typeof(decimal));
        _ = dataTable.Columns.Add("USD", typeof(decimal));

        return dataTable;
    }
}
