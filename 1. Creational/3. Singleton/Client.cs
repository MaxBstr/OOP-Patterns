using System.Threading;

namespace Patterns._1._Creational._3._Singleton
{
    public class Client
    {
        public static void Main()
        {
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });
        }
        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance();
        } 
    }
}