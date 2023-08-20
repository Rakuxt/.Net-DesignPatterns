namespace Visitor
{
    internal class ReportGenerator
    {
        private List<IReport> reports = new List<IReport>();

        public void Attach(IReport report)
        {
            reports.Add(report);
        }

        public void GenerateReports(IReportVisitor visitor)
        {
            foreach (var report in reports)
            {
                report.Accept(visitor);
            }
        }
    }
}
