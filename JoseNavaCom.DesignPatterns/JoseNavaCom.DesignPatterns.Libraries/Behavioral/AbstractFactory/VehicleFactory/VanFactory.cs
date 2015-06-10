using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Body;
using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Chassis;
using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Glassware;

namespace JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.VehicleFactory
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
