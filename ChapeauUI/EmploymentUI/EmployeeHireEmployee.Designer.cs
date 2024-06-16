namespace ChapeauUI.EmploymentUI
{
    partial class EmployeeHireEmployee
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
            cbRoles = new ComboBox();
            btnConfirmEdit = new Button();
            btnCancelEdit = new Button();
            inputEmployeeName = new TextBox();
            lblRoleText = new Label();
            lblPasswordText = new Label();
            lblNameText = new Label();
            inputPassword = new TextBox();
            SuspendLayout();
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(165, 119);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(151, 28);
            cbRoles.TabIndex = 18;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Location = new Point(337, 178);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(94, 29);
            btnConfirmEdit.TabIndex = 16;
            btnConfirmEdit.Text = "Confirm";
            btnConfirmEdit.UseVisualStyleBackColor = true;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Location = new Point(12, 178);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(94, 29);
            btnCancelEdit.TabIndex = 17;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // inputEmployeeName
            // 
            inputEmployeeName.Location = new Point(165, 28);
            inputEmployeeName.Name = "inputEmployeeName";
            inputEmployeeName.Size = new Size(250, 27);
            inputEmployeeName.TabIndex = 14;
            // 
            // lblRoleText
            // 
            lblRoleText.Location = new Point(59, 119);
            lblRoleText.Name = "lblRoleText";
            lblRoleText.Size = new Size(100, 25);
            lblRoleText.TabIndex = 11;
            lblRoleText.Text = "Role:";
            lblRoleText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPasswordText
            // 
            lblPasswordText.Location = new Point(59, 78);
            lblPasswordText.Name = "lblPasswordText";
            lblPasswordText.Size = new Size(100, 25);
            lblPasswordText.TabIndex = 12;
            lblPasswordText.Text = "Password:";
            lblPasswordText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNameText
            // 
            lblNameText.Location = new Point(59, 28);
            lblNameText.Name = "lblNameText";
            lblNameText.Size = new Size(100, 25);
            lblNameText.TabIndex = 13;
            lblNameText.Text = "Name:";
            lblNameText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(165, 76);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(250, 27);
            inputPassword.TabIndex = 14;
            // 
            // EmployeeHireEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 224);
            Controls.Add(cbRoles);
            Controls.Add(btnConfirmEdit);
            Controls.Add(btnCancelEdit);
            Controls.Add(inputPassword);
            Controls.Add(inputEmployeeName);
            Controls.Add(lblRoleText);
            Controls.Add(lblPasswordText);
            Controls.Add(lblNameText);
            Name = "EmployeeHireEmployee";
            Text = "EmployeeAddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRoles;
        private Button btnConfirmEdit;
        private Button btnCancelEdit;
        private DateTimePicker dtpEmployedAt;
        private TextBox inputEmployeeName;
        private Label lblRoleText;
        private Label lblPasswordText;
        private Label lblNameText;
        private TextBox inputPassword;
    }
}