namespace Visitor
{
    // Concrete Element
    internal class SummaryReport : IReport
    {
        public string Title { get; private set; }

        public SummaryReport(string title)
        {
            Title = title;
        }

        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
