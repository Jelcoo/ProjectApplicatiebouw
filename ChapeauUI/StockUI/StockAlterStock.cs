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

namespace ChapeauUI.StockUI
{
    public partial class StockAlterStock : Form
    {
        private int stockId;
        private StockManagement parentForm;
        public StockAlterStock(int itemId, StockManagement parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            FillMenuItemDetails(itemId);
            FillQuantifiersComboBox();
        }

        public void FillMenuItemDetails(int itemId)
        {
            StockService stockService = new StockService();
            Dictionary<MenuItem, Stock> details = stockService.GetMenuItemAndStockById(itemId);

            foreach (MenuItem item in details.Keys)
            {
                lblMenuItemName.Text = item.Name;
                lblMenuItemName.Tag = item.MenuItemId;
            }
            foreach (Stock stock in details.Values)
            {
                lblMenuItemStock.Text = stock.Count.ToString();
                lblMenuItemStock.Tag = stock.StockId;
                stockId = stock.StockId;
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = CheckAndCalculateAlterTotal().ToString();
        }

        private void InputAddStock_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = CheckAndCalculateAlterTotal().ToString();
        }

        private void InputAddStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make textbox only allow numbers as input :)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        public int CheckAndCalculateAlterTotal()
        {
            if (cbQuantifiers.SelectedIndex > -1 && !string.IsNullOrEmpty(InputAddStock.Text))
            {
                KeyValuePair<string, int> selectedQuantifier = (KeyValuePair<string, int>)cbQuantifiers.SelectedItem;
                return (int.Parse(InputAddStock.Text) * selectedQuantifier.Value);
            }
            else { return 0; }
        }

        private void btnAlterConfirm_Click(object sender, EventArgs e)
        {
            if (cbQuantifiers.SelectedIndex > -1 && InputAddStock.Text != "0" && InputAddStock.Text != string.Empty)
            {
                KeyValuePair<string, int> selectedQuantifier = (KeyValuePair<string, int>)cbQuantifiers.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to alter stock of {lblMenuItemName.Text} to ({selectedQuantifier.Value} * {InputAddStock.Text} =) {CheckAndCalculateAlterTotal()}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    StockService stockService = new StockService();

                    stockService.AlterStock(new Stock(stockId, CheckAndCalculateAlterTotal()));
                    MessageBox.Show("Stock altered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    parentForm.Reload();
                    this.Close();
                }
            }
            else { MessageBox.Show("Please select/input a correct alter amount"); }
        }

        private void btnAlterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
