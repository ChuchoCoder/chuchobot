using Primary.Data;
using Primary.Data.Orders;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipelines;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Shared;

[DebuggerDisplay("{Size.ToString(\"#0\"),nq}*{Price.ToString(\"C\"),nq} =  {Total.ToString(\"C\"),nq}")]
public class InstrumentOperation
{

    public InstrumentOperation(Side side, decimal size, decimal price, InstrumentDetail instrumentDetail)
    {
        Side = side;
        Size = size;
        Price = price;
        InstrumentDetail = instrumentDetail;

    }

    public string Text => $"{Side} {InstrumentDetail.InstrumentId.Ticker()} {Size:#0} * {Price:c} = {NetTotal:c} (Comisión {ComisionInPesos:c} Neto {NetTotalInPesos:c})";

    public Side Side { get; }

    // Precio del dolar MEP/CCL o 1 cuando es todo en pesos
    public decimal CurrencyRate
    {
        get
        {
            return InstrumentDetail.IsPesos() ? 1 : CurrencyRateMepAL30Venta.Instance.Value;
        }
    }

    public InstrumentDetail InstrumentDetail { get; }

    public decimal Size { get; set; }
    public decimal _price;
    public decimal Price
    {
        get
        {
            return _price;
        }
        set
        {
            _price = value;
        }
    }

    // Owned Sell es Dolar cuando es arbitraje de MEP/CCL
    public decimal Total => Size * Price * InstrumentDetail.PriceConvertionFactor;
    public decimal Comision => InstrumentDetail.CalculateComisionDerechosMercado(Total);
    public decimal NetTotal => Side == Side.Buy ? Total + Comision : Total - Comision;

    public decimal ComisionInPesos => Comision * CurrencyRate;
    public decimal TotalInPesos => Total * CurrencyRate;
    public decimal NetTotalInPesos => NetTotal * CurrencyRate;

    public Order Order { get; private set; }
    public OrderId OrderId { get; private set; }
    public OrderStatus OrderStatus
    {
        get
        {
            if (Argentina.Data.Orders.TryGetValue(OrderId.ClientOrderId, out var order))
            {
                return order;
            }
            return null;
        }
    }

    public decimal UpdateSize(decimal netTotal)
    {
        if (Price == 0)
            return decimal.Zero;
        var size = Math.Truncate(netTotal / Price / InstrumentDetail.PriceConvertionFactor);
        Size = size <= 0 ? 0 : size;
        return Size;
    }

    public async Task SubmitOrder()
    {
        Order = new Order()
        {
            Instrument = InstrumentDetail.InstrumentId,
            Expiration = Expiration.Day,
            Type = Primary.Data.Orders.Type.Limit,
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

