namespace Strategy
{
    /*
    The Strategy pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each algorithm, and makes them interchangeable. 
    This pattern allows a client to choose an algorithm from a family of algorithms at runtime without altering the client's code. It promotes flexibility by 
    separating the algorithm's implementation from the client code.

    Key components of the Strategy pattern:

    Strategy: This is the interface or abstract class that declares a method that represents an algorithm. Concrete strategy classes implement this interface 
    and provide the actual algorithm implementation.

    Concrete Strategy: These are the classes that implement the Strategy interface and provide different variations of the algorithm.

    Context: This is the class that maintains a reference to the Strategy and uses it to invoke the algorithm. The Context can switch between different strategies
    at runtime.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Strategy pattern allows you to switch between different payment strategies (CreditCardPayment, PayPalPayment) without altering
        /// the ShoppingCart class. The client code can choose a payment strategy at runtime, and the chosen strategy's implementation is invoked when the Checkout
        /// method is called. This promotes flexibility and maintainability by encapsulating the payment behavior in separate strategy classes.
        /// </summary>
        static void Main(string[] args)
        {
            ShoppingCart cart = new();

            IPaymentStrategy creditCardStrategy = new CreditCardPayment("1234-5678-9012-3456", "12/25");
            IPaymentStrategy paypalStrategy = new PayPalPayment("user@example.com");

            cart.SetPaymentStrategy(creditCardStrategy);
            cart.Checkout(100.50m); // Output: Paid $100.50 using credit card 1234-5678-9012-3456

            cart.SetPaymentStrategy(paypalStrategy);
            cart.Checkout(50.25m);  // Output: Paid $50.25 using PayPal account user@example.com
        }
    }
}