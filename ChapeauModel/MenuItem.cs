namespace ChapeauModel
{
    public class MenuItem
    {
        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId }; }

        private int _stockId;
        public Stock Stock;

        private int _menuId;
        public Menu Menu;

        private int _menuTypeId;
        public MenuType MenuType;

        private string _name;
        public string Name { get { return _name }; }

        private float _VATRate;
        public float VATRate { get { return _VATRate }; }

        private float _price;
        public float Price { get { return _price }; }
    }
}
