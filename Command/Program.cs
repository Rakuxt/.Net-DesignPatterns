namespace Command
{
    /*
    The Command pattern is a behavioral design pattern that encapsulates a request as an object, allowing you to parameterize clients with different requests, 
    queue or log requests, and support undoable operations. It decouples the sender (client) from the receiver (handler) of a command, enabling greater flexibility
    and extensibility in the system.

    Key components of the Command pattern:

    Command: This is the interface or abstract class that declares an Execute method. Concrete command classes implement this interface and encapsulate a specific 
    request.

    Concrete Command: These are the classes that implement the Command interface. They define the actions to be performed when the command is executed and hold a 
    reference to the receiver (the object that performs the actual operation).

    Receiver: This is the class that performs the actual action associated with a command. It knows how to perform the requested operation.

    Invoker: This class holds a reference to a Command object and knows how to execute the command. It is responsible for invoking the Execute method on the Command.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Command pattern allows you to encapsulate requests to turn a light on and off as objects (LightOnCommand, LightOffCommand). 
        /// The Light class acts as the receiver, performing the actual actions. The RemoteControl class acts as the invoker, setting and invoking commands. 
        /// This pattern provides a way to decouple the sender and receiver of a command, making it easier to extend the system with new commands and handlers.
        /// </summary>
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            RemoteControl remoteControl = new RemoteControl();

            remoteControl.SetCommand(livingRoomLightOn);
            remoteControl.PressButton(); // Output: Light is on

            remoteControl.SetCommand(livingRoomLightOff);
            remoteControl.PressButton(); // Output: Light is off
        }
    }
}