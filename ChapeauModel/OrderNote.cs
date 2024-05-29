namespace ChapeauModel
{
    public class OrderNote
    {
        private int _orderNoteId;
        public int OrderNoteId { get { return _orderNoteId; } }

        private string _note;
        public string Note { get { return _note; } }

        public OrderNote(string note)
        {
            _note = note;
        }
        public OrderNote(int orderNoteId, string note)
            : this( note)
        {
            _orderNoteId = orderNoteId;
        }

        public OrderNote SetId(int orderNoteId)
        {
            _orderNoteId = orderNoteId;
            return this;
        }
    }
}
