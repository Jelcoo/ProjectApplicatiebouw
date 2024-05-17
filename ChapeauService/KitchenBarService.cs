using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

namespace ChapeauService
{
    public class KitchenBarService
    {
        private KitchenBarDao _kitchenBarDao;

        public KitchenBarService()
        {
            _kitchenBarDao = new KitchenBarDao();
        }

        public List<Order> GetOrdersInOrder(EOrderDestination orderType)
        {
            return _kitchenBarDao.GetOrdersInOrder(orderType);
        }
        public void UpdateOrderLinesStatus(Order order)
        {
            _kitchenBarDao.UpdateOrderLinesStatus(order);
        }
        public List<Order> GetPreviousCompletedOrders(EOrderDestination orderType)
        {
            return _kitchenBarDao.GetPreviousCompletedOrders(orderType);
        }
    }
}
