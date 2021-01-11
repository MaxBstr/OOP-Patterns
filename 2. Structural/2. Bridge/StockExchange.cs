using System;

namespace Patterns._2._Structural._2._Bridge
{
    public class StockExchange : Program
    {
        public StockExchange(IDeveloper dev) : base(dev)
        {
        }

        public override void DevelopProgram()
        {
            Console.WriteLine("Stock exchange system in progress...");
            Developer.writeCode();
        }
    }
}