using System;

namespace Patterns._3._Behavioral._1._Chain_of_Responsibility
{
    public class SMSLogger : Logger
    {
        public SMSLogger(int pr) : base(pr) {}

        public override void Write(string msg)
        {
            Console.WriteLine($"SMS: {msg}");
        }
    }
}