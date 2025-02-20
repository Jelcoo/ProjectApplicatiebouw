﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauDAL;
using ChapeauService;
using ChapeauModel.Enums;
using ChapeauModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace ChapeauUI.EmploymentUI
{
    public partial class EmployeeManagement : Form
    {
        private EmployeeService _employeeService;
        private ListView currentListView;

        public EmployeeManagement()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            SetDefaultStartListView();
        }

        private void SetDefaultStartListView()
        {
            // Sets the default listview to Waiters
            currentListView = lvWaiters;
            SwitchListView(lvWaiters);
            FillListView(ERole.Waiter, lvWaiters);
        }

        private void SwitchListView(ListView switchListView)
        {
            // Switches the listview to the selected listview
            HideAllListViews();
            switchListView.Visible = true;
        }

        private void HideAllListViews()
        {
            // Hides ALL listviews
            foreach (Control control in this.Controls)
            {
                if (control is ListView) { control.Visible = false; }
            }
        }

        private void FillListView(ERole role, ListView listview)
        {
            // Clears previous data
            listview.Items.Clear();

            try
            {
                List<Employee> employees = new List<Employee>();

                // Asks employeeService for employees by role
                employees = _employeeService.GetEmployeesByRole(role);

                //Sets the data 
                foreach (Employee employee in employees)
                {
                    ListViewItem item = new ListViewItem(employee.EmployeeId.ToString());
                    item.Tag = employee;
                    item.SubItems.Add(employee.Name);
                    item.SubItems.Add(employee.EmployedAt.ToShortDateString());
                    item.SubItems.Add(employee.Role.ToString());
                    listview.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MakeTextVisible()
        {
            lblSelectAnEmployeeText.Visible = false;

            lblEmployeeName.Visible = true;
            lblIdText.Visible = true;
            lblEmployeeId.Visible = true;
            lblEmployedAtText.Visible = true;
            lblEmployedAt.Visible = true;

            btnEditEmployee.Visible = true;
            btnFireEmployee.Visible = true;
            btnChangePasswordEmployee.Visible = true;
        }

        private void MakeTextInvisible()
        {
            lblSelectAnEmployeeText.Visible = true;

            lblEmployeeName.Visible = false;
            lblIdText.Visible = false;
            lblEmployeeId.Visible = false;
            lblEmployedAtText.Visible = false;
            lblEmployedAt.Visible = false;

            btnEditEmployee.Visible = false;
            btnFireEmployee.Visible = false;
            btnChangePasswordEmployee.Visible = false;
        }

        private void btnWaitersTab_Click(object sender, EventArgs e)
        {
            currentListView = lvWaiters;
            SwitchListView(lvWaiters);
            FillListView(ERole.Waiter, lvWaiters);

        }
        private void btnChefsTab_Click(object sender, EventArgs e)
        {
            currentListView = lvChefs;
            SwitchListView(lvChefs);
            FillListView(ERole.Chef, lvChefs);
        }
        private void btnBartendersTab_Click(object sender, EventArgs e)
        {
            currentListView = lvBartenders;
            SwitchListView(lvBartenders);
            FillListView(ERole.Bartender, lvBartenders);
        }
        private void btnManagersTab_Click(object sender, EventArgs e)
        {
            currentListView = lvManagers;
            SwitchListView(lvManagers);
            FillListView(ERole.Manager, lvManagers);
        }

        private void AllListViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = currentListView.SelectedItems[0];
                Employee selectedEmployee = selectedItem.Tag as Employee;

                if (selectedEmployee != null)
                {
                    LoadEmployee(selectedEmployee);
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Opens new HireEmplyee
            new EmployeeHireEmployee(this).ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            // Opens new EditEmployee, adds SelectedEmployee and parentform
            new EmploymentEditEmployee(this, GetSelectedEmployee()).ShowDialog();
        }

        private void btnChangePasswordEmployee_Click(object sender, EventArgs e)
        {
            // Opens new ChangePassword, adds SelectedEmployee and parentform
            new EmployeeChangePassword(this, GetSelectedEmployee()).ShowDialog();
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to fire {GetSelectedEmployee().Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Gets currentEmployee
                    Employee currentEmployee = GetSelectedEmployee();

                    //Asks employeeService to fire current employee
                    _employeeService.FireEmployee(currentEmployee);
                    MessageBox.Show($"Successfully fired {currentEmployee.Name}");

                    //Reloads form
                    this.Reload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Back to ChapeauPanel
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }

        public void Reload()
        {
            SwitchListView(currentListView);
            MakeTextInvisible();
        }

        private void LoadEmployee(Employee employee)
        {
            //Shows all labels & buttons
            MakeTextVisible();

            //Sets currentEmployee data to the labels
            lblEmployeeName.Text = employee.Name;
            lblEmployeeId.Text = employee.EmployeeId.ToString();

            //Formats the EmployeAt date
            string formattedDate = $"{employee.EmployedAt:MMM} {employee.EmployedAt.Day}{GetDaySuffix(employee.EmployedAt.Day)} {employee.EmployedAt.Year}";

            lblEmployedAt.Text = formattedDate;
        }

        private Employee GetSelectedEmployee()
        {
            // Gets the currentEmployee
            ListViewItem listViewItem = currentListView.SelectedItems[0];
            return listViewItem.Tag as Employee;
        }

        private string GetDaySuffix(int day)
        {
            // Returns daysuffix depending on day
            if (day >= 11 && day <= 13)
            {
                return "th";
            }

            switch (day % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }
    }
}
