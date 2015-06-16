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
            MessageSender messageSender = new MessageSender();
            Message senderMessage = messageSender.Send();

            Assert.AreEqual<string>("Test Message", senderMessage.Subject);
        }
    }
}
