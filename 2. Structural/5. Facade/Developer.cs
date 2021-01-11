using System;

namespace Patterns._2._Structural._5._Facade
{
    public class Developer
    {
        public void DoJobBeforeDeadline(BugTracker tracker)
        {
            Console.WriteLine(tracker.IsActiveSprint() ? "Coding..." : "Sprint ended!");
        }
    }
}