namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Sender
{
    public interface IMessageSender
    {
        string SendMessage(string subject, string body);
    }
}
