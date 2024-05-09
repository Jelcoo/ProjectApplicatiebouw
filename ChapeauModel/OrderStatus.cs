namespace ChapeauModel
{
    public class OrderStatus
    {
        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        public OrderLine OrderLine;

        private string _status;
        public string Status { get { return _status; } }

        public OrderStatus(int orderStatusId, OrderLine orderLine, string status)
        {
            _orderStatusId = orderStatusId;
            OrderLine = orderLine;
            _status = status;
        }
    }
}
