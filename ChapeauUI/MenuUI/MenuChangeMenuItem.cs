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
        private MenuService _menuService;
        private MenuItem SelectedMenuItem;


        public MenuChangeMenuItem(MenuManagement form, MenuItem item)
        {
            InitializeComponent();

            parentForm = form;
            _menuService = new MenuService();
            SelectedMenuItem = item;

            FillComboBoxes();
            LoadMenuItemData();
        }

        public void LoadMenuItemData()
        {
            inputItemName.Text = SelectedMenuItem.Name;
            inputItemName.Tag = SelectedMenuItem.MenuItemId;
            inputItemDetailName.Text = SelectedMenuItem.DetailName;
            inputItemPrice.Text = SelectedMenuItem.Price.ToString("F2");

            cbItemMenu.SelectedIndex = (int)SelectedMenuItem.Menu - 1;
            cbItemType.SelectedIndex = (int)SelectedMenuItem.MenuType;
            cbItemVATRate.SelectedIndex = SelectedMenuItem.VATRate == 0.09 ? 0 : SelectedMenuItem.VATRate == 0.21 ? 1 : -1;
        }

        public void FillComboBoxes()
        {
            // MenuType's
            cbItemType.Items.Clear();
            cbItemType.DataSource = Enum.GetValues(typeof(EMenuType));

            // Menu's
            cbItemMenu.Items.Clear();
            cbItemMenu.DataSource = Enum.GetValues(typeof(EMenu));

            // VATRates
            List<double> VATRates = _menuService.GetVATRates();
            cbItemVATRate.DataSource = VATRates;
        }

        private void btnConfirmChangeItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change a item?", "Confirm Add Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes && CheckIfAllFilled())
            {
                try
                {
                    //Get menuItemData to change to
                    MenuItem changedMenuItem = GetMenuItemDataFromInput();

                    _menuService.ChangeMenuItem(changedMenuItem);
                    MessageBox.Show(changedMenuItem.MenuItemId.ToString());

                    MessageBox.Show("MenuItem Changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    parentForm.Reload();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill in all details");
            }
        }
        
        private void btnCancelChangeItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public MenuItem GetMenuItemDataFromInput()
        {
            EMenuType menuType = (EMenuType)cbItemType.SelectedValue;
            EMenu menu = (EMenu)cbItemMenu.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            MenuItem menuItem = new MenuItem(SelectedMenuItem.MenuItemId, SelectedMenuItem.Stock, itemName, itemDetailName, VATRate, price);

            menuItem.SetMenu(menu);

            if (menuType == EMenuType.None) menuItem.SetMenuType(null);
            else menuItem.SetMenuType(menuType);

            return menuItem;
        }

        private bool CheckIfAllFilled()
        {
            if (string.IsNullOrEmpty(inputItemName.Text)) { return false; }
            if (string.IsNullOrWhiteSpace(inputItemDetailName.Text)) { return false; }
            if (string.IsNullOrEmpty(inputItemPrice.Text)) { return false; }

            return true;
        }
    }
}
