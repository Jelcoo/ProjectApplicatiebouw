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

        public EmploymentEditEmployee(EmployeeManagement parentForm, Employee employee)
        {
            InitializeComponent();
            _parentForm = parentForm;
            currentEmployee = employee;
            LoadRoles();
            LoadEmployeeData(currentEmployee);
        }

        public void LoadRoles()
        {
            EmployeeService employeeService = new EmployeeService();

            // MenuType's
            cbRoles.Items.Clear();
            cbRoles.DataSource = Enum.GetValues(typeof(ERole));
        }

        public void LoadEmployeeData(Employee employee)
        {
            inputEmployeeName.Text = employee.Name;
            dtpEmployedAt.Value = employee.EmployedAt;
            cbRoles.SelectedIndex = (int)employee.Role - 1;
        }

        public Employee GetNewData()
        {
            return new Employee(
                currentEmployee.EmployeeId,
                inputEmployeeName.Text,
                string.Empty, //Cant change password here
                dtpEmployedAt.Value,
                (ERole)cbRoles.SelectedValue);
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
                EmployeeService employeeService = new EmployeeService();
                Employee newEmployee = GetNewData();

                try
                {
                    employeeService.EditEmployee(newEmployee);

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
    }
}
