using System;

namespace Patterns._3._Behavioral._1._Chain_of_Responsibility
{
    public class EmailLogger : Logger
    {
        public EmailLogger(int pr) : base(pr) {}

        public override void Write(string msg)
        {
            Console.WriteLine($"Email: {msg}");
        }
    }
}