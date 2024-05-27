using ChapeauUI.Components;

namespace ChapeauUI.OrderUI
{
    partial class OrderHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHome));
            backgroundPanel = new BackgroundPanel();
            orderOverview = new Panel();
            menuListPanel = new Panel();
            menuList = new TableLayoutPanel();
            menuSelectorDrinks = new RoundedButton();
            menuSelectorLunch = new RoundedButton();
            menuSelectorDinner = new RoundedButton();
            chapeauLogo = new PictureBox();
            loggedInAsPreLabel = new Label();
            loggedInAsLabel = new Label();
            dateTimeLabel = new Label();
            backgroundPanel.SuspendLayout();
            menuListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(204, 227, 222);
            backgroundPanel.Controls.Add(orderOverview);
            backgroundPanel.Controls.Add(menuListPanel);
            backgroundPanel.Controls.Add(menuSelectorDrinks);
            backgroundPanel.Controls.Add(menuSelectorLunch);
            backgroundPanel.Controls.Add(menuSelectorDinner);
            backgroundPanel.Location = new Point(210, 70);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(1230, 954);
            backgroundPanel.TabIndex = 0;
            // 
            // orderOverview
            // 
            orderOverview.BackColor = Color.FromArgb(234, 244, 244);
            orderOverview.Location = new Point(865, 85);
            orderOverview.Name = "orderOverview";
            orderOverview.Size = new Size(349, 830);
            orderOverview.TabIndex = 2;
            // 
            // menuListPanel
            // 
            menuListPanel.AutoScroll = true;
            menuListPanel.Controls.Add(menuList);
            menuListPanel.Location = new Point(70, 85);
            menuListPanel.Name = "menuListPanel";
            menuListPanel.Size = new Size(790, 830);
            menuListPanel.TabIndex = 2;
            // 
            // menuList
            // 
            menuList.AutoScroll = true;
            menuList.AutoSize = true;
            menuList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuList.ColumnCount = 3;
            menuList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuList.Dock = DockStyle.Fill;
            menuList.Location = new Point(0, 0);
            menuList.Name = "menuList";
            menuList.RowCount = 1;
            menuList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuList.Size = new Size(790, 830);
            menuList.TabIndex = 1;
            // 
            // menuSelectorDrinks
            // 
            menuSelectorDrinks.BackColor = Color.FromArgb(246, 255, 248);
            menuSelectorDrinks.BorderColor = Color.Black;
            menuSelectorDrinks.BorderRadius = 22;
            menuSelectorDrinks.BorderWidth = 5;
            menuSelectorDrinks.Cursor = Cursors.Hand;
            menuSelectorDrinks.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            menuSelectorDrinks.HasBorder = true;
            menuSelectorDrinks.Location = new Point(70, 12);
            menuSelectorDrinks.Name = "menuSelectorDrinks";
            menuSelectorDrinks.Size = new Size(155, 45);
            menuSelectorDrinks.TabIndex = 0;
            menuSelectorDrinks.Text = "Drinks";
            menuSelectorDrinks.UseVisualStyleBackColor = false;
            menuSelectorDrinks.Click += menuSelectorDrinks_Click;
            // 
            // menuSelectorLunch
            // 
            menuSelectorLunch.BackColor = Color.FromArgb(246, 255, 248);
            menuSelectorLunch.BorderColor = Color.Black;
            menuSelectorLunch.BorderRadius = 22;
            menuSelectorLunch.BorderWidth = 5;
            menuSelectorLunch.Cursor = Cursors.Hand;
            menuSelectorLunch.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            menuSelectorLunch.HasBorder = true;
            menuSelectorLunch.Location = new Point(240, 12);
            menuSelectorLunch.Name = "menuSelectorLunch";
            menuSelectorLunch.Size = new Size(155, 45);
            menuSelectorLunch.TabIndex = 0;
            menuSelectorLunch.Text = "Lunch";
            menuSelectorLunch.UseVisualStyleBackColor = false;
            menuSelectorLunch.Click += menuSelectorLunch_Click;
            // 
            // menuSelectorDinner
            // 
            menuSelectorDinner.BackColor = Color.FromArgb(246, 255, 248);
            menuSelectorDinner.BorderColor = Color.Black;
            menuSelectorDinner.BorderRadius = 22;
            menuSelectorDinner.BorderWidth = 5;
            menuSelectorDinner.Cursor = Cursors.Hand;
            menuSelectorDinner.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            menuSelectorDinner.HasBorder = true;
            menuSelectorDinner.Location = new Point(410, 12);
            menuSelectorDinner.Name = "menuSelectorDinner";
            menuSelectorDinner.Size = new Size(155, 45);
            menuSelectorDinner.TabIndex = 0;
            menuSelectorDinner.Text = "Dinner";
            menuSelectorDinner.UseVisualStyleBackColor = false;
            menuSelectorDinner.Click += menuSelectorDinner_Click;
            // 
            // chapeauLogo
            // 
            chapeauLogo.Image = (Image)resources.GetObject("chapeauLogo.Image");
            chapeauLogo.Location = new Point(40, 40);
            chapeauLogo.Name = "chapeauLogo";
            chapeauLogo.Size = new Size(130, 130);
            chapeauLogo.TabIndex = 1;
            chapeauLogo.TabStop = false;
            // 
            // loggedInAsPreLabel
            // 
            loggedInAsPreLabel.AutoSize = true;
            loggedInAsPreLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loggedInAsPreLabel.Location = new Point(210, 21);
            loggedInAsPreLabel.Name = "loggedInAsPreLabel";
            loggedInAsPreLabel.Size = new Size(332, 29);
            loggedInAsPreLabel.TabIndex = 2;
            loggedInAsPreLabel.Text = "You are currently logged in as";
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loggedInAsLabel.Location = new Point(534, 21);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(78, 29);
            loggedInAsLabel.TabIndex = 3;
            loggedInAsLabel.Text = "Maria";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(1195, 21);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(229, 29);
            dateTimeLabel.TabIndex = 4;
            dateTimeLabel.Text = "Loading date & time...";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OrderHome
            // 
            BackColor = Color.FromArgb(164, 195, 178);
            ClientSize = new Size(1440, 1024);
            Controls.Add(dateTimeLabel);
            Controls.Add(loggedInAsLabel);
            Controls.Add(loggedInAsPreLabel);
            Controls.Add(chapeauLogo);
            Controls.Add(backgroundPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OrderHome";
            Text = "Chapeau - Ordering";
            Load += OrderHome_Load;
            backgroundPanel.ResumeLayout(false);
            menuListPanel.ResumeLayout(false);
            menuListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BackgroundPanel backgroundPanel;
        private PictureBox chapeauLogo;
        private Label loggedInAsPreLabel;
        private Label loggedInAsLabel;
        private Label dateTimeLabel;
        private RoundedButton menuSelectorDrinks;
        private RoundedButton menuSelectorLunch;
        private RoundedButton menuSelectorDinner;
        private Panel orderOverview;
        private TableLayoutPanel menuList;
        private Panel menuListPanel;
    }
}
