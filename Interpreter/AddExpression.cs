namespace Interpreter
{
    // Non-Terminal Expression
    internal class AddExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public AddExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret(Context context)
        {
            return left.Interpret(context) + right.Interpret(context);
        }
    }
}
