using ChapeauModel;
using ChapeauModel.Enums;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class OrderReader
    {
        public static Order ReadOrder(SqlDataReader reader)
        {
            Order order = new Order(
                orderId: (int)reader["orderId"],
                invoice: InvoiceReader.ReadInvoice(reader),
                orderedAt: (DateTime)reader["orderedAt"]
            );

            return order;
        }
        public static Order ReadOrderWithoutInvoice(SqlDataReader reader)
        {
            Order order = new Order(
                orderId: (int)reader["orderId"],
                orderedAt: (DateTime)reader["orderedAt"]
            );

            return order;
        }

        public static OrderLine ReadOrderLine(SqlDataReader reader)
        {
            OrderLine orderLine = new OrderLine(
                orderLineId: (int)reader["orderLineId"],
                menuItem: MenuReader.ReadMenuItem(reader),
                orderLineStatus: (EOrderLineStatus)(int)reader["orderStatusId"],
                quantity: (int)reader["quantity"]
            );

            if (reader["orderNoteId"] != DBNull.Value)
            {
                orderLine.SetOrderNote(ReadOrderNote(reader));
            }

            return orderLine;
        }

        public static List<OrderLine> ReadOrderLines(SqlDataReader reader)
        {
            List<OrderLine> orderLines = new List<OrderLine>();

            while (reader.Read())
            {
                OrderLine orderLine = ReadOrderLine(reader);
                orderLines.Add(orderLine);
            }

            return orderLines;
        }

        public static OrderNote ReadOrderNote(SqlDataReader reader)
        {
            OrderNote orderNote = new OrderNote(
                orderNoteId: (int)reader["orderNoteId"],
                note: (string)reader["note"]
            );

            return orderNote;
        }
    }
}