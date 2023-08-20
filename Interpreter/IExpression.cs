namespace Interpreter
{
    // Abstract Expression
    internal interface IExpression
    {
        int Interpret(Context context);
    }
}
