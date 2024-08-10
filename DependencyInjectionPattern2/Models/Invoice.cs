using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern2.Models
{
    public class Invoice
    {

        private IInvoiceProgress _invoiceProgress;

        public Invoice(IInvoiceProgress invoiceProgress)
        {
            _invoiceProgress = invoiceProgress;
        }


        public void Init()
        {
            _invoiceProgress.Start();
            _invoiceProgress.Calculate();
            _invoiceProgress.Print();
            _invoiceProgress.Stop();
        }
    }
}
