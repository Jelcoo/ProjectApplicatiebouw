namespace ChapeauUI.OrderUI
{
    partial class OrderLineNote
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            specifyHeader = new Label();
            specifyItemName = new Label();
            orderNoteBox = new RichTextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // specifyHeader
            // 
            specifyHeader.AutoSize = true;
            specifyHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            specifyHeader.Location = new Point(3, 3);
            specifyHeader.Name = "specifyHeader";
            specifyHeader.Size = new Size(286, 38);
            specifyHeader.TabIndex = 0;
            specifyHeader.Text = "Specify order details";
            // 
            // specifyItemName
            // 
            specifyItemName.AutoSize = true;
            specifyItemName.Location = new Point(3, 41);
            specifyItemName.Name = "specifyItemName";
            specifyItemName.Size = new Size(157, 25);
            specifyItemName.TabIndex = 1;
            specifyItemName.Text = "You are ordering a";
            // 
            // orderNoteBox
            // 
            orderNoteBox.Location = new Point(3, 69);
            orderNoteBox.Name = "orderNoteBox";
            orderNoteBox.Size = new Size(470, 119);
            orderNoteBox.TabIndex = 2;
            orderNoteBox.Text = "";
            // 
            // addButton
            // 
            addButton.Location = new Point(361, 194);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // OrderLineNote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 231);
            Controls.Add(addButton);
            Controls.Add(orderNoteBox);
            Controls.Add(specifyItemName);
            Controls.Add(specifyHeader);
            Name = "OrderLineNote";
            Text = "Specify order details";
            Load += OrderLineNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label specifyHeader;
        private Label specifyItemName;
        private RichTextBox orderNoteBox;
        private Button addButton;
    }
}
