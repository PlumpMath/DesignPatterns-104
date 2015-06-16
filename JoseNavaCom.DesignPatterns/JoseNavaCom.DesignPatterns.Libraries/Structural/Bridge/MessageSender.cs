using JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Message;
using JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Sender;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge
{
    public class MessageSender
    {
        public Message.Message Send()
        {
            IMessageSender email = new EmailSender();
            Message.Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";
            message.MessageSender = email;

            return message;
        }
    }
}
