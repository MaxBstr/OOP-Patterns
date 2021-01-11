namespace Patterns._1._Creational._2._Abstract_Factory
{
    public interface ITeamFactory
    {
        ITester get_tester();
        IDeveloper get_developer();
    }
}