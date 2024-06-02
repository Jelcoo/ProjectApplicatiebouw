using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;

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

        public Invoice GetInvoiceById(int invoiceId)
        {
            string query = @"
SELECT I.invoiceId, I.tableId, I.servedBy, I.invoiceStatusId, I.createdAt, T.isOccupied, E.employeeId, E.employeeName, E.[password], E.employedAt, E.roleId, S.[status]
FROM invoices AS I
JOIN [tables] AS T ON T.tableId = I.tableId
JOIN employees AS E ON E.employeeId = I.servedBy
JOIN invoiceStatuses AS S ON S.invoiceStatusId = I.invoiceStatusId
WHERE invoiceId = @invoiceId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Invoice invoice = InvoiceReader.ReadInvoice(reader);

                reader.Close();
                CloseConnection();

                return invoice;
            }
            else
            {
                throw new Exception($"Invoice comment with ID '{invoiceId}' not found");
            }
        }

        public InvoiceComment CreateInvoiceComment(int invoiceId, InvoiceComment invoiceComment)
        {
            string query = @"
INSERT INTO invoiceComments (invoiceId, comment)
VALUES (@invoiceId, @comment);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceId);
            command.Parameters.AddWithValue("@comment", invoiceComment.Comment);

            int commentInvoiceId = Convert.ToInt32(command.ExecuteScalar());
            invoiceComment.SetInvoiceCommentId(commentInvoiceId);
            CloseConnection();

            return invoiceComment;
        }

        public InvoiceComment GetInvoiceCommentById(int invoiceCommentId)
        {
            string query = @"
SELECT invoiceId, comment
FROM invoiceComments
WHERE invoiceCommentId = @invoiceCommentId;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceCommentId", invoiceCommentId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                InvoiceComment invoiceComment = InvoiceReader.ReadInvoiceComment(reader);

                reader.Close();
                CloseConnection();

                return invoiceComment;
            } else {
                throw new Exception($"Invoice comment with ID '{invoiceCommentId}' not found");
            }
        }
    }
}
