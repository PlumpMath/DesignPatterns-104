using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod;
using JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod.Vehicle;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Creational.FactoryMethod
{
    [TestClass]
    public class VehicleFactoryTests
    {
        [TestMethod]
        public void Make_Returns_Camaro_Factory()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle vehicle = vehicleFactory.Make(VehicleType.Camaro);
            Assert.IsInstanceOfType(vehicle, typeof(CamaroVehicle));
        }

        [TestMethod]
        public void Get_Returns_Make_For_Camaro()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle vehicle = vehicleFactory.Make(VehicleType.Camaro);
            string make = vehicle.Make;
            Assert.AreEqual<string>(make, "Chevrolet");
        }
    }
}
