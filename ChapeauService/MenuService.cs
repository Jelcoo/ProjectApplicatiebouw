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
            return _menuDao.GetMenus();
        }

        public List<Double> GetVATRates()
        {
            return _menuDao.GetVATRates();
        }

        public int CreateItemStock()
        {
            return _menuDao.CreateItemStock();
        }

        private void AddMenuItemMenuType(MenuItem menuItem)
        {
            _menuDao.AddMenuItemMenuType(menuItem);
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuDao.AddMenuItem(menuItem);
            if (menuItem.MenuType != null) { AddMenuItemMenuType(menuItem); }
        }

        public void ChangeMenuItem(MenuItem changedMenuItem)
        {
            _menuDao.ChangeMenuItem(changedMenuItem);
            if (changedMenuItem.MenuType != null) { AddMenuItemMenuType(changedMenuItem); }
        }

        public void DeleteMenuItemAndStockById(MenuItem item)
        {
            _menuDao.DeleteMenuItemById(item.MenuItemId);
            _menuDao.DeleteMenuItemStockById(item.Stock.StockId);
        }
    }
}
