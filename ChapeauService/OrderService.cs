using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao _orderDao;

        public OrderService()
        {
            _orderDao = new OrderDao();
        }

        public Order MakeNewOrder(Order order, Table table, Employee employee)
        {
            if (order.Invoice == null)
            {
                InvoiceService invoiceService = new InvoiceService();
                order.SetInvoice(invoiceService.MakeNewInvoice(table, employee));
            }

            order = _orderDao.CreateOrder(order);
            order.SetOrderLines(MakeNewOrderLines(order));

            return order;
        }

        public List<OrderLine> MakeNewOrderLines(Order order)
        {
            List<OrderLine> orderLines = new List<OrderLine>();
            foreach (OrderLine orderLine in order.OrderLines)
            {
                OrderLine line = _orderDao.CreateOrderLine(order.OrderId, orderLine);

                if (line.OrderNote != null) line.OrderNote = _orderDao.CreateOrderNote(line).OrderNote;
                
                _orderDao.DecreaseStock(line);
                orderLines.Add(line);
            }

            return orderLines;
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            _orderDao.IncreaseStock(orderLine);
            _orderDao.DeleteOrderLine(orderLine);
        }

        public void UpdateOrderNote(OrderNote orderNote)
        {
            _orderDao.UpdateOrderNote(orderNote);
        }

        public void DeleteOrderNote(OrderNote orderNote)
        {
            _orderDao.DeleteOrderNote(orderNote);
        }

        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            return _orderDao.GetAllOrderedItemsByInvoiceId(invoiceId);
        }
    }
}
