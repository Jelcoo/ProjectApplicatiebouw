namespace ChapeauModel
{
    public class OrderNote
    {
        private int _orderNoteId;
        public int OrderNoteId { get { return _orderNoteId }; }

        private int _orderId;
        public Order Order;

        private string _note;
        public string Note { get { return _note }; }
    }
}
