namespace ChapeauModel
{
    public class Menu
    {
        private int _menuId;
        public int MenuId { get { return _menuId; } }

        private string _name;
        public string Name { get { return _name; } }

        private DateTime _serveStart;
        public DateTime ServeStart { get { return _serveStart; } }

        private DateTime _serveEnd;
        public DateTime ServeEnd { get { return _serveEnd; } }

        public List<MenuItem> MenuItems;

        public Menu(int menuId, string name, DateTime serveStart, DateTime serveEnd, List<MenuItem> menuItems)
        {
            _menuId = menuId;
            _name = name;
            _serveStart = serveStart;
            _serveEnd = serveEnd;
            MenuItems = menuItems;
        }
    }
}
