namespace Adapter
{
    /*
    The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two 
    incompatible interfaces, converting the interface of one class into an interface that the client code expects. The Adapter pattern is especially useful when 
    integrating existing classes or libraries that have different interfaces.

    Key components of the Adapter pattern:

    Target: This is the interface that the client code expects and interacts with.

    Adapter: This class adapts the interface of the Adaptee to the Target interface. It implements the Target interface and holds an instance of the Adaptee.

    Adaptee: This is the class with the incompatible interface that needs to be adapted to work with the Target interface.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Adapter pattern allows you to use the existing LegacyRectangle class (Adaptee) in a new system that expects objects to implement 
        /// the Shape interface (Target). The RectangleAdapter acts as a bridge, adapting the interface of the LegacyRectangle to the Shape interface. 
        /// This pattern facilitates the integration of legacy code or components with new systems that have different interface requirements.
        /// </summary>
        static void Main(string[] args)
        {
            LegacyRectangle legacyRectangle = new();
            IShape adaptedRectangle = new RectangleAdapter(legacyRectangle);

            Client.DrawShape(adaptedRectangle);
        }
    }
}