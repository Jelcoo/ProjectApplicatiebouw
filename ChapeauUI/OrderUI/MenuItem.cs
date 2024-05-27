namespace ChapeauUI.OrderUI
{
    public partial class MenuItem : UserControl
    {
        public MenuItem(ChapeauModel.MenuItem menuItem)
        {
            InitializeComponent();

            this.Tag = menuItem;
            this.itemName.Text = menuItem.Name;
            this.stock.Text = $"Stock: {menuItem.Stock.Count}";
            this.price.Text = $"Price: €{menuItem.Price}";
        }
    }
}
