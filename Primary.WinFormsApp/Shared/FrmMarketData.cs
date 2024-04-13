using ChuchoBot.WinFormsApp.Shared;
using Primary.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

public partial class FrmMarketData : Form
{
    private Instrument _instrument;

    public FrmMarketData()
    {
        InitializeComponent();
    }

    public void OnMarketData(Instrument instrument, Entries data)
    {
        try
        {
            Invoke(new Action(() => UpdateMarketData(instrument, data)));
        }
        catch (Exception ex)
        {
            Telemetry.LogError(nameof(OnMarketData), ex);
        }
    }

    private void UpdateMarketData(Instrument instrument, Entries data)
    {
        if (instrument?.Symbol == Text)
        {
            txtPrice.Text = data?.Last?.Price.ToString();
            txtChange.Text = (((data?.Last?.Price / data?.Close?.Price) - 1M) * 100).ToString();

            var dataTable = new DataTable();
            _ = dataTable.Columns.Add("BidSize", typeof(decimal));
            _ = dataTable.Columns.Add("BidPrice", typeof(decimal));
            _ = dataTable.Columns.Add("OfferPrice", typeof(decimal));
            _ = dataTable.Columns.Add("OfferSize", typeof(decimal));

            for (var i = 0; i < 5; i++)
            {
                var row = dataTable.NewRow();
                var bid = data?.Bids?.ElementAtOrDefault(i);
                if (bid != null)
                {
                    row["BidSize"] = bid.Size;
                    row["BidPrice"] = bid.Price;
                }
                var offer = data?.Offers?.ElementAtOrDefault(i);
                if (offer != null)
                {
                    row["OfferSize"] = offer.Size;
                    row["OfferPrice"] = offer.Price;
                }
                dataTable.Rows.Add(row);
            }

            grdBook.DataSource = dataTable;
        }

    }

    public void SetInstrument(Instrument instrument)
    {
        _instrument = instrument;
        Text = instrument.Symbol;
    }

    private void grdBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void FrmMarketData_FormClosing(object sender, FormClosingEventArgs e)
    {
        Argentina.Data.OnMarketData -= OnMarketData;
    }

    private void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }

    private void FrmMarketData_Load(object sender, EventArgs e)
    {
        Argentina.Data.OnMarketData += OnMarketData;
    }
}
