namespace Builder
{
    // Director
    internal class MealDirector
    {
        public Meal CreateMeal(IMealBuilder builder)
        {
            builder.BuildBurger();
            builder.BuildDrink();
            builder.BuildSide();
            return builder.GetMeal();
        }
    }
}
