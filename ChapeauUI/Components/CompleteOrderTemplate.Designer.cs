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
            StartPreparingBTN = new Button();
            SuspendLayout();
            // 
            // orderedAtLabel
            // 
            orderedAtLabel.AutoSize = true;
            orderedAtLabel.Location = new Point(24, 25);
            orderedAtLabel.Margin = new Padding(2, 0, 2, 0);
            orderedAtLabel.Name = "orderedAtLabel";
            orderedAtLabel.Size = new Size(50, 20);
            orderedAtLabel.TabIndex = 0;
            orderedAtLabel.Text = "label1";
            // 
            // LayoutOrderPanel
            // 
            LayoutOrderPanel.AutoSize = true;
            LayoutOrderPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutOrderPanel.ColumnCount = 1;
            LayoutOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutOrderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            LayoutOrderPanel.Location = new Point(8, 95);
            LayoutOrderPanel.Margin = new Padding(2);
            LayoutOrderPanel.Name = "LayoutOrderPanel";
            LayoutOrderPanel.RowCount = 1;
            LayoutOrderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutOrderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            LayoutOrderPanel.Size = new Size(0, 0);
            LayoutOrderPanel.TabIndex = 3;
            // 
            // ReadyButton
            // 
            ReadyButton.Location = new Point(81, 284);
            ReadyButton.Margin = new Padding(2);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(158, 70);
            ReadyButton.TabIndex = 4;
            ReadyButton.Text = "Ready?";
            ReadyButton.UseVisualStyleBackColor = true;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // StartPreparingBTN
            // 
            StartPreparingBTN.Location = new Point(179, 25);
            StartPreparingBTN.Name = "StartPreparingBTN";
            StartPreparingBTN.Size = new Size(127, 29);
            StartPreparingBTN.TabIndex = 5;
            StartPreparingBTN.Text = "Start preparing";
            StartPreparingBTN.UseVisualStyleBackColor = true;
            StartPreparingBTN.Click += StartPreparingBTN_Click;
            // 
            // CompleteOrderTemplate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(StartPreparingBTN);
            Controls.Add(ReadyButton);
            Controls.Add(LayoutOrderPanel);
            Controls.Add(orderedAtLabel);
            Margin = new Padding(2);
            Name = "CompleteOrderTemplate";
            Padding = new Padding(8);
            Size = new Size(317, 364);
            Load += CompleteOrderTemplate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderedAtLabel;
        private TableLayoutPanel LayoutOrderPanel;
        private Button ReadyButton;
        private Button StartPreparingBTN;
    }
}
