using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.OrderUI
{
    public partial class OrderModifyScreen : Form
    {
        private OrderService _orderService;
        private Order _order;

        public OrderModifyScreen(Order order)
        {
            InitializeComponent();

            _orderService = new OrderService();
            _order = order;
        }

        private void OrderModifyScreen_Load(object sender, EventArgs e)
        {
            orderOverview.Clear();
            orderOverview.Columns.Add("Item", 250);
            orderOverview.Columns.Add("Quantity", 100);
            orderOverview.Columns.Add("Note", 250);

            foreach (OrderLine line in _order.OrderLines)
            {
                ListViewItem listViewItem = new ListViewItem(line.MenuItem.Name);
                ListViewItem.ListViewSubItem quantityItem = listViewItem.SubItems.Add(line.Quantity.ToString());
                ListViewItem.ListViewSubItem noteItem = listViewItem.SubItems.Add(line.OrderNote?.Note ?? "");
                listViewItem.Tag = line;

                orderOverview.Items.Add(listViewItem);

                Button quantityButton = new Button();
                quantityButton.Text = line.Quantity.ToString();
                quantityButton.MouseDown += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                        line.IncreaseQuantity(1);
                    else if (e.Button == MouseButtons.Right && line.Quantity != 0)
                        line.DecreaseQuantity(1);

                    quantityButton.Text = line.Quantity.ToString();
                };
                SetBounds(quantityButton, quantityItem.Bounds);

                Button noteButton = new Button();
                noteButton.Text = line.OrderNote?.Note ?? "";
                noteButton.Click += (sender, e) =>
                {
                    OrderLineNote note = new OrderLineNote(line.MenuItem, line.OrderNote);
                    note.ShowDialog();

                    if (!string.IsNullOrEmpty(note.Note))
                    {
                        if (line.OrderNote == null)
                            line.OrderNote = new OrderNote(note.Note);
                        else
                            line.OrderNote.SetNote(note.Note);
                    }
                    else
                    {
                        line.OrderNote = null;
                    }

                    noteButton.Text = note.Note;
                };
                SetBounds(noteButton, noteItem.Bounds);

                orderOverview.Controls.Add(quantityButton);
                orderOverview.Controls.Add(noteButton);
            }
        }

        private void SetBounds(Button button, Rectangle bounds)
        {
            button.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_order.OrderId != 0)
            {
                Order oldOrder = _orderService.GetOrderById(_order.OrderId);
                _orderService.UpdateOrder(oldOrder, _order);
            }

            this.Close();
        }
    }
}
