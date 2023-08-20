namespace Visitor
{
    /*
    The Visitor pattern is a behavioral design pattern that allows you to add further operations to objects without having to modify them. It separates the 
    algorithm from the object structure on which it operates. This pattern is particularly useful when you have a complex object structure and want to perform 
    various operations on that structure without changing the classes representing the structure.

    Key components of the Visitor pattern:

    Visitor: This is the interface or abstract class that declares a set of visit methods, each corresponding to a different element class. Concrete visitor classes
    implement these methods to provide the actual behavior to be applied to each element.

    Concrete Visitor: These are the classes that implement the Visitor interface. Each concrete visitor defines how to perform operations on specific elements.

    Element: This is the interface or abstract class that declares an accept method. Concrete element classes implement this method to allow visitors to visit them.

    Concrete Element: These are the classes that implement the Element interface. They define their own behavior and provide an implementation of the accept method.

    Object Structure: This is the collection of elements that can be visited by visitors.
     */
    internal class Program
    {
        /// <summary>
        /// In this example, the Visitor pattern is used to generate different types of reports (PDFReportVisitor and ExcelReportVisitor) on a set of data 
        /// (Report and SummaryReport). The ReportGenerator represents the object structure holding the reports. The visitors visit the reports and apply their 
        /// specific behavior. This pattern allows you to add new report types or operations without modifying the existing report classes, promoting flexibility
        /// and maintainability.
        /// </summary>
        static void Main(string[] args)
        {
            ReportGenerator generator = new ReportGenerator();
            generator.Attach(new Report("Monthly Sales Report"));
            generator.Attach(new SummaryReport("Yearly Summary Report"));

            IReportVisitor pdfVisitor = new PDFReportVisitor();
            IReportVisitor excelVisitor = new ExcelReportVisitor();

            generator.GenerateReports(pdfVisitor);
            generator.GenerateReports(excelVisitor);
        }
    }
}