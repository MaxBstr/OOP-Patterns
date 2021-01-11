using System;

namespace Patterns._2._Structural._3._Composite
{
    public class CppDeveloper : _2._Bridge.IDeveloper
    {
        public void writeCode()
        {
            Console.WriteLine("Coding cpp...");
        }
    }
}