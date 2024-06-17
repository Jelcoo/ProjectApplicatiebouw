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

        // used for stockImage
        private int DefaultNoImageId;

        public StockManagement()
        {
            InitializeComponent();

            _stockService = new StockService();

            // 0 stands for NoId, corresponds to NoImage image
            DefaultNoImageId = 0;

            PopulateStock();
        }

        private void PopulateStock()
        {
            try
            {
                // Asks all MenuItems with Stock from stockService
                List<MenuItem> stockData = _stockService.GetStock();

                // Clears previous data
                lvStock.Items.Clear();

                // Sets the name, stockCount and Status for each MenuItem
                foreach (MenuItem item in stockData)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Name);
                    listViewItem.SubItems.Add(item.Stock.Count.ToString());

                    // Sets the Status of the stock
                    listViewItem.SubItems.Add(GiveStatus(item.Stock.Count));

                    //Sets the whole item as the tag
                    listViewItem.Tag = item;

                    lvStock.Items.Add(listViewItem);
                }

                //Auto resizes the column that contains the name
                lvStock.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count > 0)
            {
                // Sets the SelectedMenuItem
                SelectedMenuItem = (MenuItem)lvStock.SelectedItems[0].Tag;

                SetTags();
                MakeTagsVisible();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            // Opens new delivery form. Adds SelectedMenuItem and parentForm
            StockAddDelivery addDeliveryForm = new StockAddDelivery(SelectedMenuItem, this);
            addDeliveryForm.ShowDialog();
        }

        private void btnAlterStock_Click(object sender, EventArgs e)
        {
            // Opens new alter stock form. Adds SelectedMenuItem and parentForm
            StockAlterStock alterStockForm = new StockAlterStock(SelectedMenuItem, this);
            alterStockForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Back to ChapeauPanel
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }

        private void SetItemImage(int id)
        {
            // Gets Image Path
            string imagePath = GetImagePath(id);

            //Checks if file exists
            if (File.Exists(imagePath))
            {
                // tries to set the image
                try
                {
                    pbItemImage.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    //Fails, sets the image to NoImage
                    SetToNoImage();

                    throw new Exception($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                // Image doesnt exist, sets image to NoImage
                SetToNoImage();
            }
        }

        private void SetToNoImage()
        {
            // Sets the image to NoImage with Id DefaultNoImageId
            pbItemImage.Image = Image.FromFile(GetImagePath(DefaultNoImageId));
        }

        private string GetImagePath(int id)
        {
            //Gets the baseDirectory
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            
            //Combines base with Resources location
            string imagesDirectory = Path.Combine(baseDirectory, @"..\..\..\Resources\StockImages");

            //Combines path with id
            //Only Allows png
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
            // Returns the status depending on the stock
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
            // Sets the MenuItem data to labels
            lblMenuItemName.Text = SelectedMenuItem.Name;
            lblMenuItemDetail.Text = SelectedMenuItem.DetailName;
            lblMenuItemStock.Text = SelectedMenuItem.Stock.Count.ToString();

            // Trys to set the image
            try
            {
                SetItemImage(SelectedMenuItem.MenuItemId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            // Removes all data from labels
            lblMenuItemName.Text = string.Empty;
            lblMenuItemDetail.Text = string.Empty;
            lblMenuItemStock.Text = string.Empty;
            pbItemImage.Image = null;

            lblSelectAnItemText.Visible = true;
        }
    }
}
