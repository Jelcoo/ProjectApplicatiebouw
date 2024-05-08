namespace ChapeauModel
{
    public class InvoiceComment
    {
        private int _invoiceCommentId;
        public int InvoiceCommentId { get { return _invoiceCommentId }; }

        private int _invoiceId;
        public Invoice Invoice;

        private string _comment;
        public string Comment { get { return _comment }; }
    }
}
