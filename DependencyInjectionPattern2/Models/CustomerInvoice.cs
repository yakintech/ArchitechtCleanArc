using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern2.Models
{
    public class CustomerInvoice : IInvoiceProgress
    {
        public void Calculate()
        {
            Console.WriteLine("CustomerInvoice.Calculate");
        }

        public void Print()
        {
            Console.WriteLine("CustomerInvoice.Print");
        }

        public void Start()
        {
            Console.WriteLine("CustomerInvoice.Start");
        }

        public void Stop()
        {
            Console.WriteLine("CustomerInvoice.Stop");
        }
    }
}
