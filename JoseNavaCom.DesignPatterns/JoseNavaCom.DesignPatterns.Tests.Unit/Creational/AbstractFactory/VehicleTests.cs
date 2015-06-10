using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.VehicleFactory;
using JoseNavaCom.DesignPatterns.Libraries.Creational.AbstractFactory.Chassis;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Creational.AbstractFactory
{
    [TestClass]
    public class VehicleTests
    {

        [TestMethod]
        public void Get_Returns_Car_Factory()
        {
            Vehicle vehicle = new Vehicle();
            AbstractVehicleFactory vehicleFactory = vehicle.Get(VehicleType.Car);
            Assert.IsInstanceOfType(vehicleFactory, typeof(CarFactory));
        }

        [TestMethod]
        public void Get_Returns_Body_Shell_For_Car()
        {
            Vehicle vehicle = new Vehicle();
            AbstractVehicleFactory vehicleFactory = vehicle.Get(VehicleType.Car);
            IChassis vehicleChassis = vehicleFactory.CreateChassis();
            Assert.AreEqual(vehicleChassis.ChassisParts, "Chassis parts for a car");
        }
    }
}
