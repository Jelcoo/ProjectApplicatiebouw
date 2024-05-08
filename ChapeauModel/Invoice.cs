namespace ChapeauModel
{
    public class Invoice
    {
        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }

        public Table Table;

        public Employee ServedBy;

        public InvoiceStatus InvoiceStatus;

        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } }
    }
}
