using ChapeauModel.Enums;

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

        public EOrderStatus orderStatus;

        private int _quantity;
        public int Quantity { get { return _quantity; } }

        private int? _orderNoteId;
        public int? OrderNoteId { get { return _orderNoteId; } }
        public OrderNote? OrderNote;

        public OrderLine(int orderId, int menuItemId, EOrderStatus orderStatusName, int quantity, int? orderNoteId)
        {
            _orderId = orderId;
            _menuItemId = menuItemId;
            orderStatus = orderStatusName;
            _quantity = quantity;
            _orderNoteId = orderNoteId;
        }
        public OrderLine(int orderLineId, int orderId, int menuItemId, EOrderStatus orderStatusName, int quantity, int? orderNoteId)
            : this(orderId, menuItemId, orderStatusName, quantity, orderNoteId)
        {
            _orderLineId = orderLineId;
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
    }
}