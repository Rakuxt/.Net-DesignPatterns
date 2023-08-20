namespace ChainResponsability
{
    // Concrete Handlers
    internal class VicePresident : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine($"Vice President approved purchase request for {request.Amount:C}");
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
