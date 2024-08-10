using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Models
{
    internal class VehicleFactory : IVehicleFactory
    {
        public IVehicle ProduceVehicle(VehicleType type)
        {

            IVehicle vehicle = null;

            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
            return vehicle;
        }
    }
}
