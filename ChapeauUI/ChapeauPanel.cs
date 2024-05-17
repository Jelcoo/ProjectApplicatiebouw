using ChapeauUI.StockUI;

namespace ChapeauUI
{
    public partial class ChapeauPanel : Form
    {
        public ChapeauPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StockUI.StockManagement().Show();
            this.Hide();
        }
    }
}
