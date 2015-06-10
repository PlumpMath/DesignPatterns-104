using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Body;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Chassis;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Glassware;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.VehicleFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }
}
