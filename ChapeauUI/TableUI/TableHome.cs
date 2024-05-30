using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.TableUI
{
    // Do not grade, was supposed to be made by Berk
    public partial class TableHome : Form
    {
        private Restaurant _restaurant;
        private TableService _tableService;

        private List<Table> _tables;

        public TableHome()
        {
            InitializeComponent();

            _restaurant = Restaurant.GetInstance();

            _tableService = new TableService();
        }

        private void TableHome_Load(object sender, EventArgs e)
        {
            _tables = _tableService.GetTables();

            tableSelector.Clear();
            tableSelector.Columns.Add("Number", 100);
            tableSelector.Columns.Add("Free?", 100);

            foreach (Table table in _tables)
            {
                ListViewItem listViewItem = new ListViewItem(table.TableId.ToString());
                listViewItem.Tag = table;
                listViewItem.SubItems.Add(table.Occupied ? "No" : "Yes");

                tableSelector.Items.Add(listViewItem);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = tableSelector.SelectedItems.Count == 0 ? null : tableSelector.SelectedItems[0];
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a table!");
                return;
            }

            _restaurant.SetSelectedTable((Table)selectedItem.Tag);

            new OrderUI.OrderHome().Show();
            this.Hide();
        }
    }
}
