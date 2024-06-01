namespace ChapeauModel
{
    public class Stock
    {
        private int _stockId;
        public int StockId { get { return _stockId; } }

        private int _count;
        public int Count { get { return _count; } }

        public Stock(int count)
        {
            _count = count;
        }
        public Stock(int stockId, int count)
            : this(count)
        {
            _stockId = stockId;
        }

        public void Increase(int quantity) {
            _count += quantity;
        }
        public void Decrease(int quantity) {
            _count -= quantity;
        }
    }
}
