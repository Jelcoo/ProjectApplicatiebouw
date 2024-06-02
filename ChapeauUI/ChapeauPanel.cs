using ChapeauUI.BarUI;
using ChapeauUI.KitchenUI;
using ChapeauUI.TableUI;

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

        private void managementButton_Click(object sender, EventArgs e)
        {

        }
    }
}
