namespace ChapeauModel
{
    public class Tip
    {
        private int _tipId;
        public int TipId { get { return _tipId; } }

        private float _amount;
        public float Amount { get { return _amount; } }

        public Tip(float amount)
        {
            _amount = amount;
        }
        public Tip(int tipId, float amount)
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
