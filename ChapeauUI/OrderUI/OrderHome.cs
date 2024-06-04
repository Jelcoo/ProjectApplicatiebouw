using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;
using ChapeauUI.Components;
using ChapeauUI.Helpers;
using ChapeauUI.PaymentUI;

namespace ChapeauUI.OrderUI
{
    public partial class OrderHome : Form
    {
        private EMenu _selectedMenu = EMenu.Drinks;

        private Restaurant _restaurant;
        private InvoiceService _invoiceService;
        private List<ChapeauModel.MenuItem> _menuItems;
        private Order _currentOrder;

        public OrderHome()
        {
            InitializeComponent();

            _restaurant = Restaurant.GetInstance();

            _invoiceService = new InvoiceService();

            _currentOrder = new Order();
        }

        private void OrderHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);

            Invoice? openInvoice = _invoiceService.GetOpenInvoice(_restaurant.SelectedTable!);
            _currentOrder.SetInvoice(openInvoice);

            orderItemList.SetOrder(_currentOrder);

            UpdateMenuStyles();
        }

        private void UpdateMenuStyles()
        {
            _menuItems = _restaurant.Menus.Single(menu => menu.Name == _selectedMenu).MenuItems;

            SetMenuStyles();

            menuList.Controls.Clear();
            menuList.RowStyles.Clear();
            menuList.RowCount = 0;
            foreach (ChapeauModel.MenuItem menuitem in _menuItems)
            {
                AddPanel(menuitem);
            }
        }
        private void SetMenuStyles()
        {
            if (_selectedMenu == EMenu.Drinks)
            {
                SelectMenuStyle(menuSelectorDrinks);
                UnselectMenuStyle(menuSelectorLunch);
                UnselectMenuStyle(menuSelectorDinner);
            }
            if (_selectedMenu == EMenu.Lunch)
            {
                UnselectMenuStyle(menuSelectorDrinks);
                SelectMenuStyle(menuSelectorLunch);
                UnselectMenuStyle(menuSelectorDinner);
            }
            if (_selectedMenu == EMenu.Dinner)
            {
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

        private void AddPanel(ChapeauModel.MenuItem menuItem)
        {
            int count = menuList.Controls.Count; // Get the total amount of panels
            int columns = menuList.ColumnCount;
            int rows = menuList.RowCount;

            // Calculate the next cell to add a new panel
            int nextRow = count / columns;
            int nextColumn = count % columns;

            // Add a new row if there is no space anymore
            if (nextRow >= rows)
            {
                menuList.RowCount++;
                menuList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            AddOrderToPanel(nextColumn, nextRow, menuItem);
            HeightChecker();

        }
        private void HeightChecker()
        {
            int minimumRowHeight = 50; // Minimum height if no content in row

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
        private void AddOrderToPanel(int nextColumn, int nextRow, ChapeauModel.MenuItem menuItem)
        {
            // Create a new panel with random height to test
            MenuItem menuItemComponent = new MenuItem(menuItem, _currentOrder);
            orderItemList.SetObservable(menuItemComponent);

            // Adding the new panel to the layout
            menuList.Controls.Add(menuItemComponent, nextColumn, nextRow);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _restaurant.SetSelectedTable(null);

            new TableUI.TableHome().Show();
            this.Hide();
        }

        private void openOrdersButton_Click(object sender, EventArgs e)
        {
            OrderViewScreen viewScreen = new OrderViewScreen(_restaurant.SelectedTable!);
            viewScreen.ShowDialog();

            Order selectedOrder = viewScreen.SelectedOrder;
            if (selectedOrder == null) return;

            OrderModifyScreen modifyScreen = new OrderModifyScreen(selectedOrder);
            modifyScreen.ShowDialog();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            Invoice openInvoice = _invoiceService.GetOpenInvoice(_restaurant.SelectedTable);
            if (openInvoice == null)
            {
                MessageBox.Show("No open invoice found. Please place an order.");
                return;
            }

            PaymentPanel paymentPanel = new PaymentPanel(_restaurant.SelectedTable, openInvoice);
            paymentPanel.Show();
            this.Hide();
        }
    }
}
