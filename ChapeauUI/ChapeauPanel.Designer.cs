namespace ChapeauUI
{
    partial class ChapeauPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderButton = new Button();
            kitchenButton = new Button();
            barOverview = new Button();
            managementButton = new Button();
            SuspendLayout();
            // 
            // orderButton
            // 
            orderButton.Location = new Point(12, 12);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(150, 75);
            orderButton.TabIndex = 0;
            orderButton.Text = "Ordering";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // kitchenButton
            // 
            kitchenButton.Location = new Point(168, 12);
            kitchenButton.Name = "kitchenButton";
            kitchenButton.Size = new Size(150, 75);
            kitchenButton.TabIndex = 1;
            kitchenButton.Text = "Kitchen overview";
            kitchenButton.UseVisualStyleBackColor = true;
            kitchenButton.Click += kitchenButton_Click;
            // 
            // barOverview
            // 
            barOverview.Location = new Point(324, 12);
            barOverview.Name = "barOverview";
            barOverview.Size = new Size(150, 75);
            barOverview.TabIndex = 2;
            barOverview.Text = "Bar overview";
            barOverview.UseVisualStyleBackColor = true;
            barOverview.Click += barOverview_Click;
            // 
            // managementButton
            // 
            managementButton.Location = new Point(480, 12);
            managementButton.Name = "managementButton";
            managementButton.Size = new Size(150, 75);
            managementButton.TabIndex = 3;
            managementButton.Text = "Management";
            managementButton.UseVisualStyleBackColor = true;
            managementButton.Click += managementButton_Click;
            // 
            // ChapeauPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 103);
            Controls.Add(managementButton);
            Controls.Add(barOverview);
            Controls.Add(kitchenButton);
            Controls.Add(orderButton);
            Name = "ChapeauPanel";
            Text = "Chapeau Home";
            ResumeLayout(false);
        }

        #endregion

        private Button orderButton;
        private Button kitchenButton;
        private Button barOverview;
        private Button managementButton;
    }
}
