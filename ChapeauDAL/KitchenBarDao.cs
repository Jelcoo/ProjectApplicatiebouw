﻿using ChapeauModel;
using ChapeauDAL.Readers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                query = "SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName , [ON].orderNoteId, [ON].note FROM orders AS O JOIN orderLines AS OL ON OL.orderId = O.orderId JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId WHERE MT.menuTypeId IS NOT NULL AND CONVERT(date, O.orderedAt) = CONVERT(date, GETDATE()) ORDER BY O.orderedAt";
            } else
            {
                query = "SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName , [ON].orderNoteId, [ON].note FROM orders AS O JOIN orderLines AS OL ON OL.orderId = O.orderId JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId WHERE MT.menuTypeId IS NULL AND CONVERT(date, O.orderedAt) = CONVERT(date, GETDATE()) ORDER BY O.orderedAt";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = new Order((int)reader["orderId"], (int)reader["invoiceId"], (DateTime)reader["orderedAt"]);
                if (!orders.Select(order => order.OrderId).Contains(order.OrderId))
                {
                    orders.Add(order);
                }
                OrderLine orderLine = CombineData(reader);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orderLine.OrderId != orders[i].OrderId) continue;
                    orders[i].AddOrderLine(orderLine);
                }
            }
            reader.Close();
            CloseConnection();

            return orders;
        }
        private OrderLine CombineData(SqlDataReader reader)
        {
            
            OrderLine orderLine = OrderReader.ReadOrderLine(reader);
            orderLine.SetMenuItem(MenuReader.ReadMenuItemDetailed(reader));
            if (orderLine.MenuItem.MenuType != null)
            {
                orderLine.MenuItem.SetMenuType(MenuReader.ReadMenuType(reader));
            }
            if (orderLine.OrderNoteId != null)
            {
                orderLine.SetOrderNote(OrderReader.ReadOrderNote(reader));
            }
            return orderLine;
        }
        public void UpdateOrderLinesStatus(Order order)
        {
            List<OrderLine> orderLines = order.OrderLines;
            string query = "UPDATE orderLines SET orderStatusId = @statusId WHERE orderLineId = @orderLineId";
            foreach (OrderLine line in orderLines)
            {
                SqlCommand command = new SqlCommand(query, OpenConnection());
                command.Parameters.AddWithValue("@statusId", (int)line.orderStatus);
                command.Parameters.AddWithValue("@orderLineId", line.OrderLineId);
                command.ExecuteNonQuery();
            }
        }
        public List<Order> GetPreviousCompletedOrders(EOrderDestination orderType)
        {
            string query;
            if (orderType == EOrderDestination.Kitchen)
            {
                query = "SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName , [ON].orderNoteId, [ON].note FROM orders AS O JOIN orderLines AS OL ON OL.orderId = O.orderId JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId WHERE MT.menuTypeId IS NOT NULL AND CONVERT(date, O.orderedAt) <= CONVERT(date, GETDATE()) ORDER BY O.orderedAt";
            }
            else
            {
                query = "SELECT O.orderId, O.invoiceId, O.orderedAt, OL.orderLineId, OL.quantity, OS.orderStatusId, OS.[status], MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.VATRate, MI.price, MT.menuTypeId, MT.typeName , [ON].orderNoteId, [ON].note FROM orders AS O JOIN orderLines AS OL ON OL.orderId = O.orderId JOIN orderStatuses AS OS ON OL.orderStatusId = OS.orderStatusId JOIN menuItems AS MI ON OL.menuItemId = MI.menuItemId LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId LEFT JOIN orderNotes AS [ON] ON [ON].orderLineId = OL.orderLineId WHERE MT.menuTypeId IS NULL AND CONVERT(date, O.orderedAt) <= CONVERT(date, GETDATE()) ORDER BY O.orderedAt";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Order> orders = new List<Order>();

            while (reader.Read())
            {
                Order order = new Order((int)reader["orderId"], (int)reader["invoiceId"], (DateTime)reader["orderedAt"]);
                if (!orders.Select(order => order.OrderId).Contains(order.OrderId))
                {
                    orders.Add(order);
                }
                OrderLine orderLine = CombineData(reader);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orderLine.OrderId != orders[i].OrderId) continue;
                    orders[i].AddOrderLine(orderLine);
                }
            }
            reader.Close();
            CloseConnection();

            return orders;
        }
    }
}
