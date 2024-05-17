using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class OverviewDao : BaseDao
    {
        public List<TableOverview> GetTables()
        {
            string query = "SELECT tableId, isOccupied FROM [tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<TableOverview> ReadTable(DataTable dataTable)
        {
            List<TableOverview> tables = new List<TableOverview>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int tableID = (int)dr["tableId"];
                bool isOccupied = ((Int16)dr["isOccupied"] != 0);

                tables.Add(new TableOverview(tableID, isOccupied));
            }
            return tables;
        }
    }
}
