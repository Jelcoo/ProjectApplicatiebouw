namespace ChapeauUI.OrderUI
{
    partial class OrderItemList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLabel = new Label();
            orderLinesLabel = new Label();
            SuspendLayout();
            // 
            // tableLabel
            // 
            tableLabel.Location = new Point(0, 10);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(349, 25);
            tableLabel.TabIndex = 0;
            tableLabel.Text = "Order for table #?";
            tableLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderLinesLabel
            // 
            orderLinesLabel.Location = new Point(3, 35);
            orderLinesLabel.Name = "orderLinesLabel";
            orderLinesLabel.Size = new Size(343, 676);
            orderLinesLabel.TabIndex = 1;
            orderLinesLabel.Text = "label1";
            // 
            // OrderItemList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderLinesLabel);
            Controls.Add(tableLabel);
            Name = "OrderItemList";
            Size = new Size(349, 830);
            ResumeLayout(false);
        }

        #endregion

        private Label tableLabel;
        private Label orderLinesLabel;
    }
}
