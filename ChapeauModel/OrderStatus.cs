namespace ChapeauModel
{
    public class OrderStatus
    {
        const string DEFAULT_STATUS = "Pending";

        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        private string _status;
        public string Status { get { return _status; } }

        public OrderStatus(string status)
        {
            _status = status;
        }
        public OrderStatus(int orderStatusId, string status)
            : this(status)
        {
            _orderStatusId = orderStatusId;
        }
    }
}
