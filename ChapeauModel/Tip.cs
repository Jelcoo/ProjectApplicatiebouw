namespace ChapeauModel
{
    public class Tip
    {
        private int _tipId;
        public int TipId { get { return _tipId; } }

        private int _paymentId;
        public int PaymentId {  get { return _paymentId; } }
        public Payment? Payment;

        private float _amount;
        public float Amount { get { return _amount; } }

        public Tip(int tipId, int paymentId, float amount)
        {
            _tipId = tipId;
            _paymentId = paymentId;
            _amount = amount;
        }

        public Tip SetPayment(Payment payment)
        {
            Payment = payment;
            return this;
        }
    }
}
