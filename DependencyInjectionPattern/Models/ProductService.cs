using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Models
{
    public class ProductService
    {
        ILogger _logger;

        //Buraya ILogger Interfaceine sahip her hangi bir class gelebilir.
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }

        public void AddProduct(Product product)
        {
            // Add product to database
            //db operations...

            // Log
            _logger.Log("Product added: " + product.Name);
        }

    }
}
