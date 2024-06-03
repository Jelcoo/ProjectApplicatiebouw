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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            lvStock = new ListView();
            ItemName = new ColumnHeader();
            ItemStock = new ColumnHeader();
            lblStockManagementText = new Label();
            btnAddStock = new Button();
            btnAlterStock = new Button();
            imageList1 = new ImageList(components);
            lblMenuItemName = new Label();
            lblMenuItemDetail = new Label();
            lblInStockText = new Label();
            lblMenuItemStock = new Label();
            pbItemImage = new PictureBox();
            lblSelectAnItemText = new Label();
            ((System.ComponentModel.ISupportInitialize)pbItemImage).BeginInit();
            SuspendLayout();
            // 
            // lvStock
            // 
            lvStock.Columns.AddRange(new ColumnHeader[] { ItemName, ItemStock });
            lvStock.FullRowSelect = true;
            lvStock.Location = new Point(12, 12);
            lvStock.MultiSelect = false;
            lvStock.Name = "lvStock";
            lvStock.Size = new Size(455, 411);
            lvStock.TabIndex = 0;
            lvStock.UseCompatibleStateImageBehavior = false;
            lvStock.View = View.Details;
            lvStock.SelectedIndexChanged += lvStock_SelectedIndexChanged;
            // 
            // ItemName
            // 
            ItemName.Text = "Name";
            // 
            // ItemStock
            // 
            ItemStock.Text = "Stock";
            // 
            // lblStockManagementText
            // 
            lblStockManagementText.AutoSize = true;
            lblStockManagementText.Location = new Point(534, 352);
            lblStockManagementText.MinimumSize = new Size(200, 0);
            lblStockManagementText.Name = "lblStockManagementText";
            lblStockManagementText.Size = new Size(200, 20);
            lblStockManagementText.TabIndex = 1;
            lblStockManagementText.Text = "Stock Management";
            lblStockManagementText.TextAlign = ContentAlignment.MiddleCenter;
            lblStockManagementText.Visible = false;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(486, 375);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(144, 48);
            btnAddStock.TabIndex = 2;
            btnAddStock.Text = "Add Stock Delivery";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Visible = false;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // btnAlterStock
            // 
            btnAlterStock.Location = new Point(636, 375);
            btnAlterStock.Name = "btnAlterStock";
            btnAlterStock.Size = new Size(144, 48);
            btnAlterStock.TabIndex = 2;
            btnAlterStock.Text = "Alter Stock";
            btnAlterStock.UseVisualStyleBackColor = true;
            btnAlterStock.Visible = false;
            btnAlterStock.Click += btnAlterStock_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Berenburg.jpg");
            imageList1.Images.SetKeyName(1, "Café surprise.png");
            imageList1.Images.SetKeyName(2, "Cappuchino.jpg");
            imageList1.Images.SetKeyName(3, "Cherry Baby.png");
            imageList1.Images.SetKeyName(4, "Consommé van fazant.png");
            imageList1.Images.SetKeyName(5, "Duvel.jpeg");
            imageList1.Images.SetKeyName(6, "Boerenkazen.png");
            imageList1.Images.SetKeyName(7, "Espresso.png");
            imageList1.Images.SetKeyName(8, "Gebakken kabeljauw.png");
            imageList1.Images.SetKeyName(9, "Gebakken ossenhaas.png");
            imageList1.Images.SetKeyName(10, "Hertenbiefstuk.png");
            imageList1.Images.SetKeyName(11, "Hertenstoofpotje.png");
            imageList1.Images.SetKeyName(12, "Hertog Jan.jpg");
            imageList1.Images.SetKeyName(13, "Jonge Jenever.png");
            imageList1.Images.SetKeyName(14, "Kalfstartaar.png");
            imageList1.Images.SetKeyName(15, "Koffie.jpeg");
            imageList1.Images.SetKeyName(16, "Krab-zalm koekjes.png");
            imageList1.Images.SetKeyName(17, "Kriek.png");
            imageList1.Images.SetKeyName(18, "Leffe Triple.jpeg");
            imageList1.Images.SetKeyName(19, "Linguini.png");
            imageList1.Images.SetKeyName(20, "Paté van Fazant.png");
            imageList1.Images.SetKeyName(21, "Port e Fromage.png");
            imageList1.Images.SetKeyName(22, "Provençaalse vissoep.png");
            imageList1.Images.SetKeyName(23, "Rode Wijn.jpg");
            imageList1.Images.SetKeyName(24, "Rum.png");
            imageList1.Images.SetKeyName(25, "Spa Groen.jpg");
            imageList1.Images.SetKeyName(26, "Spa Rood.jpg");
            imageList1.Images.SetKeyName(27, "Steak Tartaar.png");
            imageList1.Images.SetKeyName(28, "Thee.jpg");
            imageList1.Images.SetKeyName(29, "Tonic.jpeg");
            imageList1.Images.SetKeyName(30, "Verse Madeleine.png");
            imageList1.Images.SetKeyName(31, "Vieux.png");
            imageList1.Images.SetKeyName(32, "Whiskey.jpg");
            imageList1.Images.SetKeyName(33, "Witte Chocoladetaart.png");
            imageList1.Images.SetKeyName(34, "Witte Wijn.jpg");
            // 
            // lblMenuItemName
            // 
            lblMenuItemName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItemName.Location = new Point(534, 12);
            lblMenuItemName.MaximumSize = new Size(500, 500);
            lblMenuItemName.MinimumSize = new Size(200, 50);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(200, 50);
            lblMenuItemName.TabIndex = 3;
            lblMenuItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenuItemDetail
            // 
            lblMenuItemDetail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblMenuItemDetail.Location = new Point(534, 62);
            lblMenuItemDetail.MaximumSize = new Size(500, 500);
            lblMenuItemDetail.MinimumSize = new Size(200, 50);
            lblMenuItemDetail.Name = "lblMenuItemDetail";
            lblMenuItemDetail.Size = new Size(200, 50);
            lblMenuItemDetail.TabIndex = 4;
            lblMenuItemDetail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInStockText
            // 
            lblInStockText.AutoSize = true;
            lblInStockText.Location = new Point(534, 122);
            lblInStockText.MinimumSize = new Size(200, 0);
            lblInStockText.Name = "lblInStockText";
            lblInStockText.Size = new Size(200, 20);
            lblInStockText.TabIndex = 5;
            lblInStockText.Text = "In Stock: ";
            lblInStockText.TextAlign = ContentAlignment.MiddleCenter;
            lblInStockText.Visible = false;
            // 
            // lblMenuItemStock
            // 
            lblMenuItemStock.AutoSize = true;
            lblMenuItemStock.Location = new Point(534, 142);
            lblMenuItemStock.MinimumSize = new Size(200, 30);
            lblMenuItemStock.Name = "lblMenuItemStock";
            lblMenuItemStock.Size = new Size(200, 30);
            lblMenuItemStock.TabIndex = 6;
            lblMenuItemStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbItemImage
            // 
            pbItemImage.Location = new Point(534, 189);
            pbItemImage.Name = "pbItemImage";
            pbItemImage.Size = new Size(200, 150);
            pbItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbItemImage.TabIndex = 7;
            pbItemImage.TabStop = false;
            // 
            // lblSelectAnItemText
            // 
            lblSelectAnItemText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectAnItemText.Location = new Point(534, 87);
            lblSelectAnItemText.Name = "lblSelectAnItemText";
            lblSelectAnItemText.Size = new Size(200, 35);
            lblSelectAnItemText.TabIndex = 8;
            lblSelectAnItemText.Text = "Select an Item";
            lblSelectAnItemText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSelectAnItemText);
            Controls.Add(pbItemImage);
            Controls.Add(lblMenuItemStock);
            Controls.Add(lblInStockText);
            Controls.Add(lblMenuItemDetail);
            Controls.Add(lblMenuItemName);
            Controls.Add(btnAlterStock);
            Controls.Add(btnAddStock);
            Controls.Add(lblStockManagementText);
            Controls.Add(lvStock);
            Name = "StockManagement";
            Text = "StockManagement";
            ((System.ComponentModel.ISupportInitialize)pbItemImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStock;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
        private Label lblStockManagementText;
        private Button btnAddStock;
        private Button btnAlterStock;
        private ImageList imageList1;
        private Label lblMenuItemName;
        private Label lblMenuItemDetail;
        private Label lblInStockText;
        private Label lblMenuItemStock;
        private PictureBox pbItemImage;
        private Label lblSelectAnItemText;
    }
}