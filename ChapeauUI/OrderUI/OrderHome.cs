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
        private List<ChapeauModel.MenuItem> _menuItems;

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

            menuList.Controls.Clear();
            menuList.RowStyles.Clear();
            menuList.RowCount = 0;
            foreach (ChapeauModel.MenuItem menuitem in _menuItems)
            {
                AddPanel(menuitem);
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

        private void AddPanel(ChapeauModel.MenuItem menuItem)
        {
            int count = menuList.Controls.Count; // Get the total amount of panels
            int columns = menuList.ColumnCount;
            int rows = menuList.RowCount;
            int minimumRowHeight = 50; // Minimum height if no content in row

            // Calculate the next cell to add a new panel
            int nextRow = count / columns;
            int nextColumn = count % columns;

            // Add a new row if there is no space anymore
            if (nextRow >= rows)
            {
                menuList.RowCount++;
                menuList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Create a new panel with random height to test
            MenuItem menuItemComponent = new MenuItem(menuItem);

            // Adding the new panel to the layout
            menuList.Controls.Add(menuItemComponent, nextColumn, nextRow);

            // Tries to keep every row to the minimum height that is set otherwise be dynamic 
            for (int i = 0; i < menuList.RowCount; i++)
            {
                if (menuList.GetRowHeights()[i] < minimumRowHeight)
                {
                    menuList.RowStyles[i].Height = minimumRowHeight;
                    menuList.RowStyles[i].SizeType = SizeType.Absolute;
                }
                else
                {
                    menuList.RowStyles[i].SizeType = SizeType.AutoSize;
                }
            }
        }
    }
}
