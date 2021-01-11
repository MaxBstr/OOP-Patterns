using System;

namespace Patterns._2._Structural._4._Decorator
{
    public class Client
    {
        public static void Main()
        {
            IDeveloper developer = new SeniorDeveloper(new Developer());
            Console.WriteLine(developer.MakeJob());
        }
    }
}