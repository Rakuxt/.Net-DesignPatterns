namespace Mediator
{
    // Concrete Mediator
    internal class ChatMediator : IChatMediator
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(User sender, string message)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage($"{sender.Name}: {message}");
                }
            }
        }
    }
}
