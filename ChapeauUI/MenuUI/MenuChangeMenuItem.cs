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

            //Sets SelectedMenuItem
            SelectedMenuItem = item;

            FillComboBoxes();
            LoadMenuItemData();
        }

        private void LoadMenuItemData()
        {
            //Sets selectedData to the input
            inputItemName.Text = SelectedMenuItem.Name;
            inputItemDetailName.Text = SelectedMenuItem.DetailName;
            inputItemPrice.Text = SelectedMenuItem.Price.ToString("F2");

            cbItemMenu.SelectedIndex = (int)SelectedMenuItem.Menu - 1;
            cbItemType.SelectedIndex = (int)SelectedMenuItem.MenuType;
            cbItemVATRate.SelectedIndex = SelectedMenuItem.VATRate == 0.09 ? 0 : SelectedMenuItem.VATRate == 0.21 ? 1 : -1;
        }

        private void FillComboBoxes()
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
                    // Gets all changed data
                    MenuItem changedMenuItem = GetMenuItemDataFromInput();

                    //Asks menuService to changeItem
                    _menuService.ChangeMenuItem(changedMenuItem);

                    MessageBox.Show("MenuItem Changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reloads parent form
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

        private void btnCancelChangeItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private MenuItem GetMenuItemDataFromInput()
        {
            //Gets all MenuItem data from inputs
            EMenuType menuType = (EMenuType)cbItemType.SelectedValue;
            EMenu menu = (EMenu)cbItemMenu.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            //Sets all data into a MenuItem
            MenuItem menuItem = new MenuItem(SelectedMenuItem.MenuItemId, SelectedMenuItem.Stock, itemName, itemDetailName, VATRate, price);

            //Sets the Menu
            menuItem.SetMenu(menu);

            //Sets the MenuType to Null if None, else selected
            if (menuType == EMenuType.None) menuItem.SetMenuType(null);
            else menuItem.SetMenuType(menuType);

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
