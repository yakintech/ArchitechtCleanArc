using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public class CreditSponsor : CreditAnswerBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (customer.SponsorStatus)
            {
                base.IsApproved = true;
                Console.WriteLine("Sponsorship is approved");
            }
            else
            {
                base.IsApproved = false;
                Console.WriteLine("Sponsorship is not approved");
            }
        }
    }
}
