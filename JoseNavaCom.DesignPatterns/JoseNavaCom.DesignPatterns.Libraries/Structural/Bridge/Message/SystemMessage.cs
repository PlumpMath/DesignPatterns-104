namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Bridge.Message
{
    public class SystemMessage : Message
    {
        public override string Send()
        {
            return MessageSender.SendMessage("System = " + Subject, "Body = " + Body);
        }
    }
}
