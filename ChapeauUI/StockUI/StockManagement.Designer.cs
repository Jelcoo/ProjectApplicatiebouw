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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            lblMenuItemName = new Label();
            lblMenuItemDetail = new Label();
            InStockText = new Label();
            lblMenuItemStock = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 343);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Stock Management";
            // 
            // button1
            // 
            button1.Location = new Point(486, 375);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 2;
            button1.Text = "Add Stock Delivery";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(636, 375);
            button2.Name = "button2";
            button2.Size = new Size(144, 48);
            button2.TabIndex = 2;
            button2.Text = "Alter Stock";
            button2.UseVisualStyleBackColor = true;
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
            lblMenuItemName.AutoSize = true;
            lblMenuItemName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItemName.Location = new Point(604, 12);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(0, 31);
            lblMenuItemName.TabIndex = 3;
            // 
            // lblMenuItemDetail
            // 
            lblMenuItemDetail.AutoSize = true;
            lblMenuItemDetail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblMenuItemDetail.Location = new Point(616, 61);
            lblMenuItemDetail.Name = "lblMenuItemDetail";
            lblMenuItemDetail.Size = new Size(0, 20);
            lblMenuItemDetail.TabIndex = 4;
            // 
            // InStockText
            // 
            InStockText.AutoSize = true;
            InStockText.Location = new Point(604, 122);
            InStockText.Name = "InStockText";
            InStockText.Size = new Size(68, 20);
            InStockText.TabIndex = 5;
            InStockText.Text = "In Stock: ";
            // 
            // lblMenuItemStock
            // 
            lblMenuItemStock.AutoSize = true;
            lblMenuItemStock.Location = new Point(616, 151);
            lblMenuItemStock.Name = "lblMenuItemStock";
            lblMenuItemStock.Size = new Size(0, 20);
            lblMenuItemStock.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Boerenkazen;
            pictureBox1.Location = new Point(544, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblMenuItemStock);
            Controls.Add(InStockText);
            Controls.Add(lblMenuItemDetail);
            Controls.Add(lblMenuItemName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lvStock);
            Name = "StockManagement";
            Text = "StockManagement";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStock;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
        private Label label2;
        private Button button1;
        private Button button2;
        private ImageList imageList1;
        private Label lblMenuItemName;
        private Label lblMenuItemDetail;
        private Label InStockText;
        private Label lblMenuItemStock;
        private PictureBox pictureBox1;
    }
}