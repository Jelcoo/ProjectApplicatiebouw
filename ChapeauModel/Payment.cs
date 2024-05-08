namespace ChapeauModel
{
    public class Payment
    {
        private int _paymentId;
        public int PaymentId { get { return _paymentId; } }

        public Invoice Invoice;

        public PaymentMethod PaymentMethod;

        private float _amount;
        public float Amount { get { return _amount; } }

        private DateTime _paidAt;
        public DateTime PaidAt { get { return _paidAt; } }

        public Tip? Tip;

        public Payment(int paymentId, Invoice invoice, PaymentMethod paymentMethod, float amount, DateTime paidAt, Tip? tip)
        {
            _paymentId = paymentId;
            Invoice = invoice;
            PaymentMethod = paymentMethod;
            _amount = amount;
            _paidAt = paidAt;
            Tip = tip;
        }
    }
}
