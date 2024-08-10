


using FactoryMethodPattern.Models;

var vehicleFactory = new VehicleFactory();

IVehicle car = vehicleFactory.ProduceVehicle(VehicleType.Car);
car.DisplayInfo();

IVehicle truck = vehicleFactory.ProduceVehicle(VehicleType.Truck);
truck.DisplayInfo();

IVehicle motorcycle = vehicleFactory.ProduceVehicle(VehicleType.Motorcycle);
motorcycle.DisplayInfo();

Console.ReadLine();