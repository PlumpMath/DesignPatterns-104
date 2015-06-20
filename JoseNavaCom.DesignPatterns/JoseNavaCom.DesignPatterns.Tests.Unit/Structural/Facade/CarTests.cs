using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Facade;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Structural.Facade
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Create_Returns_CarEngine()
        {
            Car car = new Car();
            CarFacade carFacade = car.Create();
            Assert.AreEqual<string>("CarEngine - SetEngine", carFacade.Engine);
        }
    }
}
