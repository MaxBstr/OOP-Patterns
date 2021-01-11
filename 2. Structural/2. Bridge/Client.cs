namespace Patterns._2._Structural._2._Bridge
{
    public class Client
    {
        public static void Main()
        {
            IDeveloper developer = new PythonDeveloper();
            Program bank = new BankSystem(developer);
            bank.DevelopProgram();
        }
    }
}