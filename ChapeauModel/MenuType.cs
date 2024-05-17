namespace ChapeauModel
{
    public class MenuType
    {
        private int _menuTypeId;
        public int MenuTypeId { get { return _menuTypeId; } }

        private string _name;
        public string Name { get { return _name; } }

        public MenuType(string name)
        {
            _name = name;
        }
        public MenuType(int menuTypeId, string name)
            : this(name)
        {
            _menuTypeId = menuTypeId;
        }

        public MenuType SetId(int typeId)
        {
            _menuTypeId = typeId;
            return this;
        }
    }
}
