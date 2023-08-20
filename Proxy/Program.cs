namespace Proxy
{
    /*
    The Proxy pattern is a structural design pattern that provides a surrogate or placeholder for another object to control its access. It allows you to create 
    a class that acts as an intermediary to another class, providing additional functionality such as lazy loading, access control, or logging without changing 
    the original class's interface.

    Key components of the Proxy pattern:

    Subject: This is the interface or abstract class that defines the common interface for both the Real Subject and the Proxy.

    Real Subject: This is the class that implements the Subject interface. It represents the actual object that the Proxy is controlling access to.

    Proxy: This class implements the Subject interface as well and holds a reference to the Real Subject. The Proxy controls access to the Real Subject and may
    provide additional functionality.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Proxy pattern allows you to control access to the Real Image objects. The ImageProxy acts as a placeholder for the RealImage 
        /// and loads the real image only when the Display method is called. This lazy loading strategy optimizes the loading process, as images are loaded only
        /// when they're needed. The client code interacts with the Proxy as if it were the Real Image, and the Proxy handles the creation and management of the
        /// Real Image instance.
        /// </summary>
        static void Main(string[] args)
        {
            IImage image1 = new ImageProxy("image1.jpg");
            IImage image2 = new ImageProxy("image2.jpg");

            // The real images are loaded only when Display is called
            image1.Display(); // Output: Loading image: image1.jpg
            image1.Display(); // Output: Displaying image: image1.jpg

            image2.Display(); // Output: Loading image: image2.jpg
        }
    }
}