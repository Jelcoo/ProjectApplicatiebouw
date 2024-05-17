﻿using ChapeauModel;
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
                orderLine.SetOrder(order);
                OrderLine line = _orderDao.CreateOrderLine(orderLine);

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

        public void UpdateOrderNote(OrderLine orderLine)
        {
            _orderDao.UpdateOrderNote(orderLine);
        }

        public void DeleteOrderNote(OrderLine orderLine)
        {
            _orderDao.DeleteOrderNote(orderLine);
        }
    }
}
