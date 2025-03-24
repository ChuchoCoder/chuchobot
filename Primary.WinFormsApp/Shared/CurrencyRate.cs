using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.Shared;
public interface ICurrencyRate
{
    decimal Value { get; }
}

public class CurrencyRateMepAL30Compra : ICurrencyRate
{
    public static CurrencyRateMepAL30Compra Instance { get; } = new CurrencyRateMepAL30Compra();

    public decimal Value => Argentina.GetDolarMEPCompra();
}

public class CurrencyRateMepAL30Venta: ICurrencyRate
{
    public static CurrencyRateMepAL30Venta Instance { get; } = new CurrencyRateMepAL30Venta();

    public decimal Value => Argentina.GetDolarMEPVenta();
}