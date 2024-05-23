namespace ChainResponsability
{
    /*
    The Chain of Responsibility pattern is a behavioral design pattern that allows multiple objects to handle a request in a chain-like manner. Each object in the
    chain has a chance to handle the request, pass it to the next object, or stop the chain. This pattern decouples the sender of the request from its receivers, 
    allowing them to process the request independently.

    Key components of the Chain of Responsibility pattern:

    Handler: This is the interface or abstract class that defines a method to handle the request and a reference to the next handler in the chain. Concrete handler
    classes implement this interface and decide whether to handle the request or pass it to the next handler.

    Concrete Handler: These are the classes that implement the Handler interface. They handle the request if they're able to or delegate it to the next handler in
    the chain.
     */
    internal class Program
    {
        /// <summary>
        /// In this output, you can see that each Approver in the chain evaluates whether they can approve a purchase request based on the request's amount. 
        /// If an approver can't handle the request, they pass it to the next approver in the chain until the request is either approved or rejected. 
        /// This pattern allows you to build flexible approval workflows where different approvers can be added or removed from the chain without affecting 
        /// the client code.
        /// </summary>
        static void Main(string[] args)
        {
            Approver manager = new Manager();
            Approver director = new Director();
            Approver vicePresident = new VicePresident();

            manager.SetNextApprover(director);
            director.SetNextApprover(vicePresident);

            PurchaseRequest request1 = new PurchaseRequest(800);
            PurchaseRequest request2 = new PurchaseRequest(3000);
            PurchaseRequest request3 = new PurchaseRequest(15000);

            manager.ProcessRequest(request1);
            manager.ProcessRequest(request2);
            manager.ProcessRequest(request3);
        }
    }
}