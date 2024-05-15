using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class OrderStatus
    {
        const string DEFAULT_STATUS = "Pending";

        private int _orderStatusId;
        public int OrderStatusId { get { return _orderStatusId; } }

        private EOrderStatus _status;
        public EOrderStatus Status { get { return _status; } }

        public OrderStatus(EOrderStatus status)
        {
            _status = status;
        }
        public OrderStatus(int orderStatusId, EOrderStatus status)
            : this(status)
        {
            _orderStatusId = orderStatusId;
        }
    }
}
