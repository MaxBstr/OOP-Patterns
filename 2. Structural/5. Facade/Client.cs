namespace Patterns._2._Structural._5._Facade
{
    public class Client
    {
        public static void Main()
        {
            var workflow = new WorkflowFacade();
            workflow.SolveProblems();
        }
    }
}