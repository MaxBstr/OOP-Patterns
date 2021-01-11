namespace Patterns._1._Creational._2._Abstract_Factory.BankSystem
{
    public class BankSystemFactory : ITeamFactory
    {
        public ITester get_tester()
        {
            return new QATester();
        }

        public IDeveloper get_developer()
        {
            return new CSharpDeveloper();
        }
    }
}