namespace ChapeauUI.EmploymentUI
{
    partial class EmployeeManagement
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
            btnWaitersTab = new Button();
            btnChefsTab = new Button();
            btnBartendersTab = new Button();
            btnManagersTab = new Button();
            lvWaiters = new ListView();
            WEmployeeId = new ColumnHeader();
            WEmployeeName = new ColumnHeader();
            WEmployedAt = new ColumnHeader();
            WRole = new ColumnHeader();
            lvChefs = new ListView();
            CEmployeeId = new ColumnHeader();
            CEmployeeName = new ColumnHeader();
            CEmployedAt = new ColumnHeader();
            CRole = new ColumnHeader();
            lvBartenders = new ListView();
            BEmployeeId = new ColumnHeader();
            BEmployeeName = new ColumnHeader();
            BEmployedAt = new ColumnHeader();
            BRole = new ColumnHeader();
            lvManagers = new ListView();
            MEmployeeId = new ColumnHeader();
            MEmployeeName = new ColumnHeader();
            MEmployedAt = new ColumnHeader();
            MRole = new ColumnHeader();
            btnAddEmployee = new Button();
            pbEmployee = new PictureBox();
            lblEmployeeName = new Label();
            lblIdText = new Label();
            lblEmployeeId = new Label();
            lblEmployedAtText = new Label();
            lblEmployedAt = new Label();
            btnFireEmployee = new Button();
            btnEditEmployee = new Button();
            btnChangePasswordEmployee = new Button();
            lblSelectAnEmployeeText = new Label();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnWaitersTab
            // 
            btnWaitersTab.Location = new Point(12, 12);
            btnWaitersTab.Name = "btnWaitersTab";
            btnWaitersTab.Size = new Size(94, 29);
            btnWaitersTab.TabIndex = 0;
            btnWaitersTab.Text = "Waiters";
            btnWaitersTab.UseVisualStyleBackColor = true;
            btnWaitersTab.Click += btnWaitersTab_Click;
            // 
            // btnChefsTab
            // 
            btnChefsTab.Location = new Point(112, 12);
            btnChefsTab.Name = "btnChefsTab";
            btnChefsTab.Size = new Size(94, 29);
            btnChefsTab.TabIndex = 0;
            btnChefsTab.Text = "Chefs";
            btnChefsTab.UseVisualStyleBackColor = true;
            btnChefsTab.Click += btnChefsTab_Click;
            // 
            // btnBartendersTab
            // 
            btnBartendersTab.Location = new Point(212, 12);
            btnBartendersTab.Name = "btnBartendersTab";
            btnBartendersTab.Size = new Size(94, 29);
            btnBartendersTab.TabIndex = 0;
            btnBartendersTab.Text = "Bartenders";
            btnBartendersTab.UseVisualStyleBackColor = true;
            btnBartendersTab.Click += btnBartendersTab_Click;
            // 
            // btnManagersTab
            // 
            btnManagersTab.Location = new Point(312, 12);
            btnManagersTab.Name = "btnManagersTab";
            btnManagersTab.Size = new Size(94, 29);
            btnManagersTab.TabIndex = 0;
            btnManagersTab.Text = "Managers";
            btnManagersTab.UseVisualStyleBackColor = true;
            btnManagersTab.Click += btnManagersTab_Click;
            // 
            // lvWaiters
            // 
            lvWaiters.Columns.AddRange(new ColumnHeader[] { WEmployeeId, WEmployeeName, WEmployedAt, WRole });
            lvWaiters.FullRowSelect = true;
            lvWaiters.Location = new Point(12, 47);
            lvWaiters.MultiSelect = false;
            lvWaiters.Name = "lvWaiters";
            lvWaiters.Size = new Size(550, 457);
            lvWaiters.TabIndex = 0;
            lvWaiters.UseCompatibleStateImageBehavior = false;
            lvWaiters.View = View.Details;
            lvWaiters.SelectedIndexChanged += AllListViews_SelectedIndexChanged;
            // 
            // WEmployeeId
            // 
            WEmployeeId.Text = "Id";
            WEmployeeId.Width = 31;
            // 
            // WEmployeeName
            // 
            WEmployeeName.Text = "Name";
            WEmployeeName.Width = 52;
            // 
            // WEmployedAt
            // 
            WEmployedAt.Text = "Day Of Employement";
            WEmployedAt.Width = 154;
            // 
            // WRole
            // 
            WRole.Text = "Role";
            WRole.Width = 280;
            // 
            // lvChefs
            // 
            lvChefs.Columns.AddRange(new ColumnHeader[] { CEmployeeId, CEmployeeName, CEmployedAt, CRole });
            lvChefs.FullRowSelect = true;
            lvChefs.Location = new Point(12, 47);
            lvChefs.MultiSelect = false;
            lvChefs.Name = "lvChefs";
            lvChefs.Size = new Size(550, 457);
            lvChefs.TabIndex = 0;
            lvChefs.UseCompatibleStateImageBehavior = false;
            lvChefs.View = View.Details;
            lvChefs.SelectedIndexChanged += AllListViews_SelectedIndexChanged;
            // 
            // CEmployeeId
            // 
            CEmployeeId.Text = "Id";
            // 
            // CEmployeeName
            // 
            CEmployeeName.Text = "Name";
            // 
            // CEmployedAt
            // 
            CEmployedAt.Text = "Day Of Employement";
            // 
            // CRole
            // 
            CRole.Text = "Role";
            // 
            // lvBartenders
            // 
            lvBartenders.Columns.AddRange(new ColumnHeader[] { BEmployeeId, BEmployeeName, BEmployedAt, BRole });
            lvBartenders.FullRowSelect = true;
            lvBartenders.Location = new Point(12, 47);
            lvBartenders.MultiSelect = false;
            lvBartenders.Name = "lvBartenders";
            lvBartenders.Size = new Size(550, 457);
            lvBartenders.TabIndex = 0;
            lvBartenders.UseCompatibleStateImageBehavior = false;
            lvBartenders.View = View.Details;
            lvBartenders.SelectedIndexChanged += AllListViews_SelectedIndexChanged;
            // 
            // BEmployeeId
            // 
            BEmployeeId.Text = "Id";
            // 
            // BEmployeeName
            // 
            BEmployeeName.Text = "Name";
            // 
            // BEmployedAt
            // 
            BEmployedAt.Text = "Day Of Employement";
            // 
            // BRole
            // 
            BRole.Text = "Role";
            // 
            // lvManagers
            // 
            lvManagers.Columns.AddRange(new ColumnHeader[] { MEmployeeId, MEmployeeName, MEmployedAt, MRole });
            lvManagers.FullRowSelect = true;
            lvManagers.Location = new Point(12, 47);
            lvManagers.MultiSelect = false;
            lvManagers.Name = "lvManagers";
            lvManagers.Size = new Size(550, 457);
            lvManagers.TabIndex = 0;
            lvManagers.UseCompatibleStateImageBehavior = false;
            lvManagers.View = View.Details;
            lvManagers.SelectedIndexChanged += AllListViews_SelectedIndexChanged;
            // 
            // MEmployeeId
            // 
            MEmployeeId.Text = "Id";
            // 
            // MEmployeeName
            // 
            MEmployeeName.Text = "Name";
            // 
            // MEmployedAt
            // 
            MEmployedAt.Text = "Day Of Employement";
            // 
            // MRole
            // 
            MRole.Text = "Role";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(618, 469);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(200, 35);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // pbEmployee
            // 
            pbEmployee.Location = new Point(618, 155);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(200, 200);
            pbEmployee.TabIndex = 2;
            pbEmployee.TabStop = false;
            pbEmployee.Visible = false;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Location = new Point(618, 12);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(200, 50);
            lblEmployeeName.TabIndex = 3;
            lblEmployeeName.TextAlign = ContentAlignment.MiddleCenter;
            lblEmployeeName.Visible = false;
            // 
            // lblIdText
            // 
            lblIdText.Location = new Point(618, 86);
            lblIdText.Name = "lblIdText";
            lblIdText.Size = new Size(100, 25);
            lblIdText.TabIndex = 4;
            lblIdText.Text = "Id:";
            lblIdText.TextAlign = ContentAlignment.MiddleRight;
            lblIdText.Visible = false;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeId.Location = new Point(718, 86);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(100, 25);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.TextAlign = ContentAlignment.MiddleLeft;
            lblEmployeeId.Visible = false;
            // 
            // lblEmployedAtText
            // 
            lblEmployedAtText.Location = new Point(618, 111);
            lblEmployedAtText.Name = "lblEmployedAtText";
            lblEmployedAtText.Size = new Size(100, 25);
            lblEmployedAtText.TabIndex = 4;
            lblEmployedAtText.Text = "Employed At:";
            lblEmployedAtText.TextAlign = ContentAlignment.MiddleRight;
            lblEmployedAtText.Visible = false;
            // 
            // lblEmployedAt
            // 
            lblEmployedAt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployedAt.Location = new Point(718, 111);
            lblEmployedAt.Name = "lblEmployedAt";
            lblEmployedAt.Size = new Size(144, 25);
            lblEmployedAt.TabIndex = 4;
            lblEmployedAt.TextAlign = ContentAlignment.MiddleLeft;
            lblEmployedAt.Visible = false;
            // 
            // btnFireEmployee
            // 
            btnFireEmployee.Location = new Point(724, 376);
            btnFireEmployee.Name = "btnFireEmployee";
            btnFireEmployee.Size = new Size(94, 29);
            btnFireEmployee.TabIndex = 5;
            btnFireEmployee.Text = "Fire";
            btnFireEmployee.UseVisualStyleBackColor = true;
            btnFireEmployee.Visible = false;
            btnFireEmployee.Click += btnFireEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(618, 376);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(94, 29);
            btnEditEmployee.TabIndex = 5;
            btnEditEmployee.Text = "Edit";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Visible = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnChangePasswordEmployee
            // 
            btnChangePasswordEmployee.Location = new Point(618, 411);
            btnChangePasswordEmployee.Name = "btnChangePasswordEmployee";
            btnChangePasswordEmployee.Size = new Size(200, 29);
            btnChangePasswordEmployee.TabIndex = 5;
            btnChangePasswordEmployee.Text = "Change Password";
            btnChangePasswordEmployee.UseVisualStyleBackColor = true;
            btnChangePasswordEmployee.Visible = false;
            btnChangePasswordEmployee.Click += btnChangePasswordEmployee_Click;
            // 
            // lblSelectAnEmployeeText
            // 
            lblSelectAnEmployeeText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectAnEmployeeText.Location = new Point(618, 180);
            lblSelectAnEmployeeText.Name = "lblSelectAnEmployeeText";
            lblSelectAnEmployeeText.Size = new Size(200, 30);
            lblSelectAnEmployeeText.TabIndex = 6;
            lblSelectAnEmployeeText.Text = "Select an Employee";
            lblSelectAnEmployeeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 516);
            Controls.Add(lblSelectAnEmployeeText);
            Controls.Add(btnChangePasswordEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnFireEmployee);
            Controls.Add(lblEmployedAt);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblEmployedAtText);
            Controls.Add(lblIdText);
            Controls.Add(lblEmployeeName);
            Controls.Add(pbEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lvWaiters);
            Controls.Add(lvChefs);
            Controls.Add(lvBartenders);
            Controls.Add(lvManagers);
            Controls.Add(btnManagersTab);
            Controls.Add(btnBartendersTab);
            Controls.Add(btnChefsTab);
            Controls.Add(btnWaitersTab);
            Name = "EmployeeManagement";
            Text = "EmployeeManagement";
            ((System.ComponentModel.ISupportInitialize)pbEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWaitersTab;
        private Button btnChefsTab;
        private Button btnBartendersTab;
        private Button btnManagersTab;
        private ListView lvWaiters;
        private ColumnHeader WEmployeeId;
        private ColumnHeader WEmployeeName;
        private ColumnHeader WEmployedAt;
        private ListView lvChefs;
        private ColumnHeader CEmployeeId;
        private ColumnHeader CEmployeeName;
        private ColumnHeader CEmployedAt;
        private ColumnHeader WRole;
        private ListView lvBartenders;
        private ColumnHeader BEmployeeId;
        private ColumnHeader BEmployeeName;
        private ColumnHeader BEmployedAt;
        private ListView lvManagers;
        private ColumnHeader MEmployeeId;
        private ColumnHeader MEmployeeName;
        private ColumnHeader MEmployedAt;
        private ColumnHeader CRole;
        private ColumnHeader BRole;
        private ColumnHeader MRole;
        private Button btnAddEmployee;
        private PictureBox pbEmployee;
        private Label lblEmployeeName;
        private Label lblIdText;
        private Label lblEmployeeId;
        private Label lblEmployedAtText;
        private Label lblEmployedAt;
        private Button btnFireEmployee;
        private Button btnEditEmployee;
        private Button btnChangePasswordEmployee;
        private Label lblSelectAnEmployeeText;
    }
}