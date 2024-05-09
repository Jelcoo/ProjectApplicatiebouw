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

        public Menu(string name, DateTime serveStart, DateTime serveEnd)
        {
            _name = name;
            _serveStart = serveStart;
            _serveEnd = serveEnd;
        }
        public Menu(int menuId, string name, DateTime serveStart, DateTime serveEnd)
            : this(name, serveStart, serveEnd)
        {
            _menuId = menuId;
        }
    }
}
