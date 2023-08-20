namespace AbstractFactory
{
    // Concrete Factories
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton() { return new WindowsButton(); }
    }
}
