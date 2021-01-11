namespace Patterns._3._Behavioral._2._Command
{
    public class Client
    {
        public static void Main(string[] args)
        {
        var comp = new Computer();
        ICommand start = new StartCommand(comp);
        ICommand stop = new StopCommand(comp);
        ICommand restart = new RestartCommand(comp);

        var user = new User(start, stop, restart);
        user.StartComputer();
        user.RestartComputer();
        user.StopComputer();
        }
}

}