namespace ChapeauModel
{
    public class OrderStatus
    {
        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        private string _status;
        public string Status { get { return _status; } }

        public OrderStatus(int orderStatusId, string status)
        {
            _orderStatusId = orderStatusId;
            _status = status;
        }
    }
}
