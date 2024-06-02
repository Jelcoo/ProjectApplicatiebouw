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
        public Invoice? GetOpenInvoice(Table table)
        {
            return _invoiceDao.GetOpenInvoice(table);
        }
        public Dictionary<MenuItem, int> GetAllOrderedItemsByInvoiceId(int invoiceId)
        {
            return _invoiceDao.GetAllOrderedItemsByInvoiceId(invoiceId);
        }
    }
}
