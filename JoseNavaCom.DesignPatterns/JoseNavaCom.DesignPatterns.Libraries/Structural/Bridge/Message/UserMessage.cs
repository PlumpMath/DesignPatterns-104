namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Message
{
    public class UserMessage : Message
    {
        public override string Send()
        {
            return MessageSender.SendMessage("User = " + Subject, "User = " + Body);
        }
    }
}