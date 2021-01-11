using System;

namespace Patterns._1._Creational._2._Abstract_Factory.Website
{
    public class ManualTester : ITester
    {
        public void Test()
        {
            Console.WriteLine("Testing web-site");
        }
    }
}