using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Models
{
    public class CreditKKBScore : CreditAnswerBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (customer.KKBScore > 500)
            {
                base.IsApproved = true;
                Console.WriteLine("KKDBSCore is greater than 500, Sponsorship is approved");
            }
            else
            {
                base.IsApproved = false;
                Console.WriteLine("KKDBSCore is less than 500, Sponsorship is not approved");
            }
        }
    }
}
