using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Structural.Decorator
{
    [TestClass]
    public class CakeDecoratorTests
    {
        [TestMethod]
        public void GetPrice_Returns_210()
        {
            CakeDecorator cakeDecorator = new CakeDecorator();
            var totalPrice = cakeDecorator.GetPrice();
        }
    }
}
