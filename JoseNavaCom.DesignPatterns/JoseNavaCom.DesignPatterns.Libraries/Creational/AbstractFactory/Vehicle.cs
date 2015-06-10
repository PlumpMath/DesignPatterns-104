using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.VehicleFactory;
using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory
{
    public class Vehicle
    {
        //Factory Pattern
        public AbstractVehicleFactory Get(VehicleType vehicleType)
        {
            AbstractVehicleFactory vehicleFactory = null;

            switch (vehicleType)
            {
                case VehicleType.Van:
                    vehicleFactory = new VanFactory();
                    break;
                default:
                    vehicleFactory = new CarFactory();
                    break;
            }

            return vehicleFactory;
        }
    }
}
