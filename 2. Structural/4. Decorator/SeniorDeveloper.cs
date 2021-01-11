namespace Patterns._2._Structural._4._Decorator
{
    public class SeniorDeveloper : DeveloperDecorator, IDeveloper
    {
        public SeniorDeveloper(IDeveloper dev) : base(dev)
        {
        }

        private string MakeCodeReview()
        {
            return "Making code review...";
        }

        public new string MakeJob()
        {
            return MakeCodeReview() + base.MakeJob();
        }
    }
}