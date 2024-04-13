using System;
using System.Collections.Generic;
using System.Data;

namespace ChuchoBot.WinFormsApp.SettlementTerms;

public class SettlementArbitrationDataTable
{

    public DataTable DataTable { get; private set; }

    public void Init()
    {
        DataTable = new DataTable();
        var ownedVentaColumn = DataTable.Columns.Add("KeyVenta", typeof(string));
        var arbitrationCompraColumn = DataTable.Columns.Add("KeyCompra", typeof(string));

        DataTable.PrimaryKey = new DataColumn[] { ownedVentaColumn, arbitrationCompraColumn };

        _ = DataTable.Columns.Add("Spread", typeof(decimal));
        _ = DataTable.Columns.Add("SpreadCaucion", typeof(decimal));
        _ = DataTable.Columns.Add("SpreadLast", typeof(decimal));

        _ = DataTable.Columns.Add("SellTotal", typeof(decimal));
        _ = DataTable.Columns.Add("BuyTotal", typeof(decimal));
        _ = DataTable.Columns.Add("Comision", typeof(decimal));

        _ = DataTable.Columns.Add("Caucion", typeof(decimal));
        _ = DataTable.Columns.Add("ComisionCaucion", typeof(decimal));

        _ = DataTable.Columns.Add("Profit", typeof(decimal));
        _ = DataTable.Columns.Add("ProfitPercentage", typeof(decimal));
        _ = DataTable.Columns.Add("ProfitCaucion", typeof(decimal));

        _ = DataTable.Columns.Add("Venta", typeof(decimal));
        _ = DataTable.Columns.Add("Compra", typeof(decimal));

        _ = DataTable.Columns.Add("CompraLast", typeof(decimal));
        _ = DataTable.Columns.Add("VentaLast", typeof(decimal));

        _ = DataTable.Columns.Add("Trade", typeof(SettlementTermTrade));

        _ = DataTable.Columns.Add("TNA", typeof(decimal));
    }

    public void Refresh(List<SettlementTermTrade> trades, int diasLiq24H, int diasLiq48H, decimal tasaCaucion, bool onlyProfitableTrades)
    {
        var processedRows = new List<DataRow>();

        foreach (var trade in trades)
        {
            DataRow row;
            trade.Calculate(0, tasaCaucion, diasLiq24H, diasLiq48H);

            if (onlyProfitableTrades && trade.ProfitLoss < 0)
            {
                continue;
            }

            var ownedVenta = trade.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
            var arbitrationCompra = trade.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();

            var existingRow = DataTable.Rows.Find(new[] { ownedVenta, arbitrationCompra });

            if (existingRow != null)
            {
                row = existingRow;
            }
            else
            {
                row = DataTable.NewRow();

                row["KeyVenta"] = ownedVenta;
                row["KeyCompra"] = arbitrationCompra;
            }

            row["Spread"] = trade.Spread;
            row["SpreadLast"] = trade.SpreadLast;


            row["SellTotal"] = trade.SellTotalNeto;
            row["BuyTotal"] = trade.BuyTotalNeto;

            row["Comision"] = trade.BuyComisionDerechos + trade.SellComisionDerechos;

            row["ComisionCaucion"] = trade.Caucion.TotalGastos;

            row["Caucion"] = trade.Caucion.ImporteConInteres;

            row["Profit"] = trade.ProfitLoss;
            row["ProfitPercentage"] = trade.ProfitLoss / trade.BuyTotalNeto;
            row["ProfitCaucion"] = trade.Caucion.InteresNeto;

            row["Venta"] = trade.Sell.Data.HasBids() ? trade.Sell.Data.Bids[0].Price : DBNull.Value;
            row["Compra"] = trade.Buy.Data.HasOffers() ? trade.Buy.Data.Offers[0].Price : DBNull.Value;
            row["VentaLast"] = trade.Sell.Data.HasLastPrice() ? trade.Sell.Data.Last.Price.Value : DBNull.Value;
            row["CompraLast"] = trade.Buy.Data.HasLastPrice() ? trade.Buy.Data.Last.Price.Value : DBNull.Value;

            row["TNA"] = trade.SpreadTNA;
            row["SpreadCaucion"] = trade.SpreadTNA - (trade.Caucion.TNA / 100m);

            row["Trade"] = trade;

            if (existingRow == null)
            {
                DataTable.Rows.Add(row);
            }
            processedRows.Add(row);
        }

        var rowsToRemove = new List<DataRow>();
        foreach (DataRow dataRow in DataTable.Rows)
        {
            if (!processedRows.Contains(dataRow))
            {
                rowsToRemove.Add(dataRow);
            }
        }
        foreach (var dataRow in rowsToRemove)
        {
            DataTable.Rows.Remove(dataRow);
        }
    }

    public class SettlementTradeItem
    {
        public string InstrumentoBuy { get; set; }
        public string InstrumentoSell { get; set; }


    }
}
