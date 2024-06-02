using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class MenuItem
    {
        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }

        public Stock Stock { get; private set; }

        public EMenuType? MenuType;

        private string _name;
        public string Name { get { return _name; } }

        private string _detailName;
        public string DetailName { get { return _detailName; } }

        private double _VATRate;
        public double VATRate { get { return _VATRate; } }

        private double _price;
        public double Price { get { return _price; } }

        public MenuItem(Stock stock, string name, string detailName, double VATRate, double price)
        {
            Stock = stock;
            _name = name;
            _detailName = detailName;
            _VATRate = VATRate;
            _price = price;
        }
        public MenuItem(int menuItemId, Stock stock, string name, string detailName, double VATRate, double price)
            : this(stock, name, detailName, VATRate, price)
        {
            _menuItemId = menuItemId;
        }

        public void SetStock(Stock stock)
        {
            Stock = stock;
        }
        public void SetMenuType(EMenuType menuType)
        {
            MenuType = menuType;
        }
    }
}
