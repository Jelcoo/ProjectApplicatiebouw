﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL.Readers;
using ChapeauModel;


namespace ChapeauDAL
{
    public class StockDao : BaseDao
    {
        public Dictionary<int, (string name, int stock)> GetStock()
        {
            string query = @"
SELECT MI.menuItemId AS id, MI.itemName AS [name], S.stock
FROM menuItems as MI
JOIN stock AS S ON S.stockId = MI.stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<int, (string name, int stock)> stock = new Dictionary<int, (string name, int stock)>();

            while (reader.Read())
            {
                int menuItemId = reader.GetInt32(reader.GetOrdinal("id"));
                string itemName = reader.GetString(reader.GetOrdinal("name"));
                int stockValue = reader.GetInt32(reader.GetOrdinal("stock"));

                stock[menuItemId] = (itemName, stockValue);
            }
            if (stock.Count == 0)
            {
                throw new Exception($"No stock found");
            }

            return stock;
        }

        // Add MenuItem

        public int AddItemStock(int stockAmount)
        {
            string query = @"
insert into stock (stock)
values (@stock);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stock", stockAmount);
            int stockId = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();

            return stockId;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            string query = @"
INSERT INTO menuItems(stockId, menuId, menuTypeId, itemName, itemDetailName, VATRate, price)
VALUES(@stockId, @menuId, @menuTypeId, @itemName, @itemDetailName, @VATRate, @price);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stockId", menuItem.StockId);
            command.Parameters.AddWithValue("@menuId", menuItem.MenuId);
            command.Parameters.AddWithValue("@menuTypeId", menuItem.MenuTypeId);
            command.Parameters.AddWithValue("@itemName", menuItem.Name);
            command.Parameters.AddWithValue("@itemDetailName", menuItem.DetailName);
            command.Parameters.AddWithValue("@VATRate", menuItem.VATRate);
            command.Parameters.AddWithValue("@price", menuItem.Price);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<MenuType> GetMenuTypes()
        {
            string query = @"
SELECT menuTypeId, typeName
FROM menuTypes";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<MenuType > menuTypes = new List<MenuType>();

            while (reader.Read())
            {
                MenuType menuType = MenuReader.ReadMenuType(reader);

                menuTypes.Add(menuType);
            }

            if (menuTypes.Count == 0)
            {
                throw new Exception("No menuTypes found");
            }

            reader.Close();
            command.Connection.Close();

            return menuTypes;
        }
        public List<Menu> GetMenus()
        {
            string query = @"
SELECT menuId, menuName, serveStart, serveEnd
FROM menus";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<Menu> menus = new List<Menu>();

            while (reader.Read())
            {
                Menu menu = MenuReader.ReadMenu(reader);

                menus.Add(menu);
            }

            if (menus.Count == 0)
            {
                throw new Exception("No menus found");
            }

            reader.Close();
            command.Connection.Close();

            return menus;
        }
        public List<Double> GetVATRates()
        {
            string query = @"
SELECT VATRate
FROM menuItems
GROUP BY VATRate;";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<double> VATRates = new List<double>();

            while (reader.Read())
            {
                double VATRate = reader.GetDouble(0);

                VATRates.Add(VATRate);
            }

            if (VATRates.Count == 0)
            {
                throw new Exception("No VAT-rates found");
            }

            reader.Close();
            command.Connection.Close();

            return VATRates;
        }
    }
}