namespace ChapeauModel
{
    public class PaymentMethod
    {
        private int _paymentMethodId;
        public int PaymentMethodId { get { return _paymentMethodId; } }

        private string _name;
        public string Name { get { return _name; } }

        public PaymentMethod(int paymentMethodId, string name)
        {
            _paymentMethodId = paymentMethodId;
            _name = name;
        }
    }
}
