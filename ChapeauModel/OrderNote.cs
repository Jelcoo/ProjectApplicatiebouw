namespace ChapeauModel
{
    public class OrderNote
    {
        private int _orderNoteId;
        public int OrderNoteId { get { return _orderNoteId; } }

        public OrderLine OrderLine;

        private string _note;
        public string Note { get { return _note; } }

        public OrderNote(int orderNoteId, OrderLine orderLine, string note)
        {
            _orderNoteId = orderNoteId;
            OrderLine = orderLine;
            _note = note;
        }
    }
}
