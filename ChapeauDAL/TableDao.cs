using ChapeauDAL.Readers;
using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetTables()
        {
            string query = @"SELECT tableId, isOccupied FROM [tables];";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<Table> tables = new List<Table>();

            while (reader.Read())
            {
                Table table = TableReader.ReadTable(reader);
                tables.Add(table);
            }

            return tables;
        }
    }
}
