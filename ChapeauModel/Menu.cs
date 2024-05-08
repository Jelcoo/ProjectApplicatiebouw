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
    }
}
