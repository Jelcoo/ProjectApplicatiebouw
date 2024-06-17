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
        private EmployeeManagement _parentForm;
        private EmployeeService _employeeService;

        private Employee currentEmployee;


        public EmployeeChangePassword(EmployeeManagement parentForm, Employee employee)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _employeeService = new EmployeeService();

            //Sets the currentemployee
            currentEmployee = employee;
        }

        private void inputNewPassword2_TextChanged(object sender, EventArgs e)
        {
            //Checks if Passwords are the same, if so changes the Checkbox
            if (CheckIfPassword1IsSameAsPassword2())
            {
                cbRepeatPasswordCorrect.Checked = true;
            }
            else if (cbRepeatPasswordCorrect.Checked)
            {
                cbRepeatPasswordCorrect.Checked = false;
            }
        }


        private void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            // Disables all interactions for security
            DisableInteractions();

            //No password hashing due to group member absent
            if (CheckIfAllFilledIn() && inputCurrentPassword.Text == GetCurrentPassword())
            {
                if (CheckIfPassword1IsSameAsPassword2())
                {
                    try
                    {
                        // Asks employeeService to change password
                        _employeeService.ChangePassword(currentEmployee.EmployeeId, inputNewPassword1.Text);

                        MessageBox.Show("Password succesfully changed");

                        // Reloads parent form
                        _parentForm.Reload();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else // Password not the same
                {
                    MessageBox.Show("New password and Repeat password are not the same");
                }
            }
            else // Incorrect password
            {
                MessageBox.Show("Current password was incorrect");
            }


            //(Re)Enable interactions
            EnableInteractions();
        }

        private void btnCancelChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetCurrentPassword()
        {
            try
            {
                return _employeeService.GetPassword(currentEmployee.EmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return string.Empty;
        }

        private bool CheckIfAllFilledIn()
        {
            //Checks if all the inputs are filled in
            if (string.IsNullOrEmpty(inputCurrentPassword.Text)) { return false; }
            if (string.IsNullOrEmpty(inputNewPassword1.Text)) { return false; }
            if (string.IsNullOrEmpty(inputNewPassword2.Text)) { return false; }
            return true;
        }

        private bool CheckIfPassword1IsSameAsPassword2()
        {
            // Checks if Password 1 is the same ass Password 2
            if (inputNewPassword2.Text == inputNewPassword1.Text) { return true; }
            else { return false; }
        }

        private void DisableInteractions()
        {
            //Disables all input interactions
            inputCurrentPassword.Enabled = false;
            inputNewPassword1.Enabled = false;
            inputNewPassword2.Enabled = false;
        }

        private void EnableInteractions()
        {
            //Enables all input interactions
            inputCurrentPassword.Enabled = true;
            inputNewPassword1.Enabled = true;
            inputNewPassword2.Enabled = true;
        }
    }
}
