

using DependencyInjectionPattern.Models;

Product product = new Product { Name = "Laptop", Price = 1200 };


//ILogger interface XML Logger ile instance aldigim icin XML Logger calisacak.
//Eger ILogger interface i ile DatabaseLogger instance alirsam FileLogger calisacak.
//ILogger logger = new XMLLogger();
ILogger logger = new DatabaseLogger();
ProductService productService = new ProductService(logger);

productService.AddProduct(product);

Console.ReadLine();
