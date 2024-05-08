namespace ChapeauModel
{
    public class MenuItem
    {
        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }

        public Stock Stock;

        public Menu Menu;

        public MenuType MenuType;

        private string _name;
        public string Name { get { return _name; } }

        private float _VATRate;
        public float VATRate { get { return _VATRate; } }

        private float _price;
        public float Price { get { return _price; } }

        public MenuItem(int menuItemId, Stock stock, Menu menu, MenuType menuType, string name, float vATRate, float price)
        {
            _menuItemId = menuItemId;
            Stock = stock;
            Menu = menu;
            MenuType = menuType;
            _name = name;
            _VATRate = vATRate;
            _price = price;
        }
    }
}
