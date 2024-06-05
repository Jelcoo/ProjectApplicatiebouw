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

            this.tableLabel.Text = $"Order for table #{_restaurant.SelectedTable.TableId}";
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
            if (_order.OrderLines.Count == 0)
            {
                MessageBox.Show("Your order is empty. Please add some items to your order.");
                return;
            }

            try {
                _orderService.MakeNewOrder(_order, _restaurant.SelectedTable, _restaurant.LoggedInEmployee);
            } catch (Exception ex) {
                MessageBox.Show($"Something went wrong: {ex.Message}");
                return;
            }

            MessageBox.Show("Your order has been processed!");

            _restaurant.SetSelectedTable(null);

            new TableUI.TableHome().Show();
            this.ParentForm.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            OrderModifyScreen modifyScreen = new OrderModifyScreen(_order);
            modifyScreen.ShowDialog();

            Update();
        }
    }
}
