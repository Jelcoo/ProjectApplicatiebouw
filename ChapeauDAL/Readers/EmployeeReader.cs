using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class EmployeeReader
    {
        public static Employee ReadEmployee(SqlDataReader reader)
        {
            Employee employee = new Employee(
                employeeId: (int)reader["employeeId"],
                name: (string)reader["name"],
                password: (string)reader["password"],
                employedAt: (DateTime)reader["employedAt"],
                roleId: (int)reader["roleId"]
            );

            return employee;
        }
    }
}
