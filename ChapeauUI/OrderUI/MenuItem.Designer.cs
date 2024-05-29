namespace ChapeauUI.OrderUI
{
    partial class MenuItem
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
            itemName = new Label();
            price = new Label();
            stock = new Label();
            specifyButton = new Components.RoundedButton();
            addButton = new Components.RoundedButton();
            SuspendLayout();
            // 
            // itemName
            // 
            itemName.Location = new Point(41, 0);
            itemName.Name = "itemName";
            itemName.Size = new Size(154, 65);
            itemName.TabIndex = 0;
            itemName.Text = "itemName";
            itemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(41, 90);
            price.Name = "price";
            price.Size = new Size(50, 25);
            price.TabIndex = 1;
            price.Text = "price";
            price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(41, 65);
            stock.Name = "stock";
            stock.Size = new Size(54, 25);
            stock.TabIndex = 2;
            stock.Text = "stock";
            stock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // specifyButton
            // 
            specifyButton.BackColor = Color.FromArgb(204, 227, 222);
            specifyButton.BorderColor = Color.Black;
            specifyButton.BorderRadius = 5;
            specifyButton.BorderWidth = 5;
            specifyButton.Cursor = Cursors.Hand;
            specifyButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            specifyButton.HasBorder = false;
            specifyButton.Location = new Point(41, 118);
            specifyButton.Name = "specifyButton";
            specifyButton.Size = new Size(154, 45);
            specifyButton.TabIndex = 0;
            specifyButton.Text = "Specify";
            specifyButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(164, 195, 178);
            addButton.BorderColor = Color.Black;
            addButton.BorderRadius = 5;
            addButton.BorderWidth = 5;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.HasBorder = false;
            addButton.Location = new Point(41, 170);
            addButton.Name = "addButton";
            addButton.Size = new Size(154, 45);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 244, 244);
            Controls.Add(specifyButton);
            Controls.Add(addButton);
            Controls.Add(stock);
            Controls.Add(price);
            Controls.Add(itemName);
            Name = "MenuItem";
            Size = new Size(240, 218);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemName;
        private Label price;
        private Label stock;
        private Components.RoundedButton specifyButton;
        private Components.RoundedButton addButton;
    }
}
