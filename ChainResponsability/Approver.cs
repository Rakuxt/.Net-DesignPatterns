namespace ChainResponsability
{
    // Handler
    internal abstract class Approver
    {
        protected Approver NextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            NextApprover = nextApprover;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
