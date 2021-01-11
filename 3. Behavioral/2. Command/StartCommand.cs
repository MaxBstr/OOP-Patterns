namespace Patterns._3._Behavioral._2._Command
{
    public class StartCommand : ICommand
    {
        private Computer _comp;

        public StartCommand(Computer comp)
        {
            _comp = comp;
        }

        public void execute()
        {
            _comp.Start();
        }
    }
}