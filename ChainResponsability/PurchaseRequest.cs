namespace ChainResponsability
{
    // Request
    internal class PurchaseRequest
    {
        public decimal Amount { get; }

        public PurchaseRequest(decimal amount)
        {
            Amount = amount;
        }
    }
}
