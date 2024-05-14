using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class KitchenService
    {
        private KitchenDao _kitchenDao;

        public KitchenService()
        {
            _kitchenDao = new KitchenDao();
        }

        public List<Order> GetOrdersInOrder()
        {
            return _kitchenDao.GetOrdersInOrder();
        }
        public void UpdateOrderLinesStatus(Order order)
        {
            _kitchenDao.UpdateOrderLinesStatus(order);
        }
        public List<Order> GetPreviousCompletedOrders()
        {
            return _kitchenDao.GetPreviousCompletedOrders();
        }
    }
}
