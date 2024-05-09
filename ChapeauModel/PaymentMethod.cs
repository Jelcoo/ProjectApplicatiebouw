namespace ChapeauModel
{
    public class PaymentMethod
    {
        private int _paymentMethodId;
        public int PaymentMethodId { get { return _paymentMethodId; } }

        private string _name;
        public string Name { get { return _name; } }

        public PaymentMethod(string name)
        {
            _name = name;
        }
        public PaymentMethod(int paymentMethodId, string name)
            : this(name)
        {
            _paymentMethodId = paymentMethodId;
        }
    }
}
