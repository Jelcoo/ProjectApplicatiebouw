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
    }
}