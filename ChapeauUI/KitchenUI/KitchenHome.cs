//using ChapeauUI.Components;
using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;
using ChapeauUI.Components;
using ChapeauUI.Helpers;
using System.Windows.Forms;

namespace ChapeauUI.KitchenUI
{
    public partial class KitchenHome : Form
    {
        public KitchenHome()
        {
            InitializeComponent();
        }
        public void KitchenHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);
            kitchenOrderLayoutPanel.HorizontalScroll.Enabled = false;
            kitchenOrderLayoutPanel.HorizontalScroll.Visible = false;
        }
        private void Addpanel()
        {
            int count = kitchenOrderLayoutPanel.Controls.Count; // Get the total amount of panels
            int columns = kitchenOrderLayoutPanel.ColumnCount;
            int rows = kitchenOrderLayoutPanel.RowCount;
            int minimumRowHeight = 50; // Minimum height if no content in row

            // Calculate the next cell to add a new panel
            int nextRow = count / columns;
            int nextColumn = 0;

            // Add a new row if there is no space anymore
            if (nextRow >= rows)
            {
                kitchenOrderLayoutPanel.RowCount++;
                kitchenOrderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            KitchenBarService barService = new KitchenBarService();
            List<Order> orders = barService.GetPreviousCompletedOrders(EOrderDestination.Kitchen);
            for (int i = 0; i < orders.Count; i++)
            {
                if (nextColumn > columns) { nextColumn = 0; }
                CompleteOrderTemplate completeOrderTemplate = new CompleteOrderTemplate(orders[i]);

                // Adding the new panel to the layout
                kitchenOrderLayoutPanel.Controls.Add(completeOrderTemplate, nextColumn, nextRow);
                nextColumn++;
            }



            // Tries to keep every row to the minimum hieght that is set otherwise be dynamic 
            for (int i = 0; i < kitchenOrderLayoutPanel.RowCount; i++)
            {
                if (kitchenOrderLayoutPanel.GetRowHeights()[i] < minimumRowHeight)
                {
                    kitchenOrderLayoutPanel.RowStyles[i].Height = minimumRowHeight;
                    kitchenOrderLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                }
                else
                {
                    kitchenOrderLayoutPanel.RowStyles[i].SizeType = SizeType.AutoSize;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addpanel();
        }
    }
}
