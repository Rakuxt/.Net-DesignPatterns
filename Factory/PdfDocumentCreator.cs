namespace FactoryMethod
{
    internal class PdfDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument() { return new PdfDocument(); }
    }
}
