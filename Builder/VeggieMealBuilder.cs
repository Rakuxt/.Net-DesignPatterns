namespace Builder
{
    // Concrete Builders
    internal class VeggieMealBuilder : IMealBuilder
    {
        private Meal meal = new();

        public void BuildBurger() { meal.Burger = "Veggie Burger"; }
        public void BuildDrink() { meal.Drink = "Coke"; }
        public void BuildSide() { meal.Side = "Fries"; }

        public Meal GetMeal() { return meal; }
    }
}
