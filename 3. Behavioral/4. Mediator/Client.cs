namespace Patterns._3._Behavioral._4._Mediator
{
    public class Client
    {
        public static void Main()
        {
            var chat = new TextChat();
            var admin = new AdminUser(chat);

            var u1 = new SimpleUser(chat);
            var u2 = new SimpleUser(chat);
            var u3 = new SimpleUser(chat);
            
            chat.SetAdmin(admin);
            chat.AddUser(u1);
            chat.AddUser(u2);
            chat.AddUser(u3);
            
            u1.sendMessage("Hello");
        }
    }
}