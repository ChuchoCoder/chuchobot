using Primary.Data;

namespace ChuchoBot.WinFormsApp.Tests;

public class EntriesBuilder
{
    public static Entries Create(decimal size, decimal bidPrice, decimal offerPrice)
    {
        var entries = new Entries()
        {
            Bids = new Trade[] {
                    new() { Size = size, Price = bidPrice }
                },
            Offers = new Trade[] {
                    new() { Size = size, Price = offerPrice }
                }
        };

        return entries;
    }
}