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
    public partial class MenuChangeMenuItem : Form
    {
        public MenuChangeMenuItem(int itemId)
        {
            InitializeComponent();
            FillComboBoxes();
            LoadMenuItemData(itemId);
        }

        private void btnConfirmChangeItem_Click(object sender, EventArgs e)
        {

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
                inputItemDetailName.Text = menuItem.DetailName;
                inputItemPrice.Text = menuItem.Price.ToString();
                
                cbItemMenu.SelectedIndex = menuItem.MenuId;
                cbItemType.SelectedIndex = (int)menuItem.MenuTypeId - 1;
                cbItemVATRate.SelectedIndex = menuItem.VATRate == 0.09 ? 0 : menuItem.VATRate == 0.21 ? 1 : -1;
            }
        }

        public void FillComboBoxes()
        {
            MenuService menuService = new MenuService();

            List<MenuType> menuTypes = menuService.GetMenuTypes();
            List<Menu> menus = menuService.GetMenus();
            List<double> VATRates = menuService.GetVATRates();

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

        private void MenuChangeItem_Load(object sender, EventArgs e)
        {

        }
    }
}
