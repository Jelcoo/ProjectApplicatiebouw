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
            return _employeeDao.GetEmployeesByRole(role);
        }

        public void EditEmployee(Employee employee)
        {
            _employeeDao.EditEmployee(employee);
        }

        public void ChangePassword(int id, string password)
        {
            _employeeDao.ChangePassword(id, password);
        }

        public void FireEmployee(Employee employee)
        {
            _employeeDao.FireEmployee(employee);
        }

        public string GetPassword(int id)
        {
            return _employeeDao.GetPassword(id);
        }
    }
}
