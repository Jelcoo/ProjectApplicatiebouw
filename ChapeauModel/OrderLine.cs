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

        public OrderNote? OrderNote;
        public OrderStatus OrderStatus;

        public OrderLine(int orderLineId, Order order, MenuItem menuItem, int quantity, OrderNote? orderNote, OrderStatus orderStatus)
        {
            _orderLineId = orderLineId;
            Order = order;
            MenuItem = menuItem;
            _quantity = quantity;
            OrderNote = orderNote;
            OrderStatus = orderStatus;
        }
    }
}
