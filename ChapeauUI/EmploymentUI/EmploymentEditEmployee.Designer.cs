namespace ChapeauUI.EmploymentUI
{
    partial class EmploymentEditEmployee
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
            lblEmployedAtText = new Label();
            lblNameText = new Label();
            inputEmployeeName = new TextBox();
            dtpEmployedAt = new DateTimePicker();
            btnCancelEdit = new Button();
            btnConfirmEdit = new Button();
            lblRoleText = new Label();
            cbRoles = new ComboBox();
            SuspendLayout();
            // 
            // lblEmployedAtText
            // 
            lblEmployedAtText.Location = new Point(12, 82);
            lblEmployedAtText.Name = "lblEmployedAtText";
            lblEmployedAtText.Size = new Size(100, 25);
            lblEmployedAtText.TabIndex = 5;
            lblEmployedAtText.Text = "Employed At:";
            lblEmployedAtText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNameText
            // 
            lblNameText.Location = new Point(12, 32);
            lblNameText.Name = "lblNameText";
            lblNameText.Size = new Size(100, 25);
            lblNameText.TabIndex = 6;
            lblNameText.Text = "Name:";
            lblNameText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputEmployeeName
            // 
            inputEmployeeName.Location = new Point(118, 32);
            inputEmployeeName.Name = "inputEmployeeName";
            inputEmployeeName.Size = new Size(250, 27);
            inputEmployeeName.TabIndex = 7;
            // 
            // dtpEmployedAt
            // 
            dtpEmployedAt.Location = new Point(118, 83);
            dtpEmployedAt.Name = "dtpEmployedAt";
            dtpEmployedAt.Size = new Size(250, 27);
            dtpEmployedAt.TabIndex = 8;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Location = new Point(12, 167);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(94, 29);
            btnCancelEdit.TabIndex = 9;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Location = new Point(274, 167);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(94, 29);
            btnConfirmEdit.TabIndex = 9;
            btnConfirmEdit.Text = "Confirm";
            btnConfirmEdit.UseVisualStyleBackColor = true;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // lblRoleText
            // 
            lblRoleText.Location = new Point(12, 123);
            lblRoleText.Name = "lblRoleText";
            lblRoleText.Size = new Size(100, 25);
            lblRoleText.TabIndex = 5;
            lblRoleText.Text = "Role:";
            lblRoleText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(118, 123);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(151, 28);
            cbRoles.TabIndex = 10;
            // 
            // EmploymentEditEmployee
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
            Name = "EmploymentEditEmployee";
            Text = "EmploymentEditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployedAtText;
        private Label lblNameText;
        private TextBox inputEmployeeName;
        private DateTimePicker dtpEmployedAt;
        private Button btnCancelEdit;
        private Button btnConfirmEdit;
        private Label lblRoleText;
        private ComboBox cbRoles;
    }
}