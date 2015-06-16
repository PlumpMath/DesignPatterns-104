using JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Sender;
using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Message
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public abstract string Send();
    }
}
