namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Sender
{
    public class EmailSender : IMessageSender
    {
        public string SendMessage(string subject, string body)
        {
            return "Email Sender (Subject = " + subject + " - Body = " + body + ")";
        }
    }
}
