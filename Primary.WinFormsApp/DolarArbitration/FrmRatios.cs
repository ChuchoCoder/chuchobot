using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp.DolarArbitration
{
    public partial class FrmRatios : Form
    {
        private DataTable dataTable = new DataTable();
        public FrmRatios()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            RefreshRatioRow("GD29", "AL29");
            RefreshRatioRow("GD30", "AL30");
            RefreshRatioRow("GD35", "AL35");
            RefreshRatioRow("GD38", "AE38");
            RefreshRatioRow("GD41", "AL41");

        }

        private void RefreshRatioRow(string gdTicker, string alTicker)
        {
            var al = Argentina.Data.GetLatestOrNull(alTicker.ToMervalSymbol24H());

            var gd = Argentina.Data.GetLatestOrNull(gdTicker.ToMervalSymbol24H());

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
            row["RatioVenta"] = al.GetTopBidPrice() > 0 ? gd.GetTopOfferPrice() / al.GetTopBidPrice() - 1 : 0;
            row["RatioCompra"] = al.GetTopOfferPrice() > 0 ? gd.GetTopBidPrice() / al.GetTopOfferPrice() - 1 : 0;

            var ratioLast = al.Last.Price > 0 ? gd.Last.Price / al.Last.Price - 1 : 0;
            row["RatioLast"] = ratioLast;

            var ratioClose = al.ClosePrice() > 0 ? gd.ClosePrice() / al.ClosePrice() - 1 : 0;
            row["RatioYesterday"] = ratioClose;

            row["RatioVariacion"] = ratioLast - ratioClose;

            if (existingRow == null)
            {
                dataTable.Rows.Add(row);
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

            grdRatios.MultiSelect = false;
            grdRatios.AutoGenerateColumns = false;
            grdRatios.DataSource = dataTable;

            tmr_Tick(this, new EventArgs());
        }
    }
}
