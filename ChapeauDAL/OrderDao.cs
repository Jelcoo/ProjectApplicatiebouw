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
            command.Parameters.AddWithValue("@invoiceId", order.Invoice.InvoiceId);
            command.Parameters.AddWithValue("@orderedAt", DateTime.Now);

            int orderId = Convert.ToInt32(command.ExecuteScalar());
            order.SetId(orderId);

            CloseConnection();

            return order;
        }

        public OrderLine CreateOrderLine(int orderId, OrderLine orderLine)
        {
            string query = @"
INSERT INTO orderLines (orderId, menuItemId, orderStatusId, quantity)
VALUES (@orderId, @menuItemId, @orderStatusId, @quantity);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItem.MenuItemId);
            command.Parameters.AddWithValue("@orderStatusId", (int)orderLine.OrderLineStatus);
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);

            int orderLineId = Convert.ToInt32(command.ExecuteScalar());
            orderLine.SetId(orderLineId);

            CloseConnection();

            return orderLine;
        }

        public void DeleteOrderLine(OrderLine orderLine)
        {
            string query = @"
DELETE FROM orderLines
WHERE orderLineId = @orderLineId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderLineId", orderLine.OrderLineId);

            command.ExecuteNonQuery();

            CloseConnection();
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

        public void UpdateOrderNote(OrderNote orderNote)
        {
            string query = @"
UPDATE orderNotes
SET note = @note
WHERE orderNoteId = @orderNoteId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@note", orderNote.Note);
            command.Parameters.AddWithValue("@orderNoteId", orderNote.OrderNoteId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteOrderNote(OrderNote orderNote)
        {
            string query = @"
DELETE FROM orderNotes
WHERE orderNoteId = @orderNoteId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderNoteId", orderNote.OrderNoteId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DecreaseStock(OrderLine orderLine)
        {
            string query = @"
UPDATE menuItems
SET stock = stock - @quantity
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItem.MenuItemId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void IncreaseStock(OrderLine orderLine)
        {
            string query = @"
UPDATE menuItems
SET stock = stock + @quantity
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItem.MenuItemId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            string query = @"
SELECT MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, SUM(OL.quantity) AS [quantity]
FROM [orderLines] AS OL
JOIN [orders] AS O ON O.orderId = OL.orderId
JOIN [invoices] AS I ON I.invoiceId = O.invoiceId
JOIN [menuItems] AS MI ON MI.menuItemId = OL.menuItemId
WHERE I.invoiceId = @invoiceId
GROUP BY MI.itemName, MI.price;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceId);

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<MenuItem, int> AllOrderedItems = new Dictionary<MenuItem, int>();

            while (reader.Read())
            {
                MenuItem menuItem = MenuReader.ReadMenuItem(reader);
                int quantity = (int)reader["quantity"];

                AllOrderedItems.Add(menuItem, quantity);
            }
            if (AllOrderedItems.Count == 0)
            {
                throw new Exception($"Invoice ID '{invoiceId}' not found");
            }

            return AllOrderedItems;
        }
    }
}
