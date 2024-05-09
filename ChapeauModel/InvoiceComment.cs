namespace ChapeauModel
{
    public class InvoiceComment
    {
        private int _invoiceCommentId;
        public int InvoiceCommentId { get { return _invoiceCommentId; } }

        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }
        public Invoice? Invoice;

        private string _comment;
        public string Comment { get { return _comment; } }

        public InvoiceComment(int invoiceId, string comment)
        {
            _invoiceId = invoiceId;
            _comment = comment;
        }
        public InvoiceComment(int invoiceCommentId, int invoiceId, string comment)
            : this(invoiceId, comment)
        {
            _invoiceCommentId = invoiceCommentId;
        }

        public InvoiceComment SetInvoice(Invoice? invoice)
        {
            Invoice = invoice;
            return this;
        }
    }
}
