namespace ChapeauUI.Components
{
    partial class CompleteOrderTemplate
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
            orderedAtLabel = new Label();
            LayoutOrderPanel = new TableLayoutPanel();
            ReadyButton = new Button();
            SuspendLayout();
            // 
            // orderedAtLabel
            // 
            orderedAtLabel.AutoSize = true;
            orderedAtLabel.Location = new Point(30, 31);
            orderedAtLabel.Name = "orderedAtLabel";
            orderedAtLabel.Size = new Size(59, 25);
            orderedAtLabel.TabIndex = 0;
            orderedAtLabel.Text = "label1";
            // 
            // LayoutOrderPanel
            // 
            LayoutOrderPanel.AutoSize = true;
            LayoutOrderPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutOrderPanel.ColumnCount = 1;
            LayoutOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LayoutOrderPanel.Location = new Point(10, 119);
            LayoutOrderPanel.Name = "LayoutOrderPanel";
            LayoutOrderPanel.RowCount = 1;
            LayoutOrderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutOrderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LayoutOrderPanel.Size = new Size(0, 0);
            LayoutOrderPanel.TabIndex = 3;
            // 
            // ReadyButton
            // 
            ReadyButton.Location = new Point(30, 355);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(197, 87);
            ReadyButton.TabIndex = 4;
            ReadyButton.Text = "Ready?";
            ReadyButton.UseVisualStyleBackColor = true;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // CompleteOrderTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(ReadyButton);
            Controls.Add(LayoutOrderPanel);
            Controls.Add(orderedAtLabel);
            Name = "CompleteOrderTemplate";
            Padding = new Padding(10);
            Size = new Size(240, 455);
            Load += CompleteOrderTemplate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderedAtLabel;
        private TableLayoutPanel LayoutOrderPanel;
        private Button ReadyButton;
    }
}
