namespace ChuchoBot.WinFormsApp.Components;

public class BidOffersEventArgs
{
    public BidsOffersClickType ClickType { get; set; }
    public decimal Value { get; set; }

    public BidOffersEventArgs(BidsOffersClickType clickType, decimal value)
    {
        ClickType = clickType;
        Value = value;
    }
}
