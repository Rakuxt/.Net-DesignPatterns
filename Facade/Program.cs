namespace Facade
{
    /*
    The Facade pattern is a structural design pattern that provides a unified interface to a set of interfaces in a subsystem. It simplifies complex systems by 
    providing a higher-level interface that makes it easier to use and understand the underlying components. The Facade pattern is useful when you want to provide
    a simple interface to a complex system or when you need to decouple client code from the internal complexities of a subsystem.

    Key components of the Facade pattern:

    Facade: This is the class that provides a simplified interface to the client code. It delegates client requests to the appropriate methods of the subsystem's
    classes.

    Subsystem Classes: These are the classes that implement the functionality of the subsystem. The Facade delegates calls to these classes to perform specific
    tasks.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Facade pattern provides a simplified interface (HomeTheaterFacade) for interacting with the complex home theater system. 
        /// The client code doesn't need to know the details of turning on and off individual components; it simply interacts with the Facade. 
        /// The Facade then delegates the requests to the appropriate subsystem classes, encapsulating the complexity and providing a more user-friendly interface.
        /// </summary>
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();

            // Turning on the home theater system
            homeTheater.TurnOn();

            // Turning off the home theater system
            homeTheater.TurnOff();
        }
    }
}