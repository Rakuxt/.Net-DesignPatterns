namespace Flyweight
{
    // Concrete Flyweight
    internal class Character : ICharacter
    {
        private char symbol;

        public Character(char symbol)
        {
            this.symbol = symbol;
        }

        public void Display(int fontSize)
        {
            Console.WriteLine($"Character: {symbol}, Font Size: {fontSize}");
        }
    }
}
