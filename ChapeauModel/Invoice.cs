namespace ChapeauModel
{
    public class Invoice
    {
        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }

        private int _tableId;
        public int TableId { get { return _tableId; } }
        public Table? Table;

        private int _servedBy;
        public int ServedBy { get { return _servedBy; } }
        public Employee? Server;

        private int _invoiceStatusId;
        public int InvoiceStatusId { get { return _invoiceStatusId; } }
        public InvoiceStatus? InvoiceStatus;

        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } }

        public Invoice(int invoiceId, int tableId, int servedBy, int invoiceStatusId, DateTime createdAt)
        {
            _invoiceId = invoiceId;
            _tableId = tableId;
            _servedBy = servedBy;
            _invoiceStatusId = invoiceStatusId;
            _createdAt = createdAt;
        }

        public Invoice SetTable(Table? table)
        {
            Table = table;
            return this;
        }
        public Invoice SetServer(Employee? server) {
            Server = server;
            return this;
        }
        public Invoice SetInvoiceStatus(InvoiceStatus? invoiceStatus)
        {
            InvoiceStatus = invoiceStatus;
            return this;
        }
    }
}
