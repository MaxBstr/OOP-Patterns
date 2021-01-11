using System;

namespace Patterns._3._Behavioral._7._State
{
    public class ThirdRadio : IStation
    {
        public void play()
        {
            Console.WriteLine("Playing third radio...");
        }
    }
}