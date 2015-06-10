using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Body;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Chassis;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Glassware;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.VehicleFactory
{
    public class VanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
