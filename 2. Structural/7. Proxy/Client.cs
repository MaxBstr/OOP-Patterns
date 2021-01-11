namespace Patterns._2._Structural._7._Proxy
{
    public class Client
    {
        public static void Main()
        {
            var proxy = new ProxyImage("PATH");
            proxy.Display();
        }
    }
}