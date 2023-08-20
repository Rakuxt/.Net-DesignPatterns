namespace Visitor
{
    // Concrete Element
    internal class Report : IReport
    {
        public string Title { get; private set; }

        public Report(string title)
        {
            Title = title;
        }

        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
