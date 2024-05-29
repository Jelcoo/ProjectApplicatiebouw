using ChapeauModel;
using ChapeauModel.Enums;
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
                invoiceStatus: (EInvoiceStatus)Enum.Parse(typeof(EInvoiceStatus), (string)reader["status"]),
                createdAt: (DateTime)reader["createdAt"]
            );

            return invoice;
        }

        public static InvoiceComment ReadInvoiceComment(SqlDataReader reader)
        {
            InvoiceComment invoiceComment = new InvoiceComment(
                invoiceCommentId: (int)reader["invoiceCommentId"],
                comment: (string)reader["comment"]
            );

            return invoiceComment;
        }
    }
}
