

using ObserverPattern.Models;

Product product = new Product();


// ilgili gozlemciyi product nesnesine ekliyoruz ki degisimlerden haberdar olsun
product.Attach(new CustomerObserver());


//stok guncellemesi yapildiginda gozlemcilere haber veriliyor.
product.UpdateStock();


Console.ReadLine();
