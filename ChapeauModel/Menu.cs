using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class Menu
    {
        private int _menuId;
        public int MenuId { get { return _menuId; } }

        private string _name;
        public string Name { get { return _name; } }

        private DateTime _menuAvailableFrom;
        public DateTime MenuAvailableFrom { get { return _menuAvailableFrom; } }

        private DateTime _menuAvailableTill;
        public DateTime MenuAvailableTill { get { return _menuAvailableTill; } }

        public EMenu MenuType { get; private set; }

        public List<MenuItem> MenuItems { get; private set; }

        public Menu(string name, DateTime menuAvailableFrom, DateTime menuAvailableTill)
        {
            _name = name;
            _menuAvailableFrom = menuAvailableFrom;
            _menuAvailableTill = menuAvailableTill;
            MenuItems = new List<MenuItem>();
        }
        public Menu(int menuId, string name, DateTime menuAvailableFrom, DateTime menuAvailableTill)
            : this(name, menuAvailableFrom, menuAvailableTill)
        {
            _menuId = menuId;
        }

        public Menu SetMenuItems(List<MenuItem> menuItems)
        {
            MenuItems = menuItems;
            return this;
        }
        public Menu AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
            return this;
        }

        public Menu SetMenuType(EMenu menuType)
        {
            MenuType = menuType;
            return this;
        }
    }
}
