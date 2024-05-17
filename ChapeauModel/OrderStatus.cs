using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class OrderStatus
    {
        public const EOrderStatus DEFAULT_STATUS = EOrderStatus.Pending;

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
