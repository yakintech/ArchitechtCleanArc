

using PrototypePattern.Models;

Invoice invoice = new Invoice
{
    InvoiceNumber = "123",
    CustomerName = "John Doe",
    CustomerAddress = "123 Main St",
    InvoiceDate = "01/01/2020",
    Balance = 100.00m
};


Invoice invoice2 = (Invoice)invoice.Clone();
invoice2.InvoiceNumber = "456";


Console.WriteLine(invoice2.InvoiceNumber);
Console.WriteLine(invoice2.CustomerName);

Console.ReadLine();
