﻿namespace ChapeauUI.MenuUI
{
    partial class MenuChangeMenuItem
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
            lblItemName = new Label();
            lblChangeMenuItemText = new Label();
            SuspendLayout();
            // 
            // btnConfirmAddItem
            // 
            btnConfirmAddItem.Location = new Point(504, 252);
            btnConfirmAddItem.Name = "btnConfirmAddItem";
            btnConfirmAddItem.Size = new Size(139, 63);
            btnConfirmAddItem.TabIndex = 46;
            btnConfirmAddItem.Text = "Confirm";
            btnConfirmAddItem.UseVisualStyleBackColor = true;
            btnConfirmAddItem.Click += btnConfirmChangeItem_Click;
            // 
            // btnCancelAddItem
            // 
            btnCancelAddItem.Location = new Point(12, 252);
            btnCancelAddItem.Name = "btnCancelAddItem";
            btnCancelAddItem.Size = new Size(140, 63);
            btnCancelAddItem.TabIndex = 47;
            btnCancelAddItem.Text = "Cancel";
            btnCancelAddItem.UseVisualStyleBackColor = true;
            btnCancelAddItem.Click += btnCancelChangeItem_Click;
            // 
            // cbItemType
            // 
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(183, 181);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(139, 28);
            cbItemType.TabIndex = 43;
            // 
            // cbItemMenu
            // 
            cbItemMenu.FormattingEnabled = true;
            cbItemMenu.Location = new Point(12, 181);
            cbItemMenu.Name = "cbItemMenu";
            cbItemMenu.Size = new Size(150, 28);
            cbItemMenu.TabIndex = 44;
            // 
            // cbItemVATRate
            // 
            cbItemVATRate.FormattingEnabled = true;
            cbItemVATRate.Location = new Point(342, 181);
            cbItemVATRate.Name = "cbItemVATRate";
            cbItemVATRate.Size = new Size(87, 28);
            cbItemVATRate.TabIndex = 45;
            // 
            // inputItemDetailName
            // 
            inputItemDetailName.Location = new Point(248, 103);
            inputItemDetailName.Name = "inputItemDetailName";
            inputItemDetailName.Size = new Size(395, 27);
            inputItemDetailName.TabIndex = 40;
            // 
            // inputItemPrice
            // 
            inputItemPrice.Location = new Point(480, 181);
            inputItemPrice.Name = "inputItemPrice";
            inputItemPrice.Size = new Size(73, 27);
            inputItemPrice.TabIndex = 41;
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(12, 103);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(226, 27);
            inputItemName.TabIndex = 42;
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(480, 158);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(41, 20);
            lblItemPrice.TabIndex = 34;
            lblItemPrice.Text = "Price";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(183, 158);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(40, 20);
            lblItemType.TabIndex = 35;
            lblItemType.Text = "Type";
            // 
            // lblItemMenu
            // 
            lblItemMenu.AutoSize = true;
            lblItemMenu.Location = new Point(12, 158);
            lblItemMenu.Name = "lblItemMenu";
            lblItemMenu.Size = new Size(46, 20);
            lblItemMenu.TabIndex = 36;
            lblItemMenu.Text = "Menu";
            // 
            // lblItemVATRate
            // 
            lblItemVATRate.AutoSize = true;
            lblItemVATRate.Location = new Point(342, 158);
            lblItemVATRate.Name = "lblItemVATRate";
            lblItemVATRate.Size = new Size(68, 20);
            lblItemVATRate.TabIndex = 37;
            lblItemVATRate.Text = "VAT Rate";
            // 
            // lblItemDetailName
            // 
            lblItemDetailName.AutoSize = true;
            lblItemDetailName.Location = new Point(248, 80);
            lblItemDetailName.Name = "lblItemDetailName";
            lblItemDetailName.Size = new Size(110, 20);
            lblItemDetailName.TabIndex = 38;
            lblItemDetailName.Text = "Detailed Name";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 80);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(49, 20);
            lblItemName.TabIndex = 39;
            lblItemName.Text = "Name";
            // 
            // lblChangeMenuItemText
            // 
            lblChangeMenuItemText.AutoSize = true;
            lblChangeMenuItemText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangeMenuItemText.Location = new Point(12, 9);
            lblChangeMenuItemText.Name = "lblChangeMenuItemText";
            lblChangeMenuItemText.Size = new Size(323, 46);
            lblChangeMenuItemText.TabIndex = 33;
            lblChangeMenuItemText.Text = "Change Menu Item";
            // 
            // MenuChangeMenuItem
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
            Controls.Add(lblItemName);
            Controls.Add(lblChangeMenuItemText);
            Name = "MenuChangeMenuItem";
            Text = "Change Menu item";
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
        private Label lblItemName;
        private Label lblChangeMenuItemText;
    }
}