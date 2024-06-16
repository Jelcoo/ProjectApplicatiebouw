using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI.StockUI
{
    public partial class StockAddDelivery : Form
    {
        private StockService _stockService;
        private StockManagement parentForm;
        private MenuItem SelectedMenuItem;

        public StockAddDelivery(MenuItem item, StockManagement parentForm)
        {
            InitializeComponent();

            _stockService = new StockService();

            this.parentForm = parentForm;
            SelectedMenuItem = item;

            FillMenuItemDetails();
            FillQuantifiersComboBox();
        }

        public void FillMenuItemDetails()
        {
            lblMenuItemName.Text = SelectedMenuItem.Name;
            lblMenuItemName.Tag = SelectedMenuItem.MenuItemId;

            lblMenuItemStock.Text = SelectedMenuItem.Stock.Count.ToString();
        }

        public void FillQuantifiersComboBox()
        {
            Dictionary<string, int> quantifiers = GetQuantifiers();

            foreach (var quantifier in quantifiers)
            {
                cbQuantifiers.Items.Add(new KeyValuePair<string, int>(quantifier.Key, quantifier.Value));
            }

            cbQuantifiers.DisplayMember = "Key";
            cbQuantifiers.ValueMember = "Value";

            cbQuantifiers.SelectedIndex = 0;
        }

        private void InputAddStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make textbox only allow numbers as input :)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void btnDeliveryConfirm_Click(object sender, EventArgs e)
        {
            if (cbQuantifiers.SelectedIndex > -1 && InputAddStock.Text != "0" && InputAddStock.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to add ({GetSelectedQuantifier().Value} * {InputAddStock.Text} =) {CheckAndCalculateTotal()} to {lblMenuItemName.Text}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _stockService.AddDelivery(SelectedMenuItem.Stock, CheckAndCalculateTotal());
                    MessageBox.Show("Stock added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    parentForm.Reload();
                    this.Close();
                }
            }
            else { MessageBox.Show("Please select/input a correct delivery amount"); }
        }

        private void cbQuantifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTotal();
        }

        private void InputAddStock_TextChanged(object sender, EventArgs e)
        {
            ChangeTotal();
        }

        private void btnDeliveryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Dictionary<string, int> GetQuantifiers()
        {
            Dictionary<string, int> quantifiers = new Dictionary<string, int>()
            {
                { "Single (x1)", 1 },
                { "Pair (x2)" , 2 },
                { "Half dozen (x6)", 6 },
                { "Ten (x10)", 10 },
                { "Dozen (x12)", 12 },
                { "Score (x20)", 20 },
                { "Hundred (x100)", 100 },
                { "Gross (x144)", 144 }
            };

            return quantifiers;
        }

        public void ChangeTotal()
        {
            lblTotal.Text = CheckAndCalculateTotal().ToString();
        }

        public int CheckAndCalculateTotal()
        {
            if (cbQuantifiers.SelectedIndex > -1 && !string.IsNullOrEmpty(InputAddStock.Text))
            {
                return (int.Parse(InputAddStock.Text) * GetSelectedQuantifier().Value);
            }
            else { return 0; }
        }

        public KeyValuePair<string, int> GetSelectedQuantifier()
        {
            return (KeyValuePair<string, int>)cbQuantifiers.SelectedItem;
        }
    }
}
