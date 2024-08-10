using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Models
{
    public interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType type);
    }
}
