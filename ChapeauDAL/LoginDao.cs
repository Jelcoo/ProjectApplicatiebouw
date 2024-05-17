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

namespace ChapeauDAL
{
    public class LoginDao : BaseDao
    {
        public Login GetLogin(int userId, string password)
        {
            string query = "SELECT employeeId, password FROM [employees] WHERE employeeId = @userId AND password = @password";

            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@userId", userId),
            new SqlParameter("@password", password)
        };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                int id = (int)dr["employeeId"];
                string retrievedPassword = dr["password"].ToString();
                if (retrievedPassword == password)
                {
                    return new Login { Id = id, Password = retrievedPassword };
                }
            }
            return null;
        }
    }


}

