namespace ChapeauModel
{
    public class Table
    {
        private int _tableId;
        public int TableId { get { return _tableId; } }

        private bool _occupied;
        public bool Occupied { get { return _occupied; } }

        public Invoice? Invoice;
    }
}
