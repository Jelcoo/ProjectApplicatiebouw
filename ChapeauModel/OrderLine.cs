namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        public Order Order;

        public MenuItem MenuItem;

        private int _quantity;
        public int Quantity { get { return _quantity; } }
    }
}
