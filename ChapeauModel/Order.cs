namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId; } }

        public Invoice InvoiceId;

        public OrderStatus OrderStatus;

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt; } }

        public List<OrderLine> OrderLines;

        public Order(int orderId, Invoice invoiceId, OrderStatus orderStatus, DateTime orderedAt, List<OrderLine> orderLines)
        {
            _orderId = orderId;
            InvoiceId = invoiceId;
            OrderStatus = orderStatus;
            _orderedAt = orderedAt;
            OrderLines = orderLines;
        }
    }
}
