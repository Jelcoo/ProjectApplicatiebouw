using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

namespace ChapeauService
{
    public class OrderService
    {
        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            OrderDao orderDao = new OrderDao();
            return orderDao.GetAllOrderedItemsByInvoiceId(invoiceId);
        }
    }
}
