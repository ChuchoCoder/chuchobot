using Primary.Data;
using Primary.Data.Orders;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Shared;

[DebuggerDisplay("{Size.ToString(\"#0\"),nq}*{Price.ToString(\"C\"),nq} =  {Total.ToString(\"C\"),nq}")]
public class InstrumentOperation
{

    public InstrumentOperation(Side side, decimal size, decimal price, decimal currencyRate, InstrumentDetail instrumentDetail)
    {
        Side = side;
        Size = size;
        Price = price;
        // Si es Pesos usar 1 como currency rate para que no haya conversion
        CurrencyRate = instrumentDetail.IsPesos() ? 1 : currencyRate;
        InstrumentDetail = instrumentDetail;

        // PriceConvertionFactor: Bonos 100, Acciones/Cedears 1
        var priceConvertionFactor = instrumentDetail.PriceConvertionFactor;

        Total = size * price * priceConvertionFactor;
        Comision = instrumentDetail.CalculateComisionDerechosMercado(Total);

    }

    public string Text => $"{Side} {InstrumentDetail.InstrumentId.Ticker()} {Size:#0} * {Price:c} = {NetTotal:c} (Comisión {ComisionInPesos:c} Neto {NetTotalInPesos:c})";

    public Side Side { get; }

    // Precio del dolar MEP/CCL o 1 cuando es todo en pesos
    public decimal CurrencyRate { get; }

    public InstrumentDetail InstrumentDetail { get; }

    public decimal Size { get; set; }
    public decimal Price { get; set; }

    // Owned Sell es Dolar cuando es arbitraje de MEP/CCL
    public decimal Total { get; }
    public decimal Comision { get; }
    public decimal NetTotal => Side == Side.Buy ? Total + Comision : Total - Comision;

    public decimal ComisionInPesos => Comision * CurrencyRate;
    public decimal NetTotalInPesos => NetTotal * CurrencyRate;

    public Order Order { get; private set; }
    public OrderId OrderId { get; private set; }
    public OrderStatus OrderStatus {
        get
        {
            if (Argentina.Data.Orders.TryGetValue(OrderId.ClientOrderId, out var order))
            {
                return order;
            }
            return null;
        }
    }

    public async Task SubmitOrder()
    {
        Order = new Order()
        {
            Instrument = InstrumentDetail.InstrumentId,
            Expiration = Expiration.Day,
            Type = Type.Limit,
            Side = Side,
            Quantity = (int)Size,
            Price = Price
        };
        OrderId = await Argentina.Data.Api.SubmitOrder(Argentina.Data.PrimaryAccount, Order);
    }

    public async Task CancelOrder()
    {
        if (OrderId != null)
            await Argentina.Data.Api.CancelOrder(OrderId);
    }
}

