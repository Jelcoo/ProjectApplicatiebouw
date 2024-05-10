namespace ChapeauModel
{
    public class MenuItem
    {
        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }

        private int _stockId;
        public int StockId { get { return _stockId; } }
        public Stock? Stock;

        private int _menuId;
        public int MenuId { get { return _menuId; } }
        public Menu? Menu;

        private int _menuTypeId;
        public int MenuTypeId { get { return _menuTypeId; } }
        public MenuType? MenuType;

        private string _name;
        public string Name { get { return _name; } }

        private float _VATRate;
        public float VATRate { get { return _VATRate; } }

        private float _price;
        public float Price { get { return _price; } }

        public MenuItem(int stockId, int menuId, int menuTypeId, string name, float VATRate, float price)
        {
            _stockId = stockId;
            _menuId = menuId;
            _menuTypeId = menuTypeId;
            _name = name;
            _VATRate = VATRate;
            _price = price;
        }
        public MenuItem(int menuItemId, int stockId, int menuId, int menuTypeId, string name, float VATRate, float price)
            : this(stockId, menuId, menuTypeId, name, VATRate, price)
        {
            _menuItemId = menuItemId;
        }

        public MenuItem SetStock(Stock stock)
        {
            _stockId = stock.StockId;
            Stock = stock;
            return this;
        }
        public MenuItem SetMenu(Menu menu)
        {
            _menuId = menu.MenuId;
            Menu = menu;
            return this;
        }
        public MenuItem SetMenuType(MenuType menuType)
        {
            _menuTypeId = menuType.MenuTypeId;
            MenuType = menuType;
            return this;
        }
    }
}
