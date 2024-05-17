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
            InvoiceStatus invoiceStatus = _invoiceDao.GetInvoiceStatusByName(InvoiceStatus.DEFAULT_STATUS);
            Invoice invoice = new Invoice(
                tableId: table.TableId,
                servedBy: employee.EmployeeId,
                invoiceStatusId: invoiceStatus.InvoiceStatusId
            );
            invoice.SetTable(table);
            invoice.SetServer(employee);
            invoice.SetInvoiceStatus(invoiceStatus);
            return _invoiceDao.CreateInvoice(invoice);
        }
    }
}
