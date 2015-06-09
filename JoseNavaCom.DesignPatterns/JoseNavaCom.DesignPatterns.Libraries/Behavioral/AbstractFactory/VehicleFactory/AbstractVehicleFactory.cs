using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Body;
using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Chassis;
using JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.Glassware;

namespace JoseNavaCom.DesignPatterns.Libraries.Behavioral.AbstractFactory.VehicleFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }
}
