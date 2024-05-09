namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        private int _orderId;
        public int OrderId { get { return _orderId; } }

        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }
        public MenuItem? MenuItem;

        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }
        public OrderStatus? OrderStatus;

        private int _quantity;
        public int Quantity { get { return _quantity; } }

        private int? _orderNoteId;
        public int? OrderNoteId { get { return _orderNoteId; } }
        public OrderNote? OrderNote;

        public OrderLine(int orderId, int menuItemId, int orderStatusId, int quantity, int orderNoteId)
        {
            _orderId = orderId;
            _menuItemId = menuItemId;
            _orderStatusId = orderStatusId;
            _quantity = quantity;
            _orderNoteId = orderNoteId;
        }
        public OrderLine(int orderLineId, int orderId, int menuItemId, int orderStatusId, int quantity, int orderNoteId)
            : this(orderId, menuItemId, orderStatusId, quantity, orderNoteId)
        {
            _orderLineId = orderLineId;
        }

        public OrderLine SetMenuItem(MenuItem? menuItem)
        {
            MenuItem = menuItem;
            return this;
        }
        public OrderLine SetOrderStatus(OrderStatus? orderStatus)
        {
            OrderStatus = orderStatus;
            return this;
        }
        public OrderLine SetOrderNote(OrderNote? orderNote)
        {
            OrderNote = orderNote;
            return this;
        }
    }
}
