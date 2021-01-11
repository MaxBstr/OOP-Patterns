using System;

namespace Patterns._2._Structural._5._Facade
{
    public class BugTracker
    {
        private bool _activeSprint;

        public bool IsActiveSprint()
        {
            return _activeSprint;
        }

        public void StartSprint()
        {
            _activeSprint = true;
            Console.WriteLine("Sprint is active!");
        }

        public void FinishSprint()
        {
            _activeSprint = false;
            Console.WriteLine("Sprint is not active!");
        }
    }
}