namespace ChapeauUI.BarUI
{
    partial class BarHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarHome));
            dateTimeLabel = new Label();
            loggedInAsLabel = new Label();
            loggedInAsPreLabel = new Label();
            chapeauLogo = new PictureBox();
            backgroundPanel = new Panel();
            backButton = new Button();
            CompletedOrderButton = new Components.RoundedButton();
            currentOrderButton = new Components.RoundedButton();
            barOrderLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).BeginInit();
            backgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(1471, 10);
            dateTimeLabel.Margin = new Padding(4, 0, 4, 0);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(230, 32);
            dateTimeLabel.TabIndex = 14;
            dateTimeLabel.Text = "Loading date & time...";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loggedInAsLabel.Location = new Point(585, 11);
            loggedInAsLabel.Margin = new Padding(4, 0, 4, 0);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(73, 32);
            loggedInAsLabel.TabIndex = 13;
            loggedInAsLabel.Text = "Mark";
            // 
            // loggedInAsPreLabel
            // 
            loggedInAsPreLabel.AutoSize = true;
            loggedInAsPreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loggedInAsPreLabel.Location = new Point(240, 10);
            loggedInAsPreLabel.Margin = new Padding(4, 0, 4, 0);
            loggedInAsPreLabel.Name = "loggedInAsPreLabel";
            loggedInAsPreLabel.Size = new Size(332, 32);
            loggedInAsPreLabel.TabIndex = 12;
            loggedInAsPreLabel.Text = "You are currently logged in as";
            // 
            // chapeauLogo
            // 
            chapeauLogo.Image = (Image)resources.GetObject("chapeauLogo.Image");
            chapeauLogo.Location = new Point(28, 34);
            chapeauLogo.Margin = new Padding(4, 4, 4, 4);
            chapeauLogo.Name = "chapeauLogo";
            chapeauLogo.Size = new Size(162, 162);
            chapeauLogo.TabIndex = 11;
            chapeauLogo.TabStop = false;
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(204, 227, 222);
            backgroundPanel.Controls.Add(backButton);
            backgroundPanel.Controls.Add(CompletedOrderButton);
            backgroundPanel.Controls.Add(currentOrderButton);
            backgroundPanel.Controls.Add(barOrderLayoutPanel);
            backgroundPanel.Location = new Point(240, 71);
            backgroundPanel.Margin = new Padding(4, 4, 4, 4);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(1538, 1192);
            backgroundPanel.TabIndex = 10;
            // 
            // backButton
            // 
            backButton.Location = new Point(1705, 26);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(171, 69);
            backButton.TabIndex = 3;
            backButton.Text = "< Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // CompletedOrderButton
            // 
            CompletedOrderButton.BackColor = Color.White;
            CompletedOrderButton.BorderColor = Color.Black;
            CompletedOrderButton.BorderRadius = 5;
            CompletedOrderButton.BorderWidth = 5;
            CompletedOrderButton.Cursor = Cursors.Hand;
            CompletedOrderButton.HasBorder = false;
            CompletedOrderButton.Location = new Point(245, 21);
            CompletedOrderButton.Margin = new Padding(4, 4, 4, 4);
            CompletedOrderButton.Name = "CompletedOrderButton";
            CompletedOrderButton.Size = new Size(218, 55);
            CompletedOrderButton.TabIndex = 2;
            CompletedOrderButton.Text = "Completed Orders";
            CompletedOrderButton.UseVisualStyleBackColor = false;
            CompletedOrderButton.Click += roundedButton2_Click;
            // 
            // currentOrderButton
            // 
            currentOrderButton.BackColor = Color.White;
            currentOrderButton.BorderColor = Color.Black;
            currentOrderButton.BorderRadius = 5;
            currentOrderButton.BorderWidth = 5;
            currentOrderButton.Cursor = Cursors.Hand;
            currentOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            currentOrderButton.HasBorder = false;
            currentOrderButton.Location = new Point(20, 21);
            currentOrderButton.Margin = new Padding(4, 4, 4, 4);
            currentOrderButton.Name = "currentOrderButton";
            currentOrderButton.Size = new Size(218, 55);
            currentOrderButton.TabIndex = 1;
            currentOrderButton.Text = "Current Orders";
            currentOrderButton.UseVisualStyleBackColor = false;
            currentOrderButton.Click += currentOrderButton_Click;
            // 
            // barOrderLayoutPanel
            // 
            barOrderLayoutPanel.AutoScroll = true;
            barOrderLayoutPanel.AutoScrollMinSize = new Size(1000, 0);
            barOrderLayoutPanel.ColumnCount = 3;
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.Location = new Point(20, 84);
            barOrderLayoutPanel.Margin = new Padding(4, 4, 4, 4);
            barOrderLayoutPanel.Name = "barOrderLayoutPanel";
            barOrderLayoutPanel.RowCount = 1;
            barOrderLayoutPanel.RowStyles.Add(new RowStyle());
            barOrderLayoutPanel.Size = new Size(1481, 1088);
            barOrderLayoutPanel.TabIndex = 0;
            // 
            // BarHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 195, 178);
            ClientSize = new Size(1805, 1272);
            Controls.Add(dateTimeLabel);
            Controls.Add(loggedInAsLabel);
            Controls.Add(loggedInAsPreLabel);
            Controls.Add(chapeauLogo);
            Controls.Add(backgroundPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BarHome";
            Text = "BarHome";
            Load += BarHome_Load;
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).EndInit();
            backgroundPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateTimeLabel;
        private Label loggedInAsLabel;
        private Label loggedInAsPreLabel;
        private PictureBox chapeauLogo;
        private Panel backgroundPanel;
        private TableLayoutPanel barOrderLayoutPanel;
        private Components.RoundedButton CompletedOrderButton;
        private Components.RoundedButton currentOrderButton;
        private Button backButton;
    }
}