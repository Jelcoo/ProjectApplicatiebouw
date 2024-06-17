namespace ChapeauUI.StockUI
{
    partial class StockAddDelivery
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
            lblMenuItemStock = new Label();
            lblInStockText = new Label();
            lblMenuItemName = new Label();
            InputAddStock = new TextBox();
            lblHowMuchIsDelivered = new Label();
            cbQuantifiers = new ComboBox();
            label1 = new Label();
            lblTotal = new Label();
            btnDeliveryConfirm = new Button();
            btnDeliveryCancel = new Button();
            lblStockId = new Label();
            SuspendLayout();
            // 
            // lblMenuItemStock
            // 
            lblMenuItemStock.AutoSize = true;
            lblMenuItemStock.Location = new Point(137, 110);
            lblMenuItemStock.MinimumSize = new Size(200, 30);
            lblMenuItemStock.Name = "lblMenuItemStock";
            lblMenuItemStock.Size = new Size(200, 30);
            lblMenuItemStock.TabIndex = 12;
            lblMenuItemStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInStockText
            // 
            lblInStockText.AutoSize = true;
            lblInStockText.Location = new Point(137, 90);
            lblInStockText.MinimumSize = new Size(200, 0);
            lblInStockText.Name = "lblInStockText";
            lblInStockText.Size = new Size(200, 20);
            lblInStockText.TabIndex = 11;
            lblInStockText.Text = "Current Stock:";
            lblInStockText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenuItemName
            // 
            lblMenuItemName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItemName.Location = new Point(137, 40);
            lblMenuItemName.MaximumSize = new Size(500, 500);
            lblMenuItemName.MinimumSize = new Size(200, 50);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(200, 50);
            lblMenuItemName.TabIndex = 9;
            lblMenuItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputAddStock
            // 
            InputAddStock.Location = new Point(276, 227);
            InputAddStock.Name = "InputAddStock";
            InputAddStock.Size = new Size(132, 27);
            InputAddStock.TabIndex = 14;
            InputAddStock.TextChanged += InputAddStock_TextChanged;
            InputAddStock.KeyPress += InputAddStock_KeyPress;
            // 
            // lblHowMuchIsDelivered
            // 
            lblHowMuchIsDelivered.AutoSize = true;
            lblHowMuchIsDelivered.Location = new Point(47, 234);
            lblHowMuchIsDelivered.MinimumSize = new Size(200, 0);
            lblHowMuchIsDelivered.Name = "lblHowMuchIsDelivered";
            lblHowMuchIsDelivered.Size = new Size(200, 20);
            lblHowMuchIsDelivered.TabIndex = 11;
            lblHowMuchIsDelivered.Text = "How much is delivered?";
            lblHowMuchIsDelivered.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbQuantifiers
            // 
            cbQuantifiers.FormattingEnabled = true;
            cbQuantifiers.Location = new Point(160, 157);
            cbQuantifiers.Name = "cbQuantifiers";
            cbQuantifiers.Size = new Size(153, 28);
            cbQuantifiers.TabIndex = 15;
            cbQuantifiers.Text = "Select a Quantifier";
            cbQuantifiers.SelectedIndexChanged += cbQuantifiers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 284);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 16;
            label1.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(276, 284);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "0";
            // 
            // btnDeliveryConfirm
            // 
            btnDeliveryConfirm.Location = new Point(328, 316);
            btnDeliveryConfirm.Name = "btnDeliveryConfirm";
            btnDeliveryConfirm.Size = new Size(135, 34);
            btnDeliveryConfirm.TabIndex = 18;
            btnDeliveryConfirm.Text = "Confirm";
            btnDeliveryConfirm.UseVisualStyleBackColor = true;
            btnDeliveryConfirm.Click += btnDeliveryConfirm_Click;
            // 
            // btnDeliveryCancel
            // 
            btnDeliveryCancel.Location = new Point(12, 316);
            btnDeliveryCancel.Name = "btnDeliveryCancel";
            btnDeliveryCancel.Size = new Size(135, 34);
            btnDeliveryCancel.TabIndex = 18;
            btnDeliveryCancel.Text = "Cancel";
            btnDeliveryCancel.UseVisualStyleBackColor = true;
            btnDeliveryCancel.Click += btnDeliveryCancel_Click;
            // 
            // lblStockId
            // 
            lblStockId.AutoSize = true;
            lblStockId.Location = new Point(425, 45);
            lblStockId.Name = "lblStockId";
            lblStockId.Size = new Size(0, 20);
            lblStockId.TabIndex = 19;
            lblStockId.Visible = false;
            // 
            // StockAddDelivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 362);
            Controls.Add(lblStockId);
            Controls.Add(btnDeliveryCancel);
            Controls.Add(btnDeliveryConfirm);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(cbQuantifiers);
            Controls.Add(InputAddStock);
            Controls.Add(lblMenuItemStock);
            Controls.Add(lblHowMuchIsDelivered);
            Controls.Add(lblInStockText);
            Controls.Add(lblMenuItemName);
            Name = "StockAddDelivery";
            Text = "StockAddDelivery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMenuItemStock;
        private Label lblInStockText;
        private Label lblMenuItemName;
        private TextBox InputAddStock;
        private Label lblHowMuchIsDelivered;
        private ComboBox cbQuantifiers;
        private Label label1;
        private Label lblTotal;
        private Button btnDeliveryConfirm;
        private Button btnDeliveryCancel;
        private Label lblStockId;
    }
}