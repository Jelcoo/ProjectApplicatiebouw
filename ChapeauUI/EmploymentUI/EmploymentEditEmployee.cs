using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI.EmploymentUI
{
    public partial class EmploymentEditEmployee : Form
    {
        private EmployeeManagement _parentForm;
        private EmployeeService _employeeService;

        private Employee currentEmployee;

        public EmploymentEditEmployee(EmployeeManagement parentForm, Employee employee)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _employeeService = new EmployeeService();

            // Sets current employee
            currentEmployee = employee;

            LoadRoles();
            LoadEmployeeData(currentEmployee);
        }

        private void LoadRoles()
        {
            // Roles
            cbRoles.Items.Clear();
            cbRoles.DataSource = Enum.GetValues(typeof(ERole));
        }

        private void LoadEmployeeData(Employee employee)
        {
            //Sets employee data to the labels and dateTimePicker
            inputEmployeeName.Text = employee.Name;
            dtpEmployedAt.Value = employee.EmployedAt;
            cbRoles.SelectedIndex = (int)employee.Role - 1;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to commit changes to {currentEmployee.Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && CheckIfAllFilled())
            {
                //Gets the newEmployeeData
                Employee newEmployee = GetNewData();

                try
                {
                    //Asks employeeService to edit Employee
                    _employeeService.EditEmployee(newEmployee);

                    MessageBox.Show("Employee edited successfully");

                    //Reload parent form
                    _parentForm.Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public bool CheckIfAllFilled()
        {
            //Checks if employeeName is filled in
            if (string.IsNullOrEmpty(inputEmployeeName.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
        }

        private Employee GetNewData()
        {
            //Gets all employee data from inputs
            return new Employee(
                currentEmployee.EmployeeId,
                inputEmployeeName.Text,
                string.Empty, //Cant change password here
                dtpEmployedAt.Value,
                (ERole)cbRoles.SelectedValue);
        }
    }
}
