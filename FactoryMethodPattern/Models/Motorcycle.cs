using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Models
{
    public class Motorcycle : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a motorcycle.");
        }
    }
}
