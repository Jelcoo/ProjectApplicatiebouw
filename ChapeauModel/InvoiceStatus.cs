namespace ChapeauModel
{
    public class InvoiceStatus
    {
        public const string DEFAULT_STATUS = "Pending";

        private int _invoiceStatusId;
        public int InvoiceStatusId { get { return _invoiceStatusId; } }

        private string _status;
        public string Status { get { return _status; } }

        public InvoiceStatus(string status)
        {
            _status = status;
        }
        public InvoiceStatus(int invoiceStatusId, string status)
            : this(status)
        {
            _invoiceStatusId = invoiceStatusId;
        }
    }
}
