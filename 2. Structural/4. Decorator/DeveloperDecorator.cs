namespace Patterns._2._Structural._4._Decorator
{
    public class DeveloperDecorator : IDeveloper
    {
        private readonly IDeveloper _developer;

        protected DeveloperDecorator(IDeveloper dev)
        {
            _developer = dev;
        }
        public string MakeJob()
        {
            return _developer.MakeJob();
        }
    }
}