using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class MenuService
    {
        private MenuDao _menuDao;

        public MenuService()
        {
            _menuDao = new MenuDao();
        }

        public List<Menu> GetMenus()
        {
            // Asks menuDao for all Menus
            return _menuDao.GetMenus();
        }

        public List<Double> GetVATRates()
        {
            // Asks menuDao for all VatRates
            return _menuDao.GetVATRates();
        }

        public int CreateItemStock()
        {
            // Asks menuDao to createItemStock
            // Also returns the newly created stockId
            return _menuDao.CreateItemStock();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            // Asks MenuDao to create menuitem
            _menuDao.AddMenuItem(menuItem);
            // If the MenuType isnt null, it sets the menuType
            if (menuItem.MenuType != null) { AddMenuItemMenuType(menuItem); }
        }

        private void AddMenuItemMenuType(MenuItem menuItem)
        {
            // Asks menuDao to add MenuType to the MenuItem
            _menuDao.AddMenuItemMenuType(menuItem);
        }

        public void ChangeMenuItem(MenuItem changedMenuItem)
        {
            // Asks menuDao to change menuitem
            _menuDao.ChangeMenuItem(changedMenuItem);
            // If the MenuType isnt null, it sets the menuType
            if (changedMenuItem.MenuType != null) { AddMenuItemMenuType(changedMenuItem); }
        }

        public void DeleteMenuItemAndStockById(MenuItem item)
        {
            // Asks MenuDao to delete menuItem and its stock
            _menuDao.DeleteMenuItemById(item.MenuItemId);
            _menuDao.DeleteMenuItemStockById(item.Stock.StockId);
        }
    }
}
