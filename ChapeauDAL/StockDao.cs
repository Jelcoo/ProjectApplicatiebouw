using System.Data.SqlClient;
using ChapeauDAL.Readers;
using ChapeauModel;

namespace ChapeauDAL
{
    public class StockDao : BaseDao
    {
        public List<MenuItem> GetStock()
        {
            string query = @"
SELECT MI.menuItemId, MI.itemName, MI.itemDetailName, MI.menuId, MI.menuTypeId, MI.VATRate, MI.price, S.stockId, S.[count]
FROM menuItems as MI
JOIN stock AS S ON S.stockId = MI.stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            SqlDataReader reader = command.ExecuteReader();

            List<MenuItem> stockItems = new List<MenuItem>();

            while (reader.Read())
            {
                stockItems = MenuReader.ReadMenuItems(reader);
            }
            
            reader.Close();
            CloseConnection();

            if (stockItems.Count == 0)
            {
                throw new Exception($"No stock found");
            }

            reader.Close();
            CloseConnection();

            return stockItems;
        }

        public void ChangeStock(Stock stock)
        {
            string query = @"
UPDATE stock
SET count = @amount
WHERE stockId = @stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@amount", stock.Count);
            command.Parameters.AddWithValue("@stockId", stock.StockId);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}