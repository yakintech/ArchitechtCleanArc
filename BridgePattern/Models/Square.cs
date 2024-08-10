using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    internal class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
           Console.WriteLine("Kare cizildi.");
        }
    }
}
