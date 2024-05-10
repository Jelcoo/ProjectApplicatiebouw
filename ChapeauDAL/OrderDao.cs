using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public Order CreateOrder(Order order, Table table, Employee employee)
        {
            // create invoice if not open
            // create orderlines
            // create orderline notes
            // set order status
            // decrease stock of item
            if (order.Invoice == null)
            {
                InvoiceDao invoiceDao = new InvoiceDao();
                order.Invoice = invoiceDao.MakeNewInvoice(table, employee);
            }

            return 0;
        }

        public OrderLine CreateOrderLine(OrderLine orderLine)
        {
            return 0;
        }
    }
}
