using System;

namespace Patterns._2._Structural._2._Bridge
{
    public class CppDeveloper : IDeveloper
    {
        public void writeCode()
        {
            Console.WriteLine("Coding cpp...");
        }
    }
}