using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;
using ChapeauUI.Components;
using ChapeauUI.Helpers;

namespace ChapeauUI.OrderUI
{
    public partial class OrderHome : Form
    {
        private EMenu _selectedMenu = EMenu.Drinks;
        private OrderService _orderService;
        private MenuService _menuService;
        private List<MenuItem> _menuItems;

        public OrderHome()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _menuService = new MenuService();
        }

        private void OrderHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);
            UpdateMenuStyles();

            _menuService.GetMenus();
        }

        private void UpdateMenuStyles()
        {
            if (_selectedMenu == EMenu.Drinks)
            {
                _menuItems = Program.Menus.Single(menu => menu.MenuType == EMenu.Drinks).MenuItems;
                SelectMenuStyle(menuSelectorDrinks);
                UnselectMenuStyle(menuSelectorLunch);
                UnselectMenuStyle(menuSelectorDinner);
            }
            if (_selectedMenu == EMenu.Lunch)
            {
                _menuItems = Program.Menus.Single(menu => menu.MenuType == EMenu.Lunch).MenuItems;
                UnselectMenuStyle(menuSelectorDrinks);
                SelectMenuStyle(menuSelectorLunch);
                UnselectMenuStyle(menuSelectorDinner);
            }
            if (_selectedMenu == EMenu.Dinner)
            {
                _menuItems = Program.Menus.Single(menu => menu.MenuType == EMenu.Dinner).MenuItems;
                UnselectMenuStyle(menuSelectorDrinks);
                UnselectMenuStyle(menuSelectorLunch);
                SelectMenuStyle(menuSelectorDinner);
            }
        }
        private void SelectMenuStyle(RoundedButton button)
        {
            button.BackColor = Color.FromArgb(246, 255, 248);
            button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            button.HasBorder = true;
            button.Cursor = Cursors.No;
        }
        private void UnselectMenuStyle(RoundedButton button)
        {
            button.BackColor = Color.FromArgb(234, 244, 244);
            button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button.HasBorder = false;
            button.Cursor = Cursors.Hand;
        }

        private void menuSelectorDrinks_Click(object sender, EventArgs e)
        {
            _selectedMenu = EMenu.Drinks;
            UpdateMenuStyles();
        }
        private void menuSelectorLunch_Click(object sender, EventArgs e)
        {
            _selectedMenu = EMenu.Lunch;
            UpdateMenuStyles();
        }
        private void menuSelectorDinner_Click(object sender, EventArgs e)
        {
            _selectedMenu = EMenu.Dinner;
            UpdateMenuStyles();
        }
    }
}
