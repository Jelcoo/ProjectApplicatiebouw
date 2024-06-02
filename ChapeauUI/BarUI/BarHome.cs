using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauModel.Interfaces;
using ChapeauService;
using ChapeauUI.Components;
using ChapeauUI.Helpers;

namespace ChapeauUI.BarUI
{
    public partial class BarHome : Form, IKitchenBar
    {
        private KitchenBarService _barService = new KitchenBarService();
        public BarHome()
        {
            InitializeComponent();
        }

        private void BarHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);
            Addpanel(EOrderTime.Current);
        }
        public void Addpanel(EOrderTime orderTime)
        {
            barOrderLayoutPanel.Controls.Clear();
            int count = barOrderLayoutPanel.Controls.Count; // Get the total amount of panels
            int columns = barOrderLayoutPanel.ColumnCount;
            int rows = barOrderLayoutPanel.RowCount;

            // Calculate the next cell to add a new panel
            int nextRow = count / columns;

            // Add a new row if there is no space anymore
            if (nextRow >= rows)
            {
                barOrderLayoutPanel.RowCount++;
                barOrderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            AddOrderToPanel(columns, nextRow, orderTime);
            HeightChecker();
        }

        private void HeightChecker()
        {
            int minimumRowHeight = 50; // Minimum height if no content in row

            // Tries to keep every row to the minimum hieght that is set otherwise be dynamic 
            for (int i = 0; i < barOrderLayoutPanel.RowCount; i++)
            {
                if (barOrderLayoutPanel.GetRowHeights()[i] < minimumRowHeight)
                {
                    barOrderLayoutPanel.RowStyles[i].Height = minimumRowHeight;
                    barOrderLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                }
                else
                {
                    barOrderLayoutPanel.RowStyles[i].SizeType = SizeType.AutoSize;
                }
            }
        }
        private void AddOrderToPanel(int columns, int nextRow, EOrderTime orderTime)
        {
            int nextColumn = 0;
            List<Order> orders;
            if (orderTime == EOrderTime.Current)
            {
                orders = _barService.GetOrdersInOrder(EOrderDestination.Bar);
            }
            else
            {
                orders = _barService.GetPreviousCompletedOrders(EOrderDestination.Bar);
            }

            for (int i = 0; i < orders.Count; i++)
            {
                if (nextColumn > columns) { nextColumn = 0; }
                CompleteOrderTemplate completeOrderTemplate = new CompleteOrderTemplate(orders[i], orderTime, this);
                if (completeOrderTemplate.ChecklistCount == 0) continue;

                // Adding the new panel to the layout
                barOrderLayoutPanel.Controls.Add(completeOrderTemplate, nextColumn, nextRow);
                nextColumn++;
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Addpanel(EOrderTime.InThePast);
        }

        private void currentOrderButton_Click(object sender, EventArgs e)
        {
            Addpanel(EOrderTime.Current);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }
    }
}
