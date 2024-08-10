
using DependencyInjectionPattern2.Models;

//Invoice invoice = new Invoice(new CompanyInvoice());
Invoice invoice = new Invoice(new CustomerInvoice());

invoice.Init();

Console.ReadLine();


