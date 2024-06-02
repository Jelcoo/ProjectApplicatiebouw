using ChapeauModel.Enums;

namespace ChapeauModel
{
    public class Payment
    {
        private int _paymentId;
        public int PaymentId { get { return _paymentId; } }

        public Invoice Invoice { get; private set; }

        public EPaymentMethod? PaymentMethod { get; private set; }

        private double _amount;
        public double Amount { get { return _amount; } }

        private DateTime _paidAt;
        public DateTime PaidAt { get { return _paidAt; } }

        public Tip? Tip { get; private set; }

        public Payment(Invoice invoice, double amount, DateTime paidAt)
        {
            Invoice = invoice;
            _amount = amount;
            _paidAt = paidAt;
        }
        public Payment(int paymentId, Invoice invoice, double amount, DateTime paidAt)
            : this(invoice, amount, paidAt)
        {
            _paymentId = paymentId;
        }

        public Payment SetPaymentMethod(EPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
            return this;
        }
        public Payment SetTip(Tip tip)
        {
            Tip = tip;
            return this;
        }

        public void SetPaymentId(int paymentId)
        {
            _paymentId = paymentId;
        }
    }
}
