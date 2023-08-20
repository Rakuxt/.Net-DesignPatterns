namespace AbstractFactory
{
    internal class Client
    {
        public void CreateUI(IUIFactory factory)
        {
            IButton button = factory.CreateButton();
            button.Render();
        }
    }
}
