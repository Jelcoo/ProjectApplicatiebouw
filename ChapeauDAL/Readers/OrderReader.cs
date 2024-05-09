using ChapeauModel;
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
                orderedAt: (DateTime)reader["orderedAt"],
                orderLines: ReadOrderLines(reader)
            );

            return order;
        }

        public static OrderStatus ReadOrderStatus(SqlDataReader reader)
        {
            OrderStatus orderStatus = new OrderStatus(
                orderStatusId: (int)reader["orderStatusId"],
                orderLine: ReadOrderLine(reader),
                status: (string)reader["status"]
            );

            return orderStatus;
        }

        public static OrderLine ReadOrderLine(SqlDataReader reader)
        {
            OrderLine orderLine = new OrderLine(
                orderLineId: (int)reader["orderLineId"],
                order: ReadOrder(reader),
                menuItem: MenuReader.ReadMenuItem(reader),
                quantity: (int)reader["quantity"],
                orderNote: ReadOrderNote(reader),
                orderStatus: ReadOrderStatus(reader)
            );

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
                orderLine: ReadOrderLine(reader),
                note: (string)reader["note"]
            );

            return orderNote;
        }
    }
}
