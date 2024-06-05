using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.EmploymentUI
{
    public partial class EmployeeChangePassword : Form
    {
        Employee currentEmployee;
        EmployeeManagement _parentForm;

        public EmployeeChangePassword(EmployeeManagement parentForm, Employee employee)
        {
            InitializeComponent();
            this.currentEmployee = employee;
            this._parentForm = parentForm;
        }

        private void inputNewPassword2_TextChanged(object sender, EventArgs e)
        {
            if (CheckIfPassword1IsSameAsPassword2())
            {
                cbRepeatPasswordCorrect.Checked = true;
            }
            else if (cbRepeatPasswordCorrect.Checked)
            {
                cbRepeatPasswordCorrect.Checked = false;
            }
        }

        private bool CheckIfPassword1IsSameAsPassword2()
        {
            if (inputNewPassword2.Text == inputNewPassword1.Text) { return true; }
            else { return false; }
        }

        public void DisableInteractions()
        {
            inputCurrentPassword.Enabled = false;
            inputNewPassword1.Enabled = false;
            inputNewPassword2.Enabled = false;
        }

        public void EnableInteractions()
        {
            inputCurrentPassword.Enabled = true;
            inputNewPassword1.Enabled = true;
            inputNewPassword2.Enabled = true;
        }

        private void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            DisableInteractions();
            EmployeeService employeeService = new EmployeeService();

            //No password hashing due to group member absent
            if (inputCurrentPassword.Text == employeeService.GetPassword(currentEmployee.EmployeeId))
            {
                if (CheckIfPassword1IsSameAsPassword2())
                {
                    try
                    {
                        employeeService.ChangePassword(currentEmployee.EmployeeId, inputNewPassword1.Text);

                        MessageBox.Show("Password succesfully changed");

                        _parentForm.Reload();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("New password and Repeat password are not the same");
                }
            }
            else
            {
                MessageBox.Show("Current password was incorrect");
            }

            EnableInteractions();
        }

        private void btnCancelChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
