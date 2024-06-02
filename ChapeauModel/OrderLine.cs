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

        public void SetId(int orderLineId)
        {
            _orderLineId = orderLineId;
        }
        public void SetMenuItem(MenuItem menuItem)
        {
            MenuItem = menuItem;
        }
        public void SetOrderNote(OrderNote? orderNote)
        {
            OrderNote = orderNote;
        }
        public void IncreaseQuantity(int quantity)
        {
            _quantity += quantity;
        }
        public void DecreaseQuantity(int quantity)
        {
            _quantity -= quantity;
        }

        public override string ToString()
        {
            if (OrderNote != null)
            {
                return $"  {Quantity}x {MenuItem.Name} '!!{OrderNote.Note}!!'";
            }
            else
            {
                return $"  {Quantity}x {MenuItem.Name}";
            }
        }
    }
}
