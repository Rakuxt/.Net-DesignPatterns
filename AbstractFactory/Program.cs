namespace AbstractFactory
{
    /*
    The Abstract Factory is a creational design pattern that provides an interface for creating families of related or dependent objects without 
    specifying their concrete classes. It's used when a system needs to be independent of how its objects are created, composed, and represented. 
    The Abstract Factory pattern allows you to produce families of objects that work together seamlessly.
     
     Key components of the Abstract Factory pattern:
     
     AbstractFactory: This is the interface that declares a set of creation methods for producing various types of related products.
     
     ConcreteFactory: These are the classes that implement the AbstractFactory interface. They create specific product objects that belong to a certain product family.
     
     AbstractProduct: This is the interface that declares the behavior of individual product types that the AbstractFactory can create.
     
     ConcreteProduct: These are the classes that implement the AbstractProduct interface. They represent the actual product objects that the ConcreteFactory creates.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Abstract Factory pattern allows you to create families of related UI components (Button) without exposing their concrete classes. 
        /// Depending on the factory used (Windows or Web), the appropriate UI components are created and rendered. 
        /// This pattern promotes flexibility and helps in maintaining a consistent interface while accommodating different platforms or product families.
        /// </summary>
        static void Main(string[] args)
        {
            Client client = new();

            // Create UI components for Windows
            IUIFactory windowsFactory = new WindowsUIFactory();
            client.CreateUI(windowsFactory);  // Output: Rendering a Windows button

            // Create UI components for Web
            IUIFactory webFactory = new WebUIFactory();
            client.CreateUI(webFactory);      // Output: Rendering a Web button
        }
    }
}