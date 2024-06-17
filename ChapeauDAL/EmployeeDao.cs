using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel.Enums;
using ChapeauModel;
using System.Data.SqlClient;
using ChapeauDAL.Readers;
using System.Data;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetEmployeesByRole(ERole role)
        {
            string query = @"
SELECT employeeId, employeeName, password, employedAt, roleId
FROM employees
WHERE roleId = @roleId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@roleId", (int)role);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            List<Employee> employeesByRole = new List<Employee>();

            while (reader.Read())
            {
                Employee employee = EmployeeReader.ReadEmployee(reader);
                employeesByRole.Add(employee);
            }

            reader.Close();
            CloseConnection();

            //Checks if any employees have been found
            if (employeesByRole.Count > 0)
            {
                throw new Exception("No employees found");
            }

            return employeesByRole;
        }

        public void HireEmployee(Employee employee)
        {
            string query = @"
INSERT INTO employees (employeeName, password, employedAt, roleId)
VALUES (@employeeName, @password, @employedAt, @roleId);";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@employeeName", employee.Name);
            command.Parameters.AddWithValue("@password", employee.Password);
            command.Parameters.AddWithValue("employedAt", employee.EmployedAt);
            command.Parameters.AddWithValue("roleId", (int)employee.Role);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void EditEmployee(Employee employee)
        {
            string query = @"
UPDATE employees
SET employeeName = @name,
employedAt = @employedAt,
roleId = @roleId
WHERE employeeId = @employeeId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@name", employee.Name);
            command.Parameters.AddWithValue("@employedAt", employee.EmployedAt);
            command.Parameters.AddWithValue("@roleId", (int)employee.Role);
            command.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
            command.ExecuteNonQuery();
            CloseConnection ();
        }

        public void ChangePassword(int id, string password)
        {
            string query = @"
UPDATE employees
SET password = @password
WHERE employeeId = @employeeId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@employeeId", id);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void FireEmployee(Employee employee)
        {
            string query = @"
DELETE employees
WHERE employeeId = @employeeId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
            command.ExecuteNonQuery();
            CloseConnection();

        }

        public string GetPassword(int id)
        {
            string query = @"
SELECT password
FROM employees
WHERE employeeId = @employeeId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@employeeId", id);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            string password = string.Empty;

            if (reader.Read())
            {
                password = reader.GetString("password");
            }

            //Checks if password isnt empty
            if (password == string.Empty)
            {
                new Exception("Password not found");
            }

            reader.Close();
            CloseConnection();

            return password;
        }
    }
}
