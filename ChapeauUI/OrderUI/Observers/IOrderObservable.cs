namespace ChapeauUI.OrderUI.Observers
{
    public interface IOrderObservable
    {
        void SetObserver(IOrderObserver observer);
        void NotifyObserver();
    }
}
