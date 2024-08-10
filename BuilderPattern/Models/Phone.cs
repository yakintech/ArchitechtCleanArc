using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
         return $"Id: {Id}, Name: {Name}, Brand: {Brand}, Price: {Price}";
        }
    }
}
