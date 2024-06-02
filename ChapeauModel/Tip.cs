namespace ChapeauModel
{
    public class Tip
    {
        private int _tipId;
        public int TipId { get { return _tipId; } }

        private double _amount;
        public double Amount { get { return _amount; } }

        public Tip(double amount)
        {
            _amount = amount;
        }
        public Tip(int tipId, double amount)
            : this(amount)
        {
            _tipId = tipId;
        }

        public Tip SetId(int tipId)
        {
            _tipId = tipId;
            return this;
        }
    }
}
