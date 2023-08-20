namespace FactoryMethod
{

    // Concrete Products
    internal class PdfDocument : IDocument
    {
        public void Open() { Console.WriteLine("Opening a PDF document"); }
    }
}
