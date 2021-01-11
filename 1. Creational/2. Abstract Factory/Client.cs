using Patterns._1._Creational._2._Abstract_Factory.Website;

namespace Patterns._1._Creational._2._Abstract_Factory
{
    public class Client
    {
        public static void Main()
        {
            ITeamFactory websiteTeam = new WebsiteFactory();
            IDeveloper developer = websiteTeam.get_developer();
            ITester tester = websiteTeam.get_tester();
            developer.writeCode();
            tester.Test();
        }
    }
}