namespace ChapeauUI.TableUI
{
    partial class TableHome
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
            tableSelector = new ListView();
            selectButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // tableSelector
            // 
            tableSelector.FullRowSelect = true;
            tableSelector.Location = new Point(12, 12);
            tableSelector.Name = "tableSelector";
            tableSelector.Size = new Size(621, 426);
            tableSelector.TabIndex = 0;
            tableSelector.UseCompatibleStateImageBehavior = false;
            tableSelector.View = View.Details;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(639, 12);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(138, 34);
            selectButton.TabIndex = 1;
            selectButton.Text = "Select Table >";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(639, 52);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 34);
            backButton.TabIndex = 2;
            backButton.Text = "< Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // TableHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(selectButton);
            Controls.Add(tableSelector);
            Name = "TableHome";
            Text = "TableHome";
            Load += TableHome_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView tableSelector;
        private Button selectButton;
        private Button backButton;
    }
}