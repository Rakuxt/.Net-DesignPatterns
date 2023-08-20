namespace Bridge
{
    /*
    The Bridge pattern is a structural design pattern that decouples an abstraction from its implementation, allowing both to vary independently. It involves 
    creating two separate hierarchies: one for abstraction (high-level functionality) and another for implementation (low-level details). This pattern is useful 
    when you want to avoid a permanent binding between abstraction and implementation, allowing them to evolve and change independently.

    Key components of the Bridge pattern:

    Abstraction: This is the high-level class that defines the interface for the client code. It contains a reference to the Implementation and delegates some 
    of its operations to the Implementation.

    Refined Abstraction: These are the classes that extend the Abstraction and provide additional features or variations of the basic interface.

    Implementation: This is the interface or abstract class that defines the low-level operations that Abstraction relies on. It's usually less stable than the 
    Abstraction.

    Concrete Implementation: These are the classes that implement the Implementation interface. They provide concrete functionality that the Abstraction uses.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Bridge pattern allows you to decouple different shapes (Circle, Square) from their rendering engines (OpenGL, DirectX). 
        /// The Shape hierarchy represents the Abstraction, and the IRenderer hierarchy represents the Implementation. The client code (Client class) interacts 
        /// with the Abstraction (Shape), and the specific rendering engines are provided through the Implementation (IRenderer). This pattern allows you to 
        /// create different combinations of shapes and rendering engines while avoiding tight coupling between them.
        /// </summary>
        static void Main(string[] args)
        {
            IRenderer openglRenderer = new OpenGLRenderer();
            IRenderer directxRenderer = new DirectXRenderer();

            Shape circle = new Circle(openglRenderer, 5.0f);
            Shape square = new Square(directxRenderer, 8.0f);

            circle.Draw();
            square.Draw();
        }
    }
}