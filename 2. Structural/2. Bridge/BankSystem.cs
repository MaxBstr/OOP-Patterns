using System;

namespace Patterns._2._Structural._2._Bridge
{
    public class BankSystem : Program
    {
        public BankSystem(IDeveloper dev) : base(dev)
        {
        }

        public override void DevelopProgram()
        {
            Console.WriteLine("Bank system in progress...");
            Developer.writeCode();
        }
    }
}