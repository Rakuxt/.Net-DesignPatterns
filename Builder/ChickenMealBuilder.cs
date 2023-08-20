namespace Builder
{
    // Concrete Builders
    internal class ChickenMealBuilder : IMealBuilder
    {
        private Meal meal = new();

        public void BuildBurger() { meal.Burger = "Chicken Burger"; }
        public void BuildDrink() { meal.Drink = "Pepsi"; }
        public void BuildSide() { meal.Side = "Salad"; }

        public Meal GetMeal() { return meal; }
    }
}
