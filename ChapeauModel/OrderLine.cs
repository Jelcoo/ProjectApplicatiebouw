using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class OrderLine
    {
        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        public MenuItem MenuItem { get; private set; }

        public EOrderLineStatus OrderLineStatus;

        private int _quantity;
        public int Quantity { get { return _quantity; } }

        public OrderNote? OrderNote;

        public OrderLine(MenuItem menuItem, EOrderLineStatus orderLineStatus, int quantity)
        {
            MenuItem = menuItem;
            OrderLineStatus = orderLineStatus;
            _quantity = quantity;
        }
        public OrderLine(int orderLineId, MenuItem menuItem, EOrderLineStatus orderLineStatus, int quantity)
            : this(menuItem, orderLineStatus, quantity)
        {
            _orderLineId = orderLineId;
        }

        public OrderLine SetId(int orderLineId)
        {
            _orderLineId = orderLineId;
            return this;
        }
        public OrderLine SetMenuItem(MenuItem menuItem)
        {
            MenuItem = menuItem;
            return this;
        }
        public OrderLine SetOrderNote(OrderNote? orderNote)
        {
            OrderNote = orderNote;
            return this;
        }
        public override string ToString()
        {
            if (OrderNote != null)
            {
                return $"  {Quantity}x {MenuItem.Name} {OrderNote.Note}";
            }
            else
            {
                return $"  {Quantity}x {MenuItem.Name}";
            }
        }
    }
}
