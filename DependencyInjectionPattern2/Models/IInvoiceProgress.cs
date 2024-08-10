using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern2.Models
{
    public interface IInvoiceProgress
    {
        void Start();
        void Calculate();
        void Print();
        void Stop();
    }
}
