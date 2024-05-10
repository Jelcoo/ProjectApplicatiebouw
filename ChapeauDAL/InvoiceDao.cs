using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class InvoiceDao : BaseDao
    {
        public Invoice MakeNewInvoice(Table table, Employee employee)
        {
            InvoiceStatus invoiceStatus = GetInvoiceStatusByName(InvoiceStatus.DEFAULT_STATUS);
            Invoice invoice = new Invoice(
                tableId: table.TableId,
                servedBy: employee.EmployeeId,
                invoiceStatusId: invoiceStatus.InvoiceStatusId
            );
            invoice.SetTable(table);
            invoice.SetServer(employee);
            invoice.SetInvoiceStatus(invoiceStatus);
            return CreateInvoice(invoice);
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            string query = @"
INSERT INTO invoices (tableId, servedBy, invoiceStatusId, createdAt)
VALUES (@tableId, @servedBy, @invoiceStatusId, @createdAt);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@tableId", invoice.TableId);
            command.Parameters.AddWithValue("@servedBy", invoice.ServedBy);
            command.Parameters.AddWithValue("@invoiceStatusId", invoice.InvoiceStatus?.InvoiceStatusId);
            command.Parameters.AddWithValue("@createdAt", invoice.CreatedAt);
            
            int invoiceId = Convert.ToInt32(command.ExecuteScalar());
            invoice.SetId(invoiceId);

            return invoice;
        }

        public InvoiceStatus GetInvoiceStatusByName(string statusName)
        {
            string query = @"
SELECT invoiceStatusId, statusName
FROM invoiceStatuses
WHERE status = @statusName";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@statusName", statusName);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return InvoiceReader.ReadInvoiceStatus(reader);
            } else
            {
                throw new Exception($"Invoice status '{statusName}' not found");
            }
        }
    }
}
