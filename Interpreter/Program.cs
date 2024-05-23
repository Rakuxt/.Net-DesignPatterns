namespace Interpreter
{
    /*
    The Interpreter pattern is a behavioral design pattern that defines a grammatical representation for a language and provides an interpreter to evaluate 
    expressions in that language. It's useful for tasks such as parsing, interpreting, and evaluating domain-specific languages or expressions. This pattern is 
    particularly suited for scenarios where you need to process and interpret textual input in a structured manner.

    Key components of the Interpreter pattern:

    Abstract Expression: This is the base interface or class that declares an abstract method for interpreting the expression.

    Terminal Expression: These are the concrete classes that implement the Abstract Expression interface and represent the terminal symbols in the language's
    grammar.

    Non-Terminal Expression: These are the concrete classes that implement the Abstract Expression interface and represent the non-terminal symbols (combinations 
    of terminal and non-terminal expressions) in the language's grammar.

    Context: This provides information that the interpreter needs while evaluating expressions.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Interpreter pattern is used to evaluate arithmetic expressions. The NumberExpression represents terminal expressions (numbers), 
        /// and the AddExpression and SubtractExpression represent non-terminal expressions (addition and subtraction). The Context holds variable values that can
        /// be used during the interpretation process. The client code builds an expression and evaluates it using the Interpret method, producing the expected 
        /// result.
        /// </summary>
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetVariableValue("a", 3);
            context.SetVariableValue("b", 5);
            context.SetVariableValue("c", 2);

            IExpression expression = new SubtractExpression(
            new AddExpression(new NumberExpression(context.GetVariableValue("a")), new NumberExpression(context.GetVariableValue("b"))),
            new NumberExpression(context.GetVariableValue("c"))
            );

            int result = expression.Interpret(context);
            Console.WriteLine($"Result: {result}"); // Output: Result: 6
        }
    }
}