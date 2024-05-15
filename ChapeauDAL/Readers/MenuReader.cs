using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class MenuReader
    {
        public static Menu ReadMenu(SqlDataReader reader)
        {
            Menu menu = new Menu(
                menuId: (int)reader["menuId"],
                name: (string)reader["menuName"],
                serveStart: (DateTime)reader["serveStart"],
                serveEnd: (DateTime)reader["serveEnd"]
            );

            return menu;
        }

        public static MenuItem ReadMenuItem(SqlDataReader reader)
        {
            MenuItem menuItem = new MenuItem(
                menuItemId: (int)reader["menuItemId"],
                stockId: (int)reader["stockId"],
                menuId: (int)reader["menuId"],
                menuTypeId: reader["orderNoteId"] == DBNull.Value ? null : (int)reader["menuTypeId"],
                name: (string)reader["itemName"],
                detailName: (string)reader["itemDetailName"],
                VATRate: (double)reader["VATRate"],
                price: (double)reader["price"]
            );

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

        public static MenuType ReadMenuType(SqlDataReader reader)
        {
            MenuType menuType = new MenuType(
                menuTypeId: (int)reader["menuTypeId"],
                name: (string)reader["typeName"]
            );

            return menuType;
        }

        public static Stock ReadStock(SqlDataReader reader)
        {
            Stock stock = new Stock(
                stockId: (int)reader["stockid"],
                stock: (int)reader["stock"],
                menuItemId: (int)reader["menuItemId"]
            );

            return stock;
        }
    }
}
