using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.StockUI
{
    public partial class StockAddItem : Form
    {
        public StockAddItem()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void btnCancelAddItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a item?","Confirm Add Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                StockService stockService = new StockService();

                int stockId = stockService.AddItemStock(GetAddStockAmount());

                MenuItem menuItem = GetMenuItemDataFromInput(stockId);

                stockService.AddMenuItem(menuItem);

                this.Close();
            }

        }

        public void FillComboBoxes()
        {
            StockService stockService = new StockService();

            List<MenuType> menuTypes = stockService.GetMenuTypes();
            List<Menu> menus = stockService.GetMenus();
            List<double> VATRates = stockService.GetVATRates();

            // Populate ItemType Combobox
            cbItemType.Items.Clear();

            menuTypes.Insert(0, new MenuType(string.Empty));

            cbItemType.DataSource = menuTypes;
            cbItemType.DisplayMember = "Name";
            cbItemType.ValueMember = "MenuTypeId";

            // Populate Menu Combobox
            cbItemMenu.Items.Clear();

            cbItemMenu.DataSource = menus;
            cbItemMenu.DisplayMember = "Name";
            cbItemMenu.ValueMember = "MenuId";

            // Populate VATRates Combobox
            cbItemVATRate.DataSource = VATRates;
        }

        public MenuItem GetMenuItemDataFromInput(int stockId)
        {
            int menuId = (int)cbItemMenu.SelectedValue; ;
            int menuTypeId = (int)cbItemType.SelectedValue;
            string itemName = inputItemName.Text;
            string itemDetailName = inputItemDetailName.Text;
            double VATRate = (double)cbItemVATRate.SelectedValue;
            double price = double.Parse(inputItemPrice.Text);

            MenuItem menuItem = new MenuItem(stockId, menuId, menuTypeId, itemName, itemDetailName, VATRate, price);

            return menuItem;
        }

        public int GetAddStockAmount()
        {
            return int.Parse(inputItemStock.Text);
        }
       
    }
}
