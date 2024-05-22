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
            backgroundPanel = new Panel();
            chapeauLogo = new PictureBox();
            loggedInAsPreLabel = new Label();
            loggedInAsLabel = new Label();
            dateTimeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).BeginInit();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(204, 227, 222);
            backgroundPanel.Location = new Point(210, 70);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(1230, 954);
            backgroundPanel.TabIndex = 0;
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
            loggedInAsPreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loggedInAsPreLabel.Location = new Point(210, 21);
            loggedInAsPreLabel.Name = "loggedInAsPreLabel";
            loggedInAsPreLabel.Size = new Size(332, 32);
            loggedInAsPreLabel.TabIndex = 2;
            loggedInAsPreLabel.Text = "You are currently logged in as";
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loggedInAsLabel.Location = new Point(534, 21);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(80, 32);
            loggedInAsLabel.TabIndex = 3;
            loggedInAsLabel.Text = "Maria";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(1195, 21);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(230, 32);
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
            ((System.ComponentModel.ISupportInitialize)chapeauLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel backgroundPanel;
        private PictureBox chapeauLogo;
        private Label loggedInAsPreLabel;
        private Label loggedInAsLabel;
        private Label dateTimeLabel;
    }
}
