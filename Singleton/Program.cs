namespace Singleton
{
    /*
    The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance. 
    It guarantees that a class has a single instance throughout the application's lifecycle and provides a way to access that instance from anywhere in the codebase. 
    The Singleton pattern is useful in scenarios where you want to ensure a single point of control, such as managing shared resources or maintaining a global 
    configuration.

    Key features of the Singleton pattern:

    Private Constructor: The Singleton class has a private constructor to prevent the direct instantiation of objects from outside the class.

    Static Instance: The Singleton class provides a static method to access its single instance, often named Instance or GetInstance.

    Lazy Initialization: The Singleton instance is created only when it's first requested, ensuring that it's not created unnecessarily.

    Thread Safety: The Singleton pattern needs to ensure that only one instance is created even in a multi-threaded environment. Proper synchronization is necessary.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Singleton pattern ensures that only one instance of the Singleton class is created. The Instance property provides a globally 
        /// accessible point to access that single instance. The use of the lock keyword ensures that the instance is created in a thread-safe manner, 
        /// preventing multiple threads from creating separate instances simultaneously.
        /// The Singleton pattern is particularly useful in scenarios where you want to maintain a single instance of a resource-intensive object, 
        /// such as database connections, thread pools, or configuration settings. It helps in centralizing control and avoiding duplication of resources.
        /// </summary>
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            Console.WriteLine(instance1 == instance2); // Output: True
        }
    }
}