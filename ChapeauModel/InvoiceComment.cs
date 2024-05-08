namespace ChapeauModel
{
    public class InvoiceComment
    {
        private int _invoiceCommentId;
        public int InvoiceCommentId { get { return _invoiceCommentId; } }

        public Invoice Invoice;

        private string _comment;
        public string Comment { get { return _comment; } }
    }
}
