namespace ChapeauUI.StockUI
{
    partial class StockAlterStock
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
            btnAlterCancel = new Button();
            btnAlterConfirm = new Button();
            lblTotal = new Label();
            lblTotalText = new Label();
            cbQuantifiers = new ComboBox();
            InputAddStock = new TextBox();
            lblMenuItemStock = new Label();
            lblHowMuchIsDelivered = new Label();
            lblInStockText = new Label();
            lblMenuItemName = new Label();
            SuspendLayout();
            // 
            // btnAlterCancel
            // 
            btnAlterCancel.Location = new Point(12, 307);
            btnAlterCancel.Name = "btnAlterCancel";
            btnAlterCancel.Size = new Size(135, 34);
            btnAlterCancel.TabIndex = 28;
            btnAlterCancel.Text = "Cancel";
            btnAlterCancel.UseVisualStyleBackColor = true;
            btnAlterCancel.Click += btnAlterCancel_Click;
            // 
            // btnAlterConfirm
            // 
            btnAlterConfirm.Location = new Point(328, 307);
            btnAlterConfirm.Name = "btnAlterConfirm";
            btnAlterConfirm.Size = new Size(135, 34);
            btnAlterConfirm.TabIndex = 29;
            btnAlterConfirm.Text = "Confirm";
            btnAlterConfirm.UseVisualStyleBackColor = true;
            btnAlterConfirm.Click += btnAlterConfirm_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(276, 275);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 27;
            lblTotal.Text = "0";
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalText.Location = new Point(178, 275);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(48, 20);
            lblTotalText.TabIndex = 26;
            lblTotalText.Text = "Total:";
            // 
            // cbQuantifiers
            // 
            cbQuantifiers.FormattingEnabled = true;
            cbQuantifiers.Location = new Point(160, 148);
            cbQuantifiers.Name = "cbQuantifiers";
            cbQuantifiers.Size = new Size(153, 28);
            cbQuantifiers.TabIndex = 25;
            cbQuantifiers.Text = "Select a Quantifier";
            cbQuantifiers.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // InputAddStock
            // 
            InputAddStock.Location = new Point(276, 218);
            InputAddStock.Name = "InputAddStock";
            InputAddStock.Size = new Size(132, 27);
            InputAddStock.TabIndex = 24;
            InputAddStock.TextChanged += InputAddStock_TextChanged;
            InputAddStock.KeyPress += InputAddStock_KeyPress;
            // 
            // lblMenuItemStock
            // 
            lblMenuItemStock.AutoSize = true;
            lblMenuItemStock.Location = new Point(137, 101);
            lblMenuItemStock.MinimumSize = new Size(200, 30);
            lblMenuItemStock.Name = "lblMenuItemStock";
            lblMenuItemStock.Size = new Size(200, 30);
            lblMenuItemStock.TabIndex = 23;
            lblMenuItemStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHowMuchIsDelivered
            // 
            lblHowMuchIsDelivered.AutoSize = true;
            lblHowMuchIsDelivered.Location = new Point(47, 225);
            lblHowMuchIsDelivered.MinimumSize = new Size(200, 0);
            lblHowMuchIsDelivered.Name = "lblHowMuchIsDelivered";
            lblHowMuchIsDelivered.Size = new Size(200, 20);
            lblHowMuchIsDelivered.TabIndex = 21;
            lblHowMuchIsDelivered.Text = "What is the new stock?";
            lblHowMuchIsDelivered.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInStockText
            // 
            lblInStockText.AutoSize = true;
            lblInStockText.Location = new Point(137, 81);
            lblInStockText.MinimumSize = new Size(200, 0);
            lblInStockText.Name = "lblInStockText";
            lblInStockText.Size = new Size(200, 20);
            lblInStockText.TabIndex = 22;
            lblInStockText.Text = "Current Stock:";
            lblInStockText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenuItemName
            // 
            lblMenuItemName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItemName.Location = new Point(137, 31);
            lblMenuItemName.MaximumSize = new Size(500, 500);
            lblMenuItemName.MinimumSize = new Size(200, 50);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(200, 50);
            lblMenuItemName.TabIndex = 20;
            lblMenuItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockAlterStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 362);
            Controls.Add(btnAlterCancel);
            Controls.Add(btnAlterConfirm);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalText);
            Controls.Add(cbQuantifiers);
            Controls.Add(InputAddStock);
            Controls.Add(lblMenuItemStock);
            Controls.Add(lblHowMuchIsDelivered);
            Controls.Add(lblInStockText);
            Controls.Add(lblMenuItemName);
            Name = "StockAlterStock";
            Text = "Alter Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAlterCancel;
        private Button btnAlterConfirm;
        private Label lblTotal;
        private Label lblTotalText;
        private ComboBox cbQuantifiers;
        private TextBox InputAddStock;
        private Label lblMenuItemStock;
        private Label lblHowMuchIsDelivered;
        private Label lblInStockText;
        private Label lblMenuItemName;
    }
}