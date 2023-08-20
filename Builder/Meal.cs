namespace Builder
{
    // Product
    internal class Meal
    {
        public string? Burger { get; set; }
        public string? Drink { get; set; }
        public string? Side { get; set; }

        public void Display()
        {
            Console.WriteLine($"Burger: {Burger}, Drink: {Drink}, Side: {Side}");
        }
    }
}
