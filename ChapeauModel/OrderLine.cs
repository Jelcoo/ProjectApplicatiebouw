namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        private int _orderId;
        public int OrderId { get { return _orderId; } }
        public Order? Order;

        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }
        public MenuItem? MenuItem;

        private int _quantity;
        public int Quantity { get { return _quantity; } }

        private int? _orderNoteId;
        public int? OrderNoteId { get { return _orderNoteId; } }
        public OrderNote? OrderNote;

        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }
        public OrderStatus? OrderStatus;

        public OrderLine(int orderLineId, int orderId, int menuItemId, int quantity, int orderNoteId, int orderStatusId)
        {
            _orderLineId = orderLineId;
            _orderId = orderId;
            _menuItemId = menuItemId;
            _quantity = quantity;
            _orderNoteId = orderNoteId;
            _orderStatusId = orderStatusId;
        }

        public OrderLine SetOrder(Order? order)
        {
            Order = order;
            return this;
        }
        public OrderLine SetMenuItem(MenuItem? menuItem)
        {
            MenuItem = menuItem;
            return this;
        }
        public OrderLine SetOrderNote(OrderNote? orderNote)
        {
            OrderNote = orderNote;
            return this;
        }
        public OrderLine SetOrderStatus(OrderStatus? orderStatus)
        {
            OrderStatus = orderStatus;
            return this;
        }
    }
}
