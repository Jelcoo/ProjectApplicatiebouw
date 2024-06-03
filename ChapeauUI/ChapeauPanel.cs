using ChapeauUI.BarUI;
using ChapeauUI.KitchenUI;
using ChapeauUI.TableUI;
using ChapeauUI.StockUI;
using ChapeauUI.MenuUI;

namespace ChapeauUI
{
    public partial class ChapeauPanel : Form
    {
        public ChapeauPanel()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            TableHome tableHome = new TableHome();
            tableHome.Show();
            this.Hide();
        }

        private void kitchenButton_Click(object sender, EventArgs e)
        {
            KitchenHome kitchenHome = new KitchenHome();
            kitchenHome.Show();
            this.Hide();
        }

        private void barOverview_Click(object sender, EventArgs e)
        {
            BarHome barHome = new BarHome();
            barHome.Show();
            this.Hide();
        }

        private void managementStockButton_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement();
            stockManagement.Show();
            this.Hide();
        }

        private void managementMenuButton_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagement = new MenuManagement();
            menuManagement.Show();
            this.Hide();
        }

        private void managementIncomeButton_Click(object sender, EventArgs e)
        {
            IncomeUI incomeUI = new IncomeUI();
            incomeUI.Show();
            this.Hide();
        }
    }
}
