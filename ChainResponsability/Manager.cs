namespace ChainResponsability
{
    // Concrete Handlers
    internal class Manager : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"Manager approved purchase request for {request.Amount:C}");
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
