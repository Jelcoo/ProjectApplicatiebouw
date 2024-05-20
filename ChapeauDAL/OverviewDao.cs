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
        public List<Table> GetTables()
        {
            string query = "SELECT tableId, isOccupied FROM [tables]";

            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return ReadTable(dataTable);
                    }
                }
            }
        }

        public Table GetTableById(int tableId)
        {
            string query = "SELECT tableId, isOccupied FROM [tables] WHERE tableId = @tableId";
            SqlParameter parameter = new SqlParameter("@tableId", tableId);

            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(parameter);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isOccupied = (bool)reader["isOccupied"];
                            return new Table(tableId, isOccupied);
                        }
                    }
                }
            }

            return null;
        }

        private List<Table> ReadTable(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int tableId = (int)dr["tableId"];
                bool occupied = (bool)dr["isOccupied"];
                tables.Add(new Table(tableId, occupied));
            }
            return tables;
        }

        public void UpdateTableStatus(int tableId, bool isOccupied)
        {
            string query = "UPDATE [tables] SET isOccupied = @isOccupied WHERE tableId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@isOccupied", isOccupied ? 1 : 0),
            new SqlParameter("@tableId", tableId)
            };

            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(sqlParameters);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
