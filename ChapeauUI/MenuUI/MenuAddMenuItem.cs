using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel.Enums;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.MenuUI
{
    public partial class MenuAddMenuItem : Form
    {
        private MenuManagement parentForm;

        public MenuAddMenuItem(MenuManagement parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            FillComboBoxes();
        }

        private void btnConfirmAddItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a item?", "Confirm Add Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MenuService menuService = new MenuService();

                int stockId = menuService.CreateItemStock();
                MenuItem menuItem = GetMenuItemDataFromInput(stockId);
                menuService.AddMenuItem(menuItem);

                MessageBox.Show("MenuItem added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm.Reload();
                this.Close();
            }
        }

        private void btnCancelAddItem_Click(object sender, EventArgs e) { this.Close(); }

        public void FillComboBoxes()
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

        public MenuItem GetMenuItemDataFromInput(int stockId)
        {
            EMenuType menuType = (EMenuType)cbItemType.SelectedValue;
            EMenu menu = (EMenu)cbItemMenu.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            MenuItem menuItem = new MenuItem(new Stock(stockId, 0), itemName, itemDetailName, VATRate, price);

            menuItem.SetMenu(menu);

            if (menuType == EMenuType.None) { menuItem.SetMenuType(null); }
            else { menuItem.SetMenuType(menuType); }

            return menuItem;
        }
    }
}
