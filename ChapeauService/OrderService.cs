using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class OrderService
    {
        public Order MakeNewOrder(Order order, Table table, Employee employee)
        {
            if (order.Invoice == null)
            {
                InvoiceService invoiceService = new InvoiceService();
                order.SetInvoice(invoiceService.MakeNewInvoice(table, employee));
            }

            OrderDao orderDao = new OrderDao();
            order = orderDao.CreateOrder(order);
            order.SetOrderLines(MakeNewOrderLines(order));

            return order;
        }

        public List<OrderLine> MakeNewOrderLines(Order order)
        {
            OrderDao orderDao = new OrderDao();
            List<OrderLine> orderLines = new List<OrderLine>();
            foreach (OrderLine orderLine in order.OrderLines)
            {
                orderLine.SetOrder(order);
                OrderLine line = orderDao.CreateOrderLine(orderLine);

                if (line.OrderNote != null) line.OrderNote = orderDao.CreateOrderNote(line).OrderNote;
                
                orderDao.DecreaseStock(line);
                orderLines.Add(line);
            }

            return orderLines;
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.IncreaseStock(orderLine);
            orderDao.DeleteOrderLine(orderLine);
        }
    }
}
