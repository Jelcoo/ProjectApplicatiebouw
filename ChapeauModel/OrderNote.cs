namespace ChapeauModel
{
    public class OrderNote
    {
        private int _orderNoteId;
        public int OrderNoteId { get { return _orderNoteId; } }

        public Order Order;

        private string _note;
        public string Note { get { return _note; } }

        public OrderNote(int orderNoteId, Order order, string note)
        {
            _orderNoteId = orderNoteId;
            Order = order;
            _note = note;
        }
    }
}
