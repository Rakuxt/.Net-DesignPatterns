namespace AbstractFactory
{
    // Concrete Factories
    internal class WebUIFactory : IUIFactory
    {
        public IButton CreateButton() { return new WebButton(); }
    }
}
