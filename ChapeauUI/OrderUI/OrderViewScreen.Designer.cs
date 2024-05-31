namespace ChapeauUI.OrderUI
{
    partial class OrderViewScreen
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
            orderOverview = new ListView();
            loadButton = new Button();
            SuspendLayout();
            // 
            // orderOverview
            // 
            orderOverview.Location = new Point(12, 12);
            orderOverview.Name = "orderOverview";
            orderOverview.Size = new Size(658, 426);
            orderOverview.TabIndex = 0;
            orderOverview.UseCompatibleStateImageBehavior = false;
            orderOverview.View = View.Details;
            orderOverview.FullRowSelect = true;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(676, 12);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(112, 34);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // OrderViewScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadButton);
            Controls.Add(orderOverview);
            Name = "OrderViewScreen";
            Text = "OrderViewScreen";
            Load += OrderViewScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView orderOverview;
        private Button loadButton;
    }
}