namespace Patterns._2._Structural._5._Facade
{
    public class WorkflowFacade
    {
        private Developer _developer = new Developer();
        private BugTracker _bugTracker = new BugTracker();
        private Job _job = new Job();
        
        public void SolveProblems()
        {
            _bugTracker.StartSprint();
            _job.DoJob();
            _developer.DoJobBeforeDeadline(_bugTracker);
        }
    }
}