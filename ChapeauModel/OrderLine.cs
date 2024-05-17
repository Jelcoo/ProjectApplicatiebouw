using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        private int _orderId;
        public int OrderId { get { return _orderId; } }
        public Order? Order { get; private set; }

        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }
        public MenuItem? MenuItem { get; private set; }

        public EOrderStatus OrderStatus;

        private int _quantity;
        public int Quantity { get { return _quantity; } }

        private int? _orderNoteId;
        public int? OrderNoteId { get { return _orderNoteId; } }
        public OrderNote? OrderNote;

        public OrderLine(int orderId, int menuItemId, EOrderStatus orderStatus, int quantity, int? orderNoteId)
        {
            _orderId = orderId;
            _menuItemId = menuItemId;
            OrderStatus = orderStatus;
            _quantity = quantity;
            _orderNoteId = orderNoteId;
        }
        public OrderLine(int orderLineId, int orderId, int menuItemId, EOrderStatus orderStatus, int quantity, int? orderNoteId)
            : this(orderId, menuItemId, orderStatus, quantity, orderNoteId)
        {
            _orderLineId = orderLineId;
        }

        public OrderLine SetId(int orderLineId)
        {
            _orderLineId = orderLineId;
            return this;
        }
        public OrderLine SetOrder(Order order)
        {
            _orderId = order.OrderId;
            Order = order;
            return this;
        }
        public OrderLine SetMenuItem(MenuItem menuItem)
        {
            _menuItemId = menuItem.MenuItemId;
            MenuItem = menuItem;
            return this;
        }
        public OrderLine SetOrderNote(OrderNote? orderNote)
        {
            _orderNoteId = orderNote.OrderNoteId;
            OrderNote = orderNote;
            return this;
        }
    }
}