namespace Patterns._3._Behavioral._1._Chain_of_Responsibility
{
    public abstract class Logger
    {
        private Logger _next;
        private readonly int _priority;

        public void SetNext(Logger logger)
        {
            _next = logger;
        }

        protected Logger(int priority)
        {
            _priority = priority;
        }
        public void WriteMessage(string message, int level)
        {
            if (level <= _priority)
            {
                Write(message);
            }

            if (_next != null)
            {
                _next.WriteMessage(message, level);
            }
        }

        public abstract void Write(string msg);
    }

    public enum Level
    {
        ERROR = 1,
        DEBUG = 2,
        INFO = 3
    }
}