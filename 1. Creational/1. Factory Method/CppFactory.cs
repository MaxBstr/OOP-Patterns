namespace Patterns._1._Creational._1._Factory_Method
{
    public class CppFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new CppDeveloper();
        }
    }
}