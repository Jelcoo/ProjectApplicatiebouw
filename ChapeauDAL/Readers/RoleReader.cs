using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class RoleReader
    {
        public static Role ReadRole(SqlDataReader reader)
        {
            Role role = new Role(
                roleId: (int)reader["roleId"],
                name: (string)reader["roleName"]
            );

            return role;
        }
    }
}
