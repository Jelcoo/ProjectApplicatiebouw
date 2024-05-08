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
    }
}
