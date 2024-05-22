using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL.Readers;
using ChapeauModel;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetMenu()
        {
            string query = @"
SELECT menuItemId, stockId, menuId, menuTypeId, itemName, itemDetailName, VATRate, price
FROM menuItems";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<MenuItem> menu = new List<MenuItem>();

            while (reader.Read())
            {
                MenuItem menuItem = MenuReader.ReadMenuItem(reader);

                menu.Add(menuItem);
            }

            if (menu.Count == 0)
            {
                throw new Exception("No menu found");
            }

            reader.Close();
            CloseConnection();

            return menu;
        }
        public int AddItemStock(int stockAmount)
        {
            string query = @"
INSERT INTO stock (stock)
VALUES (@stock);
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

            List<MenuType> menuTypes = new List<MenuType>();

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
            CloseConnection();

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
SELECT menuItemId, stockId, menuId, menuTypeId, itemName, itemDetailName, VATRate, price
FROM menuItems
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
    }
}
