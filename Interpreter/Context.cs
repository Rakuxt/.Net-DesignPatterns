namespace Interpreter
{
    // Context
    internal class Context
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();

        public int GetVariableValue(string variableName)
        {
            if (variables.TryGetValue(variableName, out int value))
            {
                return value;
            }
            return 0;
        }

        public void SetVariableValue(string variableName, int value)
        {
            variables[variableName] = value;
        }
    }
}
