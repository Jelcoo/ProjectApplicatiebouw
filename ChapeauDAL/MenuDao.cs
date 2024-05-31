using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL.Readers;
using ChapeauModel;
using ChapeauModel.Enums;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetMenu()
        {
            string query = @"
SELECT menuItemId, s.stockId, menuId, menuTypeId, itemName, itemDetailName, VATRate, price, s.[count]
FROM menuItems
JOIN stock AS s ON menuItems.stockId = s.stockId";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<MenuItem> menu = new List<MenuItem>();

            while (reader.Read())
            {
                menu = MenuReader.ReadMenuItems(reader);
            }
            if (menu.Count == 0)
            {
                throw new Exception("No menu found");
            }

            reader.Close();
            CloseConnection();

            return menu;
        }
        public int CreateItemStock()
        {
            string query = @"
INSERT INTO stock (count)
VALUES (0);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            int stockId = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();

            return stockId;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            string query = @"
INSERT INTO menuItems(stockId, menuId, itemName, itemDetailName, VATRate, price, menuTypeId)
VALUES(@stockId, @menuId, @itemName, @itemDetailName, @VATRate, @price, @menuTypeId);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stockId", menuItem.Stock.StockId);
            command.Parameters.AddWithValue("@menuId", (int)menuItem.Menu);
            command.Parameters.AddWithValue("@itemName", menuItem.Name);
            command.Parameters.AddWithValue("@itemDetailName", menuItem.DetailName);
            command.Parameters.AddWithValue("@VATRate", menuItem.VATRate);
            command.Parameters.AddWithValue("@price", menuItem.Price);

            if (menuItem.MenuType == EMenuType.None)
            {
                command.Parameters.AddWithValue("@menuTypeId", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@menuTypeId", (int)menuItem.MenuType);
            }

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void AddMenuItemMenuType(MenuItem menuItem)
        {
            string query = @"
UPDATE menuItems
SET menuTypeId = @menuTypeId
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuTypeId", (int)menuItem.MenuType);
            command.Parameters.AddWithValue("@menuItemId", menuItem.MenuItemId);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Menu> GetMenus()
        {
            string query = @"
SELECT menuId, menuName, menuAvailableFrom, menuAvailableTill
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
            CloseConnection();

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
            CloseConnection();

            return VATRates;
        }

        public MenuItem GetMenuItemById(int id)
        {
            string query = @"
SELECT menuItemId, s.stockId, s.count, menuId, menuTypeId, itemName, itemDetailName, VATRate, price
FROM menuItems
JOIN stock AS s ON menuItems.stockId = s.stockId
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuItemId", id);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MenuItem menuItem = MenuReader.ReadMenuItem(reader);

                reader.Close();
                CloseConnection();

                return menuItem;
            }
            else
            {
                throw new Exception($"MenuItem with id:{id} not found");
            }
        }

        public void ChangeMenuItem(MenuItem menuItem)
        {
            string query = @"
UPDATE menuItems
SET itemName = @itemName,
    itemDetailName = @itemDetailName,
    VATRate = @VATRate,
    menuId = @menuId,
    price = @price
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@itemName", menuItem.Name);
            command.Parameters.AddWithValue("@itemDetailName", menuItem.DetailName);
            command.Parameters.AddWithValue("@VATRate", menuItem.VATRate);
            command.Parameters.AddWithValue("@menuId", (int)menuItem.Menu);
            command.Parameters.AddWithValue("@price", menuItem.Price);
            command.Parameters.AddWithValue("@menuItemId", menuItem.MenuItemId);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteMenuItemById(int id)
        {
            string query = @"
DELETE menuItems
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuItemId", id);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetStockId(int id)
        {
            string query = @"
SELECT stockId
FROM menuItems
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuItemId", id);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int stockId = reader.GetInt32(reader.GetOrdinal("stockId"));

                CloseConnection();
                return stockId;
                
            }
            else
            {
                throw new Exception($"StockId with MenuItemId:{id} not found");
            }

        }

        public void DeleteMenuItemStockById(int id)
        {
            string query = @"
DELETE stock
where stockId = @stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stockId", id);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
