using System;
using System.Collections.Generic;
using System.Data;

namespace Primary.WinFormsApp
{
    public class SettlementArbitrationDataTable
    {

        public DataTable DataTable { get; private set; }

        public void Init()
        {
            DataTable = new DataTable();
            DataColumn ownedVentaColumn = DataTable.Columns.Add("KeyVenta", typeof(string));
            DataColumn arbitrationCompraColumn = DataTable.Columns.Add("KeyCompra", typeof(string));

            DataTable.PrimaryKey = new DataColumn[] { ownedVentaColumn, arbitrationCompraColumn };

            _ = DataTable.Columns.Add("Spread", typeof(decimal));
            _ = DataTable.Columns.Add("SpreadLast", typeof(decimal));

            _ = DataTable.Columns.Add("SellTotal", typeof(decimal));
            _ = DataTable.Columns.Add("BuyTotal", typeof(decimal));
            _ = DataTable.Columns.Add("Comision", typeof(decimal));

            _ = DataTable.Columns.Add("Caucion", typeof(decimal));
            _ = DataTable.Columns.Add("ComisionCaucion", typeof(decimal));

            _ = DataTable.Columns.Add("Profit", typeof(decimal));
            _ = DataTable.Columns.Add("ProfitCaucion", typeof(decimal));

            _ = DataTable.Columns.Add("Venta", typeof(decimal));
            _ = DataTable.Columns.Add("Compra", typeof(decimal));

            _ = DataTable.Columns.Add("CompraLast", typeof(decimal));
            _ = DataTable.Columns.Add("VentaLast", typeof(decimal));

            _ = DataTable.Columns.Add("Trade", typeof(SettlementTermTrade));

            _ = DataTable.Columns.Add("TNA", typeof(decimal));
        }

        public void Refresh(List<SettlementTermTrade> trades, int diasLiq24H, int diasLiq48H, decimal comision, 
            decimal comisionCaucionTomadora, decimal comisionCaucionColocadora, decimal tasaCaucion, bool onlyProfitableTrades)
        {
            List<DataRow> processedRows = new List<DataRow>();

            foreach (SettlementTermTrade trade in trades)
            {
                DataRow row;
                var tradeProfit = trade.Calculate(0, tasaCaucion, comisionCaucionColocadora, comisionCaucionTomadora, diasLiq24H, diasLiq48H);

                if (onlyProfitableTrades && tradeProfit.ProfitLoss < 0)
                {
                    continue;
                }

                string ownedVenta = trade.Sell.Instrument.InstrumentId.SymbolWithoutPrefix();
                string arbitrationCompra = trade.Buy.Instrument.InstrumentId.SymbolWithoutPrefix();

                DataRow existingRow = DataTable.Rows.Find(new[] { ownedVenta, arbitrationCompra });

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


                row["SellTotal"] = tradeProfit.SellTotalNeto;
                row["BuyTotal"] = tradeProfit.BuyTotalNeto;
                                
                row["Comision"] = tradeProfit.BuyComisionDerechos + tradeProfit.SellComisionDerechos;

                row["ComisionCaucion"] = tradeProfit.ComisionCaucionTotal;

                row["Caucion"] = tradeProfit.TotalCaucionConInteres;

                row["Profit"] = tradeProfit.ProfitLoss;
                row["ProfitCaucion"] = tradeProfit.InteresNeto;

                row["Venta"] = trade.Sell.Data.HasBids() ? (object)trade.Sell.Data.Bids[0].Price : DBNull.Value;
                row["Compra"] = trade.Buy.Data.HasOffers() ? (object)trade.Buy.Data.Offers[0].Price : DBNull.Value;
                row["VentaLast"] = trade.Sell.Data.HasLastPrice() ? (object)trade.Sell.Data.Last.Price.Value : DBNull.Value;
                row["CompraLast"] = trade.Buy.Data.HasLastPrice() ? (object)trade.Buy.Data.Last.Price.Value : DBNull.Value;

                row["TNA"] = tradeProfit.SpreadTNA;

                row["Trade"] = trade;

                if (existingRow == null)
                {
                    DataTable.Rows.Add(row);
                }
                processedRows.Add(row);
            }

            List<DataRow> rowsToRemove = new List<DataRow>();
            foreach (DataRow dataRow in DataTable.Rows)
            {
                if (!processedRows.Contains(dataRow))
                {
                    rowsToRemove.Add(dataRow);
                }
            }
            foreach (DataRow dataRow in rowsToRemove)
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
}
