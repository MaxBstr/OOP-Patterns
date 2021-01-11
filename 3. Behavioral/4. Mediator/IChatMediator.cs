namespace Patterns._3._Behavioral._4._Mediator
{
    public interface IChatMediator
    {
        void sendMessage(string msg, IUser user);
    }
}