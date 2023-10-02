using Primary.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
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
                this.Invoke(new Action(() => this.UpdateMarketData(instrument, data)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void UpdateMarketData(Instrument instrument, Entries data)
        {
            if (instrument?.Symbol == this.Text)
            {
                txtPrice.Text = data?.Last?.Price.ToString();
                txtChange.Text = ((data?.Last?.Price / data?.Close?.Price - 1M) * 100).ToString();

                var dataTable = new DataTable();
                dataTable.Columns.Add("BidSize", typeof(decimal));
                dataTable.Columns.Add("BidPrice", typeof(decimal));
                dataTable.Columns.Add("OfferPrice", typeof(decimal));
                dataTable.Columns.Add("OfferSize", typeof(decimal));

                for (int i = 0; i < 5; i++)
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
            this.Text = instrument.Symbol;
        }

        private void grdBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMarketData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Argentina.Data.OnMarketData -= this.OnMarketData;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMarketData_Load(object sender, EventArgs e)
        {
            Argentina.Data.OnMarketData += this.OnMarketData;
        }
    }
}
