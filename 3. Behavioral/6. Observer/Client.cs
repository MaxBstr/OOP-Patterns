using System;

namespace Patterns._3._Behavioral._6._Observer
{
    public class Client
    {
        public static void Main()
        {
            IObserver observer = new Observer();
            ISubscriber sub1 = new ConcreteSubscriber();
            ISubscriber sub2 = new ConcreteSubscriber();
            ISubscriber sub3 = new ConcreteSubscriber();
            
            observer.AddSubscriber(sub1);
            observer.AddSubscriber(sub2);
            observer.AddSubscriber(sub3);
            
            observer.Notify();
            
            observer.RemoveSubscriber(sub3);
            Console.WriteLine();
            observer.Notify();
        }
    }
}