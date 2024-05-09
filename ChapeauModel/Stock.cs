namespace ChapeauModel
{
    public class Stock
    {
        private int _stockId;
        public int StockId { get { return _stockId; } }

        private int _stock;
        public int StockCount { get { return _stock; } }

        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }
        public MenuItem? MenuItem;

        public Stock(int stockId, int stock, int menuItemId)
        {
            _stockId = stockId;
            _stock = stock;
            _menuItemId = menuItemId;
        }

        public Stock SetMenuItem(MenuItem menuItem)
        {
            MenuItem = menuItem;
            return this;
        }
    }
}
