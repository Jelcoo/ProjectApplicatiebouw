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
        private InvoiceDao _invoiceDao;

        public InvoiceService()
        {
            _invoiceDao = new InvoiceDao();
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
