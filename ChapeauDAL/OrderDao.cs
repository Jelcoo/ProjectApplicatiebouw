using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using ChapeauModel.Enums;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public Order GetOrderById(int orderId)
        {
            string query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.[count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note
FROM orders AS O
JOIN orderLines AS OL ON OL.orderId = O.orderId
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
JOIN invoices AS I ON I.invoiceId = O.invoiceId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId
WHERE O.orderId = @orderId;";
            
            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@orderId", orderId);

            SqlDataReader reader = command.ExecuteReader();

            List<Order> orders = OrderParserAndCombiner(reader);

            reader.Close();
            CloseConnection();

            return orders.First();
        }
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

        public void UpdateOrderLine(OrderLine orderLine)
        {
            string query = @"
UPDATE orderLines
SET quantity = @quantity
WHERE orderLineId = @orderLineId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", orderLine.Quantity);
            command.Parameters.AddWithValue("@orderLineId", orderLine.OrderLineId);

            command.ExecuteNonQuery();

            CloseConnection();
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

        public List<Order> GetOrdersByTable(Table table)
        {
            string query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.[count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note, I.tableId
FROM orders AS O
JOIN orderLines AS OL ON OL.orderId = O.orderId
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
JOIN invoices AS I ON I.invoiceId = O.invoiceId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId
WHERE I.tableId = @tableId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@tableId", table.TableId);

            SqlDataReader reader = command.ExecuteReader();

            List<Order> orders = OrderParserAndCombiner(reader);

            reader.Close();
            CloseConnection();

            return orders;
        }

        private OrderLine CombineData(SqlDataReader reader)
        {
            OrderLine orderLine = OrderReader.ReadOrderLine(reader);
            orderLine.SetMenuItem(MenuReader.ReadMenuItem(reader));
            if (orderLine.MenuItem.MenuType != null)
            {
                orderLine.MenuItem.SetMenuType((EMenuType)(int)reader["menuTypeId"]);
            }
            if (orderLine.OrderNote != null)
            {
                orderLine.SetOrderNote(OrderReader.ReadOrderNote(reader));
            }
            return orderLine;
        }

        private List<Order> OrderParserAndCombiner(SqlDataReader reader)
        {
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = OrderReader.ReadOrderWithoutInvoice(reader);
                if (!orders.Select(order => order.OrderId).Contains(order.OrderId))
                {
                    orders.Add(order);
                }
                OrderLine orderLine = CombineData(reader);
                for (int i = 0; i < orders.Count; i++)
                {
                    if ((int)reader["orderId"] != orders[i].OrderId) continue;
                    orders[i].AddOrderLine(orderLine);
                }
            }

            return orders;
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

        public void DecreaseStock(OrderLine orderLine, int? quantity = null)
        {
            string query = @"
UPDATE stock
SET count = count - @quantity
WHERE stockId = (
    SELECT stockId
    FROM menuItems
    WHERE menuItemId = @menuItemId
);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", quantity ?? orderLine.Quantity);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItem.MenuItemId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void IncreaseStock(OrderLine orderLine, int? quantity = null)
        {
            string query = @"
UPDATE stock
SET count = count + @quantity
WHERE stockId = (
    SELECT stockId
    FROM menuItems
    WHERE menuItemId = @menuItemId
);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@quantity", quantity ?? orderLine.Quantity);
            command.Parameters.AddWithValue("@menuItemId", orderLine.MenuItem.MenuItemId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public Invoice? GetOpenInvoice(Table table)
        {
            string query = @"
SELECT I.invoiceId, I.tableId, I.servedBy, I.invoiceStatusId, I.createdAt, T.isOccupied, E.employeeId, E.employeeName, E.password, E.employedAt, E.roleId
FROM invoices AS I
JOIN tables AS T ON T.tableId = I.tableId
JOIN employees AS E ON E.employeeId = I.servedBy
WHERE I.tableId = @tableId
AND I.invoiceStatusId = @status;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@tableId", table.TableId);
            command.Parameters.AddWithValue("@status", (int)EInvoiceStatus.Pending);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Invoice invoice = InvoiceReader.ReadInvoice(reader);

                reader.Close();
                CloseConnection();

                return invoice;
            } else {
                return null;
            }
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
