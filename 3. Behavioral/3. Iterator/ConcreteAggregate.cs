namespace Patterns._3._Behavioral._3._Iterator
{
    public class ConcreteAggregate : IAggregate
    {
        private static string[] _collection = {"Hi", "Ni hao", "Bonjour"};
        public IIterator getIterator()
        {
            return new ConcreteIterator();
        }

        private class ConcreteIterator : IIterator
        {
            private int _curPos = 0;

            public bool hasNext()
            {
                return _curPos < _collection.Length;
            }

            public object next()
            {
                return _collection[_curPos++];
            }
        }
    }
}