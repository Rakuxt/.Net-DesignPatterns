namespace Builder
{
    // Builder
    internal interface IMealBuilder
    {
        void BuildBurger();
        void BuildDrink();
        void BuildSide();
        Meal GetMeal();
    }
}
