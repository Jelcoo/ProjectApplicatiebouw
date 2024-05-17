namespace ChapeauUI.StockUI
{
    partial class StockManagement
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
            lvStock = new ListView();
            ItemName = new ColumnHeader();
            ItemStock = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnAddItem = new Button();
            btnChangeItem = new Button();
            btnDeleteItem = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lvStock
            // 
            lvStock.Columns.AddRange(new ColumnHeader[] { ItemName, ItemStock });
            lvStock.Location = new Point(12, 55);
            lvStock.Name = "lvStock";
            lvStock.Size = new Size(375, 368);
            lvStock.TabIndex = 0;
            lvStock.UseCompatibleStateImageBehavior = false;
            lvStock.View = View.Details;
            // 
            // ItemName
            // 
            ItemName.Text = "Name";
            // 
            // ItemStock
            // 
            ItemStock.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 69);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 237);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Stock Management";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(403, 102);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 48);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnChangeItem
            // 
            btnChangeItem.Location = new Point(503, 102);
            btnChangeItem.Name = "btnChangeItem";
            btnChangeItem.Size = new Size(94, 48);
            btnChangeItem.TabIndex = 2;
            btnChangeItem.Text = "Change";
            btnChangeItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(603, 102);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(94, 48);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(403, 271);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 2;
            button1.Text = "Add Stock Delivery";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(403, 338);
            button2.Name = "button2";
            button2.Size = new Size(194, 48);
            button2.TabIndex = 2;
            button2.Text = "Alter Stock";
            button2.UseVisualStyleBackColor = true;
            // 
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnChangeItem);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAddItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvStock);
            Name = "StockManagement";
            Text = "StockManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStock;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
        private Label label1;
        private Label label2;
        private Button btnAddItem;
        private Button btnChangeItem;
        private Button btnDeleteItem;
        private Button button1;
        private Button button2;
    }
}