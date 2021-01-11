namespace Patterns._1._Creational.Factory_Method
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IDeveloperFactory factory = new CppFactory();
            IDeveloper developer = factory.CreateDeveloper();
        }
    }
}