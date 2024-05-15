using ChapeauDAL;
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
            new StockManagement().Show();
            this.Hide();
        }
    }
}
