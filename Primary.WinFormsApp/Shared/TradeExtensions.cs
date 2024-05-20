using Primary.Data;
using System.Text;

namespace ChuchoBot.WinFormsApp.Shared;

public static class TradeExtensions
{
    public static string ToReadableBook(this Entries entries)
    {
        var sb = new StringBuilder();
        var length = entries.Bids.Length > entries.Offers.Length ? entries.Bids.Length : entries.Offers.Length;
        for (var i = 0; i < length; i++)
        {
            if (entries.Bids.Length > i && entries.Offers.Length > i)
            {
                _ = sb.AppendLine(entries.Bids[i].ToReadableBid() + "\t - \t" + entries.Offers[i].ToReadableOffer());
            }
            else if (entries.Bids.Length > i)
            {
                _ = sb.AppendLine(entries.Bids[i].ToReadableBid() + "\t - \t");
            }
            else if (entries.Offers.Length > i)
            {
                _ = sb.AppendLine("\t - \t" + entries.Offers[i].ToReadableOffer());
            }

        }
        return sb.ToString();
    }

    public static string ToReadableBids(this Entries entries)
    {
        if (entries.HasBids() == false)
        {
            return "NO BIDS";
        }

        var bid = new StringBuilder();
        foreach (var item in entries.Bids)
        {
            _ = bid.AppendLine(item.ToReadableBid());
        }
        return bid.ToString();
    }
    public static string ToReadableOffers(this Entries entries)
    {
        if (entries.HasOffers() == false)
        {
            return "NO OFFERS";
        }

        var offer = new StringBuilder();
        foreach (var item in entries.Offers)
        {
            _ = offer.AppendLine(item.ToReadableOffer());
        }
        return offer.ToString();
    }


    public static string ToReadableBid(this Trade trade)
    {
        return $"{trade.Size:#,###} x {trade.Price:C}";
    }

    public static string ToReadableOffer(this Trade trade)
    {
        return $"{trade.Price:C} x {trade.Size:#,###}";
    }

    public static string ToUSD(this decimal value)
    {
        return value.ToString("USD #,##0.00");
    }

    public static string ToCurrency(this decimal value)
    {
        return value.ToString("C2");
    }

    public static decimal ClosePrice(this Entries entries)
    {
        return entries.Close != null && entries.Close.Price.HasValue ? entries.Close.Price.Value : 0;
    }

    public static decimal Variation(this Entries entries)
    {
        return entries.Close != null && entries.Close.Price.HasValue && entries.Last != null && entries.Last.Price.HasValue && entries.Close.Price.Value > 0
            ? (entries.Last.Price.Value / entries.Close.Price.Value) - 1m
            : default;
    }
}
