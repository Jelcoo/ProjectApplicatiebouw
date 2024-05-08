namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId }; }

        private int _invoiceId;
        public Invoice InvoiceId;

        private int _orderStatusId;
        public OrderStatus OrderStatus;

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt }; }
    }
}
