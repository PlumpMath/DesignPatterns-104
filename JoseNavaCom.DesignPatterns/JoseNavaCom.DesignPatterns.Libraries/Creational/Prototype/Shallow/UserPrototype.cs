namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Shallow
{
    public abstract class UserPrototype
    {
        private int _id;

        public UserPrototype(int id)
        {
            _id = id;
        }

        public int Id { 
            get { 
                return _id; 
            } 
        }

        public abstract UserPrototype Clone();
    }
}
