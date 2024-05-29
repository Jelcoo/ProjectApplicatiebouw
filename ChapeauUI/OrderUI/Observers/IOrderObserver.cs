using ChapeauModel;

namespace ChapeauUI.OrderUI.Observers
{
    public interface IOrderObserver
    {
        void Update(List<OrderLine> orderlines);
    }
}
