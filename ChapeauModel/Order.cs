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

        public Order(int invoiceId, DateTime orderedAt)
        {
            _invoiceId = invoiceId;
            _orderedAt = orderedAt;
            OrderLines = new List<OrderLine>();
        }
        public Order(int orderId, int invoiceId, DateTime orderedAt)
            : this(invoiceId, orderedAt)
        {
            _orderId = orderId;
        }

        public Order SetInvoice(Invoice invoice)
        {
            _invoiceId = invoice.InvoiceId;
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
