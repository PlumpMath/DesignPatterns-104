using JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod.Vehicle;
using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod
{
    public class VehicleFactory
    {
        public IVehicle Make(VehicleType vehicleType)
        {
            IVehicle vehicle = null;

            switch (vehicleType)
            {
                case VehicleType.Camaro:
                    vehicle = new CamaroVehicle();
                    break;
                default:
                    vehicle = new SentraVehicle();
                    break;
            }

            return vehicle;
        }
    }
}
