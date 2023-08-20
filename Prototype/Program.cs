namespace Prototype
{
    /*
    The Prototype pattern is a creational design pattern that allows you to copy existing objects without making the code dependent on their classes. 
    It involves creating a clone of an existing object (prototype) and then modifying or using it as needed. This pattern is useful when you want to create new 
    objects that are similar to existing ones while minimizing the direct coupling to their classes.

    Key components of the Prototype pattern:

    Prototype: This is the interface or abstract class that declares the method for cloning itself. Concrete prototypes implement this method to create clones.

    Concrete Prototype: These are the classes that implement the Prototype interface. They define the cloning behavior, allowing the creation of copies of objects.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Prototype pattern allows you to clone shapes (Circle and Rectangle) to create new instances without relying on their concrete 
        /// classes. The Clone method creates a deep copy of the object, allowing you to modify or use the copies independently. This pattern promotes flexibility 
        /// and reusability by allowing you to create new instances based on existing ones while reducing direct dependencies on their classes.
        /// </summary>
        static void Main(string[] args)
        {
            Client.DrawShapes();
        }
    }
}