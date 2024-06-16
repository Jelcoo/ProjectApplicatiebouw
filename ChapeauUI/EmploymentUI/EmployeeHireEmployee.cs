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
        EmployeeManagement _parentForm;

        public EmployeeHireEmployee(EmployeeManagement parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            LoadRoles();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (CheckIfAllFilled())
            {
                try
                {
                    EmployeeService employeeService = new EmployeeService();
                    employeeService.HireEmployee(GetEmployeeData());

                    _parentForm.Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void LoadRoles()
        {
            EmployeeService employeeService = new EmployeeService();

            // Roles
            cbRoles.Items.Clear();
            cbRoles.DataSource = Enum.GetValues(typeof(ERole));
        }

        public Employee GetEmployeeData()
        {
            return new Employee(
                inputEmployeeName.Text,
                inputPassword.Text,
                DateTime.Now,
                (ERole)cbRoles.SelectedValue);
        }

        public bool CheckIfAllFilled()
        {
            if (inputEmployeeName.Text.Length > 0 && inputPassword.Text.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
        }
    }
}
