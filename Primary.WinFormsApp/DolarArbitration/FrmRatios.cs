using ChuchoBot.WinFormsApp.Properties;
using ChuchoBot.WinFormsApp.Shared;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
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

        tmr.Stop();
        foreach (var ratio in Settings.Default.RatioTickers)
        {
            _ = InitRatio(ratio, '/', ' ') || InitRatio(ratio, '\\', ' ');
        }
        tmr.Start();
    }

    private bool InitRatio(string ratioConfigLine, char ratioSeparator, char alertSeparator)
    {
        var ratioTickers = ratioConfigLine.Split(ratioSeparator);
        if (ratioTickers.Length >= 2)
        {
            var configRatio = ratioTickers[1].Split(alertSeparator);

            decimal? alertMin = null;
            decimal? alertMax = null;

            if (configRatio.Length >= 2)
            {
                alertMin = decimal.TryParse(configRatio[1], out var outMinValue) ? outMinValue : null;
                if (configRatio.Length >= 3)
                {
                    alertMax = decimal.TryParse(configRatio[2], out var outMaxValue) ? outMaxValue : null;
                }
            }

            RefreshRatioRow(ratioTickers[0], configRatio[0], alertMin, alertMax);

            return true;
        }

        return false;
    }

    private void RefreshRatioRow(string tickerA, string tickerB, decimal? alertMin, decimal? alertMax)
    {
        var instrumentA = Argentina.Data.GetLatestOrNull(tickerA.ToMervalSymbol24H());
        if (instrumentA == null)
            return;

        var instrumentB = Argentina.Data.GetLatestOrNull(tickerB.ToMervalSymbol24H());
        if (instrumentB == null)
            return;

        var ratio = tickerA + "/" + tickerB;
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
        row["ABid"] = instrumentA.GetTopBidPrice();
        row["AOffer"] = instrumentA.GetTopOfferPrice();
        row["BBid"] = instrumentB.GetTopBidPrice();
        row["BOffer"] = instrumentB.GetTopOfferPrice();
        // Sell A - Buy B
        row["ShortRatio"] = instrumentB.GetTopOfferPrice() > 0 ? (instrumentA.GetTopBidPrice() / instrumentB.GetTopOfferPrice()) - 1 : 0;
        // Buy A - Sell B
        row["LongRatio"] = instrumentB.GetTopBidPrice() > 0 ? (instrumentA.GetTopOfferPrice() / instrumentB.GetTopBidPrice()) - 1 : 0;

        var ratioLastHasValue = instrumentB.Last?.Price > 0 && instrumentA.Last?.Price > 0;

        var ratioLast = ratioLastHasValue ? (instrumentA.Last.Price / instrumentB.Last.Price) - 1 : 0;
        row["RatioLast"] = ratioLast;

        var ratioClose = instrumentB.ClosePrice() > 0 ? (instrumentA.ClosePrice() / instrumentB.ClosePrice()) - 1 : 0;
        row["RatioYesterday"] = ratioClose;

        row["RatioVariacion"] = ratioLast - ratioClose;

        row["AlertLower"] = alertMin.HasValue ? alertMin.Value : System.DBNull.Value;
        row["AlertGreater"] = alertMax.HasValue ? alertMax.Value : System.DBNull.Value;

        Debug.WriteLine($"Updating {ratio} {alertMin} {alertMax}");

        if (existingRow == null)
        {
            dataTable.Rows.Add(row);
        }

        if (Argentina.IsMarketOpen())
        {
            var alertLower = row["AlertLower"] as decimal?;

            if (alertLower.HasValue && ratioLastHasValue && ratioLast.Value <= alertLower.Value / 100m)
            {
                // Long Ratio
                Alerts.NotifyLongRatioTrade(tickerA, instrumentA.GetTopOfferPrice(), tickerB, instrumentB.GetTopBidPrice(), ratioLast.Value, null);
            }

            var alertGreater = row["AlertGreater"] as decimal?;

            if (alertGreater.HasValue && ratioLastHasValue && ratioLast.Value >= alertGreater.Value / 100m)
            {
                // Short Ratio
                Alerts.NotifyShortRatioTrade(tickerB, instrumentB.GetTopOfferPrice(), tickerA, instrumentA.GetTopBidPrice(), ratioLast.Value, null);
            }
        }
    }

    private void FrmRatios_Load(object sender, EventArgs e)
    {
        var ratioTickerColumn = dataTable.Columns.Add("Ratio", typeof(string));

        dataTable.PrimaryKey = new DataColumn[] { ratioTickerColumn };

        _ = dataTable.Columns.Add("ABid", typeof(decimal));
        _ = dataTable.Columns.Add("AOffer", typeof(decimal));
        _ = dataTable.Columns.Add("BBid", typeof(decimal));
        _ = dataTable.Columns.Add("BOffer", typeof(decimal));
        _ = dataTable.Columns.Add("LongRatio", typeof(decimal));
        _ = dataTable.Columns.Add("ShortRatio", typeof(decimal));
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
        if (e.RowIndex >= 0 && grdRatios.Rows.Count > e.RowIndex)
        {
            var ratio = grdRatios.Rows[e.RowIndex].Cells["Ratio"].Value.ToString();
            var alertLower = grdRatios.Rows[e.RowIndex].Cells["AlertLower"].Value.ToString();
            var alertGreater = grdRatios.Rows[e.RowIndex].Cells["AlertGreater"].Value.ToString();

            for (int i = 0; i < Settings.Default.RatioTickers.Count; i++)
            {
                if (Settings.Default.RatioTickers[i].StartsWith(ratio))
                {
                    var ratioConfig = $"{ratio} {alertLower} {alertGreater}";
                    Settings.Default.RatioTickers[i] = ratioConfig;
                    break;
                }
            }
            Settings.Default.Save();
        }
    }
}
