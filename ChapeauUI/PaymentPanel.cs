using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI
{
    public partial class PaymentPanel : Form
    {
        private OrderService _orderService;
        public PaymentPanel()
        {
            InitializeComponent();
            _orderService = new OrderService();

            int invoiceId = 1; // debug
            DisplayAllOrderedItems(GetAllOrderedItems(invoiceId));

            ResetVisibilityAndText();

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
            double totalVat = 0;

            foreach (var item in orderedItems)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Tag = item;
                listViewItem.Text = item.Key.Name; // Name
                listViewItem.SubItems.Add(item.Key.Price.ToString("€0.00")); // Price
                totalItems++;
                listViewItem.SubItems.Add(item.Value.ToString()); // Quantity
                totalPrice += item.Key.Price * item.Value;
                listViewItem.SubItems.Add((item.Key.Price * item.Value).ToString("€0.00")); // Total item price
                totalVat += item.Key.VATRate;
                lvAllOrderItems.Items.Add(listViewItem);
            }

            // Adds total quantity and price on last row
            ListViewItem subTotalItem = new ListViewItem();
            subTotalItem.Text = "";
            subTotalItem.SubItems.Add("Sub Total:");
            subTotalItem.SubItems.Add(totalItems.ToString("0x"));
            subTotalItem.SubItems.Add(totalPrice.ToString("€0.00"));
            lvAllOrderItems.Items.Add(subTotalItem);

            // Adds shows total VAT
            ListViewItem vatItem = new ListViewItem();
            vatItem.Text = "";
            vatItem.SubItems.Add("Sales Tax:");
            vatItem.SubItems.Add("");
            vatItem.SubItems.Add(totalVat.ToString("€0.00"));
            lvAllOrderItems.Items.Add(vatItem);

            // Shows vat + total price
            ListViewItem totalItem = new ListViewItem();
            totalItem.Text = "";
            totalItem.SubItems.Add("Total:");
            totalItem.SubItems.Add("");
            totalItem.SubItems.Add((totalVat + totalPrice).ToString("€0.00"));
            lvAllOrderItems.Items.Add(totalItem);
        }

        private Dictionary<MenuItem, int> GetAllOrderedItems(int invoiceId)
        {
            return _orderService.GetAllOrderedItemsByInvoiceId(invoiceId);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // back to table overview
        }

        private void tbPeopleAmount_TextChanged(object sender, EventArgs e)
        {
            int peopleAmount;

            if (int.TryParse(tbPeopleAmount.Text, out peopleAmount))
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
