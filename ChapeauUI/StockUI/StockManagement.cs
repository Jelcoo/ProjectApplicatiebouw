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
            List<StockDisplayItem> stockData = _stockService.GetStock();

            lvStock.Items.Clear();

            foreach (StockDisplayItem item in stockData)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName)
                {
                    Tag = item.MenuItemId
                };
                ListViewItem.ListViewSubItem stockAmountSubItem = new ListViewItem.ListViewSubItem
                {
                    Text = item.StockCount.ToString(),
                    Tag = item.StockId
                };

                listViewItem.SubItems.Add(stockAmountSubItem);
                lvStock.Items.Add(listViewItem);
            }

            lvStock.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new StockAddItem().ShowDialog();
        }
    }
}
