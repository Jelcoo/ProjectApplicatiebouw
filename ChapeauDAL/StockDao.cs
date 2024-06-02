using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class StockDao : BaseDao
    {
        public Dictionary<int, (string name, int stock)> GetStock()
        {
            string query = @"
SELECT MI.menuItemId AS id, MI.itemName AS [name], S.stock
FROM menuItems as MI
JOIN stock AS S ON S.stockId = MI.stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<int, (string name, int stock)> stock = new Dictionary<int, (string name, int stock)>();

            while (reader.Read())
            {
                int menuItemId = reader.GetInt32(reader.GetOrdinal("id"));
                string itemName = reader.GetString(reader.GetOrdinal("name"));
                int stockValue = reader.GetInt32(reader.GetOrdinal("stock"));

                stock[menuItemId] = (itemName, stockValue);
            }

            reader.Close();
            CloseConnection();

            if (stock.Count == 0)
            {
                throw new Exception($"No stock found");
            }

            return stock;
        }
    }
}