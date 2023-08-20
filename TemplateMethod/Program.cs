namespace TemplateMethod
{
    /*
    The Template Method pattern is a behavioral design pattern that defines the structure of an algorithm in a base class but allows subclasses to provide specific
    implementations for certain steps of the algorithm. It encapsulates the common algorithm structure in the base class while enabling subclasses to customize or
    extend certain parts of the algorithm without changing its overall structure.

    Key components of the Template Method pattern:

    Abstract Class: This is the base class that defines the template method, which outlines the algorithm's structure using a series of method calls. It may also
    provide default implementations for some steps.

    Concrete Classes: These are the subclasses that inherit from the abstract class. They override specific steps of the algorithm to provide their own 
    implementations while reusing the template method's structure.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Template Method pattern defines the structure of making hot beverages in the HotBeverage base class. The abstract methods Brew 
        /// and AddCondiments are overridden by the concrete subclasses (Coffee and Tea) to provide specific implementations for brewing and adding condiments. 
        /// The client code creates instances of the concrete classes and calls the Prepare method, which follows the template's structure but allows customization 
        /// of specific steps by subclasses. This pattern promotes code reuse while maintaining a consistent algorithm structure.
        /// </summary>
        static void Main(string[] args)
        {
            HotBeverage coffee = new Coffee();
            HotBeverage tea = new Tea();

            Console.WriteLine("Making coffee:");
            coffee.Prepare();

            Console.WriteLine("\nMaking tea:");
            tea.Prepare();
        }
    }
}