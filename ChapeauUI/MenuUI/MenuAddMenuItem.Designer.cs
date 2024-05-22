namespace ChapeauUI.StockUI
{
    partial class MenuAddMenuItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblItemStock = new Label();
            lblItemName = new Label();
            lblItemDetailName = new Label();
            lblItemVATRate = new Label();
            lblItemPrice = new Label();
            label6 = new Label();
            inputItemName = new TextBox();
            inputItemDetailName = new TextBox();
            cbItemVATRate = new ComboBox();
            lblItemMenu = new Label();
            lblItemType = new Label();
            cbItemMenu = new ComboBox();
            cbItemType = new ComboBox();
            inputItemPrice = new TextBox();
            inputItemStock = new TextBox();
            btnCancelAddItem = new Button();
            btnConfirmAddItem = new Button();
            SuspendLayout();
            // 
            // lblItemStock
            // 
            lblItemStock.AutoSize = true;
            lblItemStock.Location = new Point(597, 196);
            lblItemStock.Name = "lblItemStock";
            lblItemStock.Size = new Size(45, 20);
            lblItemStock.TabIndex = 0;
            lblItemStock.Text = "Stock";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(15, 80);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(49, 20);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Name";
            // 
            // lblItemDetailName
            // 
            lblItemDetailName.AutoSize = true;
            lblItemDetailName.Location = new Point(251, 80);
            lblItemDetailName.Name = "lblItemDetailName";
            lblItemDetailName.Size = new Size(110, 20);
            lblItemDetailName.TabIndex = 0;
            lblItemDetailName.Text = "Detailed Name";
            // 
            // lblItemVATRate
            // 
            lblItemVATRate.AutoSize = true;
            lblItemVATRate.Location = new Point(346, 196);
            lblItemVATRate.Name = "lblItemVATRate";
            lblItemVATRate.Size = new Size(68, 20);
            lblItemVATRate.TabIndex = 0;
            lblItemVATRate.Text = "VAT Rate";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(484, 196);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(41, 20);
            lblItemPrice.TabIndex = 0;
            lblItemPrice.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(351, 46);
            label6.TabIndex = 0;
            label6.Text = "Add New Menu Item";
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(15, 118);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(226, 27);
            inputItemName.TabIndex = 1;
            // 
            // inputItemDetailName
            // 
            inputItemDetailName.Location = new Point(251, 118);
            inputItemDetailName.Name = "inputItemDetailName";
            inputItemDetailName.Size = new Size(485, 27);
            inputItemDetailName.TabIndex = 1;
            // 
            // cbItemVATRate
            // 
            cbItemVATRate.FormattingEnabled = true;
            cbItemVATRate.Location = new Point(346, 233);
            cbItemVATRate.Name = "cbItemVATRate";
            cbItemVATRate.Size = new Size(87, 28);
            cbItemVATRate.TabIndex = 2;
            // 
            // lblItemMenu
            // 
            lblItemMenu.AutoSize = true;
            lblItemMenu.Location = new Point(16, 196);
            lblItemMenu.Name = "lblItemMenu";
            lblItemMenu.Size = new Size(46, 20);
            lblItemMenu.TabIndex = 0;
            lblItemMenu.Text = "Menu";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(187, 196);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(40, 20);
            lblItemType.TabIndex = 0;
            lblItemType.Text = "Type";
            // 
            // cbItemMenu
            // 
            cbItemMenu.FormattingEnabled = true;
            cbItemMenu.Location = new Point(16, 233);
            cbItemMenu.Name = "cbItemMenu";
            cbItemMenu.Size = new Size(150, 28);
            cbItemMenu.TabIndex = 2;
            // 
            // cbItemType
            // 
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(187, 233);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(139, 28);
            cbItemType.TabIndex = 2;
            // 
            // inputItemPrice
            // 
            inputItemPrice.Location = new Point(484, 233);
            inputItemPrice.Name = "inputItemPrice";
            inputItemPrice.Size = new Size(73, 27);
            inputItemPrice.TabIndex = 1;
            // 
            // inputItemStock
            // 
            inputItemStock.Location = new Point(597, 233);
            inputItemStock.Name = "inputItemStock";
            inputItemStock.Size = new Size(73, 27);
            inputItemStock.TabIndex = 1;
            // 
            // btnCancelAddItem
            // 
            btnCancelAddItem.Location = new Point(15, 304);
            btnCancelAddItem.Name = "btnCancelAddItem";
            btnCancelAddItem.Size = new Size(140, 63);
            btnCancelAddItem.TabIndex = 3;
            btnCancelAddItem.Text = "Cancel";
            btnCancelAddItem.UseVisualStyleBackColor = true;
            btnCancelAddItem.Click += btnCancelAddItem_Click;
            // 
            // btnConfirmAddItem
            // 
            btnConfirmAddItem.Location = new Point(597, 304);
            btnConfirmAddItem.Name = "btnConfirmAddItem";
            btnConfirmAddItem.Size = new Size(139, 63);
            btnConfirmAddItem.TabIndex = 3;
            btnConfirmAddItem.Text = "Confirm";
            btnConfirmAddItem.UseVisualStyleBackColor = true;
            btnConfirmAddItem.Click += btnConfirmAddItem_Click;
            // 
            // MenuAddMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 379);
            Controls.Add(btnConfirmAddItem);
            Controls.Add(btnCancelAddItem);
            Controls.Add(cbItemType);
            Controls.Add(cbItemMenu);
            Controls.Add(cbItemVATRate);
            Controls.Add(inputItemDetailName);
            Controls.Add(inputItemStock);
            Controls.Add(inputItemPrice);
            Controls.Add(inputItemName);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemType);
            Controls.Add(lblItemMenu);
            Controls.Add(lblItemVATRate);
            Controls.Add(lblItemDetailName);
            Controls.Add(label6);
            Controls.Add(lblItemName);
            Controls.Add(lblItemStock);
            Name = "MenuAddMenuItem";
            Text = "AddMenuItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemStock;
        private Label lblItemName;
        private Label lblItemDetailName;
        private Label lblItemVATRate;
        private Label lblItemPrice;
        private Label label6;
        private TextBox inputItemName;
        private TextBox inputItemDetailName;
        private ComboBox cbItemVATRate;
        private Label lblItemMenu;
        private Label lblItemType;
        private ComboBox cbItemMenu;
        private ComboBox cbItemType;
        private TextBox inputItemPrice;
        private TextBox inputItemStock;
        private Button btnCancelAddItem;
        private Button btnConfirmAddItem;
    }
}