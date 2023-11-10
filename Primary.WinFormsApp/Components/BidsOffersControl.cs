using Primary.Data;
using System;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class BidsOffersControl : UserControl
    {
        public event EventHandler<BidOffersEventArgs> ClickSize;
        public event EventHandler<BidOffersEventArgs> ClickPrice;

        public BidsOffersControl()
        {
            InitializeComponent();
        }

        public InstrumentDetail InstrumentDetail { get; set; }

        private string CurrencyFormat
        {
            get
            {
                return "N" + InstrumentDetail.InstrumentPricePrecision;
            }
        }
        private string CurrencySymbol
        {
            get
            {
                if (InstrumentDetail.IsPesos())
                    return "$";

                return InstrumentDetail.Currency;
            }
        }

        public void LoadData(Entries entries)
        {
            if (entries == null)
                return;

            if (entries.Last != null)
            {
                var formatted = entries.Last.Price.Value.ToString(CurrencyFormat);
                lnkLast.Text = $"{CurrencySymbol} {formatted}";
                lnkLast.Text += $" {entries.Variation():P2}";
                lnkLast.Tag = entries.Last;
            }
            else if (entries.Close != null)
            {
                var formatted = entries.Close.Price.Value.ToString(CurrencyFormat);
                lnkLast.Text = $"{CurrencySymbol} {formatted}";
                lnkLast.Text += $" {entries.Variation():P2}";
                lnkLast.Tag = entries.Close;
            }

            SetText(lnkBidSize1, lnkBidPrice1, entries.Bids, 0, BidsOffersClickType.TopBid);
            SetText(lnkBidSize2, lnkBidPrice2, entries.Bids, 1, BidsOffersClickType.OtherBid);
            SetText(lnkBidSize3, lnkBidPrice3, entries.Bids, 2, BidsOffersClickType.OtherBid);
            SetText(lnkBidSize4, lnkBidPrice4, entries.Bids, 3, BidsOffersClickType.OtherBid);
            SetText(lnkBidSize5, lnkBidPrice5, entries.Bids, 4, BidsOffersClickType.OtherBid);

            SetText(lnkOfferSize1, lnkOfferPrice1, entries.Offers, 0, BidsOffersClickType.TopOffer);
            SetText(lnkOfferSize2, lnkOfferPrice2, entries.Offers, 1, BidsOffersClickType.OtherOffer);
            SetText(lnkOfferSize3, lnkOfferPrice3, entries.Offers, 2, BidsOffersClickType.OtherOffer);
            SetText(lnkOfferSize4, lnkOfferPrice4, entries.Offers, 3, BidsOffersClickType.OtherOffer);
            SetText(lnkOfferSize5, lnkOfferPrice5, entries.Offers, 4, BidsOffersClickType.OtherOffer);
        }

        private void SetText(LinkLabel size, LinkLabel price, Trade[] trades, int index, BidsOffersClickType clickType)
        {
            if (trades != null && trades.Length > index)
            {
                size.Text = $"{trades[index].Size:#,###}";
                var formatted = trades[index].Price.ToString(CurrencyFormat);
                price.Text = $"{CurrencySymbol} {formatted}";
                var tag = new Tuple<Trade, BidsOffersClickType>(trades[index], clickType);
                size.Tag = tag;
                price.Tag = tag;
            }
            else
            {
                size.Text = string.Empty;
                price.Text = string.Empty;
                size.Tag = null;
                price.Tag = null;
            }
        }

        private void lnkSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = sender as LinkLabel;
            if (link.Tag is Tuple<Trade, BidsOffersClickType> trade)
            {
                ClickPrice?.Invoke(this, new BidOffersEventArgs(trade.Item2, trade.Item1.Price));
                ClickSize?.Invoke(this, new BidOffersEventArgs(trade.Item2, trade.Item1.Size));
            }
        }

        private void lnkPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = sender as LinkLabel;
            if (link.Tag is Tuple<Trade, BidsOffersClickType> trade)
            {
                ClickPrice?.Invoke(this, new BidOffersEventArgs(trade.Item2, trade.Item1.Price));
            }

        }

        private void lnkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkLast.Tag is NullableTrade trade)
            {
                if (trade.Price.HasValue)
                {
                    ClickPrice?.Invoke(this, new BidOffersEventArgs(BidsOffersClickType.Last, trade.Price.Value));
                }
            }

        }
    }
}
