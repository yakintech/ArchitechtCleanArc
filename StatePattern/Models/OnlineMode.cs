using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models
{
    public class OnlineMode : IMode
    {
        public void Answer()
        {
            Console.WriteLine("Online mod aktif.");
        }
    }
}
