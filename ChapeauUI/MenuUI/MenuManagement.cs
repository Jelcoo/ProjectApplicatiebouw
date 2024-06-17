using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI.MenuUI
{
    public partial class MenuManagement : Form
    {
        private Restaurant _restaurant;
        private MenuService _menuService;
        private MenuItem SelectedMenuItem;

        public MenuManagement()
        {
            _restaurant = Restaurant.GetInstance();
            _menuService = new MenuService();

            InitializeComponent();
            PopulateMenuDisplay();
        }

        private void PopulateMenuDisplay()
        {
            lvMenu.Items.Clear();

            foreach (MenuItem item in _restaurant.Menus.SelectMany(m => m.MenuItems))
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.Tag = item;
                listViewItem.SubItems.Add(item.DetailName);
                listViewItem.SubItems.Add(item.Menu.ToString());
                listViewItem.SubItems.Add(item.MenuType != EMenuType.None ? (item.MenuType).ToString() : "");
                listViewItem.SubItems.Add(item.Price.ToString("F2"));
                listViewItem.SubItems.Add(item.VATRate.ToString("F2"));

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
                MenuChangeMenuItem menuChangeMenuItem = new MenuChangeMenuItem(this, SelectedMenuItem);
                menuChangeMenuItem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        public void Reload() { PopulateMenuDisplay(); }

        private void btnDeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a item?", "Confirm Delete Item", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _menuService.DeleteMenuItemAndStockById(SelectedMenuItem);

                        MessageBox.Show("Item deleted successfully");

                        this.Reload();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMenuItem = (MenuItem)lvMenu.SelectedItems[0].Tag;
        }
    }
}
