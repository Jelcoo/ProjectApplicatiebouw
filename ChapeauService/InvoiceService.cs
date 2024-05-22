using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

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
                table,
                servedBy: employee,
                invoiceStatus: EInvoiceStatus.Pending
            );
            return _invoiceDao.CreateInvoice(invoice);
        }

        public InvoiceComment CreateInvoiceComment(int invoiceId, InvoiceComment invoiceComment)
        {
            return _invoiceDao.CreateInvoiceComment(invoiceId, invoiceComment);
        }

        public InvoiceComment GetInvoiceCommentById(int invoiceCommentId)
        {
            return _invoiceDao.GetInvoiceCommentById(invoiceCommentId);
        }
    }
}
