using ChuchoBot.WinFormsApp.Shared;
using Primary.Data.Orders;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ChuchoBot.WinFormsApp.DolarArbitration;

[DebuggerDisplay("Profit: {ProfitTotalInPesos.ToString(\"C\"),nq} ({ProfitPercentage.ToString(\"P\"),nq}) {OwnedBuy.InstrumentDetail.InstrumentId.Ticker(),nq} / {ArbitrationSell.InstrumentDetail.InstrumentId.Ticker(),nq}")]
public class RatioTradeOperation
{
    public string OperationLog { get; private set; } = string.Empty;

    public RatioTrade RatioTrade { get; init; }

    public InstrumentOperation OwnedSell { get; init; }
    public InstrumentOperation OwnedBuy { get; init; }
    public InstrumentOperation ArbitrationBuy { get; init; }
    public InstrumentOperation ArbitrationSell { get; init; }

    public decimal Comision => OwnedSell.Comision + ArbitrationBuy.Comision + ArbitrationSell.Comision + OwnedBuy.Comision;
    public decimal ComisionTotalInPesos => OwnedSell.ComisionInPesos + ArbitrationBuy.ComisionInPesos + ArbitrationSell.ComisionInPesos + OwnedBuy.ComisionInPesos;

    public decimal ProfitTotal => OwnedSell.NetTotal - ArbitrationBuy.NetTotal + ArbitrationSell.NetTotal - OwnedBuy.NetTotal;
    public decimal ProfitTotalInPesos => OwnedSell.NetTotalInPesos - ArbitrationBuy.NetTotalInPesos + ArbitrationSell.NetTotalInPesos - OwnedBuy.NetTotalInPesos;
    public decimal ProfitPercentage => ProfitTotalInPesos / OwnedSell.NetTotalInPesos;

    public async Task Operate()
    {
        if (OwnedSell.OrderId == null)
        {
            OperationLog += OwnedSell.Text;
            await OwnedSell.SubmitOrder(); // Puede que no tenga Parking
        }
        else if (OwnedBuy.OrderId == null)
        {
            OperationLog += OwnedBuy.Text;
            await OwnedBuy.SubmitOrder();
        }
        else if (ArbitrationBuy.OrderId == null)
        {
            OperationLog += ArbitrationBuy.Text;
            await ArbitrationBuy.SubmitOrder();
        }
        else if (ArbitrationSell.OrderId == null)
        {
            OperationLog += ArbitrationSell.Text;
            await ArbitrationSell.SubmitOrder();
        }

        if (OwnedSell.OrderId != null && OwnedSell.OrderStatus != null)
        {
            if (OwnedSell.OrderStatus.Status == Status.Filled)
            {
                OperationLog += "Ejecutada: " + OwnedSell.Text;
            }
            else if (OwnedSell.OrderStatus.Status == Status.Rejected)
            {
                OperationLog += "Rechazada: " + OwnedSell.Text;

                await OwnedBuy.CancelOrder();
                await ArbitrationBuy.CancelOrder();
                await ArbitrationSell.CancelOrder();
            }
        }
        
        if (OwnedBuy.OrderId != null && OwnedBuy.OrderStatus != null)
        {
            if (OwnedBuy.OrderStatus.Status == Status.Filled)
            {
                OperationLog += "Ejecutada: " + OwnedBuy.Text;
            }
            else if (OwnedBuy.OrderStatus.Status == Status.Rejected)
            {
                OperationLog += "Rechazada: " + OwnedBuy.Text;

                await OwnedSell.CancelOrder();
                await ArbitrationBuy.CancelOrder();
                await ArbitrationSell.CancelOrder();
            }
        }

        if (ArbitrationBuy.OrderId != null && ArbitrationBuy.OrderStatus != null)
        {
            if (ArbitrationBuy.OrderStatus.Status == Status.Filled)
            {
                OperationLog += "Ejecutada: " + ArbitrationBuy.Text;
            }
            else if (ArbitrationBuy.OrderStatus.Status == Status.Rejected)
            {
                OperationLog += "Rechazada: " + ArbitrationBuy.Text;

                await OwnedSell.CancelOrder();
                await OwnedBuy.CancelOrder();
                await ArbitrationSell.CancelOrder();
            }
        }

        if (ArbitrationSell.OrderId != null && ArbitrationSell.OrderStatus != null)
        {
            if (ArbitrationSell.OrderStatus.Status == Status.Filled)
            {
                OperationLog += "Ejecutada: " + ArbitrationSell.Text;
            }
            else if (ArbitrationSell.OrderStatus.Status == Status.Rejected)
            {
                OperationLog += "Rechazada: " + ArbitrationSell.Text;

                await OwnedSell.CancelOrder();
                await OwnedBuy.CancelOrder();
                await ArbitrationBuy.CancelOrder();
            }
        }
    }
}
