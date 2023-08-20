namespace Interpreter
{
    // Non-Terminal Expression
    internal class SubtractExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret(Context context)
        {
            return left.Interpret(context) - right.Interpret(context);
        }
    }
}
