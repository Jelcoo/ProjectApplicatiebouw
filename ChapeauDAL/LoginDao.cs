using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ChapeauModel;
using System.Diagnostics;
using ChapeauDAL.Readers;

namespace ChapeauDAL
{
    public class LoginDao : BaseDao
    {
        public Employee GetLogin(int userId, string password)
        {
            string query = "SELECT employeeId, password FROM [employees] WHERE employeeId = @userId AND password = @password";

            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@userId", userId),
            new SqlParameter("@password", password)
        };

            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(sqlParameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return EmployeeReader.ReadEmployee(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}

