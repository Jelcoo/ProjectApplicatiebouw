using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class MenuService
    {
        private MenuDao _menuDao;

        public MenuService()
        {
            _menuDao = new MenuDao();
        }

        public List<MenuItem> GetMenu()
        {
            return _menuDao.GetMenu();
        }

        public List<MenuType> GetMenuTypes()
        {
            return _menuDao.GetMenuTypes();
        }

        public List<Menu> GetMenus()
        {
            return _menuDao.GetMenus();
        }
        public List<Double> GetVATRates()
        {
            return _menuDao.GetVATRates();
        }

        public int AddItemStock(int stockAmount)
        {
            return _menuDao.AddItemStock(stockAmount);
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuDao.AddMenuItem(menuItem);
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _menuDao.GetMenuItemById(id);
        }
    }
}
