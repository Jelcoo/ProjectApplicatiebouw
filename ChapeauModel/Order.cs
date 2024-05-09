namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId; } }

        public Invoice Invoice;

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt; } }

        public List<OrderLine> OrderLines;

        public Order(int orderId, Invoice invoice, DateTime orderedAt, List<OrderLine> orderLines)
        {
            _orderId = orderId;
            Invoice = invoice;
            _orderedAt = orderedAt;
            OrderLines = orderLines;
        }
    }
}
