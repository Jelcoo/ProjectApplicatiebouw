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

        public Table(int tableId, bool occupied, int invoiceId)
        {
            _tableId = tableId;
            _occupied = occupied;
            _invoiceId = invoiceId;
        }

        public Table SetInvoice(Invoice invoice)
        {
            Invoice = invoice;
            return this;
        }
    }
}
