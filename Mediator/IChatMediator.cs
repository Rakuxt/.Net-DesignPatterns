namespace Mediator
{
    // Mediator
    internal interface IChatMediator
    {
        void AddUser(User user);

        void SendMessage(User sender, string message);
    }
}
