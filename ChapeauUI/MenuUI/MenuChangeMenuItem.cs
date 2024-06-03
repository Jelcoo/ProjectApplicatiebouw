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
using System.Drawing.Drawing2D;

namespace ChapeauUI.MenuUI
{
    public partial class MenuChangeMenuItem : Form
    {
        private MenuManagement parentForm;
        private int menuItemId;

        public MenuChangeMenuItem(MenuManagement form, int itemId)
        {
            InitializeComponent();
            this.parentForm = form;
            this.menuItemId = itemId;
            FillComboBoxes();
            LoadMenuItemData(itemId);
        }

        private void btnConfirmChangeItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change a item?", "Confirm Add Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //Get menuItemData to change to
                MenuItem changedMenuItem = GetMenuItemDataFromInput();

                MenuService menuService = new MenuService();
                menuService.ChangeMenuItem(changedMenuItem);

                MessageBox.Show("MenuItem Changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm.Reload();
                this.Close();
            }
        }
        public MenuItem GetMenuItemDataFromInput()
        {
            EMenuType menuType = (EMenuType)cbItemType.SelectedValue;
            EMenu menu = (EMenu)cbItemMenu.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            MenuItem menuItem = new MenuItem(menuItemId, new Stock(0), itemName, itemDetailName, VATRate, price);

            menuItem.SetMenu(menu);

            if (menuType == EMenuType.None) menuItem.SetMenuType(null);
            else menuItem.SetMenuType(menuType);

            return menuItem;
        }


        private void btnCancelChangeItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadMenuItemData(int itemId)
        {
            MenuService menuService = new MenuService();

            MenuItem menuItem = menuService.GetMenuItemById(itemId);

            if (menuItem != null)
            {
                inputItemName.Text = menuItem.Name;
                inputItemName.Tag = menuItem.MenuItemId;
                inputItemDetailName.Text = menuItem.DetailName;
                inputItemPrice.Text = menuItem.Price.ToString("F2");

                cbItemMenu.SelectedIndex = (int)menuItem.Menu - 1;
                cbItemType.SelectedIndex = (int)menuItem.MenuType;
                cbItemVATRate.SelectedIndex = menuItem.VATRate == 0.09 ? 0 : menuItem.VATRate == 0.21 ? 1 : -1;
            }
        }

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
    }
}
