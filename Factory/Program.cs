namespace FactoryMethod
{
    /*
    The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass but allows subclasses to alter 
    the type of objects that will be created. It defines a method for creating objects, but the specific class of the object to be instantiated is determined 
    by the subclasses. This pattern promotes loose coupling by allowing a class to delegate the responsibility of object creation to its subclasses.

    Key components of the Factory Method pattern:

    Creator (Abstract Creator): This is the abstract class or interface that declares the Factory Method. It provides an interface for creating products.

    Concrete Creator: These are the classes that implement the Factory Method to create specific types of products.

    Product (Abstract Product): This is the abstract class or interface that defines the interface for the objects the Factory Method creates.

    Concrete Product: These are the classes that implement the Product interface. They are the specific objects created by the Concrete Creators.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Factory Method pattern allows you to create different types of documents (PDF, Word) based on the user's preferences 
        /// without tightly coupling the client code to specific document classes. The client code uses the Factory Method to create documents, but the 
        /// specific type of document is determined by the subclass implementing the Factory Method. This enhances flexibility and allows for easy addition 
        /// of new document types without modifying existing code.
        /// </summary>
        static void Main(string[] args)
        {
            Client client = new();

            // Open a PDF document
            DocumentCreator pdfCreator = new PdfDocumentCreator();
            client.OpenDocument(pdfCreator);  // Output: Opening a PDF document

            // Open a Word document
            DocumentCreator wordCreator = new WordDocumentCreator();
            client.OpenDocument(wordCreator); // Output: Opening a Word document
        }
    }
}