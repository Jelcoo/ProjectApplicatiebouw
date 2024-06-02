namespace ChapeauUI.PaymentUI
{
    partial class PaymentPromptPanel
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
            lblPerson = new Label();
            lblPercentage = new Label();
            lblPrice = new Label();
            lblPaymentMethod = new Label();
            btnPay = new Button();
            SuspendLayout();
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(12, 9);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(46, 15);
            lblPerson.TabIndex = 0;
            lblPerson.Text = "Person ";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(12, 33);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(72, 15);
            lblPercentage.TabIndex = 1;
            lblPercentage.Text = "Percentage: ";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 48);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(93, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Amount to Pay: ";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(12, 63);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(105, 15);
            lblPaymentMethod.TabIndex = 3;
            lblPaymentMethod.Text = "Payment Method: ";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(12, 81);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(335, 25);
            btnPay.TabIndex = 4;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // PaymentPromptPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 114);
            Controls.Add(btnPay);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblPrice);
            Controls.Add(lblPercentage);
            Controls.Add(lblPerson);
            Name = "PaymentPromptPanel";
            Text = "PaymentPromptPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPerson;
        private Label lblPercentage;
        private Label lblPrice;
        private Label lblPaymentMethod;
        private Button btnPay;
    }
}