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
        private StockService _stockService;
        private StockManagement parentForm;

        private MenuItem SelectedMenuItem;

        public StockAlterStock(MenuItem item, StockManagement parentForm)
        {
            InitializeComponent();

            _stockService = new StockService();

            this.parentForm = parentForm;
            SelectedMenuItem = item;
            FillMenuItemDetails();
            FillQuantifiersComboBox();
        }

        private void FillMenuItemDetails()
        {
            //Sets MenuItem data to the labels
            lblMenuItemName.Text = SelectedMenuItem.Name;
            lblMenuItemName.Tag = SelectedMenuItem.MenuItemId;

            lblMenuItemStock.Text = SelectedMenuItem.Stock.Count.ToString();
        }

        private void FillQuantifiersComboBox()
        {
            // Dictornay of Quantifiers <string Name, int quantification>
            Dictionary<string, int> quantifiers = GetQuantifiers();

            // Puts each quantifier in a combobox
            foreach (var quantifier in quantifiers)
            {
                cbQuantifiers.Items.Add(new KeyValuePair<string, int>(quantifier.Key, quantifier.Value));
            }

            // Sets Key and Value
            cbQuantifiers.DisplayMember = "Key";
            cbQuantifiers.ValueMember = "Value";

            //Default combobox select is 0, means x1
            cbQuantifiers.SelectedIndex = 0;
        }

        private void InputAddStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make textbox only allow numbers as input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void btnAlterConfirm_Click(object sender, EventArgs e)
        {
            // Checks the total
            if (CheckTotal())
            {
                // Confirmation + show calculation
                DialogResult result = MessageBox.Show($"Are you sure you want to alter stock of {SelectedMenuItem.Name} to ({GetSelectedQuantifier().Value} * {InputAddStock.Text} =) {CheckAndCalculateAlterTotal()}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Sends Stock and Calculated Value to MenuService
                        _stockService.ChangeStock(new Stock(SelectedMenuItem.Stock.StockId, CalculateAlterTotal()));
                        MessageBox.Show("Stock altered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reloads parentform
                        parentForm.Reload();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else { MessageBox.Show("Please select/input a correct alter amount"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTotal();
        }

        private void InputAddStock_TextChanged(object sender, EventArgs e)
        {
            ChangeTotal();
        }

        private void btnAlterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<string, int> GetQuantifiers()
        {

            // Hardcodes all quantifiers
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

        private void ChangeTotal()
        {
            // Sets Total label to the Calculated Total
            lblTotal.Text = CalculateAlterTotal().ToString();
        }

        public bool CheckTotal()
        {
            // Checks if quantifier is selected and the input is not 0 or empty
            return (cbQuantifiers.SelectedIndex > -1 && (!string.IsNullOrEmpty(InputAddStock.Text) || InputAddStock.Text != "0"));
        }

        private int CalculateAlterTotal()
        {
            if (CheckTotal())
            {
                // returns calculated total; Quantifier * input
                return (int.Parse(InputAddStock.Text) * GetSelectedQuantifier().Value);
            }
            else { return 0; }
        }

        private KeyValuePair<string, int> GetSelectedQuantifier()
        {
            // returns the selected quantifier
            return (KeyValuePair<string, int>)cbQuantifiers.SelectedItem;
        }
    }
}
