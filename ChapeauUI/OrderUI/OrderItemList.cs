using ChapeauModel;
using ChapeauUI.OrderUI.Observers;

namespace ChapeauUI.OrderUI
{
    public partial class OrderItemList : UserControl, IOrderObserver
    {
        private IOrderObservable orderObservable;

        private Restaurant _restaurant;
        private Order _order;

        public OrderItemList()
        {
            InitializeComponent();

            _restaurant = Restaurant.GetInstance();
        }
        public void SetObservable(IOrderObservable orderObservable)
        {
            this.orderObservable = orderObservable;
            orderObservable.SetObserver(this);
        }

        public void SetOrder(Order order)
        {
            this._order = order;

            this.tableLabel.Text = $"Order for table #{order.Invoice?.Table.TableId}";
        }

        public void Update()
        {
            string labelText = "";
            foreach (OrderLine line in _order.OrderLines)
            {
                labelText += $"{line.MenuItem.Name} ({line.Quantity}x)\n";
            }

            orderLinesLabel.Text = labelText;
        }
    }
}
