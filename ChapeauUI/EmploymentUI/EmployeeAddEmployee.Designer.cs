namespace ChapeauUI.EmploymentUI
{
    partial class EmployeeAddEmployee
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
            dtpEmployedAt = new DateTimePicker();
            inputEmployeeName = new TextBox();
            lblRoleText = new Label();
            lblEmployedAtText = new Label();
            lblNameText = new Label();
            SuspendLayout();
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(122, 113);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(151, 28);
            cbRoles.TabIndex = 18;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Location = new Point(278, 157);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(94, 29);
            btnConfirmEdit.TabIndex = 16;
            btnConfirmEdit.Text = "Confirm";
            btnConfirmEdit.UseVisualStyleBackColor = true;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Location = new Point(16, 157);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(94, 29);
            btnCancelEdit.TabIndex = 17;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // dtpEmployedAt
            // 
            dtpEmployedAt.Location = new Point(122, 73);
            dtpEmployedAt.Name = "dtpEmployedAt";
            dtpEmployedAt.Size = new Size(250, 27);
            dtpEmployedAt.TabIndex = 15;
            // 
            // inputEmployeeName
            // 
            inputEmployeeName.Location = new Point(122, 22);
            inputEmployeeName.Name = "inputEmployeeName";
            inputEmployeeName.Size = new Size(250, 27);
            inputEmployeeName.TabIndex = 14;
            // 
            // lblRoleText
            // 
            lblRoleText.Location = new Point(16, 113);
            lblRoleText.Name = "lblRoleText";
            lblRoleText.Size = new Size(100, 25);
            lblRoleText.TabIndex = 11;
            lblRoleText.Text = "Role:";
            lblRoleText.TextAlign = ContentAlignment.MiddleRight;
            lblRoleText.Visible = false;
            // 
            // lblEmployedAtText
            // 
            lblEmployedAtText.Location = new Point(16, 72);
            lblEmployedAtText.Name = "lblEmployedAtText";
            lblEmployedAtText.Size = new Size(100, 25);
            lblEmployedAtText.TabIndex = 12;
            lblEmployedAtText.Text = "Employed At:";
            lblEmployedAtText.TextAlign = ContentAlignment.MiddleRight;
            lblEmployedAtText.Visible = false;
            // 
            // lblNameText
            // 
            lblNameText.Location = new Point(16, 22);
            lblNameText.Name = "lblNameText";
            lblNameText.Size = new Size(100, 25);
            lblNameText.TabIndex = 13;
            lblNameText.Text = "Name:";
            lblNameText.TextAlign = ContentAlignment.MiddleRight;
            lblNameText.Visible = false;
            // 
            // EmployeeAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 208);
            Controls.Add(cbRoles);
            Controls.Add(btnConfirmEdit);
            Controls.Add(btnCancelEdit);
            Controls.Add(dtpEmployedAt);
            Controls.Add(inputEmployeeName);
            Controls.Add(lblRoleText);
            Controls.Add(lblEmployedAtText);
            Controls.Add(lblNameText);
            Name = "EmployeeAddEmployee";
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
        private Label lblEmployedAtText;
        private Label lblNameText;
    }
}