namespace ChapeauModel
{
    public class MenuType
    {
        private int _menuTypeId;
        public int MenuTypeId { get { return _menuTypeId; } }

        private string _name;
        public string Name { get { return _name; } }

        public MenuType(int menuTypeId, string name)
        {
            _menuTypeId = menuTypeId;
            _name = name;
        }
    }
}
