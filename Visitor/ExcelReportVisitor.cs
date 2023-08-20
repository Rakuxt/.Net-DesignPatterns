namespace Visitor
{
    // Concrete Visitor
    internal class ExcelReportVisitor : IReportVisitor
    {
        public void Visit(Report report)
        {
            Console.WriteLine($"Generating Excel report for: {report.Title}");
        }

        public void Visit(SummaryReport summaryReport)
        {
            Console.WriteLine($"Generating Excel summary report for: {summaryReport.Title}");
        }
    }
}
