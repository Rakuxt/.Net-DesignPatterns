namespace TemplateMethod
{
    // Abstract Class (Template)
    internal abstract class HotBeverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void AddCondiments();
    }
}
