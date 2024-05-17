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
        private readonly StockService _stockService;
        public StockManagement()
        {
            InitializeComponent();
            _stockService = new StockService();
            PopulateStock();
        }

        public void PopulateStock()
        {
            Dictionary<int, (string name, int stock)> stockData = _stockService.GetStock();

            lvStock.Items.Clear();

            foreach (var item in stockData)
            {
                ListViewItem listViewItem = new ListViewItem(item.Value.name)
                {
                    Tag = item.Key
                };
                listViewItem.SubItems.Add(item.Value.stock.ToString());

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
