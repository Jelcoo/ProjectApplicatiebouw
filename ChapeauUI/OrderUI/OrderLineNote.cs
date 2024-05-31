
using ChapeauModel;

namespace ChapeauUI.OrderUI
{
    public partial class OrderLineNote : Form
    {
        private ChapeauModel.MenuItem _menuItem;
        private OrderNote? _note;
        public string Note;

        public OrderLineNote(ChapeauModel.MenuItem menuItem)
        {
            InitializeComponent();

            _menuItem = menuItem;
        }
        public OrderLineNote(ChapeauModel.MenuItem menuItem, OrderNote? note)
            : this(menuItem)
        {
            _note = note;
        }

        private void OrderLineNote_Load(object sender, EventArgs e)
        {
            specifyItemName.Text = $"You are ordering a {_menuItem.Name}";
            if (_note != null)
            {
                orderNoteBox.Text = _note.Note;
                Note = _note.Note;
                addButton.Text = "Update";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Note = orderNoteBox.Text;
            this.Close();
        }
    }
}
