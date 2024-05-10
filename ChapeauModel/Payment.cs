namespace ChapeauModel
{
    public class Payment
    {
        private int _paymentId;
        public int PaymentId { get { return _paymentId; } }

        private int _invoiceId;
        public int InvoiceId { get { return _invoiceId; } }

        private int _paymentMethodId;
        public int PaymentMethodId { get { return _paymentMethodId; } }
        public PaymentMethod? PaymentMethod { get; private set; }

        private float _amount;
        public float Amount { get { return _amount; } }

        private DateTime _paidAt;
        public DateTime PaidAt { get { return _paidAt; } }

        private int _tipId;
        public int TipId { get { return _tipId; } }
        public Tip? Tip { get; private set; }

        public Payment(int invoiceId, int paymentMethodId, float amount, DateTime paidAt, int tipId)
        {
            _invoiceId = invoiceId;
            _paymentMethodId = paymentMethodId;
            _amount = amount;
            _paidAt = paidAt;
            _tipId = tipId;
        }
        public Payment(int paymentId, int invoiceId, int paymentMethodId, float amount, DateTime paidAt, int tipId)
            : this(invoiceId, paymentMethodId, amount, paidAt, tipId)
        {
            _paymentId = paymentId;
        }

        public Payment SetPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethodId = paymentMethod.PaymentMethodId;
            PaymentMethod = paymentMethod;
            return this;
        }
        public Payment SetTip(Tip tip)
        {
            _tipId = tip.TipId;
            Tip = tip;
            return this;
        }
    }
}
