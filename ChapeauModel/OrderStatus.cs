namespace ChapeauModel
{
    public class OrderStatus
    {
        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        public Order Order;

        private string _status;
        public string Status { get { return _status; } }

        public OrderStatus(int orderStatusId, Order order, string status)
        {
            _orderStatusId = orderStatusId;
            Order = order;
            _status = status;
        }
    }
}
