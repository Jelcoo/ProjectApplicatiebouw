namespace ChapeauModel
{
    public class Tip
    {
        private int _tipId;
        public int TipId { get { return _tipId }; }

        private int _invoiceId;
        public Invoice Invoice;

        private float _amount;
        public float Amount { get { return _amount }; }
    }
}
