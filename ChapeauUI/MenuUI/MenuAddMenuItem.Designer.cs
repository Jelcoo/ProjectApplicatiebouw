namespace ChapeauUI.MenuUI
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
            btnConfirmAddItem = new Button();
            btnCancelAddItem = new Button();
            cbItemType = new ComboBox();
            cbItemMenu = new ComboBox();
            cbItemVATRate = new ComboBox();
            inputItemDetailName = new TextBox();
            inputItemPrice = new TextBox();
            inputItemName = new TextBox();
            lblItemPrice = new Label();
            lblItemType = new Label();
            lblItemMenu = new Label();
            lblItemVATRate = new Label();
            lblItemDetailName = new Label();
            label6 = new Label();
            lblItemName = new Label();
            SuspendLayout();
            // 
            // btnConfirmAddItem
            // 
            btnConfirmAddItem.Location = new Point(504, 246);
            btnConfirmAddItem.Name = "btnConfirmAddItem";
            btnConfirmAddItem.Size = new Size(139, 63);
            btnConfirmAddItem.TabIndex = 17;
            btnConfirmAddItem.Text = "Confirm";
            btnConfirmAddItem.UseVisualStyleBackColor = true;
            btnConfirmAddItem.Click += btnConfirmAddItem_Click;
            // 
            // btnCancelAddItem
            // 
            btnCancelAddItem.Location = new Point(12, 246);
            btnCancelAddItem.Name = "btnCancelAddItem";
            btnCancelAddItem.Size = new Size(140, 63);
            btnCancelAddItem.TabIndex = 18;
            btnCancelAddItem.Text = "Cancel";
            btnCancelAddItem.UseVisualStyleBackColor = true;
            btnCancelAddItem.Click += btnCancelAddItem_Click;
            // 
            // cbItemType
            // 
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(183, 175);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(139, 28);
            cbItemType.TabIndex = 14;
            // 
            // cbItemMenu
            // 
            cbItemMenu.FormattingEnabled = true;
            cbItemMenu.Location = new Point(12, 175);
            cbItemMenu.Name = "cbItemMenu";
            cbItemMenu.Size = new Size(150, 28);
            cbItemMenu.TabIndex = 15;
            // 
            // cbItemVATRate
            // 
            cbItemVATRate.FormattingEnabled = true;
            cbItemVATRate.Location = new Point(342, 175);
            cbItemVATRate.Name = "cbItemVATRate";
            cbItemVATRate.Size = new Size(87, 28);
            cbItemVATRate.TabIndex = 16;
            // 
            // inputItemDetailName
            // 
            inputItemDetailName.Location = new Point(248, 97);
            inputItemDetailName.Name = "inputItemDetailName";
            inputItemDetailName.Size = new Size(395, 27);
            inputItemDetailName.TabIndex = 11;
            // 
            // inputItemPrice
            // 
            inputItemPrice.Location = new Point(480, 175);
            inputItemPrice.Name = "inputItemPrice";
            inputItemPrice.Size = new Size(73, 27);
            inputItemPrice.TabIndex = 12;
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(12, 97);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(226, 27);
            inputItemName.TabIndex = 13;
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(480, 152);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(41, 20);
            lblItemPrice.TabIndex = 4;
            lblItemPrice.Text = "Price";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(183, 152);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(40, 20);
            lblItemType.TabIndex = 5;
            lblItemType.Text = "Type";
            // 
            // lblItemMenu
            // 
            lblItemMenu.AutoSize = true;
            lblItemMenu.Location = new Point(12, 152);
            lblItemMenu.Name = "lblItemMenu";
            lblItemMenu.Size = new Size(46, 20);
            lblItemMenu.TabIndex = 6;
            lblItemMenu.Text = "Menu";
            // 
            // lblItemVATRate
            // 
            lblItemVATRate.AutoSize = true;
            lblItemVATRate.Location = new Point(342, 152);
            lblItemVATRate.Name = "lblItemVATRate";
            lblItemVATRate.Size = new Size(68, 20);
            lblItemVATRate.TabIndex = 7;
            lblItemVATRate.Text = "VAT Rate";
            // 
            // lblItemDetailName
            // 
            lblItemDetailName.AutoSize = true;
            lblItemDetailName.Location = new Point(248, 74);
            lblItemDetailName.Name = "lblItemDetailName";
            lblItemDetailName.Size = new Size(110, 20);
            lblItemDetailName.TabIndex = 8;
            lblItemDetailName.Text = "Detailed Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(351, 46);
            label6.TabIndex = 9;
            label6.Text = "Add New Menu Item";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 74);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(49, 20);
            lblItemName.TabIndex = 10;
            lblItemName.Text = "Name";
            // 
            // MenuAddMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 332);
            Controls.Add(btnConfirmAddItem);
            Controls.Add(btnCancelAddItem);
            Controls.Add(cbItemType);
            Controls.Add(cbItemMenu);
            Controls.Add(cbItemVATRate);
            Controls.Add(inputItemDetailName);
            Controls.Add(inputItemPrice);
            Controls.Add(inputItemName);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemType);
            Controls.Add(lblItemMenu);
            Controls.Add(lblItemVATRate);
            Controls.Add(lblItemDetailName);
            Controls.Add(label6);
            Controls.Add(lblItemName);
            Name = "MenuAddMenuItem";
            Text = "MenuAddMenuItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmAddItem;
        private Button btnCancelAddItem;
        private ComboBox cbItemType;
        private ComboBox cbItemMenu;
        private ComboBox cbItemVATRate;
        private TextBox inputItemDetailName;
        private TextBox inputItemPrice;
        private TextBox inputItemName;
        private Label lblItemPrice;
        private Label lblItemType;
        private Label lblItemMenu;
        private Label lblItemVATRate;
        private Label lblItemDetailName;
        private Label label6;
        private Label lblItemName;
    }
}