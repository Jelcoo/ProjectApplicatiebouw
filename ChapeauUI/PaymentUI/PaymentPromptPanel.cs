using ChapeauModel.Enums;

namespace ChapeauUI.PaymentUI
{
    public partial class PaymentPromptPanel : Form
    {
        public PaymentPromptPanel(string personName, int percentage, double totalPrice, EPaymentMethod paymentMethod)
        {
            InitializeComponent();

            lblPerson.Text += personName;
            lblPercentage.Text += $"{percentage}%";
            lblPrice.Text += $"{totalPrice.ToString("€0.00")}";
            lblPaymentMethod.Text += paymentMethod.ToString();

            this.AcceptButton = btnPay;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}