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
        private Employee currentEmployee;
        private EmployeeService _employeeService;

        public EmploymentEditEmployee(EmployeeManagement parentForm, Employee employee)
        {
            InitializeComponent();
            _parentForm = parentForm;
            currentEmployee = employee;
            _employeeService = new EmployeeService();

            LoadRoles();
            LoadEmployeeData(currentEmployee);
        }

        private void LoadRoles()
        {
            EmployeeService employeeService = new EmployeeService();

            // Roles
            cbRoles.Items.Clear();
            cbRoles.DataSource = Enum.GetValues(typeof(ERole));
        }

        private void LoadEmployeeData(Employee employee)
        {
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

            if (result == DialogResult.Yes)
            {
                Employee newEmployee = GetNewData();

                try
                {
                    _employeeService.EditEmployee(newEmployee);

                    MessageBox.Show("Employee edited successfully");

                    _parentForm.Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Employee GetNewData()
        {
            return new Employee(
                currentEmployee.EmployeeId,
                inputEmployeeName.Text,
                string.Empty, //Cant change password here
                dtpEmployedAt.Value,
                (ERole)cbRoles.SelectedValue);
        }
    }
}
