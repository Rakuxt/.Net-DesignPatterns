namespace FactoryMethod
{

    // Concrete Products
    internal class WordDocument : IDocument
    {
        public void Open() { Console.WriteLine("Opening a Word document"); }
    }
}
