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
                name: (string)reader["name"],
                serveStart: (DateTime)reader["serveStart"],
                serveEnd: (DateTime)reader["serveEnd"],
                menuItems: ReadMenuItems(reader)
            );

            return menu;
        }

        public static MenuItem ReadMenuItem(SqlDataReader reader)
        {
            MenuItem menuItem = new MenuItem(
                menuItemId: (int)reader["menuItemId"],
                stock: StockReader.ReadStock(reader),
                menu: ReadMenu(reader),
                menuType: ReadMenuType(reader),
                name: (string)reader["name"],
                VATRate: (float)reader["VATRate"],
                price: (float)reader["price"]
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
                name: (string)reader["name"]
            );

            return menuType;
        }
    }
}
