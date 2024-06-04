using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI.MenuUI
{
    public partial class MenuManagement : Form
    {
        private Restaurant _restaurant;

        public MenuManagement()
        {
            _restaurant = Restaurant.GetInstance();

            InitializeComponent();
            PopulateMenuDisplay();
        }

        public void PopulateMenuDisplay()
        {
            lvMenu.Items.Clear();

            foreach (MenuItem item in _restaurant.Menus.SelectMany(m => m.MenuItems))
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.DetailName);
                listViewItem.SubItems.Add(item.Menu.ToString());
                listViewItem.SubItems.Add(item.MenuType != EMenuType.None ? (item.MenuType).ToString() : "");
                listViewItem.SubItems.Add(item.Price.ToString("F2"));
                listViewItem.SubItems.Add(item.VATRate.ToString("F2"));
                listViewItem.Tag = item.MenuItemId;

                lvMenu.Items.Add(listViewItem);
            }
            lvMenu.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMenu.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            new MenuAddMenuItem(this).ShowDialog();
        }

        private void btnChangeMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMenu.SelectedItems[0];

                int menuItemId = (int)selectedItem.Tag;

                MenuChangeMenuItem otherForm = new MenuChangeMenuItem(this, menuItemId);
                otherForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        public void Reload() { PopulateMenuDisplay(); }

        public void btnDeleteMenuItem_Click(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();

            if (lvMenu.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a item?", "Confirm Add Item", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    ListViewItem selectedItem = lvMenu.SelectedItems[0];

                    int menuItemId = (int)selectedItem.Tag;
                    MessageBox.Show(menuItemId.ToString());
                    menuService.DeleteMenuItemAndStockById(menuItemId);

                    MessageBox.Show("Item deleted successfully");

                    this.Reload();
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }
    }
}
