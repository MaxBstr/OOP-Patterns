using System;

namespace Patterns._1._Creational._2._Abstract_Factory.Website
{
    public class DjangoDeveloper : IDeveloper
    {
        public void writeCode()
        {
            Console.WriteLine("coding web-site...");
        }
    }
}