namespace Flyweight
{
    /*
    The Flyweight pattern is a structural design pattern that is used to minimize memory usage and improve performance by sharing common data between multiple
    objects. It's suitable for situations where you have a large number of similar objects that can share certain properties to conserve memory.

    Key components of the Flyweight pattern:

    Flyweight: This is the interface or abstract class that defines the methods that concrete flyweight objects must implement. It often includes intrinsic state,
    which is shared among multiple objects.

    Concrete Flyweight: These are the classes that implement the Flyweight interface. They store intrinsic state and provide methods for manipulating that state.

    Flyweight Factory: This is a factory class responsible for managing the creation and sharing of flyweight objects. It ensures that flyweight objects are shared
    and reused whenever possible.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Flyweight pattern allows you to share instances of the same character among different parts of the text. The CharacterFactory 
        /// manages the creation and sharing of flyweight characters. Each character's intrinsic state (the symbol) is stored in the concrete flyweight (Character)
        /// object, while the formatting (extrinsic state) is passed as an argument to the Display method. This pattern helps reduce memory consumption when dealing
        /// with a large number of similar objects.
        /// </summary>
        static void Main(string[] args)
        {
            CharacterFactory characterFactory = new();

            ICharacter a = characterFactory.GetCharacter('A');
            ICharacter b = characterFactory.GetCharacter('B');
            ICharacter aAgain = characterFactory.GetCharacter('A');

            a.Display(12);       // Output: Character: A, Font Size: 12
            b.Display(16);       // Output: Character: B, Font Size: 16
            aAgain.Display(14);  // Output: Character: A, Font Size: 14
        }
    }
}