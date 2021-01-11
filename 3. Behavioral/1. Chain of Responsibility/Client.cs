namespace Patterns._3._Behavioral._1._Chain_of_Responsibility
{
    public class Client
    {
        public static void Main()
        {
            Logger sms = new SMSLogger((int)Level.ERROR);
            Logger file = new FileLogger((int) Level.DEBUG);
            Logger email = new EmailLogger((int) Level.INFO);
            
            sms.SetNext(file);
            file.SetNext(email);
            
            sms.WriteMessage("All is Ok", (int)Level.INFO);
            sms.WriteMessage("Debugging...", (int)Level.DEBUG);
            sms.WriteMessage("Runtime!", (int)Level.ERROR);
        }
    }
}