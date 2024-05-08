namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId }; }

        private int _orderId;
        public Order Order;

        private int _menuItemId;
        public MenuItem MenuItem;

        private int _quantity;
        public int Quantity { get { return _quantity }; }
    }
}
