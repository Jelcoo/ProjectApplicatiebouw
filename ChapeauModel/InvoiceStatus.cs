using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class InvoiceStatus
    {
        public const EInvoiceStatus DEFAULT_STATUS = EInvoiceStatus.Pending;

        private int _invoiceStatusId;
        public int InvoiceStatusId { get { return _invoiceStatusId; } }

        private EInvoiceStatus _status;
        public EInvoiceStatus Status { get { return _status; } }

        public InvoiceStatus(EInvoiceStatus status)
        {
            _status = status;
        }
        public InvoiceStatus(int invoiceStatusId, EInvoiceStatus status)
            : this(status)
        {
            _invoiceStatusId = invoiceStatusId;
        }
    }
}
