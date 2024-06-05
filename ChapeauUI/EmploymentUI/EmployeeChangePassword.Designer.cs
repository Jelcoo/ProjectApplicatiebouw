namespace ChapeauUI.EmploymentUI
{
    partial class EmployeeChangePassword
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
            inputCurrentPassword = new TextBox();
            inputNewPassword1 = new TextBox();
            inputNewPassword2 = new TextBox();
            lblCurrentPasswordText = new Label();
            lblNewPasswordText = new Label();
            label1 = new Label();
            lblRepeatPasswordText = new Label();
            cbRepeatPasswordCorrect = new CheckBox();
            btnConfirmChangePassword = new Button();
            btnCancelChangePassword = new Button();
            SuspendLayout();
            // 
            // inputCurrentPassword
            // 
            inputCurrentPassword.Location = new Point(23, 68);
            inputCurrentPassword.Name = "inputCurrentPassword";
            inputCurrentPassword.Size = new Size(185, 27);
            inputCurrentPassword.TabIndex = 0;
            // 
            // inputNewPassword1
            // 
            inputNewPassword1.Location = new Point(23, 191);
            inputNewPassword1.Name = "inputNewPassword1";
            inputNewPassword1.Size = new Size(185, 27);
            inputNewPassword1.TabIndex = 1;
            // 
            // inputNewPassword2
            // 
            inputNewPassword2.Location = new Point(23, 279);
            inputNewPassword2.Name = "inputNewPassword2";
            inputNewPassword2.Size = new Size(185, 27);
            inputNewPassword2.TabIndex = 2;
            inputNewPassword2.TextChanged += inputNewPassword2_TextChanged;
            // 
            // lblCurrentPasswordText
            // 
            lblCurrentPasswordText.AutoSize = true;
            lblCurrentPasswordText.Location = new Point(23, 27);
            lblCurrentPasswordText.Name = "lblCurrentPasswordText";
            lblCurrentPasswordText.Size = new Size(125, 20);
            lblCurrentPasswordText.TabIndex = 3;
            lblCurrentPasswordText.Text = "Current Password:";
            // 
            // lblNewPasswordText
            // 
            lblNewPasswordText.AutoSize = true;
            lblNewPasswordText.Location = new Point(23, 168);
            lblNewPasswordText.Name = "lblNewPasswordText";
            lblNewPasswordText.Size = new Size(107, 20);
            lblNewPasswordText.TabIndex = 3;
            lblNewPasswordText.Text = "New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 235);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // lblRepeatPasswordText
            // 
            lblRepeatPasswordText.AutoSize = true;
            lblRepeatPasswordText.Location = new Point(23, 256);
            lblRepeatPasswordText.Name = "lblRepeatPasswordText";
            lblRepeatPasswordText.Size = new Size(124, 20);
            lblRepeatPasswordText.TabIndex = 3;
            lblRepeatPasswordText.Text = "Repeat Password:";
            // 
            // cbRepeatPasswordCorrect
            // 
            cbRepeatPasswordCorrect.AutoSize = true;
            cbRepeatPasswordCorrect.Enabled = false;
            cbRepeatPasswordCorrect.Location = new Point(153, 259);
            cbRepeatPasswordCorrect.Name = "cbRepeatPasswordCorrect";
            cbRepeatPasswordCorrect.Size = new Size(18, 17);
            cbRepeatPasswordCorrect.TabIndex = 4;
            cbRepeatPasswordCorrect.UseVisualStyleBackColor = true;
            // 
            // btnConfirmChangePassword
            // 
            btnConfirmChangePassword.Location = new Point(190, 346);
            btnConfirmChangePassword.Name = "btnConfirmChangePassword";
            btnConfirmChangePassword.Size = new Size(94, 29);
            btnConfirmChangePassword.TabIndex = 5;
            btnConfirmChangePassword.Text = "Confirm";
            btnConfirmChangePassword.UseVisualStyleBackColor = true;
            btnConfirmChangePassword.Click += btnConfirmChangePassword_Click;
            // 
            // btnCancelChangePassword
            // 
            btnCancelChangePassword.Location = new Point(12, 346);
            btnCancelChangePassword.Name = "btnCancelChangePassword";
            btnCancelChangePassword.Size = new Size(94, 29);
            btnCancelChangePassword.TabIndex = 5;
            btnCancelChangePassword.Text = "Cancel";
            btnCancelChangePassword.UseVisualStyleBackColor = true;
            btnCancelChangePassword.Click += btnCancelChangePassword_Click;
            // 
            // EmployeeChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 387);
            Controls.Add(btnCancelChangePassword);
            Controls.Add(btnConfirmChangePassword);
            Controls.Add(cbRepeatPasswordCorrect);
            Controls.Add(label1);
            Controls.Add(lblRepeatPasswordText);
            Controls.Add(lblNewPasswordText);
            Controls.Add(lblCurrentPasswordText);
            Controls.Add(inputNewPassword2);
            Controls.Add(inputNewPassword1);
            Controls.Add(inputCurrentPassword);
            Name = "EmployeeChangePassword";
            Text = "EmployeeChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputCurrentPassword;
        private TextBox inputNewPassword1;
        private TextBox inputNewPassword2;
        private Label lblCurrentPasswordText;
        private Label lblNewPasswordText;
        private Label label1;
        private Label lblRepeatPasswordText;
        private CheckBox cbRepeatPasswordCorrect;
        private Button btnConfirmChangePassword;
        private Button btnCancelChangePassword;
    }
}