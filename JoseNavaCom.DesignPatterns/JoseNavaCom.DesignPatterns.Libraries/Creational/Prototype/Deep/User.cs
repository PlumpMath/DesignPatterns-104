namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Deep
{
    public class User : UserPrototype
    {
        public User(int id) : base(id) { }

        public override UserPrototype Clone()
        {
            Role role = new Role();
            role.Id = this.Role.Id;
            role.Name = this.Role.Name;

            User user = (User)this.MemberwiseClone();
            user.Role = role;

            return user;
        }
    }
}
