namespace Decorator
{
    // Concrete Component
    internal class SimpleCoffee : ICoffee
    {
        public string GetDescription() { return "Simple Coffee"; }
        public double GetCost() { return 2.0; }
    }
}
