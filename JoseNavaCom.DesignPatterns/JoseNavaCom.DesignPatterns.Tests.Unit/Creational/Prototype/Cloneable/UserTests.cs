using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Cloneable;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Creational.Prototype.Cloneable
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_Returns_Correct_Role_Name()
        {
            Role role = new Role();
            role.Id = 1;
            role.Name = "Administrator";

            User user = new User(999);
            user.Role = role;
            User userClone = (User)user.Clone();
            Assert.AreEqual<string>("Administrator", userClone.Role.Name);
        }
    }
}
