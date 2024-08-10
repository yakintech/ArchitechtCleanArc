using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models
{
    internal class AwayMode : IMode
    {
        public void Answer()
        {
            Console.WriteLine("Uzakta modu aktif.");
        }
    }
}
