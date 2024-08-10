using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    internal class CreditTCControl : CreditAnswerBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (customer.HasTCNo)
            {
                base.IsApproved = true;
                Console.WriteLine("TC is approved");
            }
            else
            {
                base.IsApproved = false;
                Console.WriteLine("TC is not approved");
            }
        }
    }
}
