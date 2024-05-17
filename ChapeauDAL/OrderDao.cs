﻿using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            string query = @"
    SELECT MI.itemName AS itemName, MI.price AS price, SUM(OL.quantity) AS [quantity]
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
                string itemName = (string)reader["itemName"];
                double price = (double)reader["price"];
                MenuItem menuItem = new MenuItem(itemName, price);

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
