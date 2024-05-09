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
                invoiceId: (int)reader["invoiceId"],
                orderedAt: (DateTime)reader["orderedAt"]
            );

            return order;
        }

        public static OrderStatus ReadOrderStatus(SqlDataReader reader)
        {
            OrderStatus orderStatus = new OrderStatus(
                orderStatusId: (int)reader["orderStatusId"],
                status: (string)reader["status"]
            );

            return orderStatus;
        }

        public static OrderLine ReadOrderLine(SqlDataReader reader)
        {
            OrderLine orderLine = new OrderLine(
                orderLineId: (int)reader["orderLineId"],
                orderId: (int)reader["orderId"],
                menuItemId: (int)reader["menuItemId"],
                orderStatusId: (int)reader["orderStatusId"],
                quantity: (int)reader["quantity"],
                orderNoteId: (int)reader["orderNoteId"]
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
                orderLineId: (int)reader["orderLineId"],
                note: (string)reader["note"]
            );

            return orderNote;
        }
    }
}
