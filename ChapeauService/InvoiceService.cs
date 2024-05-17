using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class InvoiceService
    {
        public InvoiceComment CreateInvoiceComment(InvoiceComment invoiceComment)
        {
            InvoiceDao invoiceDao = new InvoiceDao();
            return invoiceDao.CreateInvoiceComment(invoiceComment);
        }

        public InvoiceComment GetInvoiceCommentById(int invoiceCommentId)
        {
            InvoiceDao invoiceDao = new InvoiceDao();
            return invoiceDao.GetInvoiceCommentById(invoiceCommentId);
        }
    }
}
