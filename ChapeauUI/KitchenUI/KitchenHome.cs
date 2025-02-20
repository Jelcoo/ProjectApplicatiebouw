﻿using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauModel.Interfaces;
using ChapeauService;
using ChapeauUI.Components;
using ChapeauUI.Helpers;

namespace ChapeauUI.KitchenUI
{
    public partial class KitchenHome : Form, IKitchenBar
    {
        private KitchenBarService _kitchenService = new KitchenBarService();
        public KitchenHome()
        {
            InitializeComponent();
        }
        public void KitchenHome_Load(object sender, EventArgs e)
        {
            dateTimeLabel.Text = GenericHelpers.FormatDateTime(DateTime.Now);
            Addpanel(EOrderTime.Current);
        }
        public void Addpanel(EOrderTime orderTime)
        {
            try
            {
                kitchenOrderLayoutPanel.Controls.Clear();
                int count = kitchenOrderLayoutPanel.Controls.Count; // Get the total amount of panels
                int columns = kitchenOrderLayoutPanel.ColumnCount;
                int rows = kitchenOrderLayoutPanel.RowCount;

                // Calculate the next cell to add a new panel
                int nextRow = count / columns;

                // Add a new row if there is no space anymore
                if (nextRow >= rows)
                {
                    kitchenOrderLayoutPanel.RowCount++;
                    kitchenOrderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                AddOrderToPanel(columns, nextRow, orderTime);
                HeightChecker();
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void HeightChecker()
        {
            int minimumRowHeight = 50; // Minimum height if no content in row

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
        private void AddOrderToPanel(int columns, int nextRow, EOrderTime orderTime)
        {
            int nextColumn = 0;
            List<Order> orders;
            if (orderTime == EOrderTime.Current)
            {
                orders = _kitchenService.GetOrdersInOrder(EOrderDestination.Kitchen);
            }
            else
            {
                orders = _kitchenService.GetPreviousCompletedOrders(EOrderDestination.Kitchen);
            }

            for (int i = 0; i < orders.Count; i++)
            {
                if (nextColumn > columns) { nextColumn = 0; }
                CompleteOrderTemplate completeOrderTemplate = new CompleteOrderTemplate(orders[i], orderTime, this);
                if (completeOrderTemplate.ChecklistCount == 0) continue;
                // Adding the new panel to the layout
                kitchenOrderLayoutPanel.Controls.Add(completeOrderTemplate, nextColumn, nextRow);
                nextColumn++;
            }
        }

        private void CompletedOrderButton_Click(object sender, EventArgs e)
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
