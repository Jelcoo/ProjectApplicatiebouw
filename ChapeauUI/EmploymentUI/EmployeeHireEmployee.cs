using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using ChapeauModel;
using ChapeauModel.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI.EmploymentUI
{
    public partial class EmployeeHireEmployee : Form
    {
        private EmployeeManagement _parentForm;
        private EmployeeService _employeeService;


        public EmployeeHireEmployee(EmployeeManagement parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _employeeService = new EmployeeService();
            LoadRoles();
        }

        private void LoadRoles()
        {
            // Roles
            cbRoles.Items.Clear();
            cbRoles.DataSource = Enum.GetValues(typeof(ERole));
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (CheckIfAllFilled())
            {
                try
                {
                    //Asks employeeService to hire Employee
                    Employee hiredEmployee = GetEmployeeData();
                    _employeeService.HireEmployee(hiredEmployee);

                    MessageBox.Show($"Succesfully hired {hiredEmployee.Name} the {hiredEmployee.Role}!");

                    //Reloads parent form
                    _parentForm.Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CheckIfAllFilled()
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

        private Employee GetEmployeeData()
        {
            //Gets all employee data from inputs
            return new Employee(
                inputEmployeeName.Text,
                inputPassword.Text,
                DateTime.Now,
                (ERole)cbRoles.SelectedValue);
        }
    }
}
