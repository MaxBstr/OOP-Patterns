namespace Patterns._3._Behavioral._2._Command
{
    public class User
    {
        private ICommand _start;
        private ICommand _stop;
        private ICommand _restart;

        public User(ICommand start, ICommand stop, ICommand restart)
        {
            _start = start;
            _stop = stop;
            _restart = restart;
        }

        public void StartComputer()
        {
            _start.execute();
        }
        
        public void StopComputer()
        {
            _stop.execute();
        }
        
        public void RestartComputer()
        {
            _restart.execute();
        }
    }
}