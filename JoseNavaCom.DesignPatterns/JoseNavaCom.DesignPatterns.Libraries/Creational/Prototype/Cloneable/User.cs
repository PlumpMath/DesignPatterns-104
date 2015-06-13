using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Prototype.Cloneable
{
    public class User : ICloneable
    {
        private int _id;

        public User(int id)
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


        private object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        private object DeepCopy()
        {
            User user = (User)this.MemberwiseClone();
            user.Role = new Role();
            user.Role.Id = this.Role.Id;
            user.Role.Name = this.Role.Name;

            return user;
        }

        public object Clone()
        {
            return DeepCopy();
        }

    }
}
