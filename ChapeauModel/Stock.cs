namespace ChapeauModel
{
    public class Stock
    {
        private int _stockId;
        public int StockId { get { return _stockId; } }

        private int _stock;
        public int StockCount { get { return _stock; } }

        public MenuItem MenuItem;

        public Stock(int stockId, int stock, MenuItem menuItem)
        {
            _stockId = stockId;
            _stock = stock;
            MenuItem = menuItem;
        }
    }
}
