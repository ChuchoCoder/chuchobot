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
        var symbolA = tickerA.ToMervalSymbol24H();
        var instrumentA = Argentina.Data.GetInstrumentDetail(symbolA);
        var instrumentAEntries = Argentina.Data.GetLatestOrNull(symbolA);
        if (instrumentAEntries == null)
            return;

        var symbolB = tickerB.ToMervalSymbol24H();
        var instrumentB = Argentina.Data.GetInstrumentDetail(symbolB);
        var instrumentBEntries = Argentina.Data.GetLatestOrNull(symbolB);
        if (instrumentBEntries == null)
            return;

        var isSameCurrency = instrumentA.Currency == instrumentB.Currency;
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

        var format = isSameCurrency ? "P" : "C2";
        
        row["ABid"] = instrumentAEntries.GetTopBidPrice();
        row["AOffer"] = instrumentAEntries.GetTopOfferPrice();
        row["BBid"] = instrumentBEntries.GetTopBidPrice();
        row["BOffer"] = instrumentBEntries.GetTopOfferPrice();

        // Sell A - Buy B
        var shortRatioValue = instrumentBEntries.GetTopOfferPrice() > 0 ? (instrumentAEntries.GetTopBidPrice() / instrumentBEntries.GetTopOfferPrice()) - 1 : 0;
        row["ShortRatio"] = shortRatioValue.ToString(format);

        // Buy A - Sell B
        var longRatioValue = instrumentBEntries.GetTopBidPrice() > 0 ? (instrumentAEntries.GetTopOfferPrice() / instrumentBEntries.GetTopBidPrice()) - 1 : 0;
        row["LongRatio"] = longRatioValue.ToString(format);

        var ratioLastHasValue = instrumentBEntries.Last?.Price > 0 && instrumentAEntries.Last?.Price > 0;

        var ratioLast = ratioLastHasValue ? (instrumentAEntries.Last.Price / instrumentBEntries.Last.Price) - 1 : 0;
        if (ratioLast != null)
        {
            row["RatioLast"] = ratioLast.Value.ToString(format);
        }

        var ratioClose = instrumentBEntries.ClosePrice() > 0 ? (instrumentAEntries.ClosePrice() / instrumentBEntries.ClosePrice()) - 1 : 0;
        row["RatioYesterday"] = ratioClose.ToString(format);

        var ratioVar = isSameCurrency ? ratioLast - ratioClose : ratioLast / ratioClose - 1;
        row["RatioVariacion"] = ratioVar;

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
            
            if (alertLower.HasValue)
            {
                var alertLowerValue = isSameCurrency ? alertLower.Value / 100m : alertLower.Value;
                if (ratioLastHasValue && ratioLast.Value <= alertLowerValue)
                {
                    // Long Ratio
                    Alerts.NotifyLongRatioTrade(format, tickerA, instrumentAEntries.GetTopOfferPrice(), tickerB, instrumentBEntries.GetTopBidPrice(), ratioLast.Value, null);
                }
            }

            var alertGreater = row["AlertGreater"] as decimal?;

            if (alertGreater.HasValue)
            {
                var alertGreaterValue = isSameCurrency ? alertGreater.Value / 100m : alertGreater.Value;
                if (ratioLastHasValue && ratioLast.Value >= alertGreaterValue)
                {
                    // Short Ratio
                    Alerts.NotifyShortRatioTrade(format, tickerB, instrumentBEntries.GetTopOfferPrice(), tickerA, instrumentAEntries.GetTopBidPrice(), ratioLast.Value, null);
                }
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
        _ = dataTable.Columns.Add("LongRatio", typeof(string));
        _ = dataTable.Columns.Add("ShortRatio", typeof(string));
        _ = dataTable.Columns.Add("RatioLast", typeof(string));
        _ = dataTable.Columns.Add("RatioYesterday", typeof(string));
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
