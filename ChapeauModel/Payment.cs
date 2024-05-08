namespace ChapeauModel
{
    public class Payment
    {
        private int _paymentId;
        public int PaymentId { get { return _paymentId }; }

        private int _invoiceId;
        public Invoice Invoice;

        private int _paymentMethodId;
        public PaymentMethod PaymentMethod;

        private float _amount;
        public float Amount { get { return _amount }; }

        private DateTime _paidAt;
        public DateTime PaidAt { get { return _paidAt }; }
    }
}
