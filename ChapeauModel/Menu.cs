namespace ChapeauModel
{
    public class Menu
    {
        private int _menuId;
        public int MenuId { get { return _menuId; } }

        public EMenu Name { get; private set; }

        private DateTime _menuAvailableFrom;
        public DateTime MenuAvailableFrom { get { return _menuAvailableFrom; } }

        private DateTime _menuAvailableTill;
        public DateTime MenuAvailableTill { get { return _menuAvailableTill; } }

        public List<MenuItem> MenuItems { get; private set; }

        public Menu(EMenu name, DateTime menuAvailableFrom, DateTime menuAvailableTill)
        {
            Name = name;
            _menuAvailableFrom = menuAvailableFrom;
            _menuAvailableTill = menuAvailableTill;
            MenuItems = new List<MenuItem>();
        }
        public Menu(int menuId, EMenu name, DateTime menuAvailableFrom, DateTime menuAvailableTill)
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
    }
}
