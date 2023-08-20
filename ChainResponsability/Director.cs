namespace ChainResponsability
{
    // Concrete Handlers
    internal class Director : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($"Director approved purchase request for {request.Amount:C}");
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
