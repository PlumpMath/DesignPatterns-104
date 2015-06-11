using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Creational.Builder;
using Moq;
using JoseNavaCom.DesignPatterns.Libraries.Creational.Builder.VehicleBuilder;
using System.Diagnostics;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Creational.Builder
{
    [TestClass]
    public class VehicleCreatorTests
    {

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Contructor_Throws_Argument_Null_Exception()
        {
            VehicleCreator vehicle = new VehicleCreator(null);
        }

        [TestMethod]
        public void GetVehicle_Returns_Null()
        {
            Mock<IVehicleBuilder> _mockVehicleBuilder = new Mock<IVehicleBuilder>();
            _mockVehicleBuilder.Setup(m => m.GetVehicle()).Returns((Vehicle)null);

            VehicleCreator vehicleCreator = new VehicleCreator(_mockVehicleBuilder.Object);
            Vehicle vehicle = vehicleCreator.GetVehicle();
            Assert.IsNull(vehicle);
        }

        [TestMethod]
        public void GetVehicle_Returns_Camaro()
        {
            Vehicle camaro = new Vehicle() { Make = "Chevrolet", Model = "Camaro", Body = "Coupe", Engine = "8 Cylinder", Transmission = "Manual" };

            Mock<IVehicleBuilder> _mockVehicleBuilder = new Mock<IVehicleBuilder>();
            _mockVehicleBuilder.Setup(m => m.GetVehicle()).Returns(camaro);

            VehicleCreator vehicleCreator = new VehicleCreator(_mockVehicleBuilder.Object);
            Vehicle vehicle = vehicleCreator.GetVehicle();
            Assert.AreEqual<string>("Camaro", vehicle.Model);
        }

    }
}
