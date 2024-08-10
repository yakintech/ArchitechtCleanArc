using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    public abstract class Shape
    {
        protected IColor _color;

        public Shape(IColor color)
        {
            _color = color;
        }


        public abstract void Draw();
    }
}
