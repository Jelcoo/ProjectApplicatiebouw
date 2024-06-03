using ChapeauModel;
using ChapeauModel.Enums;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class MenuReader
    {
        public static Menu ReadMenu(SqlDataReader reader)
        {
            Menu menu = new Menu(
                menuId: (int)reader["menuId"],
                name: (EMenu)(int)reader["menuId"],
                menuAvailableFrom: (DateTime)reader["menuAvailableFrom"],
                menuAvailableTill: (DateTime)reader["menuAvailableTill"]
            );

            return menu;
        }

        public static MenuItem ReadMenuItem(SqlDataReader reader)
        {
            MenuItem menuItem = new MenuItem(
                menuItemId: (int)reader["menuItemId"],
                stock: ReadStock(reader),
                name: (string)reader["itemName"],
                detailName: (string)reader["itemDetailName"],
                VATRate: (double)reader["VATRate"],
                price: (double)reader["price"]
            );
            if (reader["menuTypeId"] != DBNull.Value) {
                menuItem.SetMenuType((EMenuType)(int)reader["menuTypeId"]);
            }
            else { 
                menuItem.SetMenuType(EMenuType.None);
            }
            if (reader["menuId"] != DBNull.Value) {
                menuItem.SetMenu((EMenu)(int)reader["menuId"]);
            }

            return menuItem;
        }

        public static List<MenuItem> ReadMenuItems(SqlDataReader reader)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            while (reader.Read())
            {
                MenuItem menuItem = ReadMenuItem(reader);
                menuItems.Add(menuItem);
            }

            return menuItems;
        }

        public static Stock ReadStock(SqlDataReader reader)
        {
            Stock stock = new Stock(
                stockId: (int)reader["stockid"],
                count: (int)reader["count"]
            );

            return stock;
        }
    }
}
