namespace ChapeauUI.StockUI
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
            label6 = new Label();
            lblItemName = new Label();
            lblItemDetailName = new Label();
            lblItemPrice = new Label();
            inputItemName = new TextBox();
            inputItemPrice = new TextBox();
            inputItemDetailName = new TextBox();
            cbItemVATRate = new ComboBox();
            cbItemMenu = new ComboBox();
            cbItemType = new ComboBox();
            btnCancelAddItem = new Button();
            btnConfirmChangeItem = new Button();
            lblItemType = new Label();
            lblItemMenu = new Label();
            brnCancelChangeStock = new Button();
            lblItemVATRate = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(323, 46);
            label6.TabIndex = 0;
            label6.Text = "Change Menu Item";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 66);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(49, 20);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Name";
            // 
            // lblItemDetailName
            // 
            lblItemDetailName.AutoSize = true;
            lblItemDetailName.Location = new Point(248, 66);
            lblItemDetailName.Name = "lblItemDetailName";
            lblItemDetailName.Size = new Size(110, 20);
            lblItemDetailName.TabIndex = 0;
            lblItemDetailName.Text = "Detailed Name";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(481, 182);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(41, 20);
            lblItemPrice.TabIndex = 0;
            lblItemPrice.Text = "Price";
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(12, 104);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(226, 27);
            inputItemName.TabIndex = 1;
            // 
            // inputItemPrice
            // 
            inputItemPrice.Location = new Point(481, 219);
            inputItemPrice.Name = "inputItemPrice";
            inputItemPrice.Size = new Size(73, 27);
            inputItemPrice.TabIndex = 1;
            // 
            // inputItemDetailName
            // 
            inputItemDetailName.Location = new Point(248, 104);
            inputItemDetailName.Name = "inputItemDetailName";
            inputItemDetailName.Size = new Size(485, 27);
            inputItemDetailName.TabIndex = 1;
            // 
            // cbItemVATRate
            // 
            cbItemVATRate.FormattingEnabled = true;
            cbItemVATRate.Location = new Point(343, 219);
            cbItemVATRate.Name = "cbItemVATRate";
            cbItemVATRate.Size = new Size(87, 28);
            cbItemVATRate.TabIndex = 2;
            // 
            // cbItemMenu
            // 
            cbItemMenu.FormattingEnabled = true;
            cbItemMenu.Location = new Point(13, 219);
            cbItemMenu.Name = "cbItemMenu";
            cbItemMenu.Size = new Size(150, 28);
            cbItemMenu.TabIndex = 2;
            // 
            // cbItemType
            // 
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(184, 219);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(139, 28);
            cbItemType.TabIndex = 2;
            // 
            // btnCancelAddItem
            // 
            btnCancelAddItem.Location = new Point(0, 0);
            btnCancelAddItem.Name = "btnCancelAddItem";
            btnCancelAddItem.Size = new Size(75, 23);
            btnCancelAddItem.TabIndex = 6;
            // 
            // btnConfirmChangeItem
            // 
            btnConfirmChangeItem.Location = new Point(594, 300);
            btnConfirmChangeItem.Name = "btnConfirmChangeItem";
            btnConfirmChangeItem.Size = new Size(139, 63);
            btnConfirmChangeItem.TabIndex = 3;
            btnConfirmChangeItem.Text = "Confirm";
            btnConfirmChangeItem.UseVisualStyleBackColor = true;
            btnConfirmChangeItem.Click += btnConfirmChangeItem_Click;
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(184, 182);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(40, 20);
            lblItemType.TabIndex = 4;
            lblItemType.Text = "Type";
            // 
            // lblItemMenu
            // 
            lblItemMenu.AutoSize = true;
            lblItemMenu.Location = new Point(13, 182);
            lblItemMenu.Name = "lblItemMenu";
            lblItemMenu.Size = new Size(46, 20);
            lblItemMenu.TabIndex = 5;
            lblItemMenu.Text = "Menu";
            // 
            // brnCancelChangeStock
            // 
            brnCancelChangeStock.Location = new Point(13, 300);
            brnCancelChangeStock.Name = "brnCancelChangeStock";
            brnCancelChangeStock.Size = new Size(139, 63);
            brnCancelChangeStock.TabIndex = 3;
            brnCancelChangeStock.Text = "Cancel";
            brnCancelChangeStock.UseVisualStyleBackColor = true;
            brnCancelChangeStock.Click += btnCancelChangeItem_Click;
            // 
            // lblItemVATRate
            // 
            lblItemVATRate.AutoSize = true;
            lblItemVATRate.Location = new Point(344, 177);
            lblItemVATRate.Name = "lblItemVATRate";
            lblItemVATRate.Size = new Size(68, 20);
            lblItemVATRate.TabIndex = 7;
            lblItemVATRate.Text = "VAT Rate";
            // 
            // MenuChangeMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 375);
            Controls.Add(lblItemVATRate);
            Controls.Add(lblItemType);
            Controls.Add(lblItemMenu);
            Controls.Add(brnCancelChangeStock);
            Controls.Add(btnConfirmChangeItem);
            Controls.Add(label6);
            Controls.Add(btnCancelAddItem);
            Controls.Add(inputItemDetailName);
            Controls.Add(cbItemType);
            Controls.Add(cbItemMenu);
            Controls.Add(lblItemName);
            Controls.Add(cbItemVATRate);
            Controls.Add(lblItemDetailName);
            Controls.Add(lblItemPrice);
            Controls.Add(inputItemName);
            Controls.Add(inputItemPrice);
            Name = "MenuChangeMenuItem";
            Text = "ChangeMenuItem";
            Load += MenuChangeItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblItemName;
        private Label lblItemDetailName;
        private Label lblItemPrice;
        private TextBox inputItemName;
        private TextBox inputItemPrice;
        private TextBox inputItemDetailName;
        private ComboBox cbItemVATRate;
        private ComboBox cbItemMenu;
        private ComboBox cbItemType;
        private Button btnCancelAddItem;
        private Button btnConfirmChangeItem;
        private Label lblItemType;
        private Label lblItemMenu;
        private Button brnCancelChangeStock;
        private Label lblItemVATRate;
    }
}