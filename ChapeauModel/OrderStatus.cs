namespace ChapeauModel
{
    public class OrderStatus
    {
        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }
        public OrderLine? OrderLine;

        private string _status;
        public string Status { get { return _status; } }

        public OrderStatus(int orderStatusId, int orderLineId, string status)
        {
            _orderStatusId = orderStatusId;
            _orderLineId = orderLineId;
            _status = status;
        }

        public OrderStatus SetOrderLine(OrderLine? orderLine)
        {
            OrderLine = orderLine;
            return this;
        }
    }
}
