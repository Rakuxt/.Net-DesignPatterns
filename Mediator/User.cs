namespace Mediator
{
    // Colleague
    internal class User
    {
        public string Name { get; private set; }
        private IChatMediator mediator;

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} sending message: {message}");
            mediator.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} received message: {message}");
        }
    }
}
