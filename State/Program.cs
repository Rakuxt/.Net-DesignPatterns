namespace State
{
    /*
    The State pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes. It allows an object to appear 
    as if it changed its class, providing a clean and flexible way to handle state-specific behavior without using large conditional statements. The State pattern 
    is particularly useful when an object has multiple states that lead to different behaviors.

    Key components of the State pattern:

    Context: This is the class that contains a reference to the current state object. It delegates state-specific behavior to the current state object.

    State: This is the interface or abstract class that defines the methods for state-specific behavior. Concrete state classes implement this interface.

    Concrete State: These are the classes that implement the State interface and provide the actual behavior associated with a specific state.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the State pattern allows the MusicPlayer to change its behavior based on its internal state. The concrete state classes 
        /// (PlayingState, PausedState, StoppedState) implement the IPlayerState interface and provide state-specific behavior. The client code interacts
        /// with the MusicPlayer context, and the behavior changes automatically based on the current state. This pattern helps manage complex state transitions 
        /// and behavior variations in a clean and organized way.
        /// </summary>
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();

            player.Play();  // Output: Starting playback.

            player.Pause(); // Output: Pausing playback.

            player.Stop();  // Output: Stopping playback.

            player.Pause(); // Output: Cannot pause when stopped.

            player.Play();  // Output: Starting playback.
        }
    }
}