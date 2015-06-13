namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Shallow
{
    public class User : UserPrototype
    {
        public User(int id) : base(id) { }

        public override UserPrototype Clone()
        {
            return (UserPrototype)this.MemberwiseClone();
        }
    }
}
