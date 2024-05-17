using ChapeauModel;
using ChapeauDAL.Readers;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class InvoiceDao : BaseDao
    {
        public InvoiceComment CreateInvoiceComment(InvoiceComment invoiceComment)
        {
            string query = @"
    INSERT INTO invoiceComments (invoiceId, comment)
    VALUES (@invoiceId, @comment);
    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceComment.InvoiceId);
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
            }
            else
            {
                throw new Exception($"Invoice comment with ID '{invoiceCommentId}' not found");
            }
        }
    }
}
