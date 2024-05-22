namespace ChapeauModel
{
    public class InvoiceComment
    {
        private int _invoiceCommentId;
        public int InvoiceCommentId { get { return _invoiceCommentId; } }

        private string _comment;
        public string Comment { get { return _comment; } }

        public InvoiceComment(string comment)
        {
            _comment = comment;
        }
        public InvoiceComment(int invoiceCommentId, string comment)
            : this(comment)
        {
            _invoiceCommentId = invoiceCommentId;
        }

        public void SetInvoiceCommentId(int invoiceId)
        {
            _invoiceCommentId = invoiceId;
        }
    }
}
