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

        private int? _menuTypeId;
        public int? MenuTypeId { get { return _menuTypeId; } }
        public MenuType? MenuType;

        private string _name;
        public string Name { get { return _name; } }

        private string _detailName;
        public string DetailName { get { return _detailName; } }

        private double _VATRate;
        public double VATRate { get { return _VATRate; } }

        private double _price;
        public double Price { get { return _price; } }

        public MenuItem(int stockId, int menuId, int? menuTypeId, string name, string detailName, double VATRate, double price)
        {
            _stockId = stockId;
            _menuId = menuId;
            _menuTypeId = menuTypeId;
            _name = name;
            _detailName = detailName;
            _VATRate = VATRate;
            _price = price;
        }
        public MenuItem(int menuItemId, int stockId, int menuId, int? menuTypeId, string name, string detailName, double VATRate, double price)
            : this(stockId, menuId, menuTypeId, name, detailName, VATRate, price)
        {
            _menuItemId = menuItemId;
        }

        public MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public MenuItem SetStock(Stock stock)
        {
            Stock = stock;
            return this;
        }
        public MenuItem SetMenu(Menu menu)
        {
            Menu = menu;
            return this;
        }
        public MenuItem SetMenuType(MenuType menuType)
        {
            MenuType = menuType;
            return this;
        }
    }
}
