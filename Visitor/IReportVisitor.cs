namespace Visitor
{
    internal interface IReportVisitor
    {
        void Visit(Report report);
        void Visit(SummaryReport summaryReport);
    }
}
