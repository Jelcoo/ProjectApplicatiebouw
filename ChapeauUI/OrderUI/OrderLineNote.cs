
using ChapeauModel;
using ChapeauModel.Enums;

namespace ChapeauUI.OrderUI
{
    public partial class OrderLineNote : Form
    {
        private ChapeauModel.MenuItem _menuItem;
        private Order _order;
        public string Note;

        public OrderLineNote(ChapeauModel.MenuItem menuItem, Order order)
        {
            InitializeComponent();

            _menuItem = menuItem;
            _order = order;
        }

        private void OrderLineNote_Load(object sender, EventArgs e)
        {
            specifyItemName.Text = $"You are ordering a {_menuItem.Name}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Note = orderNoteBox.Text;
            this.Close();
        }
    }
}
