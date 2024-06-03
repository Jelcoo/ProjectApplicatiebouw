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

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuDao.AddMenuItem(menuItem);
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _menuDao.GetMenuItemById(id);
        }

        public void ChangeMenuItem(MenuItem changedMenuItem)
        {
            _menuDao.ChangeMenuItem(changedMenuItem);
            if (changedMenuItem.MenuType != null) { _menuDao.AddMenuItemMenuType(changedMenuItem); }
        }

        public void DeleteMenuItemAndStockById(int menuItemId)
        {
            int stockId = _menuDao.GetStockId(menuItemId);
            _menuDao.DeleteMenuItemById(menuItemId);
            _menuDao.DeleteMenuItemStockById(stockId);
        }
    }
}
