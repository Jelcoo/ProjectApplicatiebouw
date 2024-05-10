using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class InvoiceService
    {
        public Invoice MakeNewInvoice(Table table, Employee employee)
        {
            InvoiceDao invoiceDao = new InvoiceDao();
            InvoiceStatus invoiceStatus = invoiceDao.GetInvoiceStatusByName(InvoiceStatus.DEFAULT_STATUS);
            Invoice invoice = new Invoice(
                tableId: table.TableId,
                servedBy: employee.EmployeeId,
                invoiceStatusId: invoiceStatus.InvoiceStatusId
            );
            invoice.SetTable(table);
            invoice.SetServer(employee);
            invoice.SetInvoiceStatus(invoiceStatus);
            return invoiceDao.CreateInvoice(invoice);
        }
    }
}
