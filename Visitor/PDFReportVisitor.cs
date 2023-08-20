namespace Visitor
{
    // Concrete Visitor
    internal class PDFReportVisitor : IReportVisitor
    {
        public void Visit(Report report)
        {
            Console.WriteLine($"Generating PDF report for: {report.Title}");
        }

        public void Visit(SummaryReport summaryReport)
        {
            Console.WriteLine($"Generating PDF summary report for: {summaryReport.Title}");
        }
    }
}
