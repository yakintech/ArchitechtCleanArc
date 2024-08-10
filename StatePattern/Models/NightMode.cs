using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models
{
    public class NightMode : IMode
    {
        public void Answer()
        {
            Console.WriteLine("Gece modu aktif.");
        }
    }
}
