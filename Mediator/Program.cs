namespace Mediator
{
    /*
    The Mediator pattern is a behavioral design pattern that promotes loose coupling between a set of interacting objects by centralizing their communication 
    through a mediator object. This pattern helps to reduce direct dependencies between objects and allows them to communicate in a more organized and controlled
    manner.

    Key components of the Mediator pattern:

    Mediator: This is the interface or abstract class that defines the communication interface for the interacting objects. Concrete mediator classes implement 
    this interface and manage the interactions between objects.

    Colleague: These are the classes that interact with each other but do so through the mediator. Colleague classes only know about the mediator, not about each 
    other.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Mediator pattern is used to implement a chat application. The ChatMediator manages the communication between users. Each User 
        /// sends and receives messages through the mediator. This pattern reduces direct dependencies between users and facilitates organized communication 
        /// through the mediator, resulting in a more maintainable and extensible design.
        /// </summary>
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            User user1 = new User("User 1", chatMediator);
            User user2 = new User("User 2", chatMediator);
            User user3 = new User("User 3", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Hello, everyone!");
            user2.SendMessage("Hi there!");
        }
    }
}