using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Flyweight;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Structural.Flyweight
{
    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        public void GetFromName_Returns_Rectangle()
        {
            Shapes shapes = new Shapes();
            IShape rectangle = shapes.GetFromName("Rectangle");
            Assert.IsInstanceOfType(rectangle, typeof(Rectangle));
        }

        [TestMethod]
        public void GetFromName_Returns_Priting_Rectangle()
        {
            Shapes shapes = new Shapes();
            IShape rectangle = shapes.GetFromName("Rectangle");
            Assert.AreEqual<string>("Printing Rectangle", rectangle.Print());
        }
    }
}
