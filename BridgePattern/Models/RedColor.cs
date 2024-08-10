using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    internal class RedColor : IColor
    {
        public string ApplyColor()
        {
            return "Red";
        }
    }
}
