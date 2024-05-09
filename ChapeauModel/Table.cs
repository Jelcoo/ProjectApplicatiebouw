namespace ChapeauModel
{
    public class Table
    {
        private int _tableId;
        public int TableId { get { return _tableId; } }

        private bool _occupied;
        public bool Occupied { get { return _occupied; } }

        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }
        public Invoice? Invoice;

        public Table(bool occupied, int invoiceId)
        {
            _occupied = occupied;
            _invoiceId = invoiceId;
        }
        public Table(int tableId, bool occupied, int invoiceId)
            : this(occupied, invoiceId)
        {
            _tableId = tableId;
        }

        public Table SetInvoice(Invoice invoice)
        {
            Invoice = invoice;
            return this;
        }
    }
}
