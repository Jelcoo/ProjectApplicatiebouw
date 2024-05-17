using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao _orderDao;

        public OrderService()
        {
            _orderDao = new OrderDao();
        }

        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            return _orderDao.GetAllOrderedItemsByInvoiceId(invoiceId);
        }
    }
}
