using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel.Enums;
using ChapeauModel;
using System.Net;

namespace ChapeauService
{
    public class EmployeeService
    {
        private EmployeeDao _employeeDao;

        public EmployeeService()
        {
            _employeeDao = new EmployeeDao();
        }

        public List<Employee> GetEmployeesByRole(ERole role)
        {
            //Asks employeeDao for all employees with role
            return _employeeDao.GetEmployeesByRole(role);
        }

        public void HireEmployee(Employee employee)
        {
            //Asks employeeDao to Hire employee
            _employeeDao.HireEmployee(employee);
        }

        public void EditEmployee(Employee employee)
        {
            //Asks employeeDao to edit employee
            _employeeDao.EditEmployee(employee);
        }

        public void ChangePassword(int id, string password)
        {
            //Asks employeeDao to change password of employee
            _employeeDao.ChangePassword(id, password);
        }

        public void FireEmployee(Employee employee)
        {
            //Asks employeeDao to fire employee
            _employeeDao.FireEmployee(employee);
        }

        public string GetPassword(int id)
        {
            // Asks employeeDao for password of employee
            return _employeeDao.GetPassword(id);
        }
    }
}
