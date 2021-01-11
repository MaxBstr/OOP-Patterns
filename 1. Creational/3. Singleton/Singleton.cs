using System;

namespace Patterns._1._Creational._3._Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object Lock = new object();
        private Singleton() {}
        
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                { 
                    _instance = new Singleton();
                }
            }

            return _instance;
        }
        
    }
}