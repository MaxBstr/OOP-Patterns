namespace Patterns._1._Creational._1._Factory_Method
{
    public class PythonFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new PythonDeveloper();
        }
    }
}