using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao _orderDao;
        private Restaurant _restaurant;

        public OrderService()
        {
            _orderDao = new OrderDao();
            _restaurant = Restaurant.GetInstance();
        }

        public Order GetOrderById(int orderId)
        {
            return _orderDao.GetOrderById(orderId);
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

        public void UpdateOrder(Order oldOrder, Order newOrder)
        {
            foreach (OrderLine orderLine in newOrder.OrderLines)
            {
                OrderLine oldOrderLine = oldOrder.OrderLines.Find(o => o.OrderLineId == orderLine.OrderLineId);

                if (oldOrderLine.OrderNote != null && orderLine.OrderNote != null && oldOrderLine.OrderNote.Note != orderLine.OrderNote.Note)
                {
                    UpdateOrderNote(orderLine.OrderNote);
                }
                else if (oldOrderLine.OrderNote == null && orderLine.OrderNote != null)
                {
                    CreateOrderNote(orderLine);
                }
                else if (oldOrderLine.OrderNote != null && orderLine.OrderNote == null)
                {
                    DeleteOrderNote(oldOrderLine.OrderNote);
                }

                if (oldOrderLine.Quantity > orderLine.Quantity)
                {
                    _orderDao.IncreaseStock(orderLine, oldOrderLine.Quantity - orderLine.Quantity);
                    _restaurant.IncreaseStock(orderLine.MenuItem, orderLine.Quantity);
                }
                else if (oldOrderLine.Quantity < orderLine.Quantity)
                {
                    _orderDao.DecreaseStock(orderLine, orderLine.Quantity - oldOrderLine.Quantity);
                    _restaurant.DecreaseStock(orderLine.MenuItem, orderLine.Quantity);
                }

                if (orderLine.Quantity == 0) RemoveOrderLine(orderLine);

                UpdateOrderLine(orderLine);
            }
        }

        public List<OrderLine> MakeNewOrderLines(Order order)
        {
            List<OrderLine> orderLines = new List<OrderLine>();
            foreach (OrderLine orderLine in order.OrderLines)
            {
                OrderLine line = _orderDao.CreateOrderLine(order.OrderId, orderLine);

                if (line.OrderNote != null) line.OrderNote = _orderDao.CreateOrderNote(line).OrderNote;

                _orderDao.DecreaseStock(line);
                _restaurant.DecreaseStock(line.MenuItem, line.Quantity);

                orderLines.Add(line);
            }

            return orderLines;
        }

        public Invoice? GetOpenInvoice(Table table)
        {
            Invoice? invoice = _orderDao.GetOpenInvoice(table);
            return invoice;
        }

        public List<Order> GetOrdersByTable(Table table)
        {
            List<Order> orders = _orderDao.GetOrdersByTable(table);
            return orders;
        }

        public void UpdateOrderLine(OrderLine orderLine)
        {
            _orderDao.UpdateOrderLine(orderLine);
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            if (orderLine.OrderNote != null) _orderDao.DeleteOrderNote(orderLine.OrderNote);
            _orderDao.DeleteOrderLine(orderLine);
        }

        public void CreateOrderNote(OrderLine orderLine)
        {
            _orderDao.CreateOrderNote(orderLine);
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
