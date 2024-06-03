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
        
        public string GetDetailNameById(int id)
        {
            string query = @"
SELECT itemDetailName
FROM menuItems
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuItemId", id);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string detailName = reader.GetString(reader.GetOrdinal("itemDetailName"));

                reader.Close();
                CloseConnection();

                return detailName;
            }
            else
            {
                throw new Exception($"DetailName with id:{id} not found");
            }
        }

        public Dictionary<MenuItem, Stock> GetMenuItemAndStockById(int id)
        {
            string query = @"
SELECT MI.menuItemId, MI.itemName, MI.itemDetailName, MI.MenuTypeId, MI.MenuId, MI.price, MI.VATRate, S.stockId, S.count
FROM menuItems as MI
JOIN stock AS S ON S.stockId = MI.stockId
WHERE menuItemId = @menuItemId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@menuItemId", id);
            command.ExecuteNonQuery();

            Dictionary<MenuItem, Stock> details = new Dictionary<MenuItem, Stock>(); 

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                details.Add(MenuReader.ReadMenuItem(reader), MenuReader.ReadStock(reader));

                reader.Close();
                CloseConnection();

                return details;
            }
            else
            {
                throw new Exception($"DetailName with id:{id} not found");
            }
        }

        public void AddDelivery(int stockId, int amount)
        {
            string query = @"
UPDATE stock
SET count = count + @amount
WHERE stockId = @stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@stockId", stockId);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void AlterStock(Stock stock)
        {
            string query = @"
UPDATE stock
SET count = @count
WHERE stockId = @stockId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@count", stock.Count);
            command.Parameters.AddWithValue("@stockId", stock.StockId);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}