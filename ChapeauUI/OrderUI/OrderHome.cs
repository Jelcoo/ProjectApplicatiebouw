using ChapeauUI.Helpers;

namespace ChapeauUI.OrderUI
{
    public partial class OrderHome : Form
    {
        public OrderHome()
        {
            InitializeComponent();
        }

        private void OrderHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);
        }
    }
}
