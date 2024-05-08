namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId; } }

        public Invoice Invoice;

        public OrderStatus OrderStatus;

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt; } }

        public List<OrderLine> OrderLines;

        public Order(int orderId, Invoice invoice, OrderStatus orderStatus, DateTime orderedAt, List<OrderLine> orderLines)
        {
            _orderId = orderId;
            Invoice = invoice;
            OrderStatus = orderStatus;
            _orderedAt = orderedAt;
            OrderLines = orderLines;
        }
    }
}
