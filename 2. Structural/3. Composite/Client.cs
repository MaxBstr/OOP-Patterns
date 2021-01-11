namespace Patterns._2._Structural._3._Composite
{
    public class Client
    {
        public static void Main()
        {
            _2._Bridge.IDeveloper first = new _2._Bridge.PythonDeveloper();
            _2._Bridge.IDeveloper second = new _2._Bridge.CppDeveloper();
            
            var team = new Team();
            team.AddDeveloper(first);
            team.AddDeveloper(second);
            team.CreateProject();
        }
    }
}