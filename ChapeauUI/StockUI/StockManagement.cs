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
            Dictionary<Stock, string> stockData = _stockService.GetStock();

            lvStock.Items.Clear();

            foreach (var item in stockData)
            {
                ListViewItem listViewItem = new ListViewItem(item.Value)
                {
                    Tag = item.Key.MenuItemId
                };
                ListViewItem.ListViewSubItem stockAmountSubItem = new ListViewItem.ListViewSubItem
                {
                    Text = item.Key.StockCount.ToString(),
                    Tag = item.Key.StockId
                };

                listViewItem.SubItems.Add(stockAmountSubItem);
                lvStock.Items.Add(listViewItem);
            }

            lvStock.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
