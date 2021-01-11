using System;

namespace Patterns._2._Structural._2._Bridge
{
    public class PythonDeveloper : IDeveloper
    {
        public void writeCode()
        {
            Console.WriteLine("Coding python...");
        }
    }
}