namespace Decorator
{
    // Decorator
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
