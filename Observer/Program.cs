namespace Observer
{
    /*
    The Observer pattern is a behavioral design pattern that establishes a one-to-many dependency between objects, so that when one object (the subject) changes
    its state, all its dependents (observers) are notified and updated automatically. This pattern allows objects to maintain a consistent state and react to 
    changes in other objects without tight coupling.

    Key components of the Observer pattern:

    Subject: This is the class that maintains a list of observers and provides methods for adding, removing, and notifying observers about changes in its state.

    Observer: This is the interface or abstract class that defines the update method which is called by the subject when its state changes.

    Concrete Subject: This class extends the Subject and holds the actual state. It notifies its observers whenever its state changes.

    Concrete Observer: This class implements the Observer interface. It registers itself with a subject and updates its state when notified by the subject.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Observer pattern allows you to create a weather monitoring system with multiple displays that are automatically notified and 
        /// updated whenever the weather conditions change. The WeatherStation class acts as the Concrete Subject and maintains a list of registered observers. 
        /// The Display class acts as the Concrete Observer and updates its state when notified by the subject. This pattern provides a way to establish loose 
        /// coupling between the subject and its observers, allowing for flexibility in adding and removing observers and ensuring consistency across the system.
        /// </summary>
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            Display display1 = new Display("Display 1");
            Display display2 = new Display("Display 2");

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.SetMeasurements(25.5f, 60.0f, 1013.2f);
        }
    }
}