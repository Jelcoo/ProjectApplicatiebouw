using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class InvoiceReader
    {
        public static Invoice ReadInvoice(SqlDataReader reader)
        {
            Invoice invoice = new Invoice(
                invoiceId: (int)reader["invoiceId"],
                tableId: (int)reader["tableId"],
                servedBy: (int)reader["servedBy"],
                invoiceStatusId: (int)reader["invoiceStatusId"],
                createdAt: (DateTime)reader["createdAt"]
            );

            return invoice;
        }

        public static InvoiceComment ReadInvoiceComment(SqlDataReader reader)
        {
            InvoiceComment invoiceComment = new InvoiceComment(
                invoiceCommentId: (int)reader["invoiceCommentId"],
                invoiceId: (int)reader["invoiceId"],
                comment: (string)reader["comment"]
            );

            return invoiceComment;
        }

        public static InvoiceStatus ReadInvoiceStatus(SqlDataReader reader)
        {
            InvoiceStatus invoiceStatus = new InvoiceStatus(
                invoiceStatusId: (int)reader["invoiceStatusId"],
                status: (string)reader["status"]
            );

            return invoiceStatus;
        }
    }
}
