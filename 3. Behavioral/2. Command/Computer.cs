using System;

namespace Patterns._3._Behavioral._2._Command
{
    public class Computer
    {
        public void Start()
        {
            Console.WriteLine("Start computer");
        }
        
        public void Stop()
        {
            Console.WriteLine("Stop computer");
        }
        
        public void Restart()
        {
            Console.WriteLine("Restart computer");
        }
    }
}