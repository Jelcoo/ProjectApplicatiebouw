using ChapeauModel.Enums;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.MenuUI
{
    public partial class MenuAddMenuItem : Form
    {
        private MenuManagement parentForm;
        private Restaurant _restaurant;
        private MenuService _menuService;

        public MenuAddMenuItem(MenuManagement parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            _restaurant = Restaurant.GetInstance();
            _menuService = new MenuService();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            MenuService menuService = new MenuService();

            // MenuType's
            cbItemType.Items.Clear();
            cbItemType.DataSource = Enum.GetValues(typeof(EMenuType));

            // Menu's
            cbItemMenu.Items.Clear();
            cbItemMenu.DataSource = Enum.GetValues(typeof(EMenu));

            // VATRates
            List<double> VATRates = menuService.GetVATRates();
            cbItemVATRate.DataSource = VATRates;
        }

        private void btnConfirmAddItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a item?", "Confirm Add Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes && CheckIfAllFilled())
            {
                try
                {
                    // Asks menuService to create item stock
                    int stockId = _menuService.CreateItemStock();

                    //Gets all input data
                    MenuItem menuItem = GetMenuItemDataFromInput(stockId);

                    // Asks menuService to create a menuItem with StockId
                    _menuService.AddMenuItem(menuItem);
                    _restaurant.AddMenuItem(menuItem);

                    MessageBox.Show("MenuItem added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Reloads parent form
                    parentForm.Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill in all details");
            }
        }

        private void btnCancelAddItem_Click(object sender, EventArgs e) { this.Close(); }

        private MenuItem GetMenuItemDataFromInput(int stockId)
        {
            //Gets all MenuItem data from inputs
            EMenuType menuType = (EMenuType)cbItemType.SelectedValue;
            EMenu menu = (EMenu)cbItemMenu.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            //Sets all data into a MenuItem
            MenuItem menuItem = new MenuItem(new Stock(stockId, 0), itemName, itemDetailName, VATRate, price);

            //Sets the Menu
            menuItem.SetMenu(menu);

            //Sets the MenuType to Null if None, else selected
            if (menuType == EMenuType.None) { menuItem.SetMenuType(null); }
            else { menuItem.SetMenuType(menuType); }

            return menuItem;
        }

        private bool CheckIfAllFilled()
        {
            // Checks if any inputs are empty
            if (string.IsNullOrEmpty(inputItemName.Text)) { return false; }
            if (string.IsNullOrWhiteSpace(inputItemDetailName.Text)) { return false; }
            if (string.IsNullOrEmpty(inputItemPrice.Text)) { return false; }

            return true;
        }
    }
}
