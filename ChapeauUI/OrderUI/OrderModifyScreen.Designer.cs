namespace ChapeauUI.OrderUI
{
    partial class OrderModifyScreen
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
            orderOverview = new ScrollableListView();
            saveButton = new Button();
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
            orderOverview.Scroll += new ScrollEventHandler(ListView_Scroll);
            orderOverview.MouseScroll += new MouseEventHandler(ListView_MouseScroll);
            // 
            // saveButton
            // 
            saveButton.Location = new Point(676, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // OrderModifyScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(orderOverview);
            Name = "OrderModifyScreen";
            Text = "OrderModifyScreen";
            Load += OrderModifyScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScrollableListView orderOverview;
        private Button saveButton;
    }
}