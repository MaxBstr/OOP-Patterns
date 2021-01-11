using System.Collections.Generic;

namespace Patterns._3._Behavioral._6._Observer
{
    public class Observer : IObserver
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        
        public void Notify()
        {
            foreach(var s in _subscribers)
                s.doSmth();
        }

        public void AddSubscriber(ISubscriber sub)
        {
            _subscribers.Add(sub);
        }

        public void RemoveSubscriber(ISubscriber sub)
        {
            var isExist = _subscribers.Contains(sub);
            if (isExist)
                _subscribers.Remove(sub);
        }
    }
}