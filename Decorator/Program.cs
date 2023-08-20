namespace Decorator
{
    /*
    The Decorator pattern is a structural design pattern that allows you to dynamically add or modify behavior to individual objects without altering their class 
    structure. It's useful when you need to extend the functionality of a class without modifying its source code or when you have a set of optional behaviors that 
    can be combined in various ways.

    Key components of the Decorator pattern:

    Component: This is the interface or abstract class that defines the common interface for all concrete components (both original and decorated).

    Concrete Component: These are the classes that implement the Component interface. They represent the core functionality that you want to enhance.

    Decorator: This is the abstract class that also implements the Component interface and holds a reference to a Component object. Decorators have the same 
    interface as the original components and can add behavior before or after calling the wrapped component's methods.

    Concrete Decorator: These are the classes that extend the Decorator class and add specific behavior to the component they decorate. They can also call the
    methods of the wrapped component.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Decorator pattern allows you to add optional toppings (Milk, Sugar) to the core coffee (SimpleCoffee) without modifying its class.
        /// Each concrete decorator (MilkDecorator, SugarDecorator) adds behavior and enhances the functionality of the wrapped component. This pattern facilitates 
        /// the creation of flexible combinations of features while keeping the original classes intact.
        /// </summary>
        static void Main(string[] args)
        {
            ICoffee simpleCoffee = new SimpleCoffee();
            Console.WriteLine($"Simple Coffee: {simpleCoffee.GetDescription()}, Cost: ${simpleCoffee.GetCost()}");

            ICoffee milkCoffee = new MilkDecorator(simpleCoffee);
            Console.WriteLine($"Milk Coffee: {milkCoffee.GetDescription()}, Cost: ${milkCoffee.GetCost()}");

            ICoffee sugarMilkCoffee = new SugarDecorator(milkCoffee);
            Console.WriteLine($"Sugar Milk Coffee: {sugarMilkCoffee.GetDescription()}, Cost: ${sugarMilkCoffee.GetCost()}");
        }
    }
}