using System.Collections.Generic;

namespace Patterns._3._Behavioral._4._Mediator
{
    public class TextChat : IChatMediator
    {
        private IUser _admin;
        private List<IUser> _users = new List<IUser>();

        public void SetAdmin(IUser user)
        {
            _admin = user;
        }

        public void AddUser(IUser user)
        {
            _users.Add(user);
        }
        
        public void sendMessage(string msg, IUser user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                    u.getMessage(msg);
            }
            _admin.getMessage(msg);
        }
    }
}