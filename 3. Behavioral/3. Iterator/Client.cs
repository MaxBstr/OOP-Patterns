using System;

namespace Patterns._3._Behavioral._3._Iterator
{
    public class Client
    {
        public static void Main()
        {
            var collection = new ConcreteAggregate();
            var it = collection.getIterator();

            while (it.hasNext())
            {
                Console.WriteLine((string)it.next());
            }
        }
    }
}