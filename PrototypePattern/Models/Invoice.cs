using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class Invoice : ICloneable
    {

        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string InvoiceDate { get; set; }

        public decimal Balance { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
