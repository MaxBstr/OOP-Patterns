namespace Patterns._3._Behavioral._2._Command
{
    public class RestartCommand : ICommand
    {
        private Computer _comp;

        public RestartCommand(Computer comp)
        {
            _comp = comp;
        }

        public void execute()
        {
            _comp.Restart();
        }
    }
}