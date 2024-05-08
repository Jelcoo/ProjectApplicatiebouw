using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class ExampleDao : baseDao
    {
        public int GetAllExample()
        {
            string query = "Here your query";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private int ReadTables(DataTable dataTable)
        {
            int count = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                count++;
            }
            return count;
        } 
    }
}
