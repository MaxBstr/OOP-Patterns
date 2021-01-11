using System;

namespace Patterns._3._Behavioral._4._Mediator
{
    public class AdminUser : IUser
    {
        private IChatMediator _chat;

        public AdminUser(IChatMediator chat)
        {
            _chat = chat;
        }
        
        public void sendMessage(string msg)
        {
            _chat.sendMessage(msg, this);
        }

        public void getMessage(string msg)
        {
            Console.WriteLine($"Admin got msg {msg}");
        }
    }
}