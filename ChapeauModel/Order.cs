namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId; } }

        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }
        public Invoice? Invoice;

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt; } }

        public List<OrderLine> OrderLines;

        public Order(int orderId, int invoiceId, DateTime orderedAt)
        {
            _orderId = orderId;
            _invoiceId = invoiceId;
            _orderedAt = orderedAt;
            OrderLines = new List<OrderLine>();
        }

        public Order SetInvoice(Invoice invoice)
        {
            Invoice = invoice;
            return this;
        }
        public Order SetOrderLines(List<OrderLine> orderLines)
        {
            OrderLines = orderLines;
            return this;
        }
        public Order AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
            return this;
        }
    }
}
