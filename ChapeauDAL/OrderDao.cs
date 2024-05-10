using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public Order CreateOrder(Order order)
        {
            string query = @"
INSERT INTO orders (invoiceId, orderedAt)
VALUES (@invoiceId, @orderedAt);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", order.InvoiceId);
            command.Parameters.AddWithValue("@orderedAt", DateTime.Now);

            int orderId = Convert.ToInt32(command.ExecuteScalar());
            order.SetId(orderId);

            CloseConnection();

            return order;
        }

        public OrderLine CreateOrderLine(OrderLine orderLine)
        {
            string query = @"
INSERT INTO orderLines (orderId, menuItemId, orderStatusId, quantity)
VALUES (@orderId, @menuItemId, @orderStatusId, @quantity);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderId", orderLine.OrderId);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItemId);
            command.Parameters.AddWithValue("@orderStatusId", orderLine.OrderStatusId);
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);

            int orderLineId = Convert.ToInt32(command.ExecuteScalar());
            orderLine.SetId(orderLineId);

            CloseConnection();

            return orderLine;
        }

        public OrderStatus GetOrderStatusByName(string statusName)
        {
            string query = @"
SELECT orderStatusId, status
FROM orderStatuses
WHERE status = @statusName";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@statusName", statusName);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                OrderStatus orderStatus = OrderReader.ReadOrderStatus(reader);
                
                reader.Close();
                CloseConnection();

                return orderStatus;
            } else
            {
                throw new Exception($"Order status '{statusName}' not found");
            }
        }

        public OrderLine CreateOrderNote(OrderLine orderLine)
        {
            string query = @"
INSERT INTO orderNotes (orderLineId, note)
VALUES (@orderLineId, @note);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderLineId", orderLine.OrderLineId);
            command.Parameters.AddWithValue("@note", orderLine.OrderNote?.Note);

            int orderNoteId = Convert.ToInt32(command.ExecuteScalar());
            orderLine.OrderNote?.SetId(orderNoteId);

            CloseConnection();

            return orderLine;
        }

        public void DecreaseStock(OrderLine orderLine)
        {
            string query = @"
UPDATE menuItems
SET stock = stock - @quantity
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItemId);

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
