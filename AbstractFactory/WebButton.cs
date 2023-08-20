namespace AbstractFactory
{
    // Concrete Products
    internal class WebButton : IButton
    {
        public void Render() { Console.WriteLine("Rendering a Web button"); }
    }
}
