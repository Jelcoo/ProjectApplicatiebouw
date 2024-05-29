using ChapeauModel;
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
            AddOrderItem();
        }

        private void specifyButton_Click(object sender, EventArgs e)
        {
            OrderLineNote note = new OrderLineNote(_menuItem, _order);
            note.ShowDialog();

            if (!string.IsNullOrEmpty(note.Note))
            {
                AddOrderItemWithNote(note.Note);
            } else
            {
                AddOrderItem();
            }
        }

        private void AddOrderItem()
        {
            bool alreadyInOrder = false;
            foreach (OrderLine orderLine in _order.OrderLines)
            {
                if (orderLine.MenuItem.MenuItemId == _menuItem.MenuItemId && orderLine.OrderNote == null)
                {
                    alreadyInOrder = true;
                    orderLine.IncreaseQuantity(1);
                }
            }
            if (!alreadyInOrder)
            {
                OrderLine orderLine = new OrderLine(_menuItem, EOrderLineStatus.Pending, 1);
                CreateOrderline(orderLine);
            }

            NotifyObserver();
        }

        private void AddOrderItemWithNote(string note)
        {
            bool alreadyInOrder = false;
            foreach (OrderLine orderLine in _order.OrderLines)
            {
                if (orderLine.MenuItem.MenuItemId == _menuItem.MenuItemId && orderLine.OrderNote?.Note == note)
                {
                    alreadyInOrder = true;
                    orderLine.IncreaseQuantity(1);
                }
            }
            if (!alreadyInOrder)
            {
                OrderLine orderLine = new OrderLine(_menuItem, EOrderLineStatus.Pending, 1);
                orderLine.SetOrderNote(new OrderNote(note));
                CreateOrderline(orderLine);
            }

            NotifyObserver();
        }

        private void CreateOrderline(OrderLine orderLine)
        {
            _order.AddOrderLine(orderLine);
        }
    }
}
