using ChuchoBot.WinFormsApp.Properties;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Data;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

public partial class FrmRatios : Form
{
    private readonly DataTable dataTable = new();
    public FrmRatios()
    {
        InitializeComponent();
    }

    private void tmr_Tick(object sender, EventArgs e)
    {
        if (grdRatios.IsCurrentCellInEditMode == true)
            return;

        foreach (var ratio in Settings.Default.RatioTickers)
        {
            var ratioTickers = ratio.Split('/');
            if (ratioTickers.Length >= 2)
            {
                RefreshRatioRow(ratioTickers[0], ratioTickers[1]);
            }
            else
            {
                ratioTickers = ratio.Split('\\');
                if (ratioTickers.Length >= 2)
                {
                    RefreshRatioRow(ratioTickers[0], ratioTickers[1]);
                }
            }
        }
    }

    private void RefreshRatioRow(string gdTicker, string alTicker)
    {
        var al = Argentina.Data.GetLatestOrNull(alTicker.ToMervalSymbol48H());

        var gd = Argentina.Data.GetLatestOrNull(gdTicker.ToMervalSymbol48H());

        var ratio = gdTicker + "/" + alTicker;
        var existingRow = dataTable.Rows.Find(new[] { ratio });
        DataRow row;

        if (existingRow != null)
        {
            row = existingRow;
        }
        else
        {
            row = dataTable.NewRow();
            row["Ratio"] = ratio;
        }
        row["GDBid"] = gd.GetTopBidPrice();
        row["GDOffer"] = gd.GetTopOfferPrice();
        row["ALBid"] = al.GetTopBidPrice();
        row["ALOffer"] = al.GetTopOfferPrice();
        row["RatioVenta"] = al.GetTopBidPrice() > 0 ? (gd.GetTopOfferPrice() / al.GetTopBidPrice()) - 1 : 0;
        row["RatioCompra"] = al.GetTopOfferPrice() > 0 ? (gd.GetTopBidPrice() / al.GetTopOfferPrice()) - 1 : 0;

        var ratioLastHasValue = al.Last?.Price > 0 && gd.Last?.Price > 0;
            
        var ratioLast = ratioLastHasValue ? (gd.Last.Price / al.Last.Price) - 1 : 0;
        row["RatioLast"] = ratioLast;

        var ratioClose = al.ClosePrice() > 0 ? (gd.ClosePrice() / al.ClosePrice()) - 1 : 0;
        row["RatioYesterday"] = ratioClose;

        row["RatioVariacion"] = ratioLast - ratioClose;

        if (existingRow == null)
        {
            dataTable.Rows.Add(row);
        }

        if (Argentina.IsMarketOpen())
        {
            var alertLower = row["AlertLower"] as decimal?;

            if (alertLower.HasValue && ratioLastHasValue && ratioLast.Value <= alertLower.Value / 100m)
            {
                Alerts.NotifyRatioTradeLowerThan(gdTicker, alTicker, ratioLast.Value, null);
            }

            var alertGreater = row["AlertGreater"] as decimal?;

            if (alertGreater.HasValue && ratioLastHasValue && ratioLast.Value >= alertGreater.Value / 100m)
            {
                Alerts.NotifyRatioTradeGreaterThan(alTicker, gdTicker, ratioLast.Value, null);
            }
        }
    }

    private void FrmRatios_Load(object sender, EventArgs e)
    {
        var ratioTickerColumn = dataTable.Columns.Add("Ratio", typeof(string));

        dataTable.PrimaryKey = new DataColumn[] { ratioTickerColumn };

        _ = dataTable.Columns.Add("GDBid", typeof(decimal));
        _ = dataTable.Columns.Add("GDOffer", typeof(decimal));
        _ = dataTable.Columns.Add("ALBid", typeof(decimal));
        _ = dataTable.Columns.Add("ALOffer", typeof(decimal));
        _ = dataTable.Columns.Add("RatioCompra", typeof(decimal));
        _ = dataTable.Columns.Add("RatioVenta", typeof(decimal));
        _ = dataTable.Columns.Add("RatioLast", typeof(decimal));
        _ = dataTable.Columns.Add("RatioYesterday", typeof(decimal));
        _ = dataTable.Columns.Add("RatioVariacion", typeof(decimal));
        _ = dataTable.Columns.Add("AlertLower", typeof(decimal));
        _ = dataTable.Columns.Add("AlertGreater", typeof(decimal));

        grdRatios.MultiSelect = false;
        grdRatios.AutoGenerateColumns = false;
        grdRatios.DataSource = dataTable;

        tmr_Tick(this, new EventArgs());
    }

    private void grdRatios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {

    }
}
