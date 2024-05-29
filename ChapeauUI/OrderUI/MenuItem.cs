﻿using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauUI.OrderUI.Observers;

namespace ChapeauUI.OrderUI
{
    public partial class MenuItem : UserControl, IOrderObservable
    {
        private ChapeauModel.MenuItem _menuItem;
        private Order _order;

        private IOrderObserver _observer;

        public MenuItem(ChapeauModel.MenuItem menuItem, Order order)
        {
            InitializeComponent();

            this.Tag = menuItem;
            this.itemName.Text = menuItem.Name;
            this.stock.Text = $"Stock: {menuItem.Stock.Count}";
            this.price.Text = $"Price: €{menuItem.Price}";

            _menuItem = menuItem;
            _order = order;
        }

        public void SetObserver(IOrderObserver observer)
        {
            _observer = observer;
        }
        public void NotifyObserver()
        {
            _observer.Update();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool alreadyInOrder = false;
            foreach (OrderLine orderLine in _order.OrderLines)
            {
                if (orderLine.MenuItem.MenuItemId == _menuItem.MenuItemId)
                {
                    alreadyInOrder = true;
                    orderLine.IncreaseQuantity(1);
                }
            }
            if (!alreadyInOrder)
            {
                AddOrderline();
            }
            NotifyObserver();
        }

        private void AddOrderline()
        {
            OrderLine orderLine = new OrderLine(_menuItem, EOrderLineStatus.Pending, 1);
            _order.AddOrderLine(orderLine);
        }
    }
}
