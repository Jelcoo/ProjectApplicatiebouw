using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class ExampleDao : BaseDao
    {
        public Example GetAllExample()
        {
            string query = "SELECT example FROM exampleTable WHERE value=@testParam";
            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@testParam", 0);

            SqlDataReader reader = command.ExecuteReader();
            List<Example> examples = new List<Example>();

            while (reader.Read())
            {
                Example example = ReadExample(reader);
                examples.Add(example);
            }

            reader.Close();
            CloseConnection();

            return examples;
        }

        private int ReadExample(SqlDataReader reader)
        {
            Example example = new Example(
                (int)reader["exampleId"]
            );
            return example;
        } 
    }
}
