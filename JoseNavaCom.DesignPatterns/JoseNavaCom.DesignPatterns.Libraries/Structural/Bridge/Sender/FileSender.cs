namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Sender
{
    public class FileSender : IMessageSender
    {
        public string SendMessage(string subject, string body)
        {
            return "File Sender (Subject = " + subject + " - Body = " + body + ")";
        }
    }
}
