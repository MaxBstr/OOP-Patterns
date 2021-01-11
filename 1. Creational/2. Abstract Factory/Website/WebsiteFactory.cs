namespace Patterns._1._Creational._2._Abstract_Factory.Website
{
    public class WebsiteFactory : ITeamFactory
    {
        public ITester get_tester()
        {
            return new ManualTester();
        }

        public IDeveloper get_developer()
        {
            return new DjangoDeveloper();
        }
    }
}