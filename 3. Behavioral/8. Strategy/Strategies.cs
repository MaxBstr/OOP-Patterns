namespace Patterns._3._Behavioral._8._Strategy
{
    public class AddStrategy : IStrategyOperation
    {
        public double execute(double a, double b)
        {
            return a + b;
        }
    }
    
    public class SubsctractStrategy : IStrategyOperation
    {
        public double execute(double a, double b)
        {
            return a - b;
        }
    }
    
    public class MultiplyStrategy : IStrategyOperation
    {
        public double execute(double a, double b)
        {
            return a * b;
        }
    }
    
    public class DivisionStrategy : IStrategyOperation
    {
        public double execute(double a, double b)
        {
            return a / b;
        }
    }
}