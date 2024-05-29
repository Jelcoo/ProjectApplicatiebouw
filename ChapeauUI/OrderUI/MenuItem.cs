using ChapeauModel;
using ChapeauModel.Enums;

namespace ChapeauUI.OrderUI
{
    public partial class MenuItem : UserControl
    {
        private ChapeauModel.MenuItem _menuItem;
        private Order _order;

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
        }

        private void AddOrderline()
        {
            OrderLine orderLine = new OrderLine(_menuItem, EOrderLineStatus.Pending, 1);
            _order.AddOrderLine(orderLine);
        }
    }
}
