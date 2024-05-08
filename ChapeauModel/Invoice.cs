namespace ChapeauModel
{
    public class Invoice
    {
        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId }; }

        private int _tableId;
        public Table Table;

        private int _servedBy;
        public Employee ServedBy;

        private int _invoiceStatusId;
        public InvoiceStatus InvoiceStatus;

        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt }; }
    }
}
