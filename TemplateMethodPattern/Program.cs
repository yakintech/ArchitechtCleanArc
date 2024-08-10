

using TemplateMethodPattern.Models;

SystemReports pdfReport = new PDFReport();
pdfReport.GenerateReport();

SystemReports xmlReport = new XMLReport();
xmlReport.GenerateReport();

Console.ReadLine();