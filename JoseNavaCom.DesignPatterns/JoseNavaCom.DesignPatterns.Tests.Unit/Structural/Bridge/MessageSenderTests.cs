using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Message;

namespace JoseNavaCom.DesignPatterns.Tests.Unit.Structural.Bridge
{
    [TestClass]
    public class MessageSenderTests
    {
        [TestMethod]
        public void Send_Returns_SystemMessage()
        {
            string expected = "Email Sender (Subject = System Subject : Test Message - Body = System Body : Hi, This is a Test Message)";

            MessageSender messageSender = new MessageSender();
            Message senderMessage = messageSender.Send();
            string message = senderMessage.Send();
            Assert.AreEqual<string>(expected, message);
        }
    }
}
