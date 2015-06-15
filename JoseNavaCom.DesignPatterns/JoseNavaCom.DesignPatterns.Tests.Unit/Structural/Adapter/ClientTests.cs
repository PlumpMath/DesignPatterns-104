using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Adapter;
using Moq;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Structural.Adapter
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Contructor_Throws_Argument_Null_Exception()
        {
            Client vehicle = new Client(null);
        }

        [TestMethod]
        public void MakeRequest_Returns_MethodB()
        {
            string expected = "MethodB called";

            Mock<ITarget> _mockTarget = new Mock<ITarget>();
            _mockTarget.Setup(m => m.GetMethodA()).Returns("MethodB called");

            Client vehicle = new Client(_mockTarget.Object);
            string result = vehicle.MakeRequest();
            Assert.AreEqual<string>(expected, result);
        }
    }
}
