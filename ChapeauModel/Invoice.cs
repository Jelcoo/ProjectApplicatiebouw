using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class Invoice
    {
        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }

        public Table Table { get; private set; }

        public Employee Server { get; private set; }
        
        public InvoiceComment? Comment { get; private set; }

        public EInvoiceStatus InvoiceStatus;

        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } }

        public Invoice(Table table, Employee servedBy, EInvoiceStatus invoiceStatus)
        {
            Table = table;
            Server = servedBy;
            InvoiceStatus = invoiceStatus;
        }
        public Invoice(Table table, Employee servedBy, EInvoiceStatus invoiceStatus, DateTime createdAt)
            : this(table, servedBy, invoiceStatus)
        {
            _createdAt = createdAt;
        }
        public Invoice(int invoiceId, Table table, Employee servedBy, EInvoiceStatus invoiceStatus, DateTime createdAt)
            : this(table, servedBy, invoiceStatus, createdAt)
        {
            _invoiceId = invoiceId;
        }

        public Invoice SetId(int invoiceId)
        {
            _invoiceId = invoiceId;
            return this;
        }
        public Invoice SetTable(Table table)
        {
            Table = table;
            return this;
        }
        public Invoice SetServer(Employee server)
        {
            Server = server;
            return this;
        }
        public Invoice SetInvoiceComment(InvoiceComment invoiceComment)
        {
            Comment = invoiceComment;
            return this;
        }
        public Invoice SetInvoiceStatus(EInvoiceStatus invoiceStatus)
        {
            InvoiceStatus = invoiceStatus;
            return this;
        }
    }
}
