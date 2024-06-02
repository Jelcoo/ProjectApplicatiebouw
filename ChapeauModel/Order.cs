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

        public Order()
        {
            OrderLines = new List<OrderLine>();
            _orderedAt = DateTime.Now;
        }
        public Order(Invoice invoice)
            : this()
        {
            Invoice = invoice;
        }
        public Order(int orderId, DateTime orderedAt)
            : this()
        {
            _orderId = orderId;
            _orderedAt = orderedAt;
        }
        public Order(int orderId, Invoice invoice, DateTime orderedAt)
            : this(invoice)
        {
            _orderId = orderId;
            _orderedAt = orderedAt;
        }

        public void SetId(int orderId)
        {
            _orderId = orderId;
        }
        public void SetInvoice(Invoice? invoice)
        {
            Invoice = invoice;
        }
        public void SetOrderLines(List<OrderLine> orderLines)
        {
            OrderLines = orderLines;
        }
        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
        }

        public int GetTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (OrderLine orderLine in OrderLines)
            {
                totalQuantity += orderLine.Quantity;
            }

            return totalQuantity;
        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (OrderLine orderLine in OrderLines)
            {
                totalPrice += orderLine.MenuItem.Price * orderLine.Quantity;
            }

            return totalPrice;
        }
    }
}
