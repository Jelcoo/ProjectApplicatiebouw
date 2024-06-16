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
    public partial class StockManagement : Form
    {
        private StockService _stockService;
        private MenuItem SelectedMenuItem;
        private int DefaultNoImageId;

        public StockManagement()
        {
            InitializeComponent();

            _stockService = new StockService();
            DefaultNoImageId = 0;

            PopulateStock();
        }

        private void PopulateStock()
        {
            List<MenuItem> stockData = _stockService.GetStock();

            lvStock.Items.Clear();

            foreach (MenuItem item in stockData)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.Tag = item;

                listViewItem.SubItems.Add(item.Stock.Count.ToString());
                listViewItem.SubItems.Add(GiveStatus(item.Stock.Count));

                lvStock.Items.Add(listViewItem);
            }

            lvStock.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count > 0)
            {
                SelectedMenuItem = (MenuItem)lvStock.SelectedItems[0].Tag;

                SetTags();
                MakeTagsVisible();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            StockAddDelivery addDeliveryForm = new StockAddDelivery(SelectedMenuItem, this);
            addDeliveryForm.ShowDialog();
        }

        private void btnAlterStock_Click(object sender, EventArgs e)
        {
            StockAlterStock alterStockForm = new StockAlterStock(SelectedMenuItem, this);
            alterStockForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }

        private void SetItemImage(int id)
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
                    pbItemImage.Image = Image.FromFile(GetImagePath(DefaultNoImageId));
                    throw new Exception($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                pbItemImage.Image = Image.FromFile(GetImagePath(DefaultNoImageId));
            }
        }

        private string GetImagePath(int id)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagesDirectory = Path.Combine(baseDirectory, @"..\..\..\Resources\StockImages");

            string imagePath = Path.Combine(imagesDirectory, id + ".png");

            return imagePath;
        }

        public void Reload()
        {
            PopulateStock();
            MakeTagsInvisible();
        }

        private string GiveStatus(int stock)
        {
            if (stock == 0)
            {
                return "Empty";
            }
            else if (stock < 10)
            {
                return "Insufficient";
            }
            else
            {
                return "Sufficient";
            }
        }

        private void SetTags()
        {
            lblMenuItemName.Text = SelectedMenuItem.Name;
            lblMenuItemDetail.Text = SelectedMenuItem.DetailName;
            lblMenuItemStock.Text = SelectedMenuItem.Stock.Count.ToString();

            SetItemImage(SelectedMenuItem.MenuItemId);
        }

        private void MakeTagsVisible()
        {
            lblSelectAnItemText.Visible = false;

            lblStockManagementText.Visible = true;
            lblInStockText.Visible = true;
            btnAddStock.Visible = true;
            btnAlterStock.Visible = true;
        }

        private void MakeTagsInvisible()
        {
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
    }
}
