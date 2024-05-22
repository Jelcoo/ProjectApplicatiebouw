using ChapeauModel;
using ChapeauModel.Enums;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class EmployeeReader
    {
        public static Employee ReadEmployee(SqlDataReader reader)
        {
            Employee employee = new Employee(
                employeeId: (int)reader["employeeId"],
                name: (string)reader["employeeName"],
                password: (string)reader["password"],
                employedAt: (DateTime)reader["employedAt"],
                role: (ERole)(int)reader["roleId"]
            );

            return employee;
        }
    }
}
