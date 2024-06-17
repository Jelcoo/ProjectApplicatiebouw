using System.Data.SqlClient;
using ChapeauDAL.Readers;
using ChapeauModel;
using ChapeauModel.Enums;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<Menu> GetMenus()
        {
            string query = @"
SELECT MI.menuItemId, MI.stockId, MI.menuId, MI.menuTypeId, MI.itemName, MI.itemDetailName, MI.VATRate, MI.price, S.count, M.menuName, M.menuAvailableFrom, M.menuAvailableTill, MT.typeName
FROM menuItems AS MI
JOIN stock AS S ON S.stockId = MI.stockId
JOIN menus AS M ON MI.menuId = M.menuId
LEFT JOIN menuTypes AS MT ON MT.menuTypeId = MI.menuTypeId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<Menu> menus = MenuParser(reader);

            reader.Close();
            CloseConnection();

            return menus;
        }

        private List<Menu> MenuParser(SqlDataReader reader)
        {
            List<Menu> menus = new List<Menu>();

            while (reader.Read())
            {
                Menu menu = MenuReader.ReadMenu(reader);

                if (!menus.Select(menu => menu.MenuId).Contains(menu.MenuId))
                {
                    menus.Add(menu);
                }

                MenuItem menuItem = MenuReader.ReadMenuItem(reader);
                if (reader["menuTypeId"] != DBNull.Value)
                {
                    menuItem.SetMenuType((EMenuType)(int)reader["menuTypeId"]);
                }

                for (int i = 0; i < menus.Count; i++)
                {
                    if ((int)reader["menuId"] != menus[i].MenuId) continue;
                    menus[i].AddMenuItem(menuItem);
                }
            }

            return menus;
        }

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
INSERT INTO menuItems(stockId, menuId, itemName, itemDetailName, VATRate, price)
VALUES(@stockId, @menuId, @itemName, @itemDetailName, @VATRate, @price);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stockId", menuItem.Stock.StockId);
            command.Parameters.AddWithValue("@menuId", (int)menuItem.Menu);
            command.Parameters.AddWithValue("@itemName", menuItem.Name);
            command.Parameters.AddWithValue("@itemDetailName", menuItem.DetailName);
            command.Parameters.AddWithValue("@VATRate", menuItem.VATRate);
            command.Parameters.AddWithValue("@price", menuItem.Price);

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


        public void DeleteMenuItemStockById(int id)
        {
            string query = @"
DELETE stock
WHERE stockId = @stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@stockId", id);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
