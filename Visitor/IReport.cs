namespace Visitor
{
    // Element
    internal interface IReport
    {
        void Accept(IReportVisitor visitor);
        string Title { get; }
    }
}
