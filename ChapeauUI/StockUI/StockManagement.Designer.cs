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
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvStock);
            Name = "StockManagement";
            Text = "StockManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvStock;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
    }
}