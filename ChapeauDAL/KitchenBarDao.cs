using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;
using ChapeauModel.Enums;

namespace ChapeauDAL
{
    public class KitchenBarDao : BaseDao
    {
        public List<Order> GetOrdersInOrder(EOrderDestination orderType)
        {
            string query;
            if (orderType == EOrderDestination.Kitchen)
            {
                query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.stock AS [count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note 
FROM orders AS O 
JOIN orderLines AS OL ON OL.orderId = O.orderId 
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId 
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId 
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId 
WHERE MT.menuTypeId IS NOT NULL 
AND CONVERT(date, O.orderedAt) = CONVERT(date, GETDATE()) 
ORDER BY O.orderedAt";
            } else {
                query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.stock AS [count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note 
FROM orders AS O 
JOIN orderLines AS OL ON OL.orderId = O.orderId 
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId 
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId 
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId 
WHERE MT.menuTypeId IS NULL 
AND CONVERT(date, O.orderedAt) = CONVERT(date, GETDATE()) 
ORDER BY O.orderedAt";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<Order> orders = OrderParserAndCombiner(reader);

            reader.Close();
            CloseConnection();

            return orders;
        }

        public void UpdateOrderLinesStatus(Order order)
        {
            string query = @"
UPDATE orderLines 
SET orderStatusId = @statusId 
WHERE orderLineId = @orderLineId";
            foreach (OrderLine line in order.OrderLines)
            {
                SqlCommand command = new SqlCommand(query, OpenConnection());
                command.Parameters.AddWithValue("@statusId", (int)line.OrderLineStatus);
                command.Parameters.AddWithValue("@orderLineId", line.OrderLineId);
                command.ExecuteNonQuery();
            }
        }

        public List<Order> GetPreviousCompletedOrders(EOrderDestination orderType)
        {
            string query;
            if (orderType == EOrderDestination.Kitchen)
            {
                query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.stock AS [count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note 
FROM orders AS O 
JOIN orderLines AS OL ON OL.orderId = O.orderId 
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId 
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId 
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId 
WHERE MT.menuTypeId IS NOT NULL 
AND CONVERT(date, O.orderedAt) <= CONVERT(date, GETDATE()) 
ORDER BY O.orderedAt";
            } else {
                query = @"
SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, ST.stock AS [count], MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName, [ON].orderNoteId, [ON].note 
FROM orders AS O 
JOIN orderLines AS OL ON OL.orderId = O.orderId 
JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId 
JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId
JOIN stock AS ST ON MI.stockId = ST.stockId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId 
LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId 
WHERE MT.menuTypeId IS NULL 
AND CONVERT(date, O.orderedAt) <= CONVERT(date, GETDATE()) 
ORDER BY O.orderedAt";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

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
    }
}
