namespace Composite
{
    /*
    The Composite pattern is a structural design pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. 
    It lets clients treat individual objects and compositions of objects uniformly. This pattern is useful when you want to represent hierarchies of objects and 
    apply operations to both individual objects and their compositions without differentiating between them.

    Key components of the Composite pattern:

    Component: This is the interface or abstract class that defines the common interface for all concrete objects (leaf nodes) and their compositions 
    (composite nodes).

    Leaf: These are the classes that implement the Component interface. They represent individual objects in the hierarchy.

    Composite: These are the classes that implement the Component interface as well. They represent compositions of objects, which can be either leaf nodes or 
    other composite nodes.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Composite pattern allows you to treat individual shapes (Circle, Square) and groups of shapes (ShapeGroup) uniformly using the 
        /// IShape interface. The ShapeGroup can contain both leaf nodes (individual shapes) and other composite nodes (nested groups). This pattern enables you to 
        /// build complex hierarchies while treating all components consistently when performing operations such as drawing.
        /// </summary>
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();

            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.AddShape(circle);
            shapeGroup.AddShape(square);

            Client.DrawShapes(circle);
            Console.WriteLine("-----");
            Client.DrawShapes(square);
            Console.WriteLine("-----");
            Client.DrawShapes(shapeGroup);
        }
    }
}