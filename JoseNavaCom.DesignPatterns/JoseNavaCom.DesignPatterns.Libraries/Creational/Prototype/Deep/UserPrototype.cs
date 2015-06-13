namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Deep
{
    public abstract class UserPrototype
    {
        private int _id;

        public UserPrototype(int id)
        {
            _id = id;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public Role Role { get; set; }

        public abstract UserPrototype Clone();
    }
}
