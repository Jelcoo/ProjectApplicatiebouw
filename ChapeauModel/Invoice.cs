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

        public Invoice(int tableId, int servedBy, int invoiceStatusId)
        {
            _tableId = tableId;
            _servedBy = servedBy;
            _invoiceStatusId = invoiceStatusId;
        }
        public Invoice(int tableId, int servedBy, int invoiceStatusId, DateTime createdAt)
            : this(tableId, servedBy, invoiceStatusId)
        {
            _createdAt = createdAt;
        }
        public Invoice(int invoiceId, int tableId, int servedBy, int invoiceStatusId, DateTime createdAt)
            : this(tableId, servedBy, invoiceStatusId, createdAt)
        {
            _invoiceId = invoiceId;
        }

        public Invoice SetId(int invoiceId)
        {
            _invoiceId = invoiceId;
            return this;
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
