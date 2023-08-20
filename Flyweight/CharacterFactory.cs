namespace Flyweight
{
    // Flyweight Factory
    internal class CharacterFactory
    {
        private Dictionary<char, ICharacter> characters = new();

        public ICharacter GetCharacter(char key)
        {
            if (!characters.ContainsKey(key))
            {
                characters[key] = new Character(key);
            }
            return characters[key];
        }
    }
}
