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
                table: TableReader.ReadTable(reader),
                servedBy: EmployeeReader.ReadEmployee(reader),
                invoiceStatus: ReadInvoiceStatus(reader),
                createdAt: (DateTime)reader["createdAt"]
            );

            return invoice;
        }

        public static InvoiceComment ReadInvoiceComment(SqlDataReader reader)
        {
            InvoiceComment invoiceComment = new InvoiceComment(
                invoiceCommentId: (int)reader["invoiceCommentId"],
                invoice: ReadInvoice(reader),
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
