using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Shallow;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Creational.Prototype.Shallow
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_Returns_Correct_Id()
        {
            User user = new User(999);
            User userClone = (User)user.Clone();
            Assert.AreEqual<int>(999, userClone.Id);
        }
    }
}
