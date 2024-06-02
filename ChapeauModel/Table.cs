namespace ChapeauModel
{
    public class Table
    {
        private int _tableId;
        public int TableId { get { return _tableId; } }

        private bool _occupied;
        public bool Occupied { get { return _occupied; } }

        public Table(bool occupied)
        {
            _occupied = occupied;
        }
        public Table(int tableId, bool occupied)
            : this(occupied)
        {
            _tableId = tableId;
        }

        public void SetId(int tableId)
        {
            _tableId = tableId;
        }
        public void SetOccupied(bool occupied)
        {
            _occupied = occupied;
        }
    }
}
