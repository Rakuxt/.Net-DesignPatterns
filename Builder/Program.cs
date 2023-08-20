namespace Builder
{
    /*
    The Builder pattern is a creational design pattern that separates the construction of complex objects from their representation, allowing the same construction 
    process to create different representations. It's useful when dealing with objects that have multiple parts or configuration options and allows you to create 
    these objects step by step while abstracting the construction details.

    Key components of the Builder pattern:

    Director: This class is responsible for directing the construction process. It works with the Builder to build the final object.

    Builder: This is an interface that declares methods for building the parts of the complex object. Concrete builders implement these methods.

    ConcreteBuilder: These are classes that implement the Builder interface and provide specific implementations for constructing the complex object.

    Product: This is the complex object being constructed. It's often composed of several parts.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Builder pattern helps construct different types of meals (Veggie and Chicken) using the same construction process. 
        /// The Director (MealDirector) coordinates the construction by working with different Concrete Builders (VeggieMealBuilder and ChickenMealBuilder). 
        /// This pattern promotes reusability and flexibility when constructing complex objects with multiple parts and configurations.
        /// </summary>
        static void Main(string[] args)
        {
            MealDirector director = new MealDirector();

            IMealBuilder veggieBuilder = new VeggieMealBuilder();
            Meal veggieMeal = director.CreateMeal(veggieBuilder);
            veggieMeal.Display();

            IMealBuilder chickenBuilder = new ChickenMealBuilder();
            Meal chickenMeal = director.CreateMeal(chickenBuilder);
            chickenMeal.Display();
        }
    }
}