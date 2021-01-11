namespace Patterns._3._Behavioral._6._Observer
{
    public interface IObserver
    {
        void Notify();
        void AddSubscriber(ISubscriber sub);
        void RemoveSubscriber(ISubscriber sub);
    }
}