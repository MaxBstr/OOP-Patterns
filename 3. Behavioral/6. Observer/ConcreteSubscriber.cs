using System;

namespace Patterns._3._Behavioral._6._Observer
{
    public class ConcreteSubscriber : ISubscriber
    {
        public void doSmth()
        {
            Console.WriteLine("Hello!");
        }
    }
}