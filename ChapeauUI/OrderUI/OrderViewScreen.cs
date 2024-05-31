using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.OrderUI
{
    public partial class OrderViewScreen : Form
    {
        private OrderService _orderService;
        private Table _table;
        public Order SelectedOrder;

        public OrderViewScreen(Table table)
        {
            InitializeComponent();

            _orderService = new OrderService();
            _table = table;
        }

        private void OrderViewScreen_Load(object sender, EventArgs e)
        {
            orderOverview.Clear();
            orderOverview.Columns.Add("Order #", 100);
            orderOverview.Columns.Add("Ordered At", 250);
            orderOverview.Columns.Add("Total items", 100);
            orderOverview.Columns.Add("Total price", 100);

            List<Order> orders = _orderService.GetOrdersByTable(_table);

            foreach (Order order in orders)
            {
                ListViewItem listViewItem = new ListViewItem(order.OrderId.ToString());
                listViewItem.SubItems.Add(order.OrderedAt.ToString());
                listViewItem.SubItems.Add(order.GetTotalQuantity().ToString());
                listViewItem.SubItems.Add($"€{order.GetTotalPrice():0.00}");
                listViewItem.Tag = order;
                orderOverview.Items.Add(listViewItem);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = orderOverview.SelectedItems.Count == 0 ? null : orderOverview.SelectedItems[0];
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a order!");
                return;
            }

            SelectedOrder = (Order)selectedItem.Tag;
            this.Close();
        }
    }
}
