namespace FactoryMethod
{
    internal class Client
    {
        public void OpenDocument(DocumentCreator creator)
        {
            IDocument document = creator.CreateDocument();
            document.Open();
        }
    }
}
