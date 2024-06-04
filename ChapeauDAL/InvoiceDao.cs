using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;
using ChapeauModel.Enums;

namespace ChapeauDAL
{
    public class InvoiceDao : BaseDao
    {
        public Invoice CreateInvoice(Invoice invoice)
        {
            string query = @"
INSERT INTO invoices (tableId, servedBy, invoiceStatusId, createdAt)
VALUES (@tableId, @servedBy, @invoiceStatusId, @createdAt);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@tableId", invoice.Table.TableId);
            command.Parameters.AddWithValue("@servedBy", invoice.Server.EmployeeId);
            command.Parameters.AddWithValue("@invoiceStatusId", (int)invoice.InvoiceStatus);
            command.Parameters.AddWithValue("@createdAt", DateTime.Now);
            
            int invoiceId = Convert.ToInt32(command.ExecuteScalar());
            invoice.SetId(invoiceId);

            CloseConnection();

            return invoice;
        }

        public Invoice? GetOpenInvoice(Table table)
        {
            string query = @"
SELECT I.invoiceId, I.tableId, I.servedBy, I.invoiceStatusId, I.createdAt, T.isOccupied, E.employeeId, E.employeeName, E.password, E.employedAt, E.roleId
FROM invoices AS I
JOIN tables AS T ON T.tableId = I.tableId
JOIN employees AS E ON E.employeeId = I.servedBy
WHERE I.tableId = @tableId
AND I.invoiceStatusId = @status;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@tableId", table.TableId);
            command.Parameters.AddWithValue("@status", (int)EInvoiceStatus.Pending);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Invoice invoice = InvoiceReader.ReadInvoice(reader);

                reader.Close();
                CloseConnection();

                return invoice;
            }
            else {
                reader.Close();
                CloseConnection();

                return null;
            }
        }

        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            string query = @"
SELECT MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MI.menuTypeId, S.count, SUM(OL.quantity) AS [quantity]
FROM [orderLines] AS OL
JOIN [orders] AS O ON O.orderId = OL.orderId
JOIN [invoices] AS I ON I.invoiceId = O.invoiceId
JOIN [menuItems] AS MI ON MI.menuItemId = OL.menuItemId
JOIN [stock] AS S ON MI.stockId = S.stockId
WHERE I.invoiceId = @invoiceId
GROUP BY MI.menuItemId, MI.stockId, MI.menuId, MI.itemDetailName, MI.itemName, MI.VATRate, MI.price, MI.menuTypeId, S.count;
";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceId);

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<MenuItem, int> AllOrderedItems = new Dictionary<MenuItem, int>();

            while (reader.Read())
            {
                MenuItem menuItem = MenuReader.ReadMenuItem(reader);
                int quantity = (int)reader["quantity"];

                AllOrderedItems.Add(menuItem, quantity);
            }

            reader.Close();
            CloseConnection();

            if (AllOrderedItems.Count == 0)
            {
                throw new Exception($"Invoice ID '{invoiceId}' not found");
            }

            return AllOrderedItems;
        }

        public void CloseInvoice(Invoice invoice)
        {
            string query = @"
UPDATE invoices
SET invoiceStatusId = @status
WHERE invoiceId = @invoiceId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@status", (int)EInvoiceStatus.Paid);
            command.Parameters.AddWithValue("@invoiceId", invoice.InvoiceId);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
