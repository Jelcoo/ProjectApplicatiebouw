namespace ChapeauModel
{
    public class OrderNote
    {
        private int _orderNoteId;
        public int OrderNoteId { get { return _orderNoteId; } }

        private int _orderLineId;
        public int OrderLineId { get { return _orderLineId; } }

        private string _note;
        public string Note { get { return _note; } }

        public OrderNote(int orderLineId, string note)
        {
            _orderLineId = orderLineId;
            _note = note;
        }
        public OrderNote(int orderNoteId, int orderLineId, string note)
            : this(orderLineId, note)
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
