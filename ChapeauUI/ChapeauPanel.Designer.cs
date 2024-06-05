namespace ChapeauUI
{
    partial class ChapeauPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderButton = new Button();
            kitchenButton = new Button();
            barOverview = new Button();
            managementStockButton = new Button();
            managementMenuButton = new Button();
            managementIncomeButton = new Button();
            managementEmployeeButton = new Button();
            SuspendLayout();
            // 
            // orderButton
            // 
            orderButton.Location = new Point(10, 10);
            orderButton.Margin = new Padding(2, 2, 2, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(120, 60);
            orderButton.TabIndex = 0;
            orderButton.Text = "Ordering";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // kitchenButton
            // 
            kitchenButton.Location = new Point(134, 10);
            kitchenButton.Margin = new Padding(2, 2, 2, 2);
            kitchenButton.Name = "kitchenButton";
            kitchenButton.Size = new Size(120, 60);
            kitchenButton.TabIndex = 1;
            kitchenButton.Text = "Kitchen overview";
            kitchenButton.UseVisualStyleBackColor = true;
            kitchenButton.Click += kitchenButton_Click;
            // 
            // barOverview
            // 
            barOverview.Location = new Point(259, 10);
            barOverview.Margin = new Padding(2, 2, 2, 2);
            barOverview.Name = "barOverview";
            barOverview.Size = new Size(120, 60);
            barOverview.TabIndex = 2;
            barOverview.Text = "Bar overview";
            barOverview.UseVisualStyleBackColor = true;
            barOverview.Click += barOverview_Click;
            // 
            // managementStockButton
            // 
            managementStockButton.Location = new Point(384, 10);
            managementStockButton.Margin = new Padding(2, 2, 2, 2);
            managementStockButton.Name = "managementStockButton";
            managementStockButton.Size = new Size(120, 60);
            managementStockButton.TabIndex = 3;
            managementStockButton.Text = "Management: Stock";
            managementStockButton.UseVisualStyleBackColor = true;
            managementStockButton.Click += managementStockButton_Click;
            // 
            // managementMenuButton
            // 
            managementMenuButton.Location = new Point(509, 10);
            managementMenuButton.Margin = new Padding(2, 2, 2, 2);
            managementMenuButton.Name = "managementMenuButton";
            managementMenuButton.Size = new Size(120, 60);
            managementMenuButton.TabIndex = 4;
            managementMenuButton.Text = "Management: Menu";
            managementMenuButton.UseVisualStyleBackColor = true;
            managementMenuButton.Click += managementMenuButton_Click;
            // 
            // managementIncomeButton
            // 
            managementIncomeButton.Location = new Point(634, 10);
            managementIncomeButton.Margin = new Padding(2, 2, 2, 2);
            managementIncomeButton.Name = "managementIncomeButton";
            managementIncomeButton.Size = new Size(120, 60);
            managementIncomeButton.TabIndex = 5;
            managementIncomeButton.Text = "Management: Income";
            managementIncomeButton.UseVisualStyleBackColor = true;
            managementIncomeButton.Click += managementIncomeButton_Click;
            // 
            // managementEmployeeButton
            // 
            managementEmployeeButton.Location = new Point(758, 10);
            managementEmployeeButton.Margin = new Padding(2);
            managementEmployeeButton.Name = "managementEmployeeButton";
            managementEmployeeButton.Size = new Size(120, 60);
            managementEmployeeButton.TabIndex = 5;
            managementEmployeeButton.Text = "Management: Employees";
            managementEmployeeButton.UseVisualStyleBackColor = true;
            managementEmployeeButton.Click += managementEmployeeButton_Click;
            // 
            // ChapeauPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 82);
            Controls.Add(managementEmployeeButton);
            Controls.Add(managementIncomeButton);
            Controls.Add(managementMenuButton);
            Controls.Add(managementStockButton);
            Controls.Add(barOverview);
            Controls.Add(kitchenButton);
            Controls.Add(orderButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ChapeauPanel";
            Text = "Chapeau Home";
            ResumeLayout(false);
        }

        #endregion

        private Button orderButton;
        private Button kitchenButton;
        private Button barOverview;
        private Button managementStockButton;
        private Button managementMenuButton;
        private Button managementIncomeButton;
        private Button managementEmployeeButton;
    }
}
