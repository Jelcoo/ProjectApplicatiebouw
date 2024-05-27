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
    }
}
