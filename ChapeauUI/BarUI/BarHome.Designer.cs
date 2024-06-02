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
            dateTimeLabel.Location = new Point(1177, 8);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(188, 28);
            dateTimeLabel.TabIndex = 14;
            dateTimeLabel.Text = "Loading date & time...";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loggedInAsLabel.Location = new Point(468, 9);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(61, 28);
            loggedInAsLabel.TabIndex = 13;
            loggedInAsLabel.Text = "Mark";
            // 
            // loggedInAsPreLabel
            // 
            loggedInAsPreLabel.AutoSize = true;
            loggedInAsPreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loggedInAsPreLabel.Location = new Point(192, 8);
            loggedInAsPreLabel.Name = "loggedInAsPreLabel";
            loggedInAsPreLabel.Size = new Size(270, 28);
            loggedInAsPreLabel.TabIndex = 12;
            loggedInAsPreLabel.Text = "You are currently logged in as";
            // 
            // chapeauLogo
            // 
            chapeauLogo.Image = (Image)resources.GetObject("chapeauLogo.Image");
            chapeauLogo.Location = new Point(22, 27);
            chapeauLogo.Name = "chapeauLogo";
            chapeauLogo.Size = new Size(130, 130);
            chapeauLogo.TabIndex = 11;
            chapeauLogo.TabStop = false;
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(204, 227, 222);
            backgroundPanel.Controls.Add(CompletedOrderButton);
            backgroundPanel.Controls.Add(currentOrderButton);
            backgroundPanel.Controls.Add(barOrderLayoutPanel);
            backgroundPanel.Location = new Point(192, 57);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(1230, 954);
            backgroundPanel.TabIndex = 10;
            // 
            // CompletedOrderButton
            // 
            CompletedOrderButton.BackColor = Color.White;
            CompletedOrderButton.BorderColor = Color.Black;
            CompletedOrderButton.BorderRadius = 5;
            CompletedOrderButton.BorderWidth = 5;
            CompletedOrderButton.HasBorder = false;
            CompletedOrderButton.Location = new Point(196, 17);
            CompletedOrderButton.Name = "CompletedOrderButton";
            CompletedOrderButton.Size = new Size(174, 44);
            CompletedOrderButton.TabIndex = 2;
            CompletedOrderButton.Text = "Completed Orders";
            CompletedOrderButton.UseVisualStyleBackColor = false;
            CompletedOrderButton.Click += roundedButton2_Click;
            CompletedOrderButton.Cursor = Cursors.Hand;
            // 
            // currentOrderButton
            // 
            currentOrderButton.BackColor = Color.White;
            currentOrderButton.BorderColor = Color.Black;
            currentOrderButton.BorderRadius = 5;
            currentOrderButton.BorderWidth = 5;
            currentOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            currentOrderButton.HasBorder = false;
            currentOrderButton.Location = new Point(16, 17);
            currentOrderButton.Name = "currentOrderButton";
            currentOrderButton.Size = new Size(174, 44);
            currentOrderButton.TabIndex = 1;
            currentOrderButton.Text = "Current Orders";
            currentOrderButton.UseVisualStyleBackColor = false;
            currentOrderButton.Click += currentOrderButton_Click;
            currentOrderButton.Cursor = Cursors.Hand;
            // 
            // barOrderLayoutPanel
            // 
            barOrderLayoutPanel.AutoScroll = true;
            barOrderLayoutPanel.AutoScrollMinSize = new Size(1000, 0);
            barOrderLayoutPanel.ColumnCount = 3;
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            barOrderLayoutPanel.Location = new Point(16, 67);
            barOrderLayoutPanel.Name = "barOrderLayoutPanel";
            barOrderLayoutPanel.RowCount = 1;
            barOrderLayoutPanel.RowStyles.Add(new RowStyle());
            barOrderLayoutPanel.Size = new Size(1185, 653);
            barOrderLayoutPanel.TabIndex = 0;
            // 
            // BarHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 195, 178);
            ClientSize = new Size(1444, 1018);
            Controls.Add(dateTimeLabel);
            Controls.Add(loggedInAsLabel);
            Controls.Add(loggedInAsPreLabel);
            Controls.Add(chapeauLogo);
            Controls.Add(backgroundPanel);
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
    }
}