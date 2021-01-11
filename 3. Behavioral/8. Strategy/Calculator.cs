namespace Patterns._3._Behavioral._8._Strategy
{
    public class Calculator
    {
        private IStrategyOperation _curOperation;

        public void SetStrategy(IStrategyOperation str)
        {
            _curOperation = str;
        }

        public double DoOperation(double a, double b)
        {
            return _curOperation.execute(a, b);
        }
    }
}