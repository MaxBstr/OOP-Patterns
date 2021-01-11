using System;

namespace Patterns._3._Behavioral._8._Strategy
{
    public class Client
    {
        public static void Main()
        {
            var calc = new Calculator();
            
            var add = new AddStrategy();
            var minus = new SubsctractStrategy();
            var multi = new MultiplyStrategy();
            var div = new DivisionStrategy();
            
            calc.SetStrategy(add);
            Console.WriteLine(calc.DoOperation(4, 2));
            
            calc.SetStrategy(minus);
            Console.WriteLine(calc.DoOperation(4, 2));
            
            calc.SetStrategy(multi);
            Console.WriteLine(calc.DoOperation(4, 2));
            
            calc.SetStrategy(div);
            Console.WriteLine(calc.DoOperation(4, 2));
        }
    }
}