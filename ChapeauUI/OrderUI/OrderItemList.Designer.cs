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
            orderLinesBox = new RichTextBox();
            orderButton = new Button();
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
            // orderLinesBox
            // 
            orderLinesBox.BorderStyle = BorderStyle.None;
            orderLinesBox.Enabled = false;
            orderLinesBox.Location = new Point(3, 35);
            orderLinesBox.Name = "orderLinesBox";
            orderLinesBox.ReadOnly = true;
            orderLinesBox.Size = new Size(343, 676);
            orderLinesBox.TabIndex = 1;
            orderLinesBox.Text = "";
            // 
            // orderButton
            // 
            orderButton.Location = new Point(55, 740);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(239, 71);
            orderButton.TabIndex = 2;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // OrderItemList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderButton);
            Controls.Add(orderLinesBox);
            Controls.Add(tableLabel);
            Name = "OrderItemList";
            Size = new Size(349, 830);
            ResumeLayout(false);
        }

        #endregion

        private Label tableLabel;
        private RichTextBox orderLinesBox;
        private Button orderButton;
    }
}
