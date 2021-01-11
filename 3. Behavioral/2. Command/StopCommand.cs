namespace Patterns._3._Behavioral._2._Command
{
    public class StopCommand : ICommand
    {
        private Computer _comp;

        public StopCommand(Computer comp)
        {
            _comp = comp;
        }

        public void execute()
        {
            _comp.Stop();
        }
    }
}