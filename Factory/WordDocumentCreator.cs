namespace FactoryMethod
{
    internal class WordDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument() { return new WordDocument(); }
    }
}
