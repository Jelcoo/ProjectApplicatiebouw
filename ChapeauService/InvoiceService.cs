using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class InvoiceService
    {
        private InvoiceDao _invoiceDao;

        public InvoiceService()
        {
            _invoiceDao = new InvoiceDao();
        }

        public Invoice MakeNewInvoice(Table table, Employee employee)
        {
            Invoice invoice = new Invoice(
                tableId: table.TableId,
                servedBy: employee.EmployeeId,
                invoiceStatus: InvoiceStatus.DEFAULT_STATUS
            );
            invoice.SetTable(table);
            invoice.SetServer(employee);
            return _invoiceDao.CreateInvoice(invoice);
        }

        public InvoiceComment CreateInvoiceComment(InvoiceComment invoiceComment)
        {
            return _invoiceDao.CreateInvoiceComment(invoiceComment);
        }

        public InvoiceComment GetInvoiceCommentById(int invoiceCommentId)
        {
            return _invoiceDao.GetInvoiceCommentById(invoiceCommentId);
        }
    }
}
