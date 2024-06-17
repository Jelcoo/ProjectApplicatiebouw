namespace ChapeauUI.IncomeUI
{
    partial class IncomeUI
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
            lblAllTimeIncomeText = new Label();
            lblAllTimeIncome = new Label();
            lblIncomeByDateText = new Label();
            lblIncomeByDate = new Label();
            dtpStartDay = new DateTimePicker();
            cbSingleDay = new CheckBox();
            dtpEndDay = new DateTimePicker();
            lblSelectDateText = new Label();
            lblSelectEndDateText = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // lblAllTimeIncomeText
            // 
            lblAllTimeIncomeText.AutoSize = true;
            lblAllTimeIncomeText.Location = new Point(36, 31);
            lblAllTimeIncomeText.Name = "lblAllTimeIncomeText";
            lblAllTimeIncomeText.Size = new Size(117, 20);
            lblAllTimeIncomeText.TabIndex = 0;
            lblAllTimeIncomeText.Text = "All Time Income";
            // 
            // lblAllTimeIncome
            // 
            lblAllTimeIncome.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAllTimeIncome.Location = new Point(36, 60);
            lblAllTimeIncome.Name = "lblAllTimeIncome";
            lblAllTimeIncome.Size = new Size(218, 68);
            lblAllTimeIncome.TabIndex = 0;
            lblAllTimeIncome.Text = "€ 1.000.000";
            // 
            // lblIncomeByDateText
            // 
            lblIncomeByDateText.AutoSize = true;
            lblIncomeByDateText.Location = new Point(36, 211);
            lblIncomeByDateText.Name = "lblIncomeByDateText";
            lblIncomeByDateText.Size = new Size(114, 20);
            lblIncomeByDateText.TabIndex = 0;
            lblIncomeByDateText.Text = "Income by Date";
            // 
            // lblIncomeByDate
            // 
            lblIncomeByDate.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblIncomeByDate.Location = new Point(36, 231);
            lblIncomeByDate.Name = "lblIncomeByDate";
            lblIncomeByDate.Size = new Size(218, 68);
            lblIncomeByDate.TabIndex = 0;
            lblIncomeByDate.Text = "€ 1.000.000";
            // 
            // dtpStartDay
            // 
            dtpStartDay.Location = new Point(36, 181);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.Size = new Size(218, 27);
            dtpStartDay.TabIndex = 1;
            dtpStartDay.ValueChanged += dtpStartDay_ValueChanged;
            // 
            // cbSingleDay
            // 
            cbSingleDay.AutoSize = true;
            cbSingleDay.Location = new Point(36, 131);
            cbSingleDay.Name = "cbSingleDay";
            cbSingleDay.Size = new Size(102, 24);
            cbSingleDay.TabIndex = 2;
            cbSingleDay.Text = "Single Day";
            cbSingleDay.UseVisualStyleBackColor = true;
            cbSingleDay.CheckedChanged += cbSingleDay_CheckedChanged;
            // 
            // dtpEndDay
            // 
            dtpEndDay.Location = new Point(273, 181);
            dtpEndDay.Name = "dtpEndDay";
            dtpEndDay.Size = new Size(218, 27);
            dtpEndDay.TabIndex = 1;
            dtpEndDay.ValueChanged += dtpEndDay_ValueChanged;
            // 
            // lblSelectDateText
            // 
            lblSelectDateText.AutoSize = true;
            lblSelectDateText.Location = new Point(36, 158);
            lblSelectDateText.Name = "lblSelectDateText";
            lblSelectDateText.Size = new Size(88, 20);
            lblSelectDateText.TabIndex = 3;
            lblSelectDateText.Text = "Select Date:";
            // 
            // lblSelectEndDateText
            // 
            lblSelectEndDateText.AutoSize = true;
            lblSelectEndDateText.Location = new Point(273, 158);
            lblSelectEndDateText.Name = "lblSelectEndDateText";
            lblSelectEndDateText.Size = new Size(117, 20);
            lblSelectEndDateText.TabIndex = 3;
            lblSelectEndDateText.Text = "Select End Date:";
            // 
            // backButton
            // 
            backButton.Location = new Point(442, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(83, 31);
            backButton.TabIndex = 4;
            backButton.Text = "< Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // IncomeUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 400);
            Controls.Add(backButton);
            Controls.Add(lblSelectEndDateText);
            Controls.Add(lblSelectDateText);
            Controls.Add(cbSingleDay);
            Controls.Add(dtpEndDay);
            Controls.Add(dtpStartDay);
            Controls.Add(lblIncomeByDate);
            Controls.Add(lblAllTimeIncome);
            Controls.Add(lblIncomeByDateText);
            Controls.Add(lblAllTimeIncomeText);
            Name = "IncomeUI";
            Text = "RevenueUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAllTimeIncomeText;
        private Label lblAllTimeIncome;
        private Label lblIncomeByDateText;
        private Label lblIncomeByDate;
        private DateTimePicker dtpStartDay;
        private CheckBox cbSingleDay;
        private DateTimePicker dtpEndDay;
        private Label lblSelectDateText;
        private Label lblSelectEndDateText;
        private Button backButton;
    }
}