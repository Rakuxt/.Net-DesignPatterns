namespace AbstractFactory
{
    // Concrete Products
    internal class WindowsButton : IButton
    {
        public void Render() { Console.WriteLine("Rendering a Windows button"); }
    }
}
