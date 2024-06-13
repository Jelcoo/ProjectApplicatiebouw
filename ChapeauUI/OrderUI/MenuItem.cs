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

            _menuItem = menuItem;
            _order = order;

            SetComponentStyle();
        }

        public void SetObserver(IOrderObserver observer)
        {
            _observer = observer;
        }
        public void NotifyObserver()
        {
            _observer.Update();
        }

        private void SetComponentStyle()
        {
            this.Tag = _menuItem;
            this.itemName.Text = _menuItem.Name;
            this.stock.Text = $"Stock: {_menuItem.Stock.Count}";
            this.price.Text = $"Price: €{_menuItem.Price}";

            if (_menuItem.Stock.Count <= 0)
            {
                this.BackColor = Color.LightGray;
                this.addButton.Click -= addButton_Click;
                this.addButton.Cursor = Cursors.No;
                this.specifyButton.Click -= specifyButton_Click;
                this.specifyButton.Cursor = Cursors.No;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrderItem();
        }

        private void specifyButton_Click(object sender, EventArgs e)
        {
            OrderLineNote note = new OrderLineNote(_menuItem);
            note.ShowDialog();

            AddOrderItem(note.Note);
        }

        private void AddOrderItem(string? note = null)
        {
            bool alreadyInOrder = false;
            foreach (OrderLine orderLine in _order.OrderLines)
            {
                if (orderLine.MenuItem.MenuItemId == _menuItem.MenuItemId && (note != null ? orderLine.OrderNote?.Note == note : orderLine.OrderNote == null))
                {
                    if (orderLine.Quantity >= orderLine.MenuItem.Stock.Count) MessageBox.Show("There is no more stock of this item.");
                    alreadyInOrder = true;
                    orderLine.IncreaseQuantity(1);
                }
            }
            if (!alreadyInOrder) CreateOrderline(note);

            NotifyObserver();
        }

        private void CreateOrderline(string? note)
        {
            OrderLine orderLine = new OrderLine(_menuItem, EOrderLineStatus.Pending, 1);
            if (!string.IsNullOrEmpty(note)) orderLine.SetOrderNote(new OrderNote(note));
            _order.AddOrderLine(orderLine);
        }
    }
}
