


using DecoratorPattern.Models;

IRepository<string> repository = new Repository<string>();

repository = new LoggingRepository<string>(repository);


repository.Add("Hello, World!");


Console.ReadLine();