using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI.PaymentUI
{
    public partial class PaymentPanel : Form
    {
        private Table _table;
        private Invoice _invoice;
        private InvoiceService _invoiceService;
        private PaymentService _paymentService;
        private List<(string personId, int percentage, double totalPrice, EPaymentMethod paymentMethod)> paymentDetailsList;

        public PaymentPanel(Table table)
        {
            InitializeComponent();

            _table = table;

            _invoiceService = new InvoiceService();
            _paymentService = new PaymentService();
            paymentDetailsList = new List<(string, int, double, EPaymentMethod)>();

            InitializeInvoiceAndDisplayItems();
            InitializePaymentMethods();
        }

        private void InitializeInvoiceAndDisplayItems()
        {
            _invoice = _invoiceService.GetOpenInvoice(_table);
            DisplayAllOrderedItems(GetAllOrderedItems(_invoice.InvoiceId));
            ResetVisibilityAndText();
        }

        private void InitializePaymentMethods()
        {
            foreach (EPaymentMethod paymentMethod in Enum.GetValues(typeof(EPaymentMethod)))
            {
                cbPersonOne.Items.Add(paymentMethod);
                cbPersonTwo.Items.Add(paymentMethod);
                cbPersonThree.Items.Add(paymentMethod);
                cbPersonFour.Items.Add(paymentMethod);
            }
        }

        private void DisplayAllOrderedItems(Dictionary<MenuItem, int> orderedItems)
        {
            lvAllOrderItems.Items.Clear();

            int totalItems = 0;
            double totalPrice = 0;
            double totalVatRate = 0;

            foreach (var item in orderedItems)
            {
                var menuItem = item.Key;
                int quantity = item.Value;
                double itemTotalPrice = menuItem.Price * quantity;

                AddListViewItem(menuItem.Name, menuItem.Price.ToString("€0.00"), quantity.ToString("0x"), itemTotalPrice.ToString("€0.00"), item);

                totalItems += quantity;
                totalPrice += itemTotalPrice;
                totalVatRate += menuItem.VATRate;
            }

            double vatAmount = totalPrice * (totalVatRate / 100);
            double totalIncludingVat = totalPrice + vatAmount;

            AddListViewSummaryItem("Sub Total:", totalItems.ToString("0x"), totalPrice.ToString("€0.00"));
            AddListViewSummaryItem("Sales Tax:", "", vatAmount.ToString("€0.00"));
            AddListViewSummaryItem("Total:", "", totalIncludingVat.ToString("€0.00"));
        }

        private void AddListViewItem(string name, string price, string quantity, string totalPrice, object tag)
        {
            var listViewItem = new ListViewItem
            {
                Text = name,
                Tag = tag
            };
            listViewItem.SubItems.Add(price);
            listViewItem.SubItems.Add(quantity);
            listViewItem.SubItems.Add(totalPrice);

            lvAllOrderItems.Items.Add(listViewItem);
        }

        private void AddListViewSummaryItem(string label, string quantity, string totalPrice)
        {
            var listViewItem = new ListViewItem();
            listViewItem.SubItems.Add(label);
            listViewItem.SubItems.Add(quantity);
            listViewItem.SubItems.Add(totalPrice);
            lvAllOrderItems.Items.Add(listViewItem);
        }

        private Dictionary<MenuItem, int> GetAllOrderedItems(int invoiceId)
        {
            return _invoiceService.GetAllOrderedItemsByInvoiceId(invoiceId);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            paymentDetailsList.Clear();
            double totalVatPrice = GetTotalVatPriceFromListView();
            double tipAmount = CalculateTipAmount(totalVatPrice, out double totalWithTip);

            AddPaymentDetails(1, lblPersonOne, tbPersonOnePercentage, cbPersonOne, totalWithTip);
            AddPaymentDetails(2, lblPersonTwo, tbPersonTwoPercentage, cbPersonTwo, totalWithTip);
            AddPaymentDetails(3, lblPersonThree, tbPersonThreePercentage, cbPersonThree, totalWithTip);
            AddPaymentDetails(4, lblPersonFour, tbPersonFourPercentage, cbPersonFour, totalWithTip);

            ProcessPayments(tipAmount);

            MessageBox.Show("Payment successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }

        private double GetTotalVatPriceFromListView()
        {
            foreach (ListViewItem item in lvAllOrderItems.Items)
            {
                if (item.SubItems[1].Text == "Total:")
                {
                    string totalPriceText = item.SubItems[3].Text;
                    if (double.TryParse(totalPriceText.TrimStart('€'), out double totalVatPrice))
                    {
                        return totalVatPrice;
                    }
                }
            }
            return 0;
        }

        private double CalculateTipAmount(double totalVatPrice, out double totalWithTip)
        {
            double tipAmount = 0;
            totalWithTip = totalVatPrice;

            if (double.TryParse(tbPriceWithTip.Text, out double totalTip) && totalTip > totalVatPrice)
            {
                tipAmount = totalTip - totalVatPrice;
                totalWithTip = totalTip;
            }

            return tipAmount;
        }

        private void AddPaymentDetails(int personNumber, Label lblPerson, TextBox tbPercentage, ComboBox cbPaymentMethod, double totalVatPrice)
        {
            if (lblPerson.Visible && int.TryParse(tbPercentage.Text, out int percentage) && cbPaymentMethod.SelectedItem is EPaymentMethod paymentMethod)
            {
                double personTotalPrice = totalVatPrice * percentage / 100;
                paymentDetailsList.Add((personNumber.ToString(), percentage, personTotalPrice, paymentMethod));
            }
        }

        private void ProcessPayments(double tipAmount)
        {
            foreach ((string personId, int percentage, double totalPrice, EPaymentMethod paymentMethod) in paymentDetailsList)
            {
                new PaymentPromptPanel(personId, percentage, totalPrice, paymentMethod).ShowDialog();
                double personTipAmount = tipAmount * (percentage / 100);
                _paymentService.MakeNewPayment(_invoice, totalPrice, paymentMethod, personTipAmount);
            }
        }

        private void tbPeopleAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbPeopleAmount.Text, out int peopleAmount))
            {
                ResetVisibilityAndText();

                int percentage = PeopleAmountToPercentage(peopleAmount);

                PeopleAmountVisibilitySwitch(peopleAmount);

                SetAllTextBoxText(percentage);

                if ((peopleAmount * percentage) != 100)
                {
                    tbPersonOnePercentage.Text = (percentage + (100 - (peopleAmount * percentage))).ToString();
                }
            }
        }

        private int PeopleAmountToPercentage(int peopleAmount)
        {
            return peopleAmount switch
            {
                4 => 25,
                3 => 33,
                2 => 50,
                1 => 100,
                _ => 0
            };
        }

        private void PeopleAmountVisibilitySwitch(int peopleAmount)
        {
            switch (peopleAmount)
            {
                case 4:
                    lblPersonFour.Visible = true;
                    tbPersonFourPercentage.Visible = true;
                    lblPercentage4.Visible = true;
                    cbPersonFour.Visible = true;
                    goto case 3;
                case 3:
                    lblPersonThree.Visible = true;
                    tbPersonThreePercentage.Visible = true;
                    lblPercentage3.Visible = true;
                    cbPersonThree.Visible = true;
                    goto case 2;
                case 2:
                    lblPersonTwo.Visible = true;
                    tbPersonTwoPercentage.Visible = true;
                    lblPercentage2.Visible = true;
                    cbPersonTwo.Visible = true;
                    goto case 1;
                case 1:
                    lblPersonOne.Visible = true;
                    tbPersonOnePercentage.Visible = true;
                    lblPercentage1.Visible = true;
                    cbPersonOne.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void SetAllTextBoxText(int percentage)
        {
            tbPersonOnePercentage.Text = percentage.ToString();
            tbPersonTwoPercentage.Text = percentage.ToString();
            tbPersonThreePercentage.Text = percentage.ToString();
            tbPersonFourPercentage.Text = percentage.ToString();
        }

        private void ResetVisibilityAndText()
        {
            lblPersonTwo.Visible = false;
            tbPersonTwoPercentage.Visible = false;
            tbPersonTwoPercentage.Text = string.Empty;
            lblPercentage2.Visible = false;
            cbPersonTwo.Visible = false;

            lblPersonThree.Visible = false;
            tbPersonThreePercentage.Visible = false;
            tbPersonThreePercentage.Text = string.Empty;
            lblPercentage3.Visible = false;
            cbPersonThree.Visible = false;

            lblPersonFour.Visible = false;
            tbPersonFourPercentage.Visible = false;
            tbPersonFourPercentage.Text = string.Empty;
            lblPercentage4.Visible = false;
            cbPersonFour.Visible = false;
        }

        private void tbPeopleAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }

        private void tbPriceWithTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }

        private void ValidateInput(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
