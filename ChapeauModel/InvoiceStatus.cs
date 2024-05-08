namespace ChapeauModel
{
    public class InvoiceStatus
    {
        private int _invoiceStatusId;
        public int InvoiceStatusId { get { return _invoiceStatusId; } }

        private string _status;
        public string Status { get { return _status; } }

        public InvoiceStatus(int invoiceStatusId, string status)
        {
            _invoiceStatusId = invoiceStatusId;
            _status = status;
        }
    }
}
