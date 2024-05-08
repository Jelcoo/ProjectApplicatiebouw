namespace ChapeauModel
{
    public class Table
    {
        private int _tableId;
        public int TableId { get { return _tableId; } }

        private bool _occupied;
        public bool Occupied { get { return _occupied; } }

        public Invoice? Invoice;

        public Table(int tableId, bool occupied, Invoice? invoice)
        {
            _tableId = tableId;
            _occupied = occupied;
            Invoice = invoice;
        }
    }
}
