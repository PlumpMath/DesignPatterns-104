using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Body;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Chassis;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Glassware;
using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.VehicleFactory
{
    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
