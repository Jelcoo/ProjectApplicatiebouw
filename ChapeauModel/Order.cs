namespace ChapeauModel
{
    public class Order
    {
        private int _orderId;
        public int OrderId { get { return _orderId; } }

        public Invoice? Invoice { get; private set; }

        private DateTime _orderedAt;
        public DateTime OrderedAt { get { return _orderedAt; } }

        public List<OrderLine> OrderLines { get; private set; }

        public Order(Invoice invoice)
        {
            Invoice = invoice;
            OrderLines = new List<OrderLine>();
            _orderedAt = DateTime.Now;
        }

        public Order(int orderId, DateTime orderedAt)
        {
            _orderId = orderId;
            OrderLines = new List<OrderLine>();
            _orderedAt = orderedAt;
        }

        public Order(int orderId, Invoice invoice, DateTime orderedAt)
            : this(invoice)
        {
            _orderId = orderId;
            _orderedAt = orderedAt;
        }
        

        public Order SetId(int orderId)
        {
            _orderId = orderId;
            return this;
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
