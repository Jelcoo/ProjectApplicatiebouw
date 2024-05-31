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
    public partial class StockManagement : Form
    {
        private StockService _stockService;
        public StockManagement()
        {
            InitializeComponent();
            _stockService = new StockService();
            PopulateStock();
        }

        public void PopulateStock()
        {
            List<MenuItem> stockData = _stockService.GetStock();

            lvStock.Items.Clear();

            foreach (MenuItem item in stockData)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name)
                {
                    Tag = item.MenuItemId
                };
                ListViewItem.ListViewSubItem stockAmountSubItem = new ListViewItem.ListViewSubItem
                {
                    Text = item.Stock.Count.ToString(),
                    Tag = item.Stock.StockId
                };

                listViewItem.SubItems.Add(stockAmountSubItem);
                lvStock.Items.Add(listViewItem);
            }

            lvStock.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockService stockService = new StockService();

            if (lvStock.SelectedItems.Count > 0)
            {
                lblSelectAnItemText.Visible = false;

                ListViewItem selectedItem = lvStock.SelectedItems[0];

                int itemId = (int)selectedItem.Tag;

                lblMenuItemName.Text = selectedItem.Text;
                lblMenuItemDetail.Text = stockService.GetDetailNameById(itemId);
                lblMenuItemStock.Text = selectedItem.SubItems[1].Text;
                SetItemImage(itemId);
                lblStockManagementText.Visible = true;
                lblInStockText.Visible = true;
                btnAddStock.Visible = true;
                btnAlterStock.Visible = true;
            }
        }

        public void SetItemImage(int id)
        {
            string imagePath = GetImagePath(id);

            if (File.Exists(imagePath))
            {
                try
                {
                    pbItemImage.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // 0 is default NoImage
                    pbItemImage.Image = Image.FromFile(GetImagePath(0));
                    throw new Exception($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                // 0 is default NoImage
                pbItemImage.Image = Image.FromFile(GetImagePath(0));
            }
        }

        public string GetImagePath(int id)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagesDirectory = Path.Combine(baseDirectory, @"..\..\..\Resources\StockImages");

            string imagePath = Path.Combine(imagesDirectory, id + ".png");

            return imagePath;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvStock.SelectedItems[0];

            int itemId = (int)selectedItem.Tag;

            StockAddDelivery addDeliveryForm = new StockAddDelivery(itemId, this);
            addDeliveryForm.ShowDialog();
        }

        public void Reload()
        {
            PopulateStock();

            lblStockManagementText.Visible = false;
            lblInStockText.Visible = false;
            btnAddStock.Visible = false;
            btnAlterStock.Visible = false;

            lblMenuItemName.Text = string.Empty;
            lblMenuItemDetail.Text = string.Empty;
            lblMenuItemStock.Text = string.Empty;
            pbItemImage.Image = null;

            lblSelectAnItemText.Visible = true;
        }

        private void btnAlterStock_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvStock.SelectedItems[0];

            int itemId = (int)selectedItem.Tag;

            StockAlterStock alterStockForm = new StockAlterStock(itemId, this);
            alterStockForm.ShowDialog();
        }
    }
}
