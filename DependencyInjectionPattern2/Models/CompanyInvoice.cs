using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern2.Models
{
    internal class CompanyInvoice : IInvoiceProgress
    {
        public void Calculate()
        {
            Console.WriteLine("CompanyInvoice.Calculate");
        }

        public void Print()
        {
            Console.WriteLine("CompanyInvoice.Print");
        }

        public void Start()
        {
            Console.WriteLine("CompanyInvoice.Start");
        }

        public void Stop()
        {
            Console.WriteLine("CompanyInvoice.Stop");
        }
    }
}
