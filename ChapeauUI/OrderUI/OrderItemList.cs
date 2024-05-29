using ChapeauModel;
using ChapeauService;
using ChapeauUI.OrderUI.Observers;

namespace ChapeauUI.OrderUI
{
    public partial class OrderItemList : UserControl, IOrderObserver
    {
        private IOrderObservable orderObservable;

        private Restaurant _restaurant;
        private Order _order;

        private OrderService _orderService;

        public OrderItemList()
        {
            InitializeComponent();

            _restaurant = Restaurant.GetInstance();
            _orderService = new OrderService();
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
            orderLinesBox.Text = "";

            foreach (OrderLine line in _order.OrderLines)
            {
                orderLinesBox.AppendText($"{line.MenuItem.Name} ({line.Quantity}x)\n");
                if (line.OrderNote != null)
                {
                    orderLinesBox.SelectionColor = Color.Red;
                    orderLinesBox.AppendText($"!! {line.OrderNote.Note} !!\n");
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            _orderService.MakeNewOrder(_order, _restaurant.SelectedTable, _restaurant.LoggedInEmployee);

            MessageBox.Show("Your order has been processed!");

            _order = new Order();
            Update();
        }
    }
}
