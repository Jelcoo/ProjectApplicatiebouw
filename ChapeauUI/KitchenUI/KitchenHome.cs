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
            int nextColumn = count % columns;

            // Add a new row if there is no space anymore
            if (nextRow >= rows)
            {
                kitchenOrderLayoutPanel.RowCount++;
                kitchenOrderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Create a new panel with random height to test
            Panel newPanel = new Panel();
            newPanel.Size = new Size(100, new Random().Next(100, 200));
            newPanel.BackColor = Color.Red;

            // Adding the new panel to the layout
            kitchenOrderLayoutPanel.Controls.Add(newPanel, nextColumn, nextRow);

            // color randomizer to differentiate between columns and rows
            switch (count % 4)
            {
                case 0:
                    newPanel.BackColor = Color.Red;
                    break;
                case 1:
                    newPanel.BackColor = Color.Green;
                    break;
                case 2:
                    newPanel.BackColor = Color.Blue;
                    break;
                case 3:
                    newPanel.BackColor = Color.Yellow;
                    break;
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
